﻿using SimpleWeather.Controls;
using SimpleWeather.HERE;
using SimpleWeather.Location;
using SimpleWeather.Metno;
using SimpleWeather.NWS;
using SimpleWeather.OpenWeather;
using SimpleWeather.Utils;
using SimpleWeather.WeatherYahoo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.UI;

namespace SimpleWeather.WeatherData
{
    public static class WeatherAPI
    {
        // APIs
        public const string Yahoo = "Yahoo";
        public const string WeatherUnderground = "WUnderground";
        public const string OpenWeatherMap = "OpenWeather";
        public const string MetNo = "Metno";
        public const string Here = "Here";
        public const string BingMaps = "Bing";
        public const string NWS = "NWS";

        public static readonly IReadOnlyList<ProviderEntry> APIs = new List<ProviderEntry>(5)
        {
            new ProviderEntry("HERE Weather", Here,
                "https://www.here.com/en", "https://developer.here.com/?create=Freemium-Basic&keepState=true&step=account"),
            new ProviderEntry("Yahoo Weather", Yahoo,
                "https://www.yahoo.com/weather?ilc=401", "https://www.yahoo.com/weather?ilc=401"),
            new ProviderEntry("MET Norway", MetNo,
                "https://www.met.no/en", "https://www.met.no/en"),
            new ProviderEntry("U.S. National Weather Service (NOAA)", NWS,
                "https://www.weather.gov", "https://www.weather.gov"),
            new ProviderEntry("OpenWeatherMap", OpenWeatherMap,
                "http://www.openweathermap.org", "https://home.openweathermap.org/users/sign_up"),
        };

        public static readonly IReadOnlyList<ProviderEntry> LocationAPIs = new List<ProviderEntry>(2)
        {
                new ProviderEntry("HERE Maps", Here,
                        "https://www.here.com/en", "https://developer.here.com/"),
                new ProviderEntry("Bing Maps", BingMaps,
                        "https://bing.com/maps", "https://bing.com/maps")
        };
    }

    // Wrapper class for supported Weather Providers
    public sealed class WeatherManager : IWeatherProviderImpl
    {
        private static WeatherManager Instance;
        private static WeatherProviderImpl WeatherProvider;

        // Prevent instance from being created outside of this class
        private WeatherManager()
        {
            UpdateAPI();
        }

        public static WeatherManager GetInstance()
        {
            if (Instance == null)
                Instance = new WeatherManager();

            return Instance;
        }

        public void UpdateAPI()
        {
            string API = Settings.API;

            WeatherProvider = GetProvider(API);
        }

        // Static Methods
        public static WeatherProviderImpl GetProvider(string API)
        {
            WeatherProviderImpl providerImpl = null;

            switch (API)
            {
                case WeatherData.WeatherAPI.Yahoo:
                    providerImpl = new YahooWeatherProvider();
                    break;

                case WeatherData.WeatherAPI.Here:
#if !DEBUG
                default:
#endif
                    providerImpl = new HEREWeatherProvider();
                    break;

                case WeatherData.WeatherAPI.OpenWeatherMap:
                    providerImpl = new OpenWeatherMapProvider();
                    break;

                case WeatherData.WeatherAPI.MetNo:
                    providerImpl = new MetnoWeatherProvider();
                    break;

                case WeatherData.WeatherAPI.NWS:
                    providerImpl = new NWSWeatherProvider();
                    break;
            }

            if (providerImpl == null)
                throw new ArgumentNullException(nameof(API), "Invalid API name! This API is not supported");

            return providerImpl;
        }

        public static bool IsKeyRequired(string API)
        {
            WeatherProviderImpl provider = GetProvider(API);
            bool needsKey = provider.KeyRequired;
            return needsKey;
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public static Task<bool> IsKeyValid(string key, string API)
        {
            var provider = GetProvider(API);
            return provider.IsKeyValid(key);
        }

        // Provider dependent methods
        public string WeatherAPI => WeatherProvider.WeatherAPI;

        public LocationProviderImpl LocationProvider => WeatherProvider.LocationProvider;

        public bool KeyRequired => WeatherProvider.KeyRequired;

        public bool SupportsWeatherLocale => WeatherProvider.SupportsWeatherLocale;

        public bool SupportsAlerts => WeatherProvider.SupportsAlerts;

        public bool NeedsExternalAlertData => WeatherProvider.NeedsExternalAlertData;

        public Task UpdateLocationData(LocationData location)
        {
            return WeatherProvider.UpdateLocationData(location);
        }

        public string UpdateLocationQuery(Weather weather)
        {
            return WeatherProvider.UpdateLocationQuery(weather);
        }

        public string UpdateLocationQuery(LocationData location)
        {
            return WeatherProvider.UpdateLocationQuery(location);
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public Task<ObservableCollection<LocationQueryViewModel>> GetLocations(string ac_query)
        {
            return WeatherProvider.GetLocations(ac_query);
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public Task<LocationQueryViewModel> GetLocation(Windows.Devices.Geolocation.Geoposition geoPos)
        {
            return GetLocation(new WeatherUtils.Coordinate(geoPos));
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public Task<LocationQueryViewModel> GetLocation(WeatherUtils.Coordinate coord)
        {
            return WeatherProvider.GetLocation(coord);
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public Task<Weather> GetWeather(string query, string country_code)
        {
            return WeatherProvider.GetWeather(query, country_code);
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public Task<Weather> GetWeather(LocationData location)
        {
            return WeatherProvider.GetWeather(location);
        }

        public Task<ICollection<WeatherAlert>> GetAlerts(LocationData location)
        {
            return WeatherProvider.GetAlerts(location);
        }

        public String LocaleToLangCode(String iso, String name)
        {
            return WeatherProvider.LocaleToLangCode(iso, name);
        }

        public string GetWeatherIcon(string icon)
        {
            return WeatherProvider.GetWeatherIcon(icon);
        }

        public string GetWeatherIcon(bool isNight, string icon)
        {
            return WeatherProvider.GetWeatherIcon(isNight, icon);
        }

        public string GetWeatherCondition(string icon)
        {
            return WeatherProvider.GetWeatherCondition(icon);
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public Task<bool> IsKeyValid(string key)
        {
            return WeatherProvider.IsKeyValid(key);
        }

        public string GetAPIKey()
        {
            return WeatherProvider.GetAPIKey();
        }

        public bool IsNight(Weather weather)
        {
            return WeatherProvider.IsNight(weather);
        }
    }
}