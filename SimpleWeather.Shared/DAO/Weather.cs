﻿using SimpleWeather.Utils;
using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Utf8Json;
using Utf8Json.Formatters;
using NodaTime;

namespace SimpleWeather.WeatherData
{
    [JsonFormatter(typeof(CustomJsonConverter<Weather>))]
    [Table("weatherdata")]
    public partial class Weather : CustomJsonObject
    {
        [IgnoreDataMember]
        public const string NA = "N/A";

        [TextBlob(nameof(locationblob))]
        public Location location { get; set; }

        [Ignore]
        [IgnoreDataMember]
        // Doesn't store this in db
        // For DateTimeOffset, offset isn't stored when saving to db
        // Store as string (blob) instead
        // If db previously stored DateTimeOffset (as ticks) retrieve and set offset
        public DateTimeOffset update_time
        {
            get
            {
                if (DateTimeOffset.TryParseExact(updatetimeblob, DateTimeUtils.DATETIMEOFFSET_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out DateTimeOffset result))
                    return result;
                else
                    return new DateTimeOffset(long.Parse(updatetimeblob, CultureInfo.InvariantCulture), TimeSpan.Zero).ToOffset(location.tz_offset);
            }
            set { updatetimeblob = value.ToDateTimeOffsetFormat(); }
        }

        [Ignore]
        public IList<Forecast> forecast { get; set; }

        [Ignore]
        public IList<HourlyForecast> hr_forecast { get; set; }

        [Ignore]
        public IList<TextForecast> txt_forecast { get; set; }

        [Ignore]
        public IList<MinutelyForecast> min_forecast { get; set; }

        [TextBlob(nameof(conditionblob))]
        public Condition condition { get; set; }

        [TextBlob(nameof(atmosphereblob))]
        public Atmosphere atmosphere { get; set; }

        [TextBlob(nameof(astronomyblob))]
        public Astronomy astronomy { get; set; }

        [TextBlob(nameof(precipitationblob))]
        public Precipitation precipitation { get; set; }

        [Ignore]
        // Just for passing along to where its needed
        public ICollection<WeatherAlert> weather_alerts { get; set; }

        public int ttl { get; set; }
        public string source { get; set; }

        [PrimaryKey]
        public string query { get; set; }

        public string locale { get; set; }

        [IgnoreDataMember]
        public string locationblob { get; set; }

        [Column("update_time")]
        [DataMember(Name = "update_time")]
        // Keep DateTimeOffset column name to get data as string
        public string updatetimeblob { get; set; }

        [IgnoreDataMember]
        public string conditionblob { get; set; }

        [IgnoreDataMember]
        public string atmosphereblob { get; set; }

        [IgnoreDataMember]
        public string astronomyblob { get; set; }

        [IgnoreDataMember]
        public string precipitationblob { get; set; }

        public Weather()
        {
            // Needed for deserialization
        }

        public override void FromJson(ref JsonReader reader)
        {
            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(location):
                        this.location = new Location();
                        this.location.FromJson(ref reader);
                        break;

                    case nameof(update_time):
                        bool parsed = DateTimeOffset.TryParseExact(reader.ReadString(), DateTimeUtils.DATETIMEOFFSET_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out DateTimeOffset result);
                        if (!parsed) // If we can't parse as DateTimeOffset try DateTime (data could be old)
                            result = DateTime.Parse(reader.ReadString(), CultureInfo.InvariantCulture);
                        else
                        {
                            // DateTimeOffset date stored in SQLite.NET doesn't store offset
                            // Try to convert to location's timezone if possible or if time is in UTC
                            if (this.location?.tz_offset != null && result.Offset.Ticks == 0)
                                result = result.ToOffset(this.location.tz_offset);
                        }
                        this.update_time = result;
                        break;

                    case nameof(forecast):
                        // Set initial cap to 10
                        // Most provider forecasts are <= 10
                        var forecasts = new List<Forecast>(10);
                        count = 0;
                        reader.ReadIsBeginArrayWithVerify();
                        while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref count))
                        {
                            if (reader.GetCurrentJsonToken() == JsonToken.String)
                            {
                                var forecast = new Forecast();
                                forecast.FromJson(ref reader);
                                forecasts.Add(forecast);
                            }
                        }
                        if (count == 0) reader.ReadIsValueSeparator();
                        this.forecast = forecasts;
                        break;

