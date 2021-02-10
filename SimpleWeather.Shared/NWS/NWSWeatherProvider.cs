﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleWeather.Icons;
using SimpleWeather.Location;
using SimpleWeather.NWS.Hourly;
using SimpleWeather.SMC;
using SimpleWeather.Utils;
using SimpleWeather.WeatherData;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Web;
using Windows.Web.Http;
using Windows.Web.Http.Filters;
using Windows.Web.Http.Headers;

namespace SimpleWeather.NWS
{
    public partial class NWSWeatherProvider : WeatherProviderImpl
    {
        private const string FORECAST_QUERY_URL = "https://forecast.weather.gov/MapClick.php?{0}&FcstType=json";
        private const string HRFORECAST_QUERY_URL = "https://forecast.weather.gov/MapClick.php?{0}&FcstType=digitalJSON";

        public NWSWeatherProvider() : base()
        {
            LocationProvider = RemoteConfig.RemoteConfig.GetLocationProvider(WeatherAPI);
            if (LocationProvider == null)
            {
                LocationProvider = new Bing.BingMapsLocationProvider();
            }
        }

        public override string WeatherAPI => WeatherData.WeatherAPI.NWS;
        public override bool SupportsWeatherLocale => false;
        public override bool KeyRequired => false;
        public override bool NeedsExternalAlertData => true;

        public override Task<bool> IsKeyValid(string key)
        {
            return Task.FromResult(false);
        }

