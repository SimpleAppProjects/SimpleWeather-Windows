#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace SimpleWeather.EF.Utf8JsonGen.Resolvers
{
    using System;
    using Utf8Json;

    public class GeneratedResolver : global::Utf8Json.IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new GeneratedResolver();

        GeneratedResolver()
        {

        }

        public global::Utf8Json.IJsonFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::Utf8Json.IJsonFormatter<T> formatter;

            static FormatterCache()
            {
                var f = GeneratedResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::Utf8Json.IJsonFormatter<T>)f;
                }
            }
        }
    }

    internal static class GeneratedResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static GeneratedResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(23)
            {
                {typeof(global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.Forecast>), 0 },
                {typeof(global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.HourlyForecast>), 1 },
                {typeof(global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.TextForecast>), 2 },
                {typeof(global::System.Collections.Generic.ICollection<global::SimpleWeather.WeatherData.WeatherAlert>), 3 },
                {typeof(global::SimpleWeather.Location.LocationData), 4 },
                {typeof(global::SimpleWeather.Location.Favorites), 5 },
                {typeof(global::SimpleWeather.WeatherData.Location), 6 },
                {typeof(global::SimpleWeather.WeatherData.ForecastExtras), 7 },
                {typeof(global::SimpleWeather.WeatherData.Forecast), 8 },
                {typeof(global::SimpleWeather.WeatherData.HourlyForecast), 9 },
                {typeof(global::SimpleWeather.WeatherData.TextForecast), 10 },
                {typeof(global::SimpleWeather.WeatherData.Beaufort), 11 },
                {typeof(global::SimpleWeather.WeatherData.UV), 12 },
                {typeof(global::SimpleWeather.WeatherData.Condition), 13 },
                {typeof(global::SimpleWeather.WeatherData.Atmosphere), 14 },
                {typeof(global::SimpleWeather.WeatherData.MoonPhase), 15 },
                {typeof(global::SimpleWeather.WeatherData.Astronomy), 16 },
                {typeof(global::SimpleWeather.WeatherData.Precipitation), 17 },
                {typeof(global::SimpleWeather.WeatherData.WeatherAlert), 18 },
                {typeof(global::SimpleWeather.WeatherData.Weather), 19 },
                {typeof(global::SimpleWeather.WeatherData.Forecasts), 20 },
                {typeof(global::SimpleWeather.WeatherData.HourlyForecasts), 21 },
                {typeof(global::SimpleWeather.WeatherData.WeatherAlerts), 22 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new global::Utf8Json.Formatters.InterfaceListFormatter<global::SimpleWeather.WeatherData.Forecast>();
                case 1: return new global::Utf8Json.Formatters.InterfaceListFormatter<global::SimpleWeather.WeatherData.HourlyForecast>();
                case 2: return new global::Utf8Json.Formatters.InterfaceListFormatter<global::SimpleWeather.WeatherData.TextForecast>();
                case 3: return new global::Utf8Json.Formatters.InterfaceCollectionFormatter<global::SimpleWeather.WeatherData.WeatherAlert>();
                case 4: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.Location.LocationDataFormatter();
                case 5: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.Location.FavoritesFormatter();
                case 6: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.LocationFormatter();
                case 7: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.ForecastExtrasFormatter();
                case 8: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.ForecastFormatter();
                case 9: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.HourlyForecastFormatter();
                case 10: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.TextForecastFormatter();
                case 11: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.BeaufortFormatter();
                case 12: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.UVFormatter();
                case 13: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.ConditionFormatter();
                case 14: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.AtmosphereFormatter();
                case 15: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.MoonPhaseFormatter();
                case 16: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.AstronomyFormatter();
                case 17: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.PrecipitationFormatter();
                case 18: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.WeatherAlertFormatter();
                case 19: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.WeatherFormatter();
                case 20: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.ForecastsFormatter();
                case 21: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.HourlyForecastsFormatter();
                case 22: return new SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData.WeatherAlertsFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.Location
{
    using System;
    using Utf8Json;


    public sealed class LocationDataFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Location.LocationData>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public LocationDataFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("query"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz_long"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locationType"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weatherSource"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locationSource"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("query"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz_long"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("locationType"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weatherSource"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("locationSource"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Location.LocationData value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.query);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteDouble(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteDouble(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.tz_long);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteInt32((int)value.locationType);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.weatherSource);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.locationSource);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Location.LocationData Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __query__ = default(string);
            var __query__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;
            var __latitude__ = default(double);
            var __latitude__b__ = false;
            var __longitude__ = default(double);
            var __longitude__b__ = false;
            var __tz_long__ = default(string);
            var __tz_long__b__ = false;
            var __locationType__ = default(global::SimpleWeather.Location.LocationType);
            var __locationType__b__ = false;
            var __weatherSource__ = default(string);
            var __weatherSource__b__ = false;
            var __locationSource__ = default(string);
            var __locationSource__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __query__ = reader.ReadString();
                        __query__b__ = true;
                        break;
                    case 1:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    case 2:
                        __latitude__ = reader.ReadDouble();
                        __latitude__b__ = true;
                        break;
                    case 3:
                        __longitude__ = reader.ReadDouble();
                        __longitude__b__ = true;
                        break;
                    case 4:
                        __tz_long__ = reader.ReadString();
                        __tz_long__b__ = true;
                        break;
                    case 5:
                        __locationType__ = (global::SimpleWeather.Location.LocationType)reader.ReadInt32();
                        __locationType__b__ = true;
                        break;
                    case 6:
                        __weatherSource__ = reader.ReadString();
                        __weatherSource__b__ = true;
                        break;
                    case 7:
                        __locationSource__ = reader.ReadString();
                        __locationSource__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Location.LocationData();
            if(__query__b__) ____result.query = __query__;
            if(__name__b__) ____result.name = __name__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__tz_long__b__) ____result.tz_long = __tz_long__;
            if(__locationType__b__) ____result.locationType = __locationType__;
            if(__weatherSource__b__) ____result.weatherSource = __weatherSource__;
            if(__locationSource__b__) ____result.locationSource = __locationSource__;

            return ____result;
        }
    }


    public sealed class FavoritesFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Location.Favorites>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public FavoritesFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("query"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("position"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("query"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("position"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Location.Favorites value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.query);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.position);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Location.Favorites Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __query__ = default(string);
            var __query__b__ = false;
            var __position__ = default(int);
            var __position__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __query__ = reader.ReadString();
                        __query__b__ = true;
                        break;
                    case 1:
                        __position__ = reader.ReadInt32();
                        __position__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Location.Favorites();
            if(__query__b__) ____result.query = __query__;
            if(__position__b__) ____result.position = __position__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.EF.Utf8JsonGen.Formatters.SimpleWeather.WeatherData
{
    using System;
    using Utf8Json;


    public sealed class LocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.Location>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public LocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz_offset"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz_short"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz_long"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz_offset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz_short"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz_long"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.Location value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::System.TimeSpan>().Serialize(ref writer, value.tz_offset, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.tz_short);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.tz_long);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.Location Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __name__ = default(string);
            var __name__b__ = false;
            var __latitude__ = default(string);
            var __latitude__b__ = false;
            var __longitude__ = default(string);
            var __longitude__b__ = false;
            var __tz_offset__ = default(global::System.TimeSpan);
            var __tz_offset__b__ = false;
            var __tz_short__ = default(string);
            var __tz_short__b__ = false;
            var __tz_long__ = default(string);
            var __tz_long__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    case 1:
                        __latitude__ = reader.ReadString();
                        __latitude__b__ = true;
                        break;
                    case 2:
                        __longitude__ = reader.ReadString();
                        __longitude__b__ = true;
                        break;
                    case 3:
                        __tz_offset__ = formatterResolver.GetFormatterWithVerify<global::System.TimeSpan>().Deserialize(ref reader, formatterResolver);
                        __tz_offset__b__ = true;
                        break;
                    case 4:
                        __tz_short__ = reader.ReadString();
                        __tz_short__b__ = true;
                        break;
                    case 5:
                        __tz_long__ = reader.ReadString();
                        __tz_long__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.Location();
            if (__name__b__) ____result.name = __name__;
            if (__latitude__b__) ____result.latitude = __latitude__;
            if (__longitude__b__) ____result.longitude = __longitude__;
            if (__tz_offset__b__) ____result.tz_offset = __tz_offset__;
            if (__tz_short__b__) ____result.tz_short = __tz_short__;
            if (__tz_long__b__) ____result.tz_long = __tz_long__;

            return ____result;
        }
    }


    public sealed class ForecastExtrasFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.ForecastExtras>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastExtrasFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feelslike_f"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feelslike_c"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("humidity"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint_f"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint_c"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uv_index"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pop"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_rain_in"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_rain_mm"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_snow_in"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_snow_cm"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure_mb"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure_in"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_degrees"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_mph"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_kph"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility_mi"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility_km"), 17},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("feelslike_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("feelslike_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uv_index"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pop"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_rain_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_rain_mm"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_snow_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_snow_cm"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure_mb"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_degrees"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_mph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_kph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility_mi"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility_km"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.ForecastExtras value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.feelslike_f);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.feelslike_c);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.humidity);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.dewpoint_f);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.dewpoint_c);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.uv_index);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.pop);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteSingle(value.qpf_rain_in);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteSingle(value.qpf_rain_mm);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteSingle(value.qpf_snow_in);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteSingle(value.qpf_snow_cm);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.pressure_mb);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.pressure_in);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteInt32(value.wind_degrees);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteSingle(value.wind_mph);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteSingle(value.wind_kph);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.visibility_mi);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.visibility_km);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.ForecastExtras Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __feelslike_f__ = default(float);
            var __feelslike_f__b__ = false;
            var __feelslike_c__ = default(float);
            var __feelslike_c__b__ = false;
            var __humidity__ = default(string);
            var __humidity__b__ = false;
            var __dewpoint_f__ = default(string);
            var __dewpoint_f__b__ = false;
            var __dewpoint_c__ = default(string);
            var __dewpoint_c__b__ = false;
            var __uv_index__ = default(float);
            var __uv_index__b__ = false;
            var __pop__ = default(string);
            var __pop__b__ = false;
            var __qpf_rain_in__ = default(float);
            var __qpf_rain_in__b__ = false;
            var __qpf_rain_mm__ = default(float);
            var __qpf_rain_mm__b__ = false;
            var __qpf_snow_in__ = default(float);
            var __qpf_snow_in__b__ = false;
            var __qpf_snow_cm__ = default(float);
            var __qpf_snow_cm__b__ = false;
            var __pressure_mb__ = default(string);
            var __pressure_mb__b__ = false;
            var __pressure_in__ = default(string);
            var __pressure_in__b__ = false;
            var __wind_degrees__ = default(int);
            var __wind_degrees__b__ = false;
            var __wind_mph__ = default(float);
            var __wind_mph__b__ = false;
            var __wind_kph__ = default(float);
            var __wind_kph__b__ = false;
            var __visibility_mi__ = default(string);
            var __visibility_mi__b__ = false;
            var __visibility_km__ = default(string);
            var __visibility_km__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __feelslike_f__ = reader.ReadSingle();
                        __feelslike_f__b__ = true;
                        break;
                    case 1:
                        __feelslike_c__ = reader.ReadSingle();
                        __feelslike_c__b__ = true;
                        break;
                    case 2:
                        __humidity__ = reader.ReadString();
                        __humidity__b__ = true;
                        break;
                    case 3:
                        __dewpoint_f__ = reader.ReadString();
                        __dewpoint_f__b__ = true;
                        break;
                    case 4:
                        __dewpoint_c__ = reader.ReadString();
                        __dewpoint_c__b__ = true;
                        break;
                    case 5:
                        __uv_index__ = reader.ReadSingle();
                        __uv_index__b__ = true;
                        break;
                    case 6:
                        __pop__ = reader.ReadString();
                        __pop__b__ = true;
                        break;
                    case 7:
                        __qpf_rain_in__ = reader.ReadSingle();
                        __qpf_rain_in__b__ = true;
                        break;
                    case 8:
                        __qpf_rain_mm__ = reader.ReadSingle();
                        __qpf_rain_mm__b__ = true;
                        break;
                    case 9:
                        __qpf_snow_in__ = reader.ReadSingle();
                        __qpf_snow_in__b__ = true;
                        break;
                    case 10:
                        __qpf_snow_cm__ = reader.ReadSingle();
                        __qpf_snow_cm__b__ = true;
                        break;
                    case 11:
                        __pressure_mb__ = reader.ReadString();
                        __pressure_mb__b__ = true;
                        break;
                    case 12:
                        __pressure_in__ = reader.ReadString();
                        __pressure_in__b__ = true;
                        break;
                    case 13:
                        __wind_degrees__ = reader.ReadInt32();
                        __wind_degrees__b__ = true;
                        break;
                    case 14:
                        __wind_mph__ = reader.ReadSingle();
                        __wind_mph__b__ = true;
                        break;
                    case 15:
                        __wind_kph__ = reader.ReadSingle();
                        __wind_kph__b__ = true;
                        break;
                    case 16:
                        __visibility_mi__ = reader.ReadString();
                        __visibility_mi__b__ = true;
                        break;
                    case 17:
                        __visibility_km__ = reader.ReadString();
                        __visibility_km__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.ForecastExtras();
            if (__feelslike_f__b__) ____result.feelslike_f = __feelslike_f__;
            if (__feelslike_c__b__) ____result.feelslike_c = __feelslike_c__;
            if (__humidity__b__) ____result.humidity = __humidity__;
            if (__dewpoint_f__b__) ____result.dewpoint_f = __dewpoint_f__;
            if (__dewpoint_c__b__) ____result.dewpoint_c = __dewpoint_c__;
            if (__uv_index__b__) ____result.uv_index = __uv_index__;
            if (__pop__b__) ____result.pop = __pop__;
            if (__qpf_rain_in__b__) ____result.qpf_rain_in = __qpf_rain_in__;
            if (__qpf_rain_mm__b__) ____result.qpf_rain_mm = __qpf_rain_mm__;
            if (__qpf_snow_in__b__) ____result.qpf_snow_in = __qpf_snow_in__;
            if (__qpf_snow_cm__b__) ____result.qpf_snow_cm = __qpf_snow_cm__;
            if (__pressure_mb__b__) ____result.pressure_mb = __pressure_mb__;
            if (__pressure_in__b__) ____result.pressure_in = __pressure_in__;
            if (__wind_degrees__b__) ____result.wind_degrees = __wind_degrees__;
            if (__wind_mph__b__) ____result.wind_mph = __wind_mph__;
            if (__wind_kph__b__) ____result.wind_kph = __wind_kph__;
            if (__visibility_mi__b__) ____result.visibility_mi = __visibility_mi__;
            if (__visibility_km__b__) ____result.visibility_km = __visibility_km__;

            return ____result;
        }
    }


    public sealed class ForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.Forecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("date"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("high_f"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("high_c"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("low_f"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("low_c"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("condition"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("extras"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("date"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("high_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("high_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("low_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("low_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("condition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("extras"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.Forecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Serialize(ref writer, value.date, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.high_f);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.high_c);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.low_f);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.low_c);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.condition);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.ForecastExtras>().Serialize(ref writer, value.extras, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.Forecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __date__ = default(global::System.DateTime);
            var __date__b__ = false;
            var __high_f__ = default(string);
            var __high_f__b__ = false;
            var __high_c__ = default(string);
            var __high_c__b__ = false;
            var __low_f__ = default(string);
            var __low_f__b__ = false;
            var __low_c__ = default(string);
            var __low_c__b__ = false;
            var __condition__ = default(string);
            var __condition__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __extras__ = default(global::SimpleWeather.WeatherData.ForecastExtras);
            var __extras__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __date__ = formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Deserialize(ref reader, formatterResolver);
                        __date__b__ = true;
                        break;
                    case 1:
                        __high_f__ = reader.ReadString();
                        __high_f__b__ = true;
                        break;
                    case 2:
                        __high_c__ = reader.ReadString();
                        __high_c__b__ = true;
                        break;
                    case 3:
                        __low_f__ = reader.ReadString();
                        __low_f__b__ = true;
                        break;
                    case 4:
                        __low_c__ = reader.ReadString();
                        __low_c__b__ = true;
                        break;
                    case 5:
                        __condition__ = reader.ReadString();
                        __condition__b__ = true;
                        break;
                    case 6:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 7:
                        __extras__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.ForecastExtras>().Deserialize(ref reader, formatterResolver);
                        __extras__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.Forecast();
            if (__date__b__) ____result.date = __date__;
            if (__high_f__b__) ____result.high_f = __high_f__;
            if (__high_c__b__) ____result.high_c = __high_c__;
            if (__low_f__b__) ____result.low_f = __low_f__;
            if (__low_c__b__) ____result.low_c = __low_c__;
            if (__condition__b__) ____result.condition = __condition__;
            if (__icon__b__) ____result.icon = __icon__;
            if (__extras__b__) ____result.extras = __extras__;

            return ____result;
        }
    }


    public sealed class HourlyForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.HourlyForecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public HourlyForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("date"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("high_f"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("high_c"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("condition"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pop"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_degrees"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_mph"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_kph"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("extras"), 9},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("date"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("high_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("high_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("condition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pop"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_degrees"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_mph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_kph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("extras"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.HourlyForecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.date, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.high_f);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.high_c);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.condition);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.pop);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value.wind_degrees);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteSingle(value.wind_mph);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteSingle(value.wind_kph);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.ForecastExtras>().Serialize(ref writer, value.extras, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.HourlyForecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __date__ = default(global::System.DateTimeOffset);
            var __date__b__ = false;
            var __high_f__ = default(string);
            var __high_f__b__ = false;
            var __high_c__ = default(string);
            var __high_c__b__ = false;
            var __condition__ = default(string);
            var __condition__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __pop__ = default(string);
            var __pop__b__ = false;
            var __wind_degrees__ = default(int);
            var __wind_degrees__b__ = false;
            var __wind_mph__ = default(float);
            var __wind_mph__b__ = false;
            var __wind_kph__ = default(float);
            var __wind_kph__b__ = false;
            var __extras__ = default(global::SimpleWeather.WeatherData.ForecastExtras);
            var __extras__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __date__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __date__b__ = true;
                        break;
                    case 1:
                        __high_f__ = reader.ReadString();
                        __high_f__b__ = true;
                        break;
                    case 2:
                        __high_c__ = reader.ReadString();
                        __high_c__b__ = true;
                        break;
                    case 3:
                        __condition__ = reader.ReadString();
                        __condition__b__ = true;
                        break;
                    case 4:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 5:
                        __pop__ = reader.ReadString();
                        __pop__b__ = true;
                        break;
                    case 6:
                        __wind_degrees__ = reader.ReadInt32();
                        __wind_degrees__b__ = true;
                        break;
                    case 7:
                        __wind_mph__ = reader.ReadSingle();
                        __wind_mph__b__ = true;
                        break;
                    case 8:
                        __wind_kph__ = reader.ReadSingle();
                        __wind_kph__b__ = true;
                        break;
                    case 9:
                        __extras__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.ForecastExtras>().Deserialize(ref reader, formatterResolver);
                        __extras__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.HourlyForecast();
            if (__date__b__) ____result.date = __date__;
            if (__high_f__b__) ____result.high_f = __high_f__;
            if (__high_c__b__) ____result.high_c = __high_c__;
            if (__condition__b__) ____result.condition = __condition__;
            if (__icon__b__) ____result.icon = __icon__;
            if (__pop__b__) ____result.pop = __pop__;
            if (__wind_degrees__b__) ____result.wind_degrees = __wind_degrees__;
            if (__wind_mph__b__) ____result.wind_mph = __wind_mph__;
            if (__wind_kph__b__) ____result.wind_kph = __wind_kph__;
            if (__extras__b__) ____result.extras = __extras__;

            return ____result;
        }
    }


    public sealed class TextForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.TextForecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TextForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("title"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("fcttext"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("fcttext_metric"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pop"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("title"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("fcttext"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("fcttext_metric"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pop"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.TextForecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.title);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.fcttext);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.fcttext_metric);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.pop);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.TextForecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __title__ = default(string);
            var __title__b__ = false;
            var __fcttext__ = default(string);
            var __fcttext__b__ = false;
            var __fcttext_metric__ = default(string);
            var __fcttext_metric__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __pop__ = default(string);
            var __pop__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __title__ = reader.ReadString();
                        __title__b__ = true;
                        break;
                    case 1:
                        __fcttext__ = reader.ReadString();
                        __fcttext__b__ = true;
                        break;
                    case 2:
                        __fcttext_metric__ = reader.ReadString();
                        __fcttext_metric__b__ = true;
                        break;
                    case 3:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 4:
                        __pop__ = reader.ReadString();
                        __pop__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.TextForecast();
            if (__title__b__) ____result.title = __title__;
            if (__fcttext__b__) ____result.fcttext = __fcttext__;
            if (__fcttext_metric__b__) ____result.fcttext_metric = __fcttext_metric__;
            if (__icon__b__) ____result.icon = __icon__;
            if (__pop__b__) ____result.pop = __pop__;

            return ____result;
        }
    }


    public sealed class BeaufortFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.Beaufort>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BeaufortFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("scale"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("desc"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("scale"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("desc"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.Beaufort value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32((int)value.scale);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.desc);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.Beaufort Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __scale__ = default(global::SimpleWeather.WeatherData.Beaufort.BeaufortScale);
            var __scale__b__ = false;
            var __desc__ = default(string);
            var __desc__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __scale__ = (global::SimpleWeather.WeatherData.Beaufort.BeaufortScale)reader.ReadInt32();
                        __scale__b__ = true;
                        break;
                    case 1:
                        __desc__ = reader.ReadString();
                        __desc__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.Beaufort();
            if (__scale__b__) ____result.scale = __scale__;
            if (__desc__b__) ____result.desc = __desc__;

            return ____result;
        }
    }


    public sealed class UVFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.UV>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public UVFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("index"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("desc"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("index"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("desc"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.UV value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.index);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.desc);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.UV Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __index__ = default(float);
            var __index__b__ = false;
            var __desc__ = default(string);
            var __desc__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __index__ = reader.ReadSingle();
                        __index__b__ = true;
                        break;
                    case 1:
                        __desc__ = reader.ReadString();
                        __desc__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.UV();
            if (__index__b__) ____result.index = __index__;
            if (__desc__b__) ____result.desc = __desc__;

            return ____result;
        }
    }


    public sealed class ConditionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.Condition>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ConditionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weather"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_f"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_c"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_degrees"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_mph"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_kph"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feelslike_f"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feelslike_c"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("beaufort"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uv"), 10},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("weather"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_degrees"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_mph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_kph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("feelslike_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("feelslike_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("beaufort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uv"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.Condition value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.weather);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.temp_f);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.temp_c);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.wind_degrees);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.wind_mph);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.wind_kph);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.feelslike_f);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteSingle(value.feelslike_c);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Beaufort>().Serialize(ref writer, value.beaufort, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[10]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.UV>().Serialize(ref writer, value.uv, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.Condition Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __weather__ = default(string);
            var __weather__b__ = false;
            var __temp_f__ = default(float);
            var __temp_f__b__ = false;
            var __temp_c__ = default(float);
            var __temp_c__b__ = false;
            var __wind_degrees__ = default(int);
            var __wind_degrees__b__ = false;
            var __wind_mph__ = default(float);
            var __wind_mph__b__ = false;
            var __wind_kph__ = default(float);
            var __wind_kph__b__ = false;
            var __feelslike_f__ = default(float);
            var __feelslike_f__b__ = false;
            var __feelslike_c__ = default(float);
            var __feelslike_c__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __beaufort__ = default(global::SimpleWeather.WeatherData.Beaufort);
            var __beaufort__b__ = false;
            var __uv__ = default(global::SimpleWeather.WeatherData.UV);
            var __uv__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __weather__ = reader.ReadString();
                        __weather__b__ = true;
                        break;
                    case 1:
                        __temp_f__ = reader.ReadSingle();
                        __temp_f__b__ = true;
                        break;
                    case 2:
                        __temp_c__ = reader.ReadSingle();
                        __temp_c__b__ = true;
                        break;
                    case 3:
                        __wind_degrees__ = reader.ReadInt32();
                        __wind_degrees__b__ = true;
                        break;
                    case 4:
                        __wind_mph__ = reader.ReadSingle();
                        __wind_mph__b__ = true;
                        break;
                    case 5:
                        __wind_kph__ = reader.ReadSingle();
                        __wind_kph__b__ = true;
                        break;
                    case 6:
                        __feelslike_f__ = reader.ReadSingle();
                        __feelslike_f__b__ = true;
                        break;
                    case 7:
                        __feelslike_c__ = reader.ReadSingle();
                        __feelslike_c__b__ = true;
                        break;
                    case 8:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 9:
                        __beaufort__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Beaufort>().Deserialize(ref reader, formatterResolver);
                        __beaufort__b__ = true;
                        break;
                    case 10:
                        __uv__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.UV>().Deserialize(ref reader, formatterResolver);
                        __uv__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.Condition();
            if (__weather__b__) ____result.weather = __weather__;
            if (__temp_f__b__) ____result.temp_f = __temp_f__;
            if (__temp_c__b__) ____result.temp_c = __temp_c__;
            if (__wind_degrees__b__) ____result.wind_degrees = __wind_degrees__;
            if (__wind_mph__b__) ____result.wind_mph = __wind_mph__;
            if (__wind_kph__b__) ____result.wind_kph = __wind_kph__;
            if (__feelslike_f__b__) ____result.feelslike_f = __feelslike_f__;
            if (__feelslike_c__b__) ____result.feelslike_c = __feelslike_c__;
            if (__icon__b__) ____result.icon = __icon__;
            if (__beaufort__b__) ____result.beaufort = __beaufort__;
            if (__uv__b__) ____result.uv = __uv__;

            return ____result;
        }
    }


    public sealed class AtmosphereFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.Atmosphere>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AtmosphereFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("humidity"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure_mb"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure_in"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure_trend"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility_mi"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility_km"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint_f"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint_c"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure_mb"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure_trend"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility_mi"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility_km"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint_c"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.Atmosphere value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.humidity);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.pressure_mb);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.pressure_in);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.pressure_trend);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.visibility_mi);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.visibility_km);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.dewpoint_f);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.dewpoint_c);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.Atmosphere Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __humidity__ = default(string);
            var __humidity__b__ = false;
            var __pressure_mb__ = default(string);
            var __pressure_mb__b__ = false;
            var __pressure_in__ = default(string);
            var __pressure_in__b__ = false;
            var __pressure_trend__ = default(string);
            var __pressure_trend__b__ = false;
            var __visibility_mi__ = default(string);
            var __visibility_mi__b__ = false;
            var __visibility_km__ = default(string);
            var __visibility_km__b__ = false;
            var __dewpoint_f__ = default(string);
            var __dewpoint_f__b__ = false;
            var __dewpoint_c__ = default(string);
            var __dewpoint_c__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __humidity__ = reader.ReadString();
                        __humidity__b__ = true;
                        break;
                    case 1:
                        __pressure_mb__ = reader.ReadString();
                        __pressure_mb__b__ = true;
                        break;
                    case 2:
                        __pressure_in__ = reader.ReadString();
                        __pressure_in__b__ = true;
                        break;
                    case 3:
                        __pressure_trend__ = reader.ReadString();
                        __pressure_trend__b__ = true;
                        break;
                    case 4:
                        __visibility_mi__ = reader.ReadString();
                        __visibility_mi__b__ = true;
                        break;
                    case 5:
                        __visibility_km__ = reader.ReadString();
                        __visibility_km__b__ = true;
                        break;
                    case 6:
                        __dewpoint_f__ = reader.ReadString();
                        __dewpoint_f__b__ = true;
                        break;
                    case 7:
                        __dewpoint_c__ = reader.ReadString();
                        __dewpoint_c__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.Atmosphere();
            if (__humidity__b__) ____result.humidity = __humidity__;
            if (__pressure_mb__b__) ____result.pressure_mb = __pressure_mb__;
            if (__pressure_in__b__) ____result.pressure_in = __pressure_in__;
            if (__pressure_trend__b__) ____result.pressure_trend = __pressure_trend__;
            if (__visibility_mi__b__) ____result.visibility_mi = __visibility_mi__;
            if (__visibility_km__b__) ____result.visibility_km = __visibility_km__;
            if (__dewpoint_f__b__) ____result.dewpoint_f = __dewpoint_f__;
            if (__dewpoint_c__b__) ____result.dewpoint_c = __dewpoint_c__;

            return ____result;
        }
    }


    public sealed class MoonPhaseFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.MoonPhase>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MoonPhaseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("phase"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("desc"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("phase"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("desc"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.MoonPhase value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32((int)value.phase);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.desc);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.MoonPhase Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __phase__ = default(global::SimpleWeather.WeatherData.MoonPhase.MoonPhaseType);
            var __phase__b__ = false;
            var __desc__ = default(string);
            var __desc__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __phase__ = (global::SimpleWeather.WeatherData.MoonPhase.MoonPhaseType)reader.ReadInt32();
                        __phase__b__ = true;
                        break;
                    case 1:
                        __desc__ = reader.ReadString();
                        __desc__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.MoonPhase();
            if (__phase__b__) ____result.phase = __phase__;
            if (__desc__b__) ____result.desc = __desc__;

            return ____result;
        }
    }


    public sealed class AstronomyFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.Astronomy>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AstronomyFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunrise"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunset"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonrise"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonset"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonphase"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("sunrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonphase"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.Astronomy value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Serialize(ref writer, value.sunrise, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Serialize(ref writer, value.sunset, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Serialize(ref writer, value.moonrise, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Serialize(ref writer, value.moonset, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.MoonPhase>().Serialize(ref writer, value.moonphase, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.Astronomy Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __sunrise__ = default(global::System.DateTime);
            var __sunrise__b__ = false;
            var __sunset__ = default(global::System.DateTime);
            var __sunset__b__ = false;
            var __moonrise__ = default(global::System.DateTime);
            var __moonrise__b__ = false;
            var __moonset__ = default(global::System.DateTime);
            var __moonset__b__ = false;
            var __moonphase__ = default(global::SimpleWeather.WeatherData.MoonPhase);
            var __moonphase__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __sunrise__ = formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Deserialize(ref reader, formatterResolver);
                        __sunrise__b__ = true;
                        break;
                    case 1:
                        __sunset__ = formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Deserialize(ref reader, formatterResolver);
                        __sunset__b__ = true;
                        break;
                    case 2:
                        __moonrise__ = formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Deserialize(ref reader, formatterResolver);
                        __moonrise__b__ = true;
                        break;
                    case 3:
                        __moonset__ = formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Deserialize(ref reader, formatterResolver);
                        __moonset__b__ = true;
                        break;
                    case 4:
                        __moonphase__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.MoonPhase>().Deserialize(ref reader, formatterResolver);
                        __moonphase__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.Astronomy();
            if (__sunrise__b__) ____result.sunrise = __sunrise__;
            if (__sunset__b__) ____result.sunset = __sunset__;
            if (__moonrise__b__) ____result.moonrise = __moonrise__;
            if (__moonset__b__) ____result.moonset = __moonset__;
            if (__moonphase__b__) ____result.moonphase = __moonphase__;

            return ____result;
        }
    }


    public sealed class PrecipitationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.Precipitation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public PrecipitationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pop"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_rain_in"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_rain_mm"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_snow_in"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_snow_cm"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("pop"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_rain_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_rain_mm"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_snow_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_snow_cm"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.Precipitation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.pop);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.qpf_rain_in);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.qpf_rain_mm);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteSingle(value.qpf_snow_in);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.qpf_snow_cm);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.Precipitation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __pop__ = default(string);
            var __pop__b__ = false;
            var __qpf_rain_in__ = default(float);
            var __qpf_rain_in__b__ = false;
            var __qpf_rain_mm__ = default(float);
            var __qpf_rain_mm__b__ = false;
            var __qpf_snow_in__ = default(float);
            var __qpf_snow_in__b__ = false;
            var __qpf_snow_cm__ = default(float);
            var __qpf_snow_cm__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __pop__ = reader.ReadString();
                        __pop__b__ = true;
                        break;
                    case 1:
                        __qpf_rain_in__ = reader.ReadSingle();
                        __qpf_rain_in__b__ = true;
                        break;
                    case 2:
                        __qpf_rain_mm__ = reader.ReadSingle();
                        __qpf_rain_mm__b__ = true;
                        break;
                    case 3:
                        __qpf_snow_in__ = reader.ReadSingle();
                        __qpf_snow_in__b__ = true;
                        break;
                    case 4:
                        __qpf_snow_cm__ = reader.ReadSingle();
                        __qpf_snow_cm__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.Precipitation();
            if (__pop__b__) ____result.pop = __pop__;
            if (__qpf_rain_in__b__) ____result.qpf_rain_in = __qpf_rain_in__;
            if (__qpf_rain_mm__b__) ____result.qpf_rain_mm = __qpf_rain_mm__;
            if (__qpf_snow_in__b__) ____result.qpf_snow_in = __qpf_snow_in__;
            if (__qpf_snow_cm__b__) ____result.qpf_snow_cm = __qpf_snow_cm__;

            return ____result;
        }
    }


    public sealed class WeatherAlertFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.WeatherAlert>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WeatherAlertFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Severity"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Title"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Message"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Attribution"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Date"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ExpiresDate"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Notified"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("Type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Severity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Title"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Message"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Attribution"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Date"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ExpiresDate"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Notified"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.WeatherAlert value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32((int)value.Type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32((int)value.Severity);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.Title);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.Message);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.Attribution);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.Date, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.ExpiresDate, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteBoolean(value.Notified);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.WeatherAlert Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }


            var __Type__ = default(global::SimpleWeather.WeatherData.WeatherAlertType);
            var __Type__b__ = false;
            var __Severity__ = default(global::SimpleWeather.WeatherData.WeatherAlertSeverity);
            var __Severity__b__ = false;
            var __Title__ = default(string);
            var __Title__b__ = false;
            var __Message__ = default(string);
            var __Message__b__ = false;
            var __Attribution__ = default(string);
            var __Attribution__b__ = false;
            var __Date__ = default(global::System.DateTimeOffset);
            var __Date__b__ = false;
            var __ExpiresDate__ = default(global::System.DateTimeOffset);
            var __ExpiresDate__b__ = false;
            var __Notified__ = default(bool);
            var __Notified__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __Type__ = (global::SimpleWeather.WeatherData.WeatherAlertType)reader.ReadInt32();
                        __Type__b__ = true;
                        break;
                    case 1:
                        __Severity__ = (global::SimpleWeather.WeatherData.WeatherAlertSeverity)reader.ReadInt32();
                        __Severity__b__ = true;
                        break;
                    case 2:
                        __Title__ = reader.ReadString();
                        __Title__b__ = true;
                        break;
                    case 3:
                        __Message__ = reader.ReadString();
                        __Message__b__ = true;
                        break;
                    case 4:
                        __Attribution__ = reader.ReadString();
                        __Attribution__b__ = true;
                        break;
                    case 5:
                        __Date__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __Date__b__ = true;
                        break;
                    case 6:
                        __ExpiresDate__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __ExpiresDate__b__ = true;
                        break;
                    case 7:
                        __Notified__ = reader.ReadBoolean();
                        __Notified__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

            NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.WeatherAlert();
            if (__Type__b__) ____result.Type = __Type__;
            if (__Severity__b__) ____result.Severity = __Severity__;
            if (__Title__b__) ____result.Title = __Title__;
            if (__Message__b__) ____result.Message = __Message__;
            if (__Attribution__b__) ____result.Attribution = __Attribution__;
            if (__Date__b__) ____result.Date = __Date__;
            if (__ExpiresDate__b__) ____result.ExpiresDate = __ExpiresDate__;
            if (__Notified__b__) ____result.Notified = __Notified__;

            return ____result;
        }
    }


    public sealed class WeatherFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.Weather>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WeatherFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("location"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hr_forecast"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("txt_forecast"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("condition"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("atmosphere"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("astronomy"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weather_alerts"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ttl"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("source"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("query"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locale"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("update_time"), 13},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("location"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hr_forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("txt_forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("condition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("atmosphere"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("astronomy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weather_alerts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ttl"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("source"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("query"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("locale"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("update_time"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.Weather value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Location>().Serialize(ref writer, value.location, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.Forecast>>().Serialize(ref writer, value.forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.HourlyForecast>>().Serialize(ref writer, value.hr_forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.TextForecast>>().Serialize(ref writer, value.txt_forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Condition>().Serialize(ref writer, value.condition, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Atmosphere>().Serialize(ref writer, value.atmosphere, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Astronomy>().Serialize(ref writer, value.astronomy, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Precipitation>().Serialize(ref writer, value.precipitation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.ICollection<global::SimpleWeather.WeatherData.WeatherAlert>>().Serialize(ref writer, value.weather_alerts, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.ttl);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.source);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.query);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.locale);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.updatetimeblob);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.Weather Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __location__ = default(global::SimpleWeather.WeatherData.Location);
            var __location__b__ = false;
            var __forecast__ = default(global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.Forecast>);
            var __forecast__b__ = false;
            var __hr_forecast__ = default(global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.HourlyForecast>);
            var __hr_forecast__b__ = false;
            var __txt_forecast__ = default(global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.TextForecast>);
            var __txt_forecast__b__ = false;
            var __condition__ = default(global::SimpleWeather.WeatherData.Condition);
            var __condition__b__ = false;
            var __atmosphere__ = default(global::SimpleWeather.WeatherData.Atmosphere);
            var __atmosphere__b__ = false;
            var __astronomy__ = default(global::SimpleWeather.WeatherData.Astronomy);
            var __astronomy__b__ = false;
            var __precipitation__ = default(global::SimpleWeather.WeatherData.Precipitation);
            var __precipitation__b__ = false;
            var __weather_alerts__ = default(global::System.Collections.Generic.ICollection<global::SimpleWeather.WeatherData.WeatherAlert>);
            var __weather_alerts__b__ = false;
            var __ttl__ = default(string);
            var __ttl__b__ = false;
            var __source__ = default(string);
            var __source__b__ = false;
            var __query__ = default(string);
            var __query__b__ = false;
            var __locale__ = default(string);
            var __locale__b__ = false;
            var __updatetimeblob__ = default(string);
            var __updatetimeblob__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __location__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Location>().Deserialize(ref reader, formatterResolver);
                        __location__b__ = true;
                        break;
                    case 1:
                        __forecast__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.Forecast>>().Deserialize(ref reader, formatterResolver);
                        __forecast__b__ = true;
                        break;
                    case 2:
                        __hr_forecast__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.HourlyForecast>>().Deserialize(ref reader, formatterResolver);
                        __hr_forecast__b__ = true;
                        break;
                    case 3:
                        __txt_forecast__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.TextForecast>>().Deserialize(ref reader, formatterResolver);
                        __txt_forecast__b__ = true;
                        break;
                    case 4:
                        __condition__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Condition>().Deserialize(ref reader, formatterResolver);
                        __condition__b__ = true;
                        break;
                    case 5:
                        __atmosphere__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Atmosphere>().Deserialize(ref reader, formatterResolver);
                        __atmosphere__b__ = true;
                        break;
                    case 6:
                        __astronomy__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Astronomy>().Deserialize(ref reader, formatterResolver);
                        __astronomy__b__ = true;
                        break;
                    case 7:
                        __precipitation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.Precipitation>().Deserialize(ref reader, formatterResolver);
                        __precipitation__b__ = true;
                        break;
                    case 8:
                        __weather_alerts__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.ICollection<global::SimpleWeather.WeatherData.WeatherAlert>>().Deserialize(ref reader, formatterResolver);
                        __weather_alerts__b__ = true;
                        break;
                    case 9:
                        __ttl__ = reader.ReadString();
                        __ttl__b__ = true;
                        break;
                    case 10:
                        __source__ = reader.ReadString();
                        __source__b__ = true;
                        break;
                    case 11:
                        __query__ = reader.ReadString();
                        __query__b__ = true;
                        break;
                    case 12:
                        __locale__ = reader.ReadString();
                        __locale__b__ = true;
                        break;
                    case 13:
                        __updatetimeblob__ = reader.ReadString();
                        __updatetimeblob__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.Weather();
            if(__location__b__) ____result.location = __location__;
            if(__forecast__b__) ____result.forecast = __forecast__;
            if(__hr_forecast__b__) ____result.hr_forecast = __hr_forecast__;
            if(__txt_forecast__b__) ____result.txt_forecast = __txt_forecast__;
            if(__condition__b__) ____result.condition = __condition__;
            if(__atmosphere__b__) ____result.atmosphere = __atmosphere__;
            if(__astronomy__b__) ____result.astronomy = __astronomy__;
            if(__precipitation__b__) ____result.precipitation = __precipitation__;
            if(__weather_alerts__b__) ____result.weather_alerts = __weather_alerts__;
            if(__ttl__b__) ____result.ttl = __ttl__;
            if(__source__b__) ____result.source = __source__;
            if(__query__b__) ____result.query = __query__;
            if(__locale__b__) ____result.locale = __locale__;
            if(__updatetimeblob__b__) ____result.updatetimeblob = __updatetimeblob__;

            return ____result;
        }
    }


    public sealed class ForecastsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.Forecasts>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("query"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("txt_forecast"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("query"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("txt_forecast"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.Forecasts value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.query);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.Forecast>>().Serialize(ref writer, value.forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.TextForecast>>().Serialize(ref writer, value.txt_forecast, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.Forecasts Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __query__ = default(string);
            var __query__b__ = false;
            var __forecast__ = default(global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.Forecast>);
            var __forecast__b__ = false;
            var __txt_forecast__ = default(global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.TextForecast>);
            var __txt_forecast__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __query__ = reader.ReadString();
                        __query__b__ = true;
                        break;
                    case 1:
                        __forecast__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.Forecast>>().Deserialize(ref reader, formatterResolver);
                        __forecast__b__ = true;
                        break;
                    case 2:
                        __txt_forecast__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.IList<global::SimpleWeather.WeatherData.TextForecast>>().Deserialize(ref reader, formatterResolver);
                        __txt_forecast__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.Forecasts();
            if(__query__b__) ____result.query = __query__;
            if(__forecast__b__) ____result.forecast = __forecast__;
            if(__txt_forecast__b__) ____result.txt_forecast = __txt_forecast__;

            return ____result;
        }
    }


    public sealed class HourlyForecastsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.HourlyForecasts>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public HourlyForecastsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("query"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hr_forecast"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("date"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("query"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hr_forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("date"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.HourlyForecasts value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.query);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.HourlyForecast>().Serialize(ref writer, value.hr_forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.dateblob);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.HourlyForecasts Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __query__ = default(string);
            var __query__b__ = false;
            var __hr_forecast__ = default(global::SimpleWeather.WeatherData.HourlyForecast);
            var __hr_forecast__b__ = false;
            var __dateblob__ = default(string);
            var __dateblob__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __query__ = reader.ReadString();
                        __query__b__ = true;
                        break;
                    case 1:
                        __hr_forecast__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherData.HourlyForecast>().Deserialize(ref reader, formatterResolver);
                        __hr_forecast__b__ = true;
                        break;
                    case 2:
                        __dateblob__ = reader.ReadString();
                        __dateblob__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.HourlyForecasts();
            if(__query__b__) ____result.query = __query__;
            if(__hr_forecast__b__) ____result.hr_forecast = __hr_forecast__;
            if(__dateblob__b__) ____result.dateblob = __dateblob__;

            return ____result;
        }
    }


    public sealed class WeatherAlertsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherData.WeatherAlerts>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WeatherAlertsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("query"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("alerts"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("query"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("alerts"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherData.WeatherAlerts value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.query);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.ICollection<global::SimpleWeather.WeatherData.WeatherAlert>>().Serialize(ref writer, value.alerts, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherData.WeatherAlerts Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __query__ = default(string);
            var __query__b__ = false;
            var __alerts__ = default(global::System.Collections.Generic.ICollection<global::SimpleWeather.WeatherData.WeatherAlert>);
            var __alerts__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __query__ = reader.ReadString();
                        __query__b__ = true;
                        break;
                    case 1:
                        __alerts__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.ICollection<global::SimpleWeather.WeatherData.WeatherAlert>>().Deserialize(ref reader, formatterResolver);
                        __alerts__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherData.WeatherAlerts();
            if(__query__b__) ____result.query = __query__;
            if(__alerts__b__) ____result.alerts = __alerts__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