                    case nameof(hr_forecast):
                        // Set initial cap to 90
                        // MetNo contains ~90 items, but HERE contains ~165
                        // If 90+ is needed, let the List impl allocate more
                        var hr_forecasts = new List<HourlyForecast>(90);
                        count = 0;
                        reader.ReadIsBeginArrayWithVerify();
                        while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref count))
                        {
                            if (reader.GetCurrentJsonToken() == JsonToken.String)
                            {
                                var hrf = new HourlyForecast();
                                hrf.FromJson(ref reader);
                                hr_forecasts.Add(hrf);
                            }
                        }
                        if (count == 0) reader.ReadIsValueSeparator();
                        this.hr_forecast = hr_forecasts;
                        break;

                    case nameof(txt_forecast):
                        // Set initial cap to 20
                        // Most provider forecasts are <= 10 (x2 for day & nt)
                        var txt_forecasts = new List<TextForecast>(20);
                        count = 0;
                        reader.ReadIsBeginArrayWithVerify();
                        while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref count))
                        {
                            if (reader.GetCurrentJsonToken() == JsonToken.String)
                            {
                                var txtf = new TextForecast();
                                txtf.FromJson(ref reader);
                                txt_forecasts.Add(txtf);
                            }
                        }
                        if (count == 0) reader.ReadIsValueSeparator();
                        this.txt_forecast = txt_forecasts;
                        break;

                    case nameof(min_forecast):
                        // Set initial cap to 60
                        // Minutely forecasts are usually only for an hour
                        var min_forecasts = new List<MinutelyForecast>(60);
                        count = 0;
                        reader.ReadIsBeginArrayWithVerify();
                        while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref count))
                        {
                            if (reader.GetCurrentJsonToken() == JsonToken.String)
                            {
                                var minF = new MinutelyForecast();
                                minF.FromJson(ref reader);
                                min_forecasts.Add(minF);
                            }
                        }
                        if (count == 0) reader.ReadIsValueSeparator();
                        this.min_forecast = min_forecasts;
                        break;

                    case nameof(condition):
                        this.condition = new Condition();
                        this.condition.FromJson(ref reader);
                        break;

                    case nameof(atmosphere):
                        this.atmosphere = new Atmosphere();
                        this.atmosphere.FromJson(ref reader);
                        break;

                    case nameof(astronomy):
                        this.astronomy = new Astronomy();
                        this.astronomy.FromJson(ref reader);
                        break;

                    case nameof(precipitation):
                        this.precipitation = new Precipitation();
                        this.precipitation.FromJson(ref reader);
                        break;

                    case nameof(weather_alerts):
                        // Set initial cap to 5
                        var alerts = new List<WeatherAlert>(5);
                        count = 0;
                        reader.ReadIsBeginArrayWithVerify();
                        while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref count))
                        {
                            if (reader.GetCurrentJsonToken() == JsonToken.String)
                            {
                                var alert = new WeatherAlert();
                                alert.FromJson(ref reader);
                                alerts.Add(alert);
                            }
                        }
                        if (count == 0) reader.ReadIsValueSeparator();
                        this.weather_alerts = alerts;
                        break;

                    case nameof(ttl):
                        this.ttl = int.Parse(reader.ReadString(), CultureInfo.InvariantCulture);
                        break;

                    case nameof(source):
                        this.source = reader.ReadString();
                        break;

                    case nameof(query):
                        this.query = reader.ReadString();
                        break;

                    case nameof(locale):
                        this.locale = reader.ReadString();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "location" : ""
            writer.WritePropertyName(nameof(location));
            writer.WriteString(location?.ToJson());

            writer.WriteValueSeparator();

            // "update_time" : ""
            writer.WritePropertyName(nameof(update_time));
            writer.WriteString(update_time.ToDateTimeOffsetFormat());

            writer.WriteValueSeparator();

            // "forecast" : ""
            if (forecast != null)
            {
                writer.WritePropertyName(nameof(forecast));
                writer.WriteBeginArray();
                var itemCount = 0;
                foreach (Forecast cast in forecast)
                {
                    if (itemCount > 0)
                        writer.WriteValueSeparator();
                    writer.WriteString(cast?.ToJson());
                    itemCount++;
                }
                writer.WriteEndArray();

                writer.WriteValueSeparator();
            }

            // "hr_forecast" : ""
            if (hr_forecast != null)
            {
                writer.WritePropertyName(nameof(hr_forecast));
                writer.WriteBeginArray();
                var itemCount = 0;
                foreach (HourlyForecast hr_cast in hr_forecast)
                {
                    if (itemCount > 0)
                        writer.WriteValueSeparator();
                    writer.WriteString(hr_cast?.ToJson());
                    itemCount++;
                }
                writer.WriteEndArray();

                writer.WriteValueSeparator();
            }

            // "txt_forecast" : ""
            if (txt_forecast != null)
            {
                writer.WritePropertyName(nameof(txt_forecast));
                writer.WriteBeginArray();
                var itemCount = 0;
                foreach (TextForecast txt_cast in txt_forecast)
                {
                    if (itemCount > 0)
                        writer.WriteValueSeparator();
                    writer.WriteString(txt_cast?.ToJson());
                    itemCount++;
                }
                writer.WriteEndArray();

                writer.WriteValueSeparator();
            }

            // "min_forecast" : ""
            if (min_forecast != null)
            {
                writer.WritePropertyName(nameof(min_forecast));
                writer.WriteBeginArray();
                var itemCount = 0;
                foreach (MinutelyForecast min_cast in min_forecast)
                {
                    if (itemCount > 0)
                        writer.WriteValueSeparator();
                    writer.WriteString(min_cast?.ToJson());
                    itemCount++;
                }
                writer.WriteEndArray();

                writer.WriteValueSeparator();
            }

            // "condition" : ""
            writer.WritePropertyName(nameof(condition));
            writer.WriteString(condition?.ToJson());

            writer.WriteValueSeparator();

            // "atmosphere" : ""
            writer.WritePropertyName(nameof(atmosphere));
            writer.WriteString(atmosphere?.ToJson());

            writer.WriteValueSeparator();

            // "astronomy" : ""
            writer.WritePropertyName(nameof(astronomy));
            writer.WriteString(astronomy?.ToJson());

            writer.WriteValueSeparator();

            // "precipitation" : ""
            if (precipitation != null)
            {
                writer.WritePropertyName(nameof(precipitation));
                writer.WriteString(precipitation?.ToJson());

                writer.WriteValueSeparator();
            }

            // "weather_alerts" : ""
            if (weather_alerts != null)
            {
                writer.WritePropertyName(nameof(weather_alerts));
                writer.WriteBeginArray();
                var itemCount = 0;
                foreach (WeatherAlert alert in weather_alerts)
                {
                    if (itemCount > 0)
                        writer.WriteValueSeparator();
                    writer.WriteString(alert?.ToJson());
                    itemCount++;
                }
                writer.WriteEndArray();

                writer.WriteValueSeparator();
            }

            // "ttl" : ""
            writer.WritePropertyName(nameof(ttl));
            writer.WriteString(ttl.ToInvariantString());

            writer.WriteValueSeparator();

            // "source" : ""
            writer.WritePropertyName(nameof(source));
            writer.WriteString(source);

            writer.WriteValueSeparator();

            // "query" : ""
            writer.WritePropertyName(nameof(query));
            writer.WriteString(query);

            writer.WriteValueSeparator();

            // "locale" : ""
            writer.WritePropertyName(nameof(locale));
            writer.WriteString(locale);

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }

        public bool IsValid()
        {
            if (location == null || condition == null || atmosphere == null)
                return false;
            else
                return true;
        }

        public override bool Equals(object obj)
        {
            return obj is Weather weather &&
                   Object.Equals(location, weather.location) &&
                   //update_time.Equals(weather.update_time) &&
                   ((forecast == null && weather.forecast == null) || weather.forecast != null && forecast?.SequenceEqual(weather.forecast) == true) &&
                   ((hr_forecast == null && weather.hr_forecast == null) || weather.hr_forecast != null && hr_forecast?.SequenceEqual(weather.hr_forecast) == true) &&
                   ((txt_forecast == null && weather.txt_forecast == null) || weather.txt_forecast != null && txt_forecast?.SequenceEqual(weather.txt_forecast) == true) &&
                   ((min_forecast == null && weather.min_forecast == null) || weather.min_forecast != null && min_forecast?.SequenceEqual(weather.min_forecast) == true) &&
                   Object.Equals(condition, weather.condition) &&
                   Object.Equals(atmosphere, weather.atmosphere) &&
                   Object.Equals(astronomy, weather.astronomy) &&
                   Object.Equals(precipitation, weather.precipitation) &&
                   ((weather_alerts == null && weather.weather_alerts == null) || weather.weather_alerts != null && weather_alerts?.SequenceEqual(weather.weather_alerts) == true) &&
                   ttl == weather.ttl &&
                   source == weather.source &&
                   query == weather.query &&
                   locale == weather.locale &&
                   updatetimeblob == weather.updatetimeblob;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(location);
            //hash.Add(update_time);
            hash.Add(forecast);
            hash.Add(hr_forecast);
            hash.Add(txt_forecast);
            hash.Add(min_forecast);
            hash.Add(condition);
            hash.Add(atmosphere);
            hash.Add(astronomy);
            hash.Add(precipitation);
            hash.Add(weather_alerts);
            hash.Add(ttl);
            hash.Add(source);
            hash.Add(query);
            hash.Add(locale);
            hash.Add(updatetimeblob);
            return hash.ToHashCode();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<Location>))]
    public partial class Location : CustomJsonObject
    {
        public string name { get; set; }
        public float? latitude { get; set; }
        public float? longitude { get; set; }
        public string tz_long { get; set; }

        [IgnoreDataMember]
        [Ignore]
        public TimeSpan tz_offset
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(tz_long))
                {
                    var nodaTz = DateTimeZoneProviders.Tzdb.GetZoneOrNull(tz_long);
                    if (nodaTz != null)
                        return nodaTz.GetUtcOffset(SystemClock.Instance.GetCurrentInstant()).ToTimeSpan();
                }
                return TimeSpan.Zero;
            }
        }

        [IgnoreDataMember]
        [Ignore]
        public string tz_short
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(tz_long))
                {
                    var nodaTz = DateTimeZoneProviders.Tzdb.GetZoneOrNull(tz_long);
                    if (nodaTz != null)
                    {
                        return new ZonedDateTime(SystemClock.Instance.GetCurrentInstant(), nodaTz)
                            .ToString("%x", CultureUtils.UserCulture);
                    }
                }
                return "UTC";
            }
        }

        public Location()
        {
            // Needed for deserialization
            tz_long = "UTC";
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   name == location.name &&
                   latitude == location.latitude &&
                   longitude == location.longitude &&
                   tz_long == location.tz_long;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, latitude, longitude, tz_long);
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(name):
                        this.name = reader.ReadString();
                        break;

                    case nameof(latitude):
                        this.latitude = float.Parse(reader.ReadString(), CultureInfo.InvariantCulture);
                        break;

                    case nameof(longitude):
                        this.longitude = float.Parse(reader.ReadString(), CultureInfo.InvariantCulture);
                        break;

                    case nameof(tz_long):
                        this.tz_long = reader.ReadString();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "name" : ""
            writer.WritePropertyName(nameof(name));
            writer.WriteString(name);

            writer.WriteValueSeparator();

            // "latitude" : ""
            writer.WritePropertyName(nameof(latitude));
            writer.WriteString(latitude?.ToInvariantString());

            writer.WriteValueSeparator();

            // "longitude" : ""
            writer.WritePropertyName(nameof(longitude));
            writer.WriteString(longitude?.ToInvariantString());

            writer.WriteValueSeparator();

            // "tz_long" : ""
            writer.WritePropertyName(nameof(tz_long));
            writer.WriteString(tz_long);

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    public abstract class BaseForecast : CustomJsonObject
    {
        public float? high_f { get; set; }
        public float? high_c { get; set; }
        public string condition { get; set; }
        public string icon { get; set; }
        public ForecastExtras extras { get; set; }
    }

    [JsonFormatter(typeof(CustomJsonConverter<Forecast>))]
    public partial class Forecast : BaseForecast
    {
        [JsonFormatter(typeof(DateTimeFormatter), DateTimeUtils.ISO8601_DATETIME_FORMAT)]
        public DateTime date { get; set; }

        public float? low_f { get; set; }
        public float? low_c { get; set; }

        public Forecast()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is Forecast forecast &&
                   date == forecast.date &&
                   high_f == forecast.high_f &&
                   high_c == forecast.high_c &&
                   low_f == forecast.low_f &&
                   low_c == forecast.low_c &&
                   condition == forecast.condition &&
                   icon == forecast.icon &&
                   Object.Equals(extras, forecast.extras);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(date, high_f, high_c, low_f, low_c, condition, icon, extras);
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(date):
                        this.date = DateTime.Parse(reader.ReadString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        break;

                    case nameof(high_f):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float highF))
                            this.high_f = highF;
                        break;

                    case nameof(high_c):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float highC))
                            this.high_c = highC;
                        break;

                    case nameof(low_f):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float lowF))
                            this.low_f = lowF;
                        break;

                    case nameof(low_c):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float lowC))
                            this.low_c = lowC;
                        break;

                    case nameof(condition):
                        this.condition = reader.ReadString();
                        break;

                    case nameof(icon):
                        this.icon = reader.ReadString();
                        break;

                    case nameof(extras):
                        this.extras = new ForecastExtras();
                        this.extras.FromJson(ref reader);
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "date" : ""
            writer.WritePropertyName(nameof(date));
            writer.WriteString(date.ToISO8601Format());

            writer.WriteValueSeparator();

            // "high_f" : ""
            writer.WritePropertyName(nameof(high_f));
            writer.WriteString(high_f?.ToInvariantString());

            writer.WriteValueSeparator();

            // "high_c" : ""
            writer.WritePropertyName(nameof(high_c));
            writer.WriteString(high_c?.ToInvariantString());

            writer.WriteValueSeparator();

            // "low_f" : ""
            writer.WritePropertyName(nameof(low_f));
            writer.WriteString(low_f?.ToInvariantString());

            writer.WriteValueSeparator();

            // "low_c" : ""
            writer.WritePropertyName(nameof(low_c));
            writer.WriteString(low_c?.ToInvariantString());

            writer.WriteValueSeparator();

            // "condition" : ""
            writer.WritePropertyName(nameof(condition));
            writer.WriteString(condition);

            writer.WriteValueSeparator();

            // "icon" : ""
            writer.WritePropertyName(nameof(icon));
            writer.WriteString(icon);

            // "extras" : ""
            if (extras != null)
            {
                writer.WriteValueSeparator();

                writer.WritePropertyName(nameof(extras));
                writer.WriteString(extras?.ToJson());
            }

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<HourlyForecast>))]
    public partial class HourlyForecast : BaseForecast
    {
        [DataMember(Name = "date")]
        [JsonFormatter(typeof(DateTimeOffsetFormatter), DateTimeUtils.DATETIMEOFFSET_FORMAT)]
        public DateTimeOffset date { get; set; }

        public int? wind_degrees { get; set; }
        public float? wind_mph { get; set; }
        public float? wind_kph { get; set; }

        public HourlyForecast()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is HourlyForecast forecast &&
                   date == forecast.date &&
                   high_f == forecast.high_f &&
                   high_c == forecast.high_c &&
                   condition == forecast.condition &&
                   icon == forecast.icon &&
                   wind_degrees == forecast.wind_degrees &&
                   wind_mph == forecast.wind_mph &&
                   wind_kph == forecast.wind_kph &&
                   Object.Equals(extras, forecast.extras);
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(date);
            hash.Add(high_f);
            hash.Add(high_c);
            hash.Add(condition);
            hash.Add(icon);
            hash.Add(wind_degrees);
            hash.Add(wind_mph);
            hash.Add(wind_kph);
            hash.Add(extras);
            return hash.ToHashCode();
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(date):
                        this.date = DateTimeOffset.ParseExact(reader.ReadString(), DateTimeUtils.DATETIMEOFFSET_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        break;

                    case nameof(high_f):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float highF))
                            this.high_f = highF;
                        break;

                    case nameof(high_c):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float highC))
                            this.high_c = highC;
                        break;

                    case nameof(condition):
                        this.condition = reader.ReadString();
                        break;

                    case nameof(icon):
                        this.icon = reader.ReadString();
                        break;

                    case nameof(wind_degrees):
                        this.wind_degrees = reader.ReadInt32();
                        break;

                    case nameof(wind_mph):
                        this.wind_mph = reader.ReadSingle();
                        break;

                    case nameof(wind_kph):
                        this.wind_kph = reader.ReadSingle();
                        break;

                    case nameof(extras):
                        this.extras = new ForecastExtras();
                        this.extras.FromJson(ref reader);
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "date" : ""
            writer.WritePropertyName(nameof(date));
            writer.WriteString(date.ToDateTimeOffsetFormat());

            writer.WriteValueSeparator();

            // "high_f" : ""
            writer.WritePropertyName(nameof(high_f));
            writer.WriteString(high_f?.ToInvariantString());

            writer.WriteValueSeparator();

            // "high_c" : ""
            writer.WritePropertyName(nameof(high_c));
            writer.WriteString(high_c?.ToInvariantString());

            writer.WriteValueSeparator();

            // "condition" : ""
            writer.WritePropertyName(nameof(condition));
            writer.WriteString(condition);

            writer.WriteValueSeparator();

            // "icon" : ""
            writer.WritePropertyName(nameof(icon));
            writer.WriteString(icon);

            writer.WriteValueSeparator();

            // "wind_degrees" : ""
            writer.WritePropertyName(nameof(wind_degrees));
            writer.WriteInt32(wind_degrees.GetValueOrDefault(-1));

            writer.WriteValueSeparator();

            // "wind_mph" : ""
            writer.WritePropertyName(nameof(wind_mph));
            writer.WriteSingle(wind_mph.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "wind_kph" : ""
            writer.WritePropertyName(nameof(wind_kph));
            writer.WriteSingle(wind_kph.GetValueOrDefault(-1.0f));

            // "extras" : ""
            if (extras != null)
            {
                writer.WriteValueSeparator();

                writer.WritePropertyName(nameof(extras));
                writer.WriteString(extras?.ToJson());
            }

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<MinutelyForecast>))]
    public partial class MinutelyForecast : CustomJsonObject
    {
        [JsonFormatter(typeof(DateTimeOffsetFormatter), DateTimeUtils.ISO8601_DATETIMEOFFSET_FORMAT)]
        public DateTimeOffset date { get; set; }

        public float? rain_mm { get; set; }

        public MinutelyForecast()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is MinutelyForecast forecast &&
                   date == forecast.date &&
                   rain_mm == forecast.rain_mm;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(date);
            hash.Add(rain_mm);
            return hash.ToHashCode();
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(date):
                        this.date = DateTimeOffset.ParseExact(reader.ReadString(), DateTimeUtils.ISO8601_DATETIMEOFFSET_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        break;

                    case nameof(rain_mm):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float rainMm))
                            this.rain_mm = rainMm;
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "date" : ""
            writer.WritePropertyName(nameof(date));
            writer.WriteString(date.ToISO8601Format());

            writer.WriteValueSeparator();

            // "rain_mm" : ""
            writer.WritePropertyName(nameof(rain_mm));
            writer.WriteString(rain_mm?.ToInvariantString());

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<TextForecast>))]
    public partial class TextForecast : CustomJsonObject
    {
        [JsonFormatter(typeof(DateTimeOffsetFormatter), DateTimeUtils.ISO8601_DATETIMEOFFSET_FORMAT)]
        public DateTimeOffset date { get; set; }

        public string fcttext { get; set; }
        public string fcttext_metric { get; set; }

        public TextForecast()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is TextForecast forecast &&
                   date == forecast.date &&
                   fcttext == forecast.fcttext &&
                   fcttext_metric == forecast.fcttext_metric;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(date);
            hash.Add(fcttext);
            hash.Add(fcttext_metric);
            return hash.ToHashCode();
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(date):
                        this.date = DateTimeOffset.ParseExact(reader.ReadString(), DateTimeUtils.ISO8601_DATETIMEOFFSET_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        break;

                    case nameof(fcttext):
                        this.fcttext = reader.ReadString();
                        break;

                    case nameof(fcttext_metric):
                        this.fcttext_metric = reader.ReadString();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "date" : ""
            writer.WritePropertyName(nameof(date));
            writer.WriteString(date.ToISO8601Format());

            writer.WriteValueSeparator();

            // "fcttext" : ""
            writer.WritePropertyName(nameof(fcttext));
            writer.WriteString(fcttext);

            writer.WriteValueSeparator();

            // "fcttext_metric" : ""
            writer.WritePropertyName(nameof(fcttext_metric));
            writer.WriteString(fcttext_metric);

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<ForecastExtras>))]
    public class ForecastExtras : CustomJsonObject
    {
        public float? feelslike_f { get; set; }
        public float? feelslike_c { get; set; }
        public int? humidity { get; set; }
        public float? dewpoint_f { get; set; }
        public float? dewpoint_c { get; set; }
        public float? uv_index { get; set; }
        public int? pop { get; set; }
        public int? cloudiness { get; set; }
        public float? qpf_rain_in { get; set; }
        public float? qpf_rain_mm { get; set; }
        public float? qpf_snow_in { get; set; }
        public float? qpf_snow_cm { get; set; }
        public float? pressure_mb { get; set; }
        public float? pressure_in { get; set; }
        public int? wind_degrees { get; set; }
        public float? wind_mph { get; set; }
        public float? wind_kph { get; set; }
        public float? visibility_mi { get; set; }
        public float? visibility_km { get; set; }
        public float? windgust_mph { get; set; }
        public float? windgust_kph { get; set; }

        public ForecastExtras()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is ForecastExtras extras &&
                   feelslike_f == extras.feelslike_f &&
                   feelslike_c == extras.feelslike_c &&
                   humidity == extras.humidity &&
                   dewpoint_f == extras.dewpoint_f &&
                   dewpoint_c == extras.dewpoint_c &&
                   uv_index == extras.uv_index &&
                   pop == extras.pop &&
                   cloudiness == extras.cloudiness &&
                   qpf_rain_in == extras.qpf_rain_in &&
                   qpf_rain_mm == extras.qpf_rain_mm &&
                   qpf_snow_in == extras.qpf_snow_in &&
                   qpf_snow_cm == extras.qpf_snow_cm &&
                   pressure_mb == extras.pressure_mb &&
                   pressure_in == extras.pressure_in &&
                   wind_degrees == extras.wind_degrees &&
                   wind_mph == extras.wind_mph &&
                   wind_kph == extras.wind_kph &&
                   visibility_mi == extras.visibility_mi &&
                   visibility_km == extras.visibility_km &&
                   windgust_mph == extras.windgust_mph &&
                   windgust_kph == extras.windgust_kph;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(feelslike_f);
            hash.Add(feelslike_c);
            hash.Add(humidity);
            hash.Add(dewpoint_f);
            hash.Add(dewpoint_c);
            hash.Add(uv_index);
            hash.Add(pop);
            hash.Add(cloudiness);
            hash.Add(qpf_rain_in);
            hash.Add(qpf_rain_mm);
            hash.Add(qpf_snow_in);
            hash.Add(qpf_snow_cm);
            hash.Add(pressure_mb);
            hash.Add(pressure_in);
            hash.Add(wind_degrees);
            hash.Add(wind_mph);
            hash.Add(wind_kph);
            hash.Add(visibility_mi);
            hash.Add(visibility_km);
            hash.Add(windgust_mph);
            hash.Add(windgust_kph);
            return hash.ToHashCode();
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(feelslike_f):
                        this.feelslike_f = reader.ReadSingle();
                        break;

                    case nameof(feelslike_c):
                        this.feelslike_c = reader.ReadSingle();
                        break;

                    case nameof(humidity):
                        if (int.TryParse(reader.ReadString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int Humidity))
                            this.humidity = Humidity;
                        break;

                    case nameof(dewpoint_f):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float dewpointF))
                            this.dewpoint_f = dewpointF;
                        break;

                    case nameof(dewpoint_c):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float dewpointC))
                            this.dewpoint_c = dewpointC;
                        break;

                    case nameof(uv_index):
                        this.uv_index = reader.ReadSingle();
                        break;

                    case nameof(pop):
                        if (int.TryParse(reader.ReadString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int POP))
                            this.pop = POP;
                        break;

                    case nameof(cloudiness):
                        if (int.TryParse(reader.ReadString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int Clouds))
                            this.cloudiness = Clouds;
                        break;

                    case nameof(qpf_rain_in):
                        this.qpf_rain_in = reader.ReadSingle();
                        break;

                    case nameof(qpf_rain_mm):
                        this.qpf_rain_mm = reader.ReadSingle();
                        break;

                    case nameof(qpf_snow_in):
                        this.qpf_snow_in = reader.ReadSingle();
                        break;

                    case nameof(qpf_snow_cm):
                        this.qpf_snow_cm = reader.ReadSingle();
                        break;

                    case nameof(pressure_mb):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float pressureMB))
                            this.pressure_mb = pressureMB;
                        break;

                    case nameof(pressure_in):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float pressureIN))
                            this.pressure_in = pressureIN;
                        break;

                    case nameof(wind_degrees):
                        this.wind_degrees = reader.ReadInt32();
                        break;

                    case nameof(wind_mph):
                        this.wind_mph = reader.ReadSingle();
                        break;

                    case nameof(wind_kph):
                        this.wind_kph = reader.ReadSingle();
                        break;

                    case nameof(visibility_mi):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float visibilityMI))
                            this.visibility_mi = visibilityMI;
                        break;

                    case nameof(visibility_km):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float visibilityKM))
                            this.visibility_km = visibilityKM;
                        break;

                    case nameof(windgust_mph):
                        this.windgust_mph = reader.ReadSingle();
                        break;

                    case nameof(windgust_kph):
                        this.windgust_kph = reader.ReadSingle();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();
            // {
            writer.WriteBeginObject();

            // "feelslike_f" : ""
            writer.WritePropertyName(nameof(feelslike_f));
            writer.WriteSingle(feelslike_f.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "feelslike_c" : ""
            writer.WritePropertyName(nameof(feelslike_c));
            writer.WriteSingle(feelslike_c.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "humidity" : ""
            writer.WritePropertyName(nameof(humidity));
            writer.WriteString(humidity?.ToInvariantString());

            writer.WriteValueSeparator();

            // "dewpoint_f" : ""
            writer.WritePropertyName(nameof(dewpoint_f));
            writer.WriteString(dewpoint_f?.ToInvariantString());

            writer.WriteValueSeparator();

            // "dewpoint_c" : ""
            writer.WritePropertyName(nameof(dewpoint_c));
            writer.WriteString(dewpoint_c?.ToInvariantString());

            writer.WriteValueSeparator();

            // "uv_index" : ""
            writer.WritePropertyName(nameof(uv_index));
            writer.WriteSingle(uv_index.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "pop" : ""
            writer.WritePropertyName(nameof(pop));
            writer.WriteString(pop?.ToInvariantString());

            writer.WriteValueSeparator();

            // "cloudiness" : ""
            writer.WritePropertyName(nameof(cloudiness));
            writer.WriteString(cloudiness?.ToInvariantString());

            writer.WriteValueSeparator();

            // "qpf_rain_in" : ""
            writer.WritePropertyName(nameof(qpf_rain_in));
            writer.WriteSingle(qpf_rain_in.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "qpf_rain_mm" : ""
            writer.WritePropertyName(nameof(qpf_rain_mm));
            writer.WriteSingle(qpf_rain_mm.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "qpf_snow_in" : ""
            writer.WritePropertyName(nameof(qpf_snow_in));
            writer.WriteSingle(qpf_snow_in.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "qpf_snow_cm" : ""
            writer.WritePropertyName(nameof(qpf_snow_cm));
            writer.WriteSingle(qpf_snow_cm.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "pressure_mb" : ""
            writer.WritePropertyName(nameof(pressure_mb));
            writer.WriteString(pressure_mb?.ToInvariantString());

            writer.WriteValueSeparator();

            // "pressure_in" : ""
            writer.WritePropertyName(nameof(pressure_in));
            writer.WriteString(pressure_in?.ToInvariantString());

            writer.WriteValueSeparator();

            // "wind_degrees" : ""
            writer.WritePropertyName(nameof(wind_degrees));
            writer.WriteInt32(wind_degrees.GetValueOrDefault(-1));

            writer.WriteValueSeparator();

            // "wind_mph" : ""
            writer.WritePropertyName(nameof(wind_mph));
            writer.WriteSingle(wind_mph.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "wind_kph" : ""
            writer.WritePropertyName(nameof(wind_kph));
            writer.WriteSingle(wind_kph.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "visibility_mi" : ""
            writer.WritePropertyName(nameof(visibility_mi));
            writer.WriteString(visibility_mi?.ToInvariantString());

            writer.WriteValueSeparator();

            // "visibility_km" : ""
            writer.WritePropertyName(nameof(visibility_km));
            writer.WriteString(visibility_km?.ToInvariantString());

            writer.WriteValueSeparator();

            // "windgust_mph" : ""
            writer.WritePropertyName(nameof(windgust_mph));
            writer.WriteSingle(windgust_mph.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "windgust_kph" : ""
            writer.WritePropertyName(nameof(windgust_kph));
            writer.WriteSingle(windgust_kph.GetValueOrDefault(-1.0f));

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<Condition>))]
    public partial class Condition : CustomJsonObject
    {
        public string weather { get; set; }
        public float? temp_f { get; set; }
        public float? temp_c { get; set; }
        public int? wind_degrees { get; set; }
        public float? wind_mph { get; set; }
        public float? wind_kph { get; set; }
        public float? windgust_mph { get; set; }
        public float? windgust_kph { get; set; }
        public float? feelslike_f { get; set; }
        public float? feelslike_c { get; set; }
        public string icon { get; set; }
        public Beaufort beaufort { get; set; }
        public UV uv { get; set; }
        public float? high_f { get; set; }
        public float? high_c { get; set; }
        public float? low_f { get; set; }
        public float? low_c { get; set; }
        public AirQuality airQuality { get; set; }
        public DateTimeOffset observation_time { get; set; }
        public string summary { get; set; }

        public Condition()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is Condition condition &&
                   weather == condition.weather &&
                   temp_f == condition.temp_f &&
                   temp_c == condition.temp_c &&
                   wind_degrees == condition.wind_degrees &&
                   wind_mph == condition.wind_mph &&
                   wind_kph == condition.wind_kph &&
                   feelslike_f == condition.feelslike_f &&
                   feelslike_c == condition.feelslike_c &&
                   icon == condition.icon &&
                   Object.Equals(beaufort, condition.beaufort) &&
                   Object.Equals(uv, condition.uv) &&
                   high_f == condition.high_f &&
                   high_c == condition.high_c &&
                   low_f == condition.low_f &&
                   low_c == condition.low_c &&
                   Object.Equals(airQuality, condition.airQuality) &&
                   observation_time == condition.observation_time &&
                   summary == condition.summary;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(weather);
            hash.Add(temp_f);
            hash.Add(temp_c);
            hash.Add(wind_degrees);
            hash.Add(wind_mph);
            hash.Add(wind_kph);
            hash.Add(feelslike_f);
            hash.Add(feelslike_c);
            hash.Add(icon);
            hash.Add(beaufort);
            hash.Add(uv);
            hash.Add(high_f);
            hash.Add(high_c);
            hash.Add(low_f);
            hash.Add(low_c);
            hash.Add(airQuality);
            hash.Add(observation_time);
            hash.Add(summary);
            return hash.ToHashCode();
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(weather):
                        this.weather = reader.ReadString();
                        break;

                    case nameof(temp_f):
                        this.temp_f = reader.ReadSingle();
                        break;

                    case nameof(temp_c):
                        this.temp_c = reader.ReadSingle();
                        break;

                    case nameof(wind_degrees):
                        this.wind_degrees = reader.ReadInt32();
                        break;

                    case nameof(wind_mph):
                        this.wind_mph = reader.ReadSingle();
                        break;

                    case nameof(wind_kph):
                        this.wind_kph = reader.ReadSingle();
                        break;

                    case nameof(windgust_mph):
                        this.windgust_mph = reader.ReadSingle();
                        break;

                    case nameof(windgust_kph):
                        this.windgust_kph = reader.ReadSingle();
                        break;

                    case nameof(feelslike_f):
                        this.feelslike_f = reader.ReadSingle();
                        break;

                    case nameof(feelslike_c):
                        this.feelslike_c = reader.ReadSingle();
                        break;

                    case nameof(icon):
                        this.icon = reader.ReadString();
                        break;

                    case nameof(beaufort):
                        this.beaufort = new Beaufort();
                        this.beaufort.FromJson(ref reader);
                        break;

                    case nameof(uv):
                        this.uv = new UV();
                        this.uv.FromJson(ref reader);
                        break;

                    case nameof(high_f):
                        this.high_f = reader.ReadSingle();
                        break;

                    case nameof(high_c):
                        this.high_c = reader.ReadSingle();
                        break;

                    case nameof(low_f):
                        this.low_f = reader.ReadSingle();
                        break;

                    case nameof(low_c):
                        this.low_c = reader.ReadSingle();
                        break;

                    case nameof(airQuality):
                        this.airQuality = new AirQuality();
                        this.airQuality.FromJson(ref reader);
                        break;

                    case nameof(observation_time):
                        this.observation_time = DateTimeOffset.ParseExact(reader.ReadString(), DateTimeUtils.ISO8601_DATETIMEOFFSET_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        break;

                    case nameof(summary):
                        this.summary = reader.ReadString();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "weather" : ""
            writer.WritePropertyName(nameof(weather));
            writer.WriteString(weather);

            writer.WriteValueSeparator();

            // "temp_f" : ""
            writer.WritePropertyName(nameof(temp_f));
            writer.WriteSingle(temp_f.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "temp_c" : ""
            writer.WritePropertyName(nameof(temp_c));
            writer.WriteSingle(temp_c.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "wind_degrees" : ""
            writer.WritePropertyName(nameof(wind_degrees));
            writer.WriteInt32(wind_degrees.GetValueOrDefault(-1));

            writer.WriteValueSeparator();

            // "wind_mph" : ""
            writer.WritePropertyName(nameof(wind_mph));
            writer.WriteSingle(wind_mph.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "wind_kph" : ""
            writer.WritePropertyName(nameof(wind_kph));
            writer.WriteSingle(wind_kph.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "windgust_mph" : ""
            writer.WritePropertyName(nameof(windgust_mph));
            writer.WriteSingle(windgust_mph.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "windgust_kph" : ""
            writer.WritePropertyName(nameof(windgust_kph));
            writer.WriteSingle(windgust_kph.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "feelslike_f" : ""
            writer.WritePropertyName(nameof(feelslike_f));
            writer.WriteSingle(feelslike_f.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "feelslike_c" : ""
            writer.WritePropertyName(nameof(feelslike_c));
            writer.WriteSingle(feelslike_c.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "icon" : ""
            writer.WritePropertyName(nameof(icon));
            writer.WriteString(icon);

            // "beaufort" : ""
            if (beaufort != null)
            {
                writer.WriteValueSeparator();

                writer.WritePropertyName(nameof(beaufort));
                writer.WriteString(beaufort?.ToJson());
            }

            // "uv" : ""
            if (uv != null)
            {
                writer.WriteValueSeparator();

                writer.WritePropertyName(nameof(uv));
                writer.WriteString(uv?.ToJson());
            }

            writer.WriteValueSeparator();

            // "high_f" : ""
            writer.WritePropertyName(nameof(high_f));
            writer.WriteSingle(high_f.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "high_c" : ""
            writer.WritePropertyName(nameof(high_c));
            writer.WriteSingle(high_c.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "low_f" : ""
            writer.WritePropertyName(nameof(low_f));
            writer.WriteSingle(low_f.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "low_c" : ""
            writer.WritePropertyName(nameof(low_c));
            writer.WriteSingle(low_c.GetValueOrDefault(-1.0f));

            // "airQuality" : ""
            if (airQuality != null)
            {
                writer.WriteValueSeparator();

                writer.WritePropertyName(nameof(airQuality));
                writer.WriteString(airQuality?.ToJson());
            }

            writer.WriteValueSeparator();

            // "observation_time" : ""
            writer.WritePropertyName(nameof(observation_time));
            writer.WriteString(observation_time.ToISO8601Format());

            writer.WriteValueSeparator();

            // "summary" : ""
            writer.WritePropertyName(nameof(summary));
            writer.WriteString(summary);

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<Atmosphere>))]
    public partial class Atmosphere : CustomJsonObject
    {
        public int? humidity { get; set; }
        public float? pressure_mb { get; set; }
        public float? pressure_in { get; set; }
        public string pressure_trend { get; set; }
        public float? visibility_mi { get; set; }
        public float? visibility_km { get; set; }
        public float? dewpoint_f { get; set; }
        public float? dewpoint_c { get; set; }

        public Atmosphere()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is Atmosphere atmosphere &&
                   humidity == atmosphere.humidity &&
                   pressure_mb == atmosphere.pressure_mb &&
                   pressure_in == atmosphere.pressure_in &&
                   pressure_trend == atmosphere.pressure_trend &&
                   visibility_mi == atmosphere.visibility_mi &&
                   visibility_km == atmosphere.visibility_km &&
                   dewpoint_f == atmosphere.dewpoint_f &&
                   dewpoint_c == atmosphere.dewpoint_c;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(humidity, pressure_mb, pressure_in, pressure_trend, visibility_mi, visibility_km, dewpoint_f, dewpoint_c);
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(humidity):
                        if (int.TryParse(reader.ReadString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int Humidity))
                            this.humidity = Humidity;
                        break;

                    case nameof(pressure_mb):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float pressureMB))
                            this.pressure_mb = pressureMB;
                        break;

                    case nameof(pressure_in):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float pressureIN))
                            this.pressure_in = pressureIN;
                        break;

                    case nameof(pressure_trend):
                        this.pressure_trend = reader.ReadString();
                        break;

                    case nameof(visibility_mi):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float visibilityMI))
                            this.visibility_mi = visibilityMI;
                        break;

                    case nameof(visibility_km):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float visibilityKM))
                            this.visibility_km = visibilityKM;
                        break;

                    case nameof(dewpoint_f):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float dewpointF))
                            this.dewpoint_f = dewpointF;
                        break;

                    case nameof(dewpoint_c):
                        if (float.TryParse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float dewpointC))
                            this.dewpoint_c = dewpointC;
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "humidity" : ""
            writer.WritePropertyName(nameof(humidity));
            writer.WriteString(humidity?.ToInvariantString());

            writer.WriteValueSeparator();

            // "pressure_mb" : ""
            writer.WritePropertyName(nameof(pressure_mb));
            writer.WriteString(pressure_mb?.ToInvariantString());

            writer.WriteValueSeparator();

            // "pressure_in" : ""
            writer.WritePropertyName(nameof(pressure_in));
            writer.WriteString(pressure_in?.ToInvariantString());

            writer.WriteValueSeparator();

            // "pressure_trend" : ""
            writer.WritePropertyName(nameof(pressure_trend));
            writer.WriteString(pressure_trend);

            writer.WriteValueSeparator();

            // "visibility_mi" : ""
            writer.WritePropertyName(nameof(visibility_mi));
            writer.WriteString(visibility_mi?.ToInvariantString());

            writer.WriteValueSeparator();

            // "visibility_km" : ""
            writer.WritePropertyName(nameof(visibility_km));
            writer.WriteString(visibility_km?.ToInvariantString());

            writer.WriteValueSeparator();

            // "dewpoint_f" : ""
            writer.WritePropertyName(nameof(dewpoint_f));
            writer.WriteString(dewpoint_f?.ToInvariantString());

            writer.WriteValueSeparator();

            // "dewpoint_c" : ""
            writer.WritePropertyName(nameof(dewpoint_c));
            writer.WriteString(dewpoint_c?.ToInvariantString());

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<Astronomy>))]
    public partial class Astronomy : CustomJsonObject
    {
        [JsonFormatter(typeof(DateTimeFormatter), DateTimeUtils.ISO8601_DATETIME_FORMAT)]
        public DateTime sunrise { get; set; }

        [JsonFormatter(typeof(DateTimeFormatter), DateTimeUtils.ISO8601_DATETIME_FORMAT)]
        public DateTime sunset { get; set; }

        [JsonFormatter(typeof(DateTimeFormatter), DateTimeUtils.ISO8601_DATETIME_FORMAT)]
        public DateTime moonrise { get; set; }

        [JsonFormatter(typeof(DateTimeFormatter), DateTimeUtils.ISO8601_DATETIME_FORMAT)]
        public DateTime moonset { get; set; }

        public MoonPhase moonphase { get; set; }

        public Astronomy()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is Astronomy astronomy &&
                   sunrise == astronomy.sunrise &&
                   sunset == astronomy.sunset &&
                   moonrise == astronomy.moonrise &&
                   moonset == astronomy.moonset &&
                   Object.Equals(moonphase, astronomy.moonphase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sunrise, sunset, moonrise, moonset, moonphase);
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(sunrise):
                        this.sunrise = DateTime.Parse(reader.ReadString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        break;

                    case nameof(sunset):
                        this.sunset = DateTime.Parse(reader.ReadString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        break;

                    case nameof(moonrise):
                        this.moonrise = DateTime.Parse(reader.ReadString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        break;

                    case nameof(moonset):
                        this.moonset = DateTime.Parse(reader.ReadString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        break;

                    case nameof(moonphase):
                        this.moonphase = new MoonPhase();
                        this.moonphase.FromJson(ref reader);
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "sunrise" : ""
            writer.WritePropertyName(nameof(sunrise));
            writer.WriteString(sunrise.ToISO8601Format());

            writer.WriteValueSeparator();

            // "sunset" : ""
            writer.WritePropertyName(nameof(sunset));
            writer.WriteString(sunset.ToISO8601Format());

            writer.WriteValueSeparator();

            // "moonrise" : ""
            writer.WritePropertyName(nameof(moonrise));
            writer.WriteString(moonrise.ToISO8601Format());

            writer.WriteValueSeparator();

            // "moonset" : ""
            writer.WritePropertyName(nameof(moonset));
            writer.WriteString(moonset.ToISO8601Format());

            // "moonphase" : ""
            if (moonphase != null)
            {
                writer.WriteValueSeparator();

                writer.WritePropertyName(nameof(moonphase));
                writer.WriteString(moonphase?.ToJson());
            }

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<Precipitation>))]
    public partial class Precipitation : CustomJsonObject
    {
        public int? pop { get; set; }
        public int? cloudiness { get; set; }
        public float? qpf_rain_in { get; set; }
        public float? qpf_rain_mm { get; set; }
        public float? qpf_snow_in { get; set; }
        public float? qpf_snow_cm { get; set; }

        public Precipitation()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is Precipitation precipitation &&
                   pop == precipitation.pop &&
                   cloudiness == precipitation.cloudiness &&
                   qpf_rain_in == precipitation.qpf_rain_in &&
                   qpf_rain_mm == precipitation.qpf_rain_mm &&
                   qpf_snow_in == precipitation.qpf_snow_in &&
                   qpf_snow_cm == precipitation.qpf_snow_cm;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(pop, cloudiness, qpf_rain_in, qpf_rain_mm, qpf_snow_in, qpf_snow_cm);
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(pop):
                        if (int.TryParse(reader.ReadString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int POP))
                            this.pop = POP;
                        break;

                    case nameof(cloudiness):
                        if (int.TryParse(reader.ReadString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int Clouds))
                            this.cloudiness = Clouds;
                        break;

                    case nameof(qpf_rain_in):
                        this.qpf_rain_in = reader.ReadSingle();
                        break;

                    case nameof(qpf_rain_mm):
                        this.qpf_rain_mm = reader.ReadSingle();
                        break;

                    case nameof(qpf_snow_in):
                        this.qpf_snow_in = reader.ReadSingle();
                        break;

                    case nameof(qpf_snow_cm):
                        this.qpf_snow_cm = reader.ReadSingle();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "pop" : ""
            writer.WritePropertyName(nameof(pop));
            writer.WriteString(pop?.ToInvariantString());

            writer.WriteValueSeparator();

            // "cloudiness" : ""
            writer.WritePropertyName(nameof(cloudiness));
            writer.WriteString(cloudiness?.ToInvariantString());

            writer.WriteValueSeparator();

            // "qpf_rain_in" : ""
            writer.WritePropertyName(nameof(qpf_rain_in));
            writer.WriteSingle(qpf_rain_in.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "qpf_rain_mm" : ""
            writer.WritePropertyName(nameof(qpf_rain_mm));
            writer.WriteSingle(qpf_rain_mm.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "qpf_snow_in" : ""
            writer.WritePropertyName(nameof(qpf_snow_in));
            writer.WriteSingle(qpf_snow_in.GetValueOrDefault(-1.0f));

            writer.WriteValueSeparator();

            // "qpf_snow_cm" : ""
            writer.WritePropertyName(nameof(qpf_snow_cm));
            writer.WriteSingle(qpf_snow_cm.GetValueOrDefault(-1.0f));

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<Beaufort>))]
    public partial class Beaufort : CustomJsonObject
    {
        public enum BeaufortScale
        {
            B0 = 0,
            B1 = 1,
            B2 = 2,
            B3 = 3,
            B4 = 4,
            B5 = 5,
            B6 = 6,
            B7 = 7,
            B8 = 8,
            B9 = 9,
            B10 = 10,
            B11 = 11,
            B12 = 12
        }

        public BeaufortScale scale { get; set; }

        public Beaufort()
        {
            // Needed for deserialization
        }

        public Beaufort(BeaufortScale scale)
        {
            this.scale = scale;
        }

        public override bool Equals(object obj)
        {
            return obj is Beaufort beaufort &&
                   scale == beaufort.scale;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(scale);
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(scale):
                        this.scale = (BeaufortScale)reader.ReadInt32();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "scale" : ""
            writer.WritePropertyName(nameof(scale));
            writer.WriteInt32((int)scale);

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<MoonPhase>))]
    public partial class MoonPhase : CustomJsonObject
    {
        public enum MoonPhaseType
        {
            NewMoon = 0,
            WaxingCrescent,
            FirstQtr,
            WaxingGibbous,
            FullMoon,
            WaningGibbous,
            LastQtr,
            WaningCrescent
        }

        public MoonPhaseType phase { get; set; }

        public MoonPhase()
        {
            // Needed for deserialization
        }

        public MoonPhase(MoonPhaseType moonPhaseType)
        {
            this.phase = moonPhaseType;
        }

        public override bool Equals(object obj)
        {
            return obj is MoonPhase phase &&
                   this.phase == phase.phase;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(phase);
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(phase):
                        this.phase = (MoonPhaseType)reader.ReadInt32();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "phase" : ""
            writer.WritePropertyName(nameof(phase));
            writer.WriteInt32((int)phase);

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<UV>))]
    public partial class UV : CustomJsonObject
    {
        public float? index { get; set; }

        public UV()
        {
            // Needed for deserialization
        }

        public UV(float index)
        {
            this.index = index;
        }

        public override bool Equals(object obj)
        {
            return obj is UV uV &&
                   index == uV.index;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(index);
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(index):
                        this.index = reader.ReadSingle();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "scale" : ""
            writer.WritePropertyName(nameof(index));
            writer.WriteSingle(index.GetValueOrDefault(-1.0f));

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [JsonFormatter(typeof(CustomJsonConverter<AirQuality>))]
    public partial class AirQuality : CustomJsonObject
    {
        public int? index { get; set; }
        public string attribution { get; set; }

        public AirQuality()
        {
            // Needed for deserialization
        }

        public override bool Equals(object obj)
        {
            return obj is AirQuality aqi &&
                   index == aqi.index &&
                   attribution == aqi.attribution;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(index, attribution);
        }

        public override void FromJson(ref JsonReader extReader)
        {
            JsonReader reader;
            string jsonValue;

            if (extReader.GetCurrentJsonToken() == JsonToken.String)
                jsonValue = extReader.ReadString();
            else
                jsonValue = null;

            if (jsonValue == null)
                reader = extReader;
            else
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                reader = new JsonReader(Encoding.UTF8.GetBytes(jsonValue));
#pragma warning restore CA2000 // Dispose objects before losing scope
            }

            var count = 0;
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref count))
            {
                reader.ReadIsBeginObject(); // StartObject

                string property = reader.ReadPropertyName();
                //reader.ReadNext(); // prop value

                switch (property)
                {
                    case nameof(index):
                        this.index = reader.ReadInt32();
                        break;

                    case nameof(attribution):
                        this.attribution = reader.ReadString();
                        break;

                    default:
                        reader.ReadNextBlock();
                        break;
                }
            }
        }

        public override string ToJson()
        {
            var writer = new JsonWriter();

            // {
            writer.WriteBeginObject();

            // "index" : ""
            writer.WritePropertyName(nameof(index));
            writer.WriteSingle(index.GetValueOrDefault(-1));

            writer.WriteValueSeparator();

            // "attribution" : ""
            writer.WritePropertyName(nameof(attribution));
            writer.WriteString(attribution);

            // }
            writer.WriteEndObject();

            return writer.ToString();
        }
    }

    [Table(TABLE_NAME)]
    public class Forecasts
    {
        public const string TABLE_NAME = "forecasts";

        [PrimaryKey]
        public string query { get; set; }

        [TextBlob(nameof(forecastblob))]
        public IList<Forecast> forecast { get; set; }

        [TextBlob(nameof(txtforecastblob))]
        public IList<TextForecast> txt_forecast { get; set; }

        [TextBlob(nameof(minforecastblob))]
        public IList<MinutelyForecast> min_forecast { get; set; }

        [IgnoreDataMember]
        public string forecastblob { get; set; }

        [IgnoreDataMember]
        public string txtforecastblob { get; set; }

        [IgnoreDataMember]
        public string minforecastblob { get; set; }

        public Forecasts()
        {
        }

        public Forecasts(Weather weatherData)
        {
            this.query = weatherData?.query;
            this.forecast = weatherData?.forecast;
            this.txt_forecast = weatherData?.txt_forecast;
            this.min_forecast = weatherData?.min_forecast;
        }
    }

    [Table(TABLE_NAME)]
    public class HourlyForecasts
    {
        public const string TABLE_NAME = "hr_forecasts";

        [PrimaryKey]
        public string id { get; set; }

        [Indexed(Name = "queryIdx", Order = 1)]
        public string query { get; set; }

        [IgnoreDataMember]
        [Ignore]
        // Doesn't store this in db
        // For DateTimeOffset, offset isn't stored when saving to db
        // Store as string (blob) instead
        // If db previously stored DateTimeOffset (as ticks) retrieve and set offset
        public DateTimeOffset date
        {
            get
            {
                if (DateTimeOffset.TryParseExact(dateblob, "yyyy-MM-dd HH:mm:ss zzzz", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out DateTimeOffset result))
                    return result;
                else
                    return DateTimeOffset.Parse(dateblob, CultureInfo.InvariantCulture);
            }
            set { dateblob = value.ToString("yyyy-MM-dd HH:mm:ss zzzz", CultureInfo.InvariantCulture); }
        }

        [TextBlob(nameof(hrforecastblob))]
        [NotNull]
        public HourlyForecast hr_forecast { get; set; }

        [Indexed(Name = "dateIdx", Order = 2)]
        [DataMember(Name = "date")]
        [NotNull]
        // Keep DateTimeOffset column name to get data as string
        public string dateblob { get; set; }

        [IgnoreDataMember]
        public string hrforecastblob { get; set; }

        public HourlyForecasts()
        {
        }

        public HourlyForecasts(string query, HourlyForecast forecast)
        {
            this.query = query;
            this.hr_forecast = forecast;
            this.date = forecast.date;
            this.id = query + '|' + dateblob;
        }
    }
}