        public override String GetAPIKey()
        {
            return null;
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public override Task<Weather> GetWeather(string location_query, string country_code)
        {
            return Task.Run(async () =>
            {
                Weather weather = null;
                WeatherException wEx = null;

                try
                {
                    Uri observationURL = new Uri(string.Format(FORECAST_QUERY_URL, location_query));
                    Uri hrlyForecastURL = new Uri(string.Format(HRFORECAST_QUERY_URL, location_query));

                    using (var observationRequest = new HttpRequestMessage(HttpMethod.Get, observationURL))
                    using (var hrForecastRequest = new HttpRequestMessage(HttpMethod.Get, hrlyForecastURL))
                    {
                        observationRequest.Headers.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("application/ld+json"));
                        hrForecastRequest.Headers.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("application/ld+json"));

                        observationRequest.Headers.CacheControl.MaxAge = TimeSpan.FromHours(1);
                        hrForecastRequest.Headers.CacheControl.MaxAge = TimeSpan.FromHours(1);

                        // Get response
                        var webClient = SimpleLibrary.WebClient;
                        using (var ctsO = new CancellationTokenSource((int)(Settings.READ_TIMEOUT * 1.5f)))
                        using (var observationResponse = await webClient.SendRequestAsync(observationRequest).AsTask(ctsO.Token))
                        {
                            // Check for errors
                            CheckForErrors(observationResponse.StatusCode);

                            Stream observationStream = WindowsRuntimeStreamExtensions.AsStreamForRead(await observationResponse.Content.ReadAsInputStreamAsync());

                            // Load point json data
                            Observation.ForecastRootobject observationData = JSONParser.Deserializer<Observation.ForecastRootobject>(observationStream);

                            using (var ctsF = new CancellationTokenSource((int)(Settings.READ_TIMEOUT * 1.5f)))
                            using (var forecastResponse = await webClient.SendRequestAsync(hrForecastRequest).AsTask(ctsF.Token))
                            {
                                // Check for errors
                                CheckForErrors(forecastResponse.StatusCode);

                                Stream forecastStream = WindowsRuntimeStreamExtensions.AsStreamForRead(await forecastResponse.Content.ReadAsInputStreamAsync());

                                // Load point json data
                                Hourly.HourlyForecastResponse forecastData = await CreateHourlyForecastResponse(forecastStream);

                                weather = new Weather(observationData, forecastData);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    weather = null;

                    if (WebError.GetStatus(ex.HResult) > WebErrorStatus.Unknown)
                    {
                        wEx = new WeatherException(WeatherUtils.ErrorStatus.NetworkError);
                    }

                    Logger.WriteLine(LoggerLevel.Error, ex, "NWSWeatherProvider: error getting weather data");
                }

                if (wEx == null && (weather == null || !weather.IsValid()))
                {
                    wEx = new WeatherException(WeatherUtils.ErrorStatus.NoWeather);
                }
                else if (weather != null)
                {
                    weather.query = location_query;
                }

                if (wEx != null)
                    throw wEx;

                return weather;
            });
        }

        private async Task<HourlyForecastResponse> CreateHourlyForecastResponse(Stream forecastStream)
        {
            var forecastData = new HourlyForecastResponse();
            var forecastObj = await JObject.LoadAsync(new JsonTextReader(new StreamReader(forecastStream)));

            if (forecastObj.HasValues)
            {
                var fcastRoot = forecastObj.Root.ToObject<JObject>();

                forecastData.creationDate = fcastRoot.Property("creationDate").Value.ToObject<DateTimeOffset>();
                forecastData.location = new Hourly.Location();

                var location = fcastRoot.Property("location").Value.ToObject<JObject>();
                forecastData.location.latitude = location.Property("latitude").Value.ToObject<double>();
                forecastData.location.longitude = location.Property("longitude").Value.ToObject<double>();

                var periodNameList = fcastRoot.Property("PeriodNameList").Value.ToObject<JObject>();
                SortedSet<string> sortedKeys = new SortedSet<string>(periodNameList.Properties().Select(p => p.Name), new StrNumComparator());

                forecastData.periodsItems = new List<PeriodsItem>(sortedKeys.Count);

                foreach (var periodNumber in sortedKeys)
                {
                    var periodName = periodNameList.Value<string>(periodNumber);

                    if (!fcastRoot.ContainsKey(periodName))
                        continue;

                    var item = new PeriodsItem();

                    var periodObj = fcastRoot.Property(periodName).Value.ToObject<JObject>();
                    var timeArr = periodObj.Property("time").Value.ToObject<JArray>();
                    var unixTimeArr = periodObj.Property("unixtime").Value.ToObject<JArray>();
                    var windChillArr = periodObj.Property("windChill").Value.ToObject<JArray>();
                    var windSpeedArr = periodObj.Property("windSpeed").Value.ToObject<JArray>();
                    var cloudAmtArr = periodObj.Property("cloudAmount").Value.ToObject<JArray>();
                    var popArr = periodObj.Property("pop").Value.ToObject<JArray>();
                    var humidityArr = periodObj.Property("relativeHumidity").Value.ToObject<JArray>();
                    var windGustArr = periodObj.Property("windGust").Value.ToObject<JArray>();
                    var tempArr = periodObj.Property("temperature").Value.ToObject<JArray>();
                    var windDirArr = periodObj.Property("windDirection").Value.ToObject<JArray>();
                    var iconArr = periodObj.Property("iconLink").Value.ToObject<JArray>();
                    var conditionTxtArr = periodObj.Property("weather").Value.ToObject<JArray>();

                    item.periodName = periodObj.Property("periodName").Value.ToObject<string>();

                    item.time = new List<string>(timeArr.Count);
                    foreach (var jsonElement in timeArr.Children<JValue>())
                    {
                        String time = jsonElement.Value?.ToString();
                        item.time.Add(time);
                    }

                    item.unixtime = new List<string>(unixTimeArr.Count);
                    foreach (var jsonElement in unixTimeArr.Children<JValue>())
                    {
                        String time = jsonElement.Value?.ToString();
                        item.unixtime.Add(time);
                    }

                    item.windChill = new List<string>(windChillArr.Count);
                    foreach (var jsonElement in windChillArr.Children<JValue>())
                    {
                        String windChill = jsonElement.Value?.ToString();
                        item.windChill.Add(windChill);
                    }

                    item.windSpeed = new List<string>(windSpeedArr.Count);
                    foreach (var jsonElement in windSpeedArr.Children<JValue>())
                    {
                        String windSpeed = jsonElement.Value?.ToString();
                        item.windSpeed.Add(windSpeed);
                    }

                    item.cloudAmount = new List<string>(cloudAmtArr.Count);
                    foreach (var jsonElement in cloudAmtArr.Children<JValue>())
                    {
                        String cloudAmt = jsonElement.Value?.ToString();
                        item.cloudAmount.Add(cloudAmt);
                    }

                    item.pop = new List<string>(popArr.Count);
                    foreach (var jsonElement in popArr.Children<JValue>())
                    {
                        String pop = jsonElement.Value?.ToString();
                        item.pop.Add(pop);
                    }

                    item.relativeHumidity = new List<string>(humidityArr.Count);
                    foreach (var jsonElement in humidityArr.Children<JValue>())
                    {
                        String humidity = jsonElement.Value?.ToString();
                        item.relativeHumidity.Add(humidity);
                    }

                    item.windGust = new List<string>(windGustArr.Count);
                    foreach (var jsonElement in windGustArr.Children<JValue>())
                    {
                        String windGust = jsonElement.Value?.ToString();
                        item.windGust.Add(windGust);
                    }

                    item.temperature = new List<string>(tempArr.Count);
                    foreach (var jsonElement in tempArr.Children<JValue>())
                    {
                        String temp = jsonElement.Value?.ToString();
                        item.temperature.Add(temp);
                    }

                    item.windDirection = new List<string>(windDirArr.Count);
                    foreach (var jsonElement in windDirArr.Children<JValue>())
                    {
                        String windDir = jsonElement.Value?.ToString();
                        item.windDirection.Add(windDir);
                    }

                    item.iconLink = new List<string>(iconArr.Count);
                    foreach (var jsonElement in iconArr.Children<JValue>())
                    {
                        String icon = jsonElement.Value?.ToString();
                        item.iconLink.Add(icon);
                    }

                    item.weather = new List<string>(conditionTxtArr.Count);
                    foreach (var jsonElement in conditionTxtArr.Children<JValue>())
                    {
                        String condition = jsonElement.Value?.ToString();
                        item.weather.Add(condition);
                    }

                    forecastData.periodsItems.Add(item);
                }
            }

            return forecastData;
        }

        private class StrNumComparator : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                if (int.TryParse(x, out int numX) && int.TryParse(y, out int numY))
                {
                    return numX.CompareTo(numY);
                }
                else
                {
                    return StringComparer.OrdinalIgnoreCase.Compare(x, y);
                }
            }
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        private void CheckForErrors(HttpStatusCode responseCode)
        {
            switch (responseCode)
            {
                case HttpStatusCode.Ok:
                    break;
                // 400 (OK since this isn't a valid request)
                case HttpStatusCode.BadRequest:
                default:
                    throw new WeatherException(WeatherUtils.ErrorStatus.NoWeather);
                // 404 (Not found - Invalid query)
                case HttpStatusCode.NotFound:
                    throw new WeatherException(WeatherUtils.ErrorStatus.QueryNotFound);
            }
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public override async Task<Weather> GetWeather(LocationData location)
        {
            var weather = await base.GetWeather(location);

            var offset = location.tz_offset;
            weather.update_time = weather.update_time.ToOffset(offset);
            weather.condition.observation_time = weather.condition.observation_time.ToOffset(location.tz_offset);

            // NWS does not provide astrodata; calculate this ourselves (using their calculator)
            var solCalcData = await new SolCalcAstroProvider().GetAstronomyData(location, weather.condition.observation_time);
            weather.astronomy = await new SunMoonCalcProvider().GetAstronomyData(location, weather.condition.observation_time);
            weather.astronomy.sunrise = solCalcData.sunrise;
            weather.astronomy.sunset = solCalcData.sunset;

            // Update icons
            var now = DateTimeOffset.UtcNow.ToOffset(offset).TimeOfDay;
            var sunrise = weather.astronomy.sunrise.TimeOfDay;
            var sunset = weather.astronomy.sunset.TimeOfDay;

            weather.condition.icon = GetWeatherIcon(now < sunrise || now > sunset, weather.condition.icon);

            foreach (HourlyForecast hr_forecast in weather.hr_forecast)
            {
                var hrf_date = hr_forecast.date.ToOffset(offset);
                hr_forecast.date = hrf_date;

                var hrf_localTime = hrf_date.LocalDateTime.TimeOfDay;
                hr_forecast.icon = GetWeatherIcon(hrf_localTime < sunrise || hrf_localTime > sunset, hr_forecast.icon);
            }

            return weather;
        }

        public override string UpdateLocationQuery(Weather weather)
        {
            var str = string.Format(CultureInfo.InvariantCulture, "lat={0:0.####}&lon={1:0.####}", weather.location.latitude, weather.location.longitude);
            return str;
        }

        public override string UpdateLocationQuery(LocationData location)
        {
            var str = string.Format(CultureInfo.InvariantCulture, "lat={0:0.####}&lon={1:0.####}", location.latitude, location.longitude);
            return str;
        }

        public override string GetWeatherIcon(string icon)
        {
            return GetWeatherIcon(false, icon);
        }

        public override string GetWeatherIcon(bool isNight, string icon)
        {
            // Example: https://api.weather.gov/icons/land/day/tsra_hi,20?size=medium
            string WeatherIcon = string.Empty;

            if (icon == null)
                return WeatherIcons.NA;

            if (icon.Contains("fog"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_FOG;
                else
                    WeatherIcon = WeatherIcons.DAY_FOG;
            }
            else if (icon.Contains("blizzard"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_ALT_SNOW_WIND;
                else
                    WeatherIcon = WeatherIcons.DAY_SNOW_WIND;
            }
            else if (icon.Contains("cold"))
            {
                WeatherIcon = WeatherIcons.SNOWFLAKE_COLD;
            }
            else if (icon.Contains("hot"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_CLEAR;
                else
                    WeatherIcon = WeatherIcons.DAY_HOT;
            }
            else if (icon.Contains("haze"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_FOG;
                else
                    WeatherIcon = WeatherIcons.DAY_HAZE;
            }
            else if (icon.Contains("smoke"))
            {
                WeatherIcon = WeatherIcons.SMOKE;
            }
            else if (icon.Contains("dust"))
            {
                WeatherIcon = WeatherIcons.DUST;
            }
            else if (icon.Contains("tropical_storm") || icon.Contains("tsra") || icon.Contains("hurricane"))
            {
                WeatherIcon = WeatherIcons.HURRICANE;
            }
            else if (icon.Contains("tornado"))
            {
                WeatherIcon = WeatherIcons.TORNADO;
            }
            else if (icon.Contains("rain_showers"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_ALT_SHOWERS;
                else
                    WeatherIcon = WeatherIcons.DAY_SHOWERS;
            }
            else if (icon.Contains("fzra") || icon.Contains("rain_sleet") || icon.Contains("rain_snow"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_ALT_RAIN_MIX;
                else
                    WeatherIcon = WeatherIcons.DAY_RAIN_MIX;
            }
            else if (icon.Contains("sleet"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_ALT_SLEET;
                else
                    WeatherIcon = WeatherIcons.DAY_SLEET;
            }
            else if (icon.Contains("rain"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_ALT_RAIN;
                else
                    WeatherIcon = WeatherIcons.DAY_RAIN;
            }
            else if (icon.Contains("snow"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_ALT_SNOW;
                else
                    WeatherIcon = WeatherIcons.DAY_SNOW;
            }
            else if (icon.Contains("wind_bkn") || icon.Contains("wind_ovc") || icon.Contains("wind_sct"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_ALT_CLOUDY_WINDY;
                else
                    WeatherIcon = WeatherIcons.DAY_CLOUDY_WINDY;
            }
            else if (icon.Contains("wind"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.WINDY;
                else
                    WeatherIcon = WeatherIcons.DAY_WINDY;
            }
            else if (icon.Contains("ovc") || icon.Contains("sct") || icon.Contains("few"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_ALT_PARTLY_CLOUDY;
                else
                    WeatherIcon = WeatherIcons.DAY_SUNNY_OVERCAST;
            }
            else if (icon.Contains("bkn"))
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_ALT_CLOUDY;
                else
                    WeatherIcon = WeatherIcons.DAY_CLOUDY;
            }
            else
            {
                if (isNight)
                    WeatherIcon = WeatherIcons.NIGHT_CLEAR;
                else
                    WeatherIcon = WeatherIcons.DAY_SUNNY;
            }

            if (String.IsNullOrWhiteSpace(WeatherIcon))
            {
                // Not Available
                WeatherIcon = WeatherIcons.NA;
            }

            return WeatherIcon;
        }

        public override String GetWeatherCondition(String icon)
        {
            if (icon == null)
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_notavailable");

            if (icon.Contains("fog"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_fog");
            }
            else if (icon.Contains("blizzard"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_blizzard");
            }
            else if (icon.Contains("cold"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_cold");
            }
            else if (icon.Contains("hot"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_hot");
            }
            else if (icon.Contains("haze"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_haze");
            }
            else if (icon.Contains("smoke"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_smoky");
            }
            else if (icon.Contains("dust"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_dust");
            }
            else if (icon.Contains("tropical_storm") || icon.Contains("tsra"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_tropicalstorm");
            }
            else if (icon.Contains("hurricane"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_hurricane");
            }
            else if (icon.Contains("tornado"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_tornado");
            }
            else if (icon.Contains("rain_showers"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_rainshowers");
            }
            else if (icon.Contains("fzra"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_freezingrain");
            }
            else if (icon.Contains("rain_sleet"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_rainandsleet");
            }
            else if (icon.Contains("rain_snow"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_rainandsnow");
            }
            else if (icon.Contains("sleet"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_sleet");
            }
            else if (icon.Contains("rain"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_rain");
            }
            else if (icon.Contains("snow"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_snow");
            }
            else if (icon.Contains("wind_bkn") || icon.Contains("wind_ovc") || icon.Contains("wind_sct") || icon.Contains("wind"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_windy");
            }
            else if (icon.Contains("ovc"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_overcast");
            }
            else if (icon.Contains("sct") || icon.Contains("few"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_partlycloudy");
            }
            else if (icon.Contains("bkn"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_cloudy");
            }
            else if (icon.Contains("day"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_sunny");
            }
            else if (icon.Contains("night"))
            {
                return SimpleLibrary.ResLoader.GetString("/WeatherConditions/weather_clearsky");
            }
            else
            {
                return base.GetWeatherCondition(icon);
            }
        }

        // Some conditions can be for any time of day
        // So use sunrise/set data as fallback
        public override bool IsNight(Weather weather)
        {
            bool isNight = base.IsNight(weather);

            // The following cases can be present at any time of day
            if (WeatherIcons.SNOWFLAKE_COLD.Equals(weather.condition.icon))
            {
                if (!isNight)
                {
                    // Fallback to sunset/rise time just in case
                    var sunrise = NodaTime.LocalTime.FromTicksSinceMidnight(weather.astronomy.sunrise.TimeOfDay.Ticks);
                    var sunset = NodaTime.LocalTime.FromTicksSinceMidnight(weather.astronomy.sunset.TimeOfDay.Ticks);

                    var tz = NodaTime.DateTimeZoneProviders.Tzdb.GetZoneOrNull(weather.location.tz_long);
                    if (tz == null)
                        tz = NodaTime.DateTimeZone.ForOffset(NodaTime.Offset.FromTimeSpan(weather.location.tz_offset));

                    var now = NodaTime.SystemClock.Instance.GetCurrentInstant()
                                .InZone(tz).TimeOfDay;

                    // Determine whether its night using sunset/rise times
                    if (now < sunrise || now > sunset)
                        isNight = true;
                }
            }

            return isNight;
        }
    }
}