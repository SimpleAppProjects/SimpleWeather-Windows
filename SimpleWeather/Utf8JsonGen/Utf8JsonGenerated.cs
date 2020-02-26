#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace SimpleWeather.Utf8JsonGen.Resolvers
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
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(192)
            {
                {typeof(global::SimpleWeather.Bing.Value[]), 0 },
                {typeof(global::SimpleWeather.Bing.Resource[]), 1 },
                {typeof(global::SimpleWeather.Bing.Resourceset[]), 2 },
                {typeof(global::SimpleWeather.HERE.Timesegment[]), 3 },
                {typeof(global::SimpleWeather.HERE.Alert[]), 4 },
                {typeof(global::SimpleWeather.HERE.Additionaldata[]), 5 },
                {typeof(global::SimpleWeather.HERE.Suggestion[]), 6 },
                {typeof(global::SimpleWeather.HERE.Navigationposition[]), 7 },
                {typeof(global::SimpleWeather.HERE.Result[]), 8 },
                {typeof(global::SimpleWeather.HERE.View[]), 9 },
                {typeof(global::SimpleWeather.HERE.Observation[]), 10 },
                {typeof(global::SimpleWeather.HERE.Location[]), 11 },
                {typeof(global::SimpleWeather.HERE.Forecast[]), 12 },
                {typeof(global::SimpleWeather.HERE.Forecast1[]), 13 },
                {typeof(global::SimpleWeather.HERE.Astronomy1[]), 14 },
                {typeof(global::SimpleWeather.NWS.AlertGraph[]), 15 },
                {typeof(global::SimpleWeather.NWS.Period[]), 16 },
                {typeof(global::SimpleWeather.NWS.ObsGraph[]), 17 },
                {typeof(global::SimpleWeather.NWS.Cloudlayer[]), 18 },
                {typeof(global::SimpleWeather.OpenWeather.Weather[]), 19 },
                {typeof(global::SimpleWeather.OpenWeather.List[]), 20 },
                {typeof(global::SimpleWeather.WeatherUnderground.Alert[]), 21 },
                {typeof(global::SimpleWeather.WeatherUnderground.Vertex[]), 22 },
                {typeof(global::SimpleWeather.WeatherUnderground.AC_RESULT[]), 23 },
                {typeof(global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation[]), 24 },
                {typeof(global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1[]), 25 },
                {typeof(global::SimpleWeather.WeatherUnderground.Forecastday[]), 26 },
                {typeof(global::SimpleWeather.WeatherUnderground.Forecastday1[]), 27 },
                {typeof(global::SimpleWeather.WeatherUnderground.Hourly_Forecast[]), 28 },
                {typeof(global::SimpleWeather.WeatherYahoo.Forecast[]), 29 },
                {typeof(global::SimpleWeather.Bing.Address), 30 },
                {typeof(global::SimpleWeather.Bing.Value), 31 },
                {typeof(global::SimpleWeather.Bing.Resource), 32 },
                {typeof(global::SimpleWeather.Bing.Resourceset), 33 },
                {typeof(global::SimpleWeather.Bing.AC_Rootobject), 34 },
                {typeof(global::SimpleWeather.HERE.Timesegment), 35 },
                {typeof(global::SimpleWeather.HERE.Alert), 36 },
                {typeof(global::SimpleWeather.HERE.Alerts), 37 },
                {typeof(global::SimpleWeather.HERE.Additionaldata), 38 },
                {typeof(global::SimpleWeather.HERE.Address), 39 },
                {typeof(global::SimpleWeather.HERE.Suggestion), 40 },
                {typeof(global::SimpleWeather.HERE.AC_Rootobject), 41 },
                {typeof(global::SimpleWeather.HERE.Metainfo), 42 },
                {typeof(global::SimpleWeather.HERE.Matchquality), 43 },
                {typeof(global::SimpleWeather.HERE.Displayposition), 44 },
                {typeof(global::SimpleWeather.HERE.Navigationposition), 45 },
                {typeof(global::SimpleWeather.HERE.Timezone), 46 },
                {typeof(global::SimpleWeather.HERE.Admininfo), 47 },
                {typeof(global::SimpleWeather.HERE.GeoLocation), 48 },
                {typeof(global::SimpleWeather.HERE.Result), 49 },
                {typeof(global::SimpleWeather.HERE.View), 50 },
                {typeof(global::SimpleWeather.HERE.Response), 51 },
                {typeof(global::SimpleWeather.HERE.Geo_Rootobject), 52 },
                {typeof(global::SimpleWeather.HERE.TokenRootobject), 53 },
                {typeof(global::SimpleWeather.HERE.Token), 54 },
                {typeof(global::SimpleWeather.HERE.Observation), 55 },
                {typeof(global::SimpleWeather.HERE.Location), 56 },
                {typeof(global::SimpleWeather.HERE.Observations), 57 },
                {typeof(global::SimpleWeather.HERE.Forecast), 58 },
                {typeof(global::SimpleWeather.HERE.Forecastlocation), 59 },
                {typeof(global::SimpleWeather.HERE.Dailyforecasts), 60 },
                {typeof(global::SimpleWeather.HERE.Forecast1), 61 },
                {typeof(global::SimpleWeather.HERE.Forecastlocation1), 62 },
                {typeof(global::SimpleWeather.HERE.Hourlyforecasts), 63 },
                {typeof(global::SimpleWeather.HERE.Astronomy1), 64 },
                {typeof(global::SimpleWeather.HERE.Astronomy), 65 },
                {typeof(global::SimpleWeather.HERE.Rootobject), 66 },
                {typeof(global::SimpleWeather.NWS.Geometry), 67 },
                {typeof(global::SimpleWeather.NWS.Distance), 68 },
                {typeof(global::SimpleWeather.NWS.Bearing), 69 },
                {typeof(global::SimpleWeather.NWS.Value), 70 },
                {typeof(global::SimpleWeather.NWS.Unitcode), 71 },
                {typeof(global::SimpleWeather.NWS.Forecastoffice), 72 },
                {typeof(global::SimpleWeather.NWS.Forecastgriddata), 73 },
                {typeof(global::SimpleWeather.NWS.Publiczone), 74 },
                {typeof(global::SimpleWeather.NWS.County), 75 },
                {typeof(global::SimpleWeather.NWS.Context), 76 },
                {typeof(global::SimpleWeather.NWS.Geocode), 77 },
                {typeof(global::SimpleWeather.NWS.Parameters), 78 },
                {typeof(global::SimpleWeather.NWS.AlertGraph), 79 },
                {typeof(global::SimpleWeather.NWS.AlertRootobject), 80 },
                {typeof(global::SimpleWeather.NWS.Distance1), 81 },
                {typeof(global::SimpleWeather.NWS.Bearing1), 82 },
                {typeof(global::SimpleWeather.NWS.Relativelocation), 83 },
                {typeof(global::SimpleWeather.NWS.PointsRootobject), 84 },
                {typeof(global::SimpleWeather.NWS.Elevation), 85 },
                {typeof(global::SimpleWeather.NWS.Period), 86 },
                {typeof(global::SimpleWeather.NWS.ForecastRootobject), 87 },
                {typeof(global::SimpleWeather.NWS.ObsGraph), 88 },
                {typeof(global::SimpleWeather.NWS.ObservationsStationsRootobject), 89 },
                {typeof(global::SimpleWeather.NWS.Observationstations), 90 },
                {typeof(global::SimpleWeather.NWS.Temperature), 91 },
                {typeof(global::SimpleWeather.NWS.Dewpoint), 92 },
                {typeof(global::SimpleWeather.NWS.Winddirection), 93 },
                {typeof(global::SimpleWeather.NWS.Windspeed), 94 },
                {typeof(global::SimpleWeather.NWS.Windgust), 95 },
                {typeof(global::SimpleWeather.NWS.Barometricpressure), 96 },
                {typeof(global::SimpleWeather.NWS.Sealevelpressure), 97 },
                {typeof(global::SimpleWeather.NWS.Visibility), 98 },
                {typeof(global::SimpleWeather.NWS.Maxtemperaturelast24hours), 99 },
                {typeof(global::SimpleWeather.NWS.Mintemperaturelast24hours), 100 },
                {typeof(global::SimpleWeather.NWS.Precipitationlasthour), 101 },
                {typeof(global::SimpleWeather.NWS.Precipitationlast3hours), 102 },
                {typeof(global::SimpleWeather.NWS.Precipitationlast6hours), 103 },
                {typeof(global::SimpleWeather.NWS.Relativehumidity), 104 },
                {typeof(global::SimpleWeather.NWS.Windchill), 105 },
                {typeof(global::SimpleWeather.NWS.Heatindex), 106 },
                {typeof(global::SimpleWeather.NWS.Base), 107 },
                {typeof(global::SimpleWeather.NWS.Cloudlayer), 108 },
                {typeof(global::SimpleWeather.NWS.ObservationsCurrentRootobject), 109 },
                {typeof(global::SimpleWeather.OpenWeather.Coord), 110 },
                {typeof(global::SimpleWeather.OpenWeather.Weather), 111 },
                {typeof(global::SimpleWeather.OpenWeather.Main), 112 },
                {typeof(global::SimpleWeather.OpenWeather.Wind), 113 },
                {typeof(global::SimpleWeather.OpenWeather.Clouds), 114 },
                {typeof(global::SimpleWeather.OpenWeather.Rain), 115 },
                {typeof(global::SimpleWeather.OpenWeather.Snow), 116 },
                {typeof(global::SimpleWeather.OpenWeather.Sys), 117 },
                {typeof(global::SimpleWeather.OpenWeather.CurrentRootobject), 118 },
                {typeof(global::SimpleWeather.OpenWeather.ForecastSys), 119 },
                {typeof(global::SimpleWeather.OpenWeather.List), 120 },
                {typeof(global::SimpleWeather.OpenWeather.City), 121 },
                {typeof(global::SimpleWeather.OpenWeather.ForecastRootobject), 122 },
                {typeof(global::SimpleWeather.OpenWeather.Rootobject), 123 },
                {typeof(global::SimpleWeather.WeatherUnderground.Features), 124 },
                {typeof(global::SimpleWeather.WeatherUnderground.Error), 125 },
                {typeof(global::SimpleWeather.WeatherUnderground.Response), 126 },
                {typeof(global::SimpleWeather.WeatherUnderground.Alert), 127 },
                {typeof(global::SimpleWeather.WeatherUnderground.AlertRootobject), 128 },
                {typeof(global::SimpleWeather.WeatherUnderground.AlertFeatures), 129 },
                {typeof(global::SimpleWeather.WeatherUnderground.Vertex), 130 },
                {typeof(global::SimpleWeather.WeatherUnderground.Storminfo), 131 },
                {typeof(global::SimpleWeather.WeatherUnderground.Stormbased), 132 },
                {typeof(global::SimpleWeather.WeatherUnderground.AlertZONE), 133 },
                {typeof(global::SimpleWeather.WeatherUnderground.AC_RESULT), 134 },
                {typeof(global::SimpleWeather.WeatherUnderground.AC_Rootobject), 135 },
                {typeof(global::SimpleWeather.WeatherUnderground.locationTermsofservice), 136 },
                {typeof(global::SimpleWeather.WeatherUnderground.locationRadar), 137 },
                {typeof(global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation), 138 },
                {typeof(global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1), 139 },
                {typeof(global::SimpleWeather.WeatherUnderground.locationNearby_weather_stations), 140 },
                {typeof(global::SimpleWeather.WeatherUnderground.location), 141 },
                {typeof(global::SimpleWeather.WeatherUnderground.Image), 142 },
                {typeof(global::SimpleWeather.WeatherUnderground.Display_Location), 143 },
                {typeof(global::SimpleWeather.WeatherUnderground.Observation_Location), 144 },
                {typeof(global::SimpleWeather.WeatherUnderground.Current_Observation), 145 },
                {typeof(global::SimpleWeather.WeatherUnderground.Forecastday), 146 },
                {typeof(global::SimpleWeather.WeatherUnderground.Txt_Forecast), 147 },
                {typeof(global::SimpleWeather.WeatherUnderground.Date), 148 },
                {typeof(global::SimpleWeather.WeatherUnderground.High), 149 },
                {typeof(global::SimpleWeather.WeatherUnderground.Low), 150 },
                {typeof(global::SimpleWeather.WeatherUnderground.Qpf_Allday), 151 },
                {typeof(global::SimpleWeather.WeatherUnderground.Qpf_Day), 152 },
                {typeof(global::SimpleWeather.WeatherUnderground.Qpf_Night), 153 },
                {typeof(global::SimpleWeather.WeatherUnderground.Snow_Allday), 154 },
                {typeof(global::SimpleWeather.WeatherUnderground.Snow_Day), 155 },
                {typeof(global::SimpleWeather.WeatherUnderground.Snow_Night), 156 },
                {typeof(global::SimpleWeather.WeatherUnderground.Maxwind), 157 },
                {typeof(global::SimpleWeather.WeatherUnderground.Avewind), 158 },
                {typeof(global::SimpleWeather.WeatherUnderground.Forecastday1), 159 },
                {typeof(global::SimpleWeather.WeatherUnderground.Simpleforecast), 160 },
                {typeof(global::SimpleWeather.WeatherUnderground.Forecast), 161 },
                {typeof(global::SimpleWeather.WeatherUnderground.FCTTIME), 162 },
                {typeof(global::SimpleWeather.WeatherUnderground.Temp), 163 },
                {typeof(global::SimpleWeather.WeatherUnderground.Dewpoint), 164 },
                {typeof(global::SimpleWeather.WeatherUnderground.Wspd), 165 },
                {typeof(global::SimpleWeather.WeatherUnderground.Wdir), 166 },
                {typeof(global::SimpleWeather.WeatherUnderground.Windchill), 167 },
                {typeof(global::SimpleWeather.WeatherUnderground.Heatindex), 168 },
                {typeof(global::SimpleWeather.WeatherUnderground.Feelslike), 169 },
                {typeof(global::SimpleWeather.WeatherUnderground.Qpf), 170 },
                {typeof(global::SimpleWeather.WeatherUnderground.Snow), 171 },
                {typeof(global::SimpleWeather.WeatherUnderground.Mslp), 172 },
                {typeof(global::SimpleWeather.WeatherUnderground.Hourly_Forecast), 173 },
                {typeof(global::SimpleWeather.WeatherUnderground.Current_Time), 174 },
                {typeof(global::SimpleWeather.WeatherUnderground.Sunrise), 175 },
                {typeof(global::SimpleWeather.WeatherUnderground.Sunset), 176 },
                {typeof(global::SimpleWeather.WeatherUnderground.Moonrise), 177 },
                {typeof(global::SimpleWeather.WeatherUnderground.Moonset), 178 },
                {typeof(global::SimpleWeather.WeatherUnderground.Moon_Phase), 179 },
                {typeof(global::SimpleWeather.WeatherUnderground.Sunrise1), 180 },
                {typeof(global::SimpleWeather.WeatherUnderground.Sunset1), 181 },
                {typeof(global::SimpleWeather.WeatherUnderground.Sun_Phase), 182 },
                {typeof(global::SimpleWeather.WeatherUnderground.Rootobject), 183 },
                {typeof(global::SimpleWeather.WeatherYahoo.Location), 184 },
                {typeof(global::SimpleWeather.WeatherYahoo.Wind), 185 },
                {typeof(global::SimpleWeather.WeatherYahoo.Atmosphere), 186 },
                {typeof(global::SimpleWeather.WeatherYahoo.Astronomy), 187 },
                {typeof(global::SimpleWeather.WeatherYahoo.Condition), 188 },
                {typeof(global::SimpleWeather.WeatherYahoo.Current_Observation), 189 },
                {typeof(global::SimpleWeather.WeatherYahoo.Forecast), 190 },
                {typeof(global::SimpleWeather.WeatherYahoo.Rootobject), 191 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.Bing.Value>();
                case 1: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.Bing.Resource>();
                case 2: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.Bing.Resourceset>();
                case 3: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Timesegment>();
                case 4: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Alert>();
                case 5: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Additionaldata>();
                case 6: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Suggestion>();
                case 7: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Navigationposition>();
                case 8: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Result>();
                case 9: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.View>();
                case 10: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Observation>();
                case 11: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Location>();
                case 12: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Forecast>();
                case 13: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Forecast1>();
                case 14: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Astronomy1>();
                case 15: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.NWS.AlertGraph>();
                case 16: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.NWS.Period>();
                case 17: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.NWS.ObsGraph>();
                case 18: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.NWS.Cloudlayer>();
                case 19: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.OpenWeather.Weather>();
                case 20: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.OpenWeather.List>();
                case 21: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherUnderground.Alert>();
                case 22: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherUnderground.Vertex>();
                case 23: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherUnderground.AC_RESULT>();
                case 24: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation>();
                case 25: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1>();
                case 26: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherUnderground.Forecastday>();
                case 27: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherUnderground.Forecastday1>();
                case 28: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherUnderground.Hourly_Forecast>();
                case 29: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherYahoo.Forecast>();
                case 30: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.AddressFormatter();
                case 31: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.ValueFormatter();
                case 32: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.ResourceFormatter();
                case 33: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.ResourcesetFormatter();
                case 34: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.AC_RootobjectFormatter();
                case 35: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.TimesegmentFormatter();
                case 36: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AlertFormatter();
                case 37: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AlertsFormatter();
                case 38: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AdditionaldataFormatter();
                case 39: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AddressFormatter();
                case 40: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.SuggestionFormatter();
                case 41: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AC_RootobjectFormatter();
                case 42: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.MetainfoFormatter();
                case 43: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.MatchqualityFormatter();
                case 44: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.DisplaypositionFormatter();
                case 45: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.NavigationpositionFormatter();
                case 46: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.TimezoneFormatter();
                case 47: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AdmininfoFormatter();
                case 48: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.GeoLocationFormatter();
                case 49: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ResultFormatter();
                case 50: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ViewFormatter();
                case 51: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ResponseFormatter();
                case 52: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.Geo_RootobjectFormatter();
                case 53: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.TokenRootobjectFormatter();
                case 54: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.TokenFormatter();
                case 55: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ObservationFormatter();
                case 56: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.LocationFormatter();
                case 57: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ObservationsFormatter();
                case 58: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ForecastFormatter();
                case 59: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ForecastlocationFormatter();
                case 60: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.DailyforecastsFormatter();
                case 61: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.Forecast1Formatter();
                case 62: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.Forecastlocation1Formatter();
                case 63: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.HourlyforecastsFormatter();
                case 64: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.Astronomy1Formatter();
                case 65: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AstronomyFormatter();
                case 66: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.RootobjectFormatter();
                case 67: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.GeometryFormatter();
                case 68: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.DistanceFormatter();
                case 69: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.BearingFormatter();
                case 70: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ValueFormatter();
                case 71: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.UnitcodeFormatter();
                case 72: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ForecastofficeFormatter();
                case 73: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ForecastgriddataFormatter();
                case 74: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.PubliczoneFormatter();
                case 75: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.CountyFormatter();
                case 76: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ContextFormatter();
                case 77: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.GeocodeFormatter();
                case 78: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ParametersFormatter();
                case 79: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.AlertGraphFormatter();
                case 80: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.AlertRootobjectFormatter();
                case 81: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.Distance1Formatter();
                case 82: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.Bearing1Formatter();
                case 83: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.RelativelocationFormatter();
                case 84: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.PointsRootobjectFormatter();
                case 85: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ElevationFormatter();
                case 86: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.PeriodFormatter();
                case 87: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ForecastRootobjectFormatter();
                case 88: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ObsGraphFormatter();
                case 89: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ObservationsStationsRootobjectFormatter();
                case 90: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ObservationstationsFormatter();
                case 91: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.TemperatureFormatter();
                case 92: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.DewpointFormatter();
                case 93: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.WinddirectionFormatter();
                case 94: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.WindspeedFormatter();
                case 95: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.WindgustFormatter();
                case 96: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.BarometricpressureFormatter();
                case 97: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.SealevelpressureFormatter();
                case 98: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.VisibilityFormatter();
                case 99: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.Maxtemperaturelast24hoursFormatter();
                case 100: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.Mintemperaturelast24hoursFormatter();
                case 101: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.PrecipitationlasthourFormatter();
                case 102: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.Precipitationlast3hoursFormatter();
                case 103: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.Precipitationlast6hoursFormatter();
                case 104: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.RelativehumidityFormatter();
                case 105: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.WindchillFormatter();
                case 106: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.HeatindexFormatter();
                case 107: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.BaseFormatter();
                case 108: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.CloudlayerFormatter();
                case 109: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ObservationsCurrentRootobjectFormatter();
                case 110: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.CoordFormatter();
                case 111: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.WeatherFormatter();
                case 112: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.MainFormatter();
                case 113: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.WindFormatter();
                case 114: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.CloudsFormatter();
                case 115: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.RainFormatter();
                case 116: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.SnowFormatter();
                case 117: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.SysFormatter();
                case 118: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.CurrentRootobjectFormatter();
                case 119: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.ForecastSysFormatter();
                case 120: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.ListFormatter();
                case 121: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.CityFormatter();
                case 122: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.ForecastRootobjectFormatter();
                case 123: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.RootobjectFormatter();
                case 124: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.FeaturesFormatter();
                case 125: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.ErrorFormatter();
                case 126: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.ResponseFormatter();
                case 127: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.AlertFormatter();
                case 128: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.AlertRootobjectFormatter();
                case 129: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.AlertFeaturesFormatter();
                case 130: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.VertexFormatter();
                case 131: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.StorminfoFormatter();
                case 132: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.StormbasedFormatter();
                case 133: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.AlertZONEFormatter();
                case 134: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.AC_RESULTFormatter();
                case 135: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.AC_RootobjectFormatter();
                case 136: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.locationTermsofserviceFormatter();
                case 137: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.locationRadarFormatter();
                case 138: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStationFormatter();
                case 139: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1Formatter();
                case 140: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.locationNearby_weather_stationsFormatter();
                case 141: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.locationFormatter();
                case 142: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.ImageFormatter();
                case 143: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Display_LocationFormatter();
                case 144: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Observation_LocationFormatter();
                case 145: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Current_ObservationFormatter();
                case 146: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.ForecastdayFormatter();
                case 147: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Txt_ForecastFormatter();
                case 148: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.DateFormatter();
                case 149: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.HighFormatter();
                case 150: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.LowFormatter();
                case 151: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Qpf_AlldayFormatter();
                case 152: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Qpf_DayFormatter();
                case 153: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Qpf_NightFormatter();
                case 154: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Snow_AlldayFormatter();
                case 155: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Snow_DayFormatter();
                case 156: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Snow_NightFormatter();
                case 157: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.MaxwindFormatter();
                case 158: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.AvewindFormatter();
                case 159: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Forecastday1Formatter();
                case 160: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.SimpleforecastFormatter();
                case 161: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.ForecastFormatter();
                case 162: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.FCTTIMEFormatter();
                case 163: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.TempFormatter();
                case 164: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.DewpointFormatter();
                case 165: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.WspdFormatter();
                case 166: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.WdirFormatter();
                case 167: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.WindchillFormatter();
                case 168: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.HeatindexFormatter();
                case 169: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.FeelslikeFormatter();
                case 170: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.QpfFormatter();
                case 171: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.SnowFormatter();
                case 172: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.MslpFormatter();
                case 173: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Hourly_ForecastFormatter();
                case 174: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Current_TimeFormatter();
                case 175: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.SunriseFormatter();
                case 176: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.SunsetFormatter();
                case 177: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.MoonriseFormatter();
                case 178: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.MoonsetFormatter();
                case 179: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Moon_PhaseFormatter();
                case 180: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Sunrise1Formatter();
                case 181: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Sunset1Formatter();
                case 182: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.Sun_PhaseFormatter();
                case 183: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground.RootobjectFormatter();
                case 184: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.LocationFormatter();
                case 185: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.WindFormatter();
                case 186: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.AtmosphereFormatter();
                case 187: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.AstronomyFormatter();
                case 188: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.ConditionFormatter();
                case 189: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.Current_ObservationFormatter();
                case 190: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.ForecastFormatter();
                case 191: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.RootobjectFormatter();
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

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing
{
    using System;
    using Utf8Json;


    public sealed class AddressFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.Address>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AddressFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("countryRegion"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locality"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("adminDistrict"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("countryRegionIso2"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("formattedAddress"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("adminDistrict2"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("houseNumber"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("streetName"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("addressLine"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("neighborhood"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("postalCode"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("entityType"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 12},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("countryRegion"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("locality"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("adminDistrict"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("countryRegionIso2"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("formattedAddress"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("adminDistrict2"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("houseNumber"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("streetName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("addressLine"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("neighborhood"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("postalCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("entityType"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.Address value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.countryRegion);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.locality);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.adminDistrict);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.countryRegionIso2);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.formattedAddress);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.adminDistrict2);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.houseNumber);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.streetName);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.addressLine);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.neighborhood);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.postalCode);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.entityType);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.name);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.Address Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __countryRegion__ = default(string);
            var __countryRegion__b__ = false;
            var __locality__ = default(string);
            var __locality__b__ = false;
            var __adminDistrict__ = default(string);
            var __adminDistrict__b__ = false;
            var __countryRegionIso2__ = default(string);
            var __countryRegionIso2__b__ = false;
            var __formattedAddress__ = default(string);
            var __formattedAddress__b__ = false;
            var __adminDistrict2__ = default(string);
            var __adminDistrict2__b__ = false;
            var __houseNumber__ = default(string);
            var __houseNumber__b__ = false;
            var __streetName__ = default(string);
            var __streetName__b__ = false;
            var __addressLine__ = default(string);
            var __addressLine__b__ = false;
            var __neighborhood__ = default(string);
            var __neighborhood__b__ = false;
            var __postalCode__ = default(string);
            var __postalCode__b__ = false;
            var __entityType__ = default(string);
            var __entityType__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;

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
                        __countryRegion__ = reader.ReadString();
                        __countryRegion__b__ = true;
                        break;
                    case 1:
                        __locality__ = reader.ReadString();
                        __locality__b__ = true;
                        break;
                    case 2:
                        __adminDistrict__ = reader.ReadString();
                        __adminDistrict__b__ = true;
                        break;
                    case 3:
                        __countryRegionIso2__ = reader.ReadString();
                        __countryRegionIso2__b__ = true;
                        break;
                    case 4:
                        __formattedAddress__ = reader.ReadString();
                        __formattedAddress__b__ = true;
                        break;
                    case 5:
                        __adminDistrict2__ = reader.ReadString();
                        __adminDistrict2__b__ = true;
                        break;
                    case 6:
                        __houseNumber__ = reader.ReadString();
                        __houseNumber__b__ = true;
                        break;
                    case 7:
                        __streetName__ = reader.ReadString();
                        __streetName__b__ = true;
                        break;
                    case 8:
                        __addressLine__ = reader.ReadString();
                        __addressLine__b__ = true;
                        break;
                    case 9:
                        __neighborhood__ = reader.ReadString();
                        __neighborhood__b__ = true;
                        break;
                    case 10:
                        __postalCode__ = reader.ReadString();
                        __postalCode__b__ = true;
                        break;
                    case 11:
                        __entityType__ = reader.ReadString();
                        __entityType__b__ = true;
                        break;
                    case 12:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.Address();
            if(__countryRegion__b__) ____result.countryRegion = __countryRegion__;
            if(__locality__b__) ____result.locality = __locality__;
            if(__adminDistrict__b__) ____result.adminDistrict = __adminDistrict__;
            if(__countryRegionIso2__b__) ____result.countryRegionIso2 = __countryRegionIso2__;
            if(__formattedAddress__b__) ____result.formattedAddress = __formattedAddress__;
            if(__adminDistrict2__b__) ____result.adminDistrict2 = __adminDistrict2__;
            if(__houseNumber__b__) ____result.houseNumber = __houseNumber__;
            if(__streetName__b__) ____result.streetName = __streetName__;
            if(__addressLine__b__) ____result.addressLine = __addressLine__;
            if(__neighborhood__b__) ____result.neighborhood = __neighborhood__;
            if(__postalCode__b__) ____result.postalCode = __postalCode__;
            if(__entityType__b__) ____result.entityType = __entityType__;
            if(__name__b__) ____result.name = __name__;

            return ____result;
        }
    }


    public sealed class ValueFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.Value>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ValueFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("__type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("address"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("__type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("address"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.Value value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.__type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Address>().Serialize(ref writer, value.address, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.Value Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ____type__ = default(string);
            var ____type__b__ = false;
            var __address__ = default(global::SimpleWeather.Bing.Address);
            var __address__b__ = false;

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
                        ____type__ = reader.ReadString();
                        ____type__b__ = true;
                        break;
                    case 1:
                        __address__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Address>().Deserialize(ref reader, formatterResolver);
                        __address__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.Value();
            if(____type__b__) ____result.__type = ____type__;
            if(__address__b__) ____result.address = __address__;

            return ____result;
        }
    }


    public sealed class ResourceFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.Resource>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ResourceFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("__type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("__type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("value"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.Resource value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.__type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Value[]>().Serialize(ref writer, value.value, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.Resource Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ____type__ = default(string);
            var ____type__b__ = false;
            var __value__ = default(global::SimpleWeather.Bing.Value[]);
            var __value__b__ = false;

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
                        ____type__ = reader.ReadString();
                        ____type__b__ = true;
                        break;
                    case 1:
                        __value__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Value[]>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.Resource();
            if(____type__b__) ____result.__type = ____type__;
            if(__value__b__) ____result.value = __value__;

            return ____result;
        }
    }


    public sealed class ResourcesetFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.Resourceset>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ResourcesetFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("estimatedTotal"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("resources"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("estimatedTotal"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("resources"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.Resourceset value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.estimatedTotal);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Resource[]>().Serialize(ref writer, value.resources, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.Resourceset Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __estimatedTotal__ = default(int);
            var __estimatedTotal__b__ = false;
            var __resources__ = default(global::SimpleWeather.Bing.Resource[]);
            var __resources__b__ = false;

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
                        __estimatedTotal__ = reader.ReadInt32();
                        __estimatedTotal__b__ = true;
                        break;
                    case 1:
                        __resources__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Resource[]>().Deserialize(ref reader, formatterResolver);
                        __resources__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.Resourceset();
            if(__estimatedTotal__b__) ____result.estimatedTotal = __estimatedTotal__;
            if(__resources__b__) ____result.resources = __resources__;

            return ____result;
        }
    }


    public sealed class AC_RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.AC_Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AC_RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("authenticationResultCode"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("brandLogoUri"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("copyright"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("resourceSets"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("statusCode"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("statusDescription"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("traceId"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("authenticationResultCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("brandLogoUri"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("copyright"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("resourceSets"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("statusCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("statusDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("traceId"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.AC_Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.authenticationResultCode);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.brandLogoUri);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.copyright);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Resourceset[]>().Serialize(ref writer, value.resourceSets, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value.statusCode);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.statusDescription);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.traceId);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.AC_Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __authenticationResultCode__ = default(string);
            var __authenticationResultCode__b__ = false;
            var __brandLogoUri__ = default(string);
            var __brandLogoUri__b__ = false;
            var __copyright__ = default(string);
            var __copyright__b__ = false;
            var __resourceSets__ = default(global::SimpleWeather.Bing.Resourceset[]);
            var __resourceSets__b__ = false;
            var __statusCode__ = default(int);
            var __statusCode__b__ = false;
            var __statusDescription__ = default(string);
            var __statusDescription__b__ = false;
            var __traceId__ = default(string);
            var __traceId__b__ = false;

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
                        __authenticationResultCode__ = reader.ReadString();
                        __authenticationResultCode__b__ = true;
                        break;
                    case 1:
                        __brandLogoUri__ = reader.ReadString();
                        __brandLogoUri__b__ = true;
                        break;
                    case 2:
                        __copyright__ = reader.ReadString();
                        __copyright__b__ = true;
                        break;
                    case 3:
                        __resourceSets__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Resourceset[]>().Deserialize(ref reader, formatterResolver);
                        __resourceSets__b__ = true;
                        break;
                    case 4:
                        __statusCode__ = reader.ReadInt32();
                        __statusCode__b__ = true;
                        break;
                    case 5:
                        __statusDescription__ = reader.ReadString();
                        __statusDescription__b__ = true;
                        break;
                    case 6:
                        __traceId__ = reader.ReadString();
                        __traceId__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.AC_Rootobject();
            if(__authenticationResultCode__b__) ____result.authenticationResultCode = __authenticationResultCode__;
            if(__brandLogoUri__b__) ____result.brandLogoUri = __brandLogoUri__;
            if(__copyright__b__) ____result.copyright = __copyright__;
            if(__resourceSets__b__) ____result.resourceSets = __resourceSets__;
            if(__statusCode__b__) ____result.statusCode = __statusCode__;
            if(__statusDescription__b__) ____result.statusDescription = __statusDescription__;
            if(__traceId__b__) ____result.traceId = __traceId__;

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

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE
{
    using System;
    using Utf8Json;


    public sealed class TimesegmentFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Timesegment>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TimesegmentFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("segment"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("otherAttributes"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("day_of_week"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("segment"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("otherAttributes"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("day_of_week"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Timesegment value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.value);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.segment);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Otherattributes>().Serialize(ref writer, value.otherAttributes, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.day_of_week);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Timesegment Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(string);
            var __value__b__ = false;
            var __segment__ = default(string);
            var __segment__b__ = false;
            var __otherAttributes__ = default(global::SimpleWeather.HERE.Otherattributes);
            var __otherAttributes__b__ = false;
            var __day_of_week__ = default(string);
            var __day_of_week__b__ = false;

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
                        __value__ = reader.ReadString();
                        __value__b__ = true;
                        break;
                    case 1:
                        __segment__ = reader.ReadString();
                        __segment__b__ = true;
                        break;
                    case 2:
                        __otherAttributes__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Otherattributes>().Deserialize(ref reader, formatterResolver);
                        __otherAttributes__b__ = true;
                        break;
                    case 3:
                        __day_of_week__ = reader.ReadString();
                        __day_of_week__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Timesegment();
            if(__value__b__) ____result.value = __value__;
            if(__segment__b__) ____result.segment = __segment__;
            if(__otherAttributes__b__) ____result.otherAttributes = __otherAttributes__;
            if(__day_of_week__b__) ____result.day_of_week = __day_of_week__;

            return ____result;
        }
    }


    public sealed class AlertFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Alert>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timeSegment"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("timeSegment"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Alert value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Timesegment[]>().Serialize(ref writer, value.timeSegment, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.type);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.description);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Alert Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __timeSegment__ = default(global::SimpleWeather.HERE.Timesegment[]);
            var __timeSegment__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;

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
                        __timeSegment__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Timesegment[]>().Deserialize(ref reader, formatterResolver);
                        __timeSegment__b__ = true;
                        break;
                    case 1:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    case 2:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Alert();
            if(__timeSegment__b__) ____result.timeSegment = __timeSegment__;
            if(__type__b__) ____result.type = __type__;
            if(__description__b__) ____result.description = __description__;

            return ____result;
        }
    }


    public sealed class AlertsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Alerts>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("alerts"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("alerts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Alerts value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Alert[]>().Serialize(ref writer, value.alerts, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Alerts Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __alerts__ = default(global::SimpleWeather.HERE.Alert[]);
            var __alerts__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

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
                        __alerts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Alert[]>().Deserialize(ref reader, formatterResolver);
                        __alerts__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Alerts();
            if(__alerts__b__) ____result.alerts = __alerts__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class AdditionaldataFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Additionaldata>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AdditionaldataFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("key"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("key"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Additionaldata value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.value);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.key);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Additionaldata Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(string);
            var __value__b__ = false;
            var __key__ = default(string);
            var __key__b__ = false;

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
                        __value__ = reader.ReadString();
                        __value__b__ = true;
                        break;
                    case 1:
                        __key__ = reader.ReadString();
                        __key__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Additionaldata();
            if(__value__b__) ____result.value = __value__;
            if(__key__b__) ____result.key = __key__;

            return ____result;
        }
    }


    public sealed class AddressFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Address>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AddressFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("county"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("postalCode"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("district"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("street"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("label"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("houseNumber"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("additionalData"), 9},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("county"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("postalCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("district"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("street"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("label"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("houseNumber"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("additionalData"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Address value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.county);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.postalCode);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.district);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.street);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.label);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.houseNumber);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Additionaldata[]>().Serialize(ref writer, value.additionalData, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Address Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __county__ = default(string);
            var __county__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __postalCode__ = default(string);
            var __postalCode__b__ = false;
            var __district__ = default(string);
            var __district__b__ = false;
            var __street__ = default(string);
            var __street__b__ = false;
            var __label__ = default(string);
            var __label__b__ = false;
            var __houseNumber__ = default(string);
            var __houseNumber__b__ = false;
            var __additionalData__ = default(global::SimpleWeather.HERE.Additionaldata[]);
            var __additionalData__b__ = false;

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
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 1:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 2:
                        __county__ = reader.ReadString();
                        __county__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __postalCode__ = reader.ReadString();
                        __postalCode__b__ = true;
                        break;
                    case 5:
                        __district__ = reader.ReadString();
                        __district__b__ = true;
                        break;
                    case 6:
                        __street__ = reader.ReadString();
                        __street__b__ = true;
                        break;
                    case 7:
                        __label__ = reader.ReadString();
                        __label__b__ = true;
                        break;
                    case 8:
                        __houseNumber__ = reader.ReadString();
                        __houseNumber__b__ = true;
                        break;
                    case 9:
                        __additionalData__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Additionaldata[]>().Deserialize(ref reader, formatterResolver);
                        __additionalData__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Address();
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__county__b__) ____result.county = __county__;
            if(__city__b__) ____result.city = __city__;
            if(__postalCode__b__) ____result.postalCode = __postalCode__;
            if(__district__b__) ____result.district = __district__;
            if(__street__b__) ____result.street = __street__;
            if(__label__b__) ____result.label = __label__;
            if(__houseNumber__b__) ____result.houseNumber = __houseNumber__;
            if(__additionalData__b__) ____result.additionalData = __additionalData__;

            return ____result;
        }
    }


    public sealed class SuggestionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Suggestion>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SuggestionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("label"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("language"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("countryCode"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locationId"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("address"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("matchLevel"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("label"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("language"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("countryCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("locationId"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("address"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("matchLevel"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Suggestion value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.label);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.language);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.countryCode);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.locationId);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Address>().Serialize(ref writer, value.address, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.matchLevel);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Suggestion Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __label__ = default(string);
            var __label__b__ = false;
            var __language__ = default(string);
            var __language__b__ = false;
            var __countryCode__ = default(string);
            var __countryCode__b__ = false;
            var __locationId__ = default(string);
            var __locationId__b__ = false;
            var __address__ = default(global::SimpleWeather.HERE.Address);
            var __address__b__ = false;
            var __matchLevel__ = default(string);
            var __matchLevel__b__ = false;

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
                        __label__ = reader.ReadString();
                        __label__b__ = true;
                        break;
                    case 1:
                        __language__ = reader.ReadString();
                        __language__b__ = true;
                        break;
                    case 2:
                        __countryCode__ = reader.ReadString();
                        __countryCode__b__ = true;
                        break;
                    case 3:
                        __locationId__ = reader.ReadString();
                        __locationId__b__ = true;
                        break;
                    case 4:
                        __address__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Address>().Deserialize(ref reader, formatterResolver);
                        __address__b__ = true;
                        break;
                    case 5:
                        __matchLevel__ = reader.ReadString();
                        __matchLevel__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Suggestion();
            if(__label__b__) ____result.label = __label__;
            if(__language__b__) ____result.language = __language__;
            if(__countryCode__b__) ____result.countryCode = __countryCode__;
            if(__locationId__b__) ____result.locationId = __locationId__;
            if(__address__b__) ____result.address = __address__;
            if(__matchLevel__b__) ____result.matchLevel = __matchLevel__;

            return ____result;
        }
    }


    public sealed class AC_RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.AC_Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AC_RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("suggestions"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("suggestions"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.AC_Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Suggestion[]>().Serialize(ref writer, value.suggestions, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.AC_Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __suggestions__ = default(global::SimpleWeather.HERE.Suggestion[]);
            var __suggestions__b__ = false;

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
                        __suggestions__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Suggestion[]>().Deserialize(ref reader, formatterResolver);
                        __suggestions__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.AC_Rootobject();
            if(__suggestions__b__) ____result.suggestions = __suggestions__;

            return ____result;
        }
    }


    public sealed class MetainfoFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Metainfo>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MetainfoFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timestamp"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nextPageInformation"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("timestamp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nextPageInformation"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Metainfo value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.timestamp);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.nextPageInformation);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Metainfo Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __timestamp__ = default(string);
            var __timestamp__b__ = false;
            var __nextPageInformation__ = default(string);
            var __nextPageInformation__b__ = false;

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
                        __timestamp__ = reader.ReadString();
                        __timestamp__b__ = true;
                        break;
                    case 1:
                        __nextPageInformation__ = reader.ReadString();
                        __nextPageInformation__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Metainfo();
            if(__timestamp__b__) ____result.timestamp = __timestamp__;
            if(__nextPageInformation__b__) ____result.nextPageInformation = __nextPageInformation__;

            return ____result;
        }
    }


    public sealed class MatchqualityFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Matchquality>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MatchqualityFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("county"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("district"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("street"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("houseNumber"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("postalCode"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("county"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("district"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("street"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("houseNumber"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("postalCode"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Matchquality value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.country);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.state);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.county);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteSingle(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.district);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<float[]>().Serialize(ref writer, value.street, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.houseNumber);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteSingle(value.postalCode);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Matchquality Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __country__ = default(float);
            var __country__b__ = false;
            var __state__ = default(float);
            var __state__b__ = false;
            var __county__ = default(float);
            var __county__b__ = false;
            var __city__ = default(float);
            var __city__b__ = false;
            var __district__ = default(float);
            var __district__b__ = false;
            var __street__ = default(float[]);
            var __street__b__ = false;
            var __houseNumber__ = default(float);
            var __houseNumber__b__ = false;
            var __postalCode__ = default(float);
            var __postalCode__b__ = false;

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
                        __country__ = reader.ReadSingle();
                        __country__b__ = true;
                        break;
                    case 1:
                        __state__ = reader.ReadSingle();
                        __state__b__ = true;
                        break;
                    case 2:
                        __county__ = reader.ReadSingle();
                        __county__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadSingle();
                        __city__b__ = true;
                        break;
                    case 4:
                        __district__ = reader.ReadSingle();
                        __district__b__ = true;
                        break;
                    case 5:
                        __street__ = formatterResolver.GetFormatterWithVerify<float[]>().Deserialize(ref reader, formatterResolver);
                        __street__b__ = true;
                        break;
                    case 6:
                        __houseNumber__ = reader.ReadSingle();
                        __houseNumber__b__ = true;
                        break;
                    case 7:
                        __postalCode__ = reader.ReadSingle();
                        __postalCode__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Matchquality();
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__county__b__) ____result.county = __county__;
            if(__city__b__) ____result.city = __city__;
            if(__district__b__) ____result.district = __district__;
            if(__street__b__) ____result.street = __street__;
            if(__houseNumber__b__) ____result.houseNumber = __houseNumber__;
            if(__postalCode__b__) ____result.postalCode = __postalCode__;

            return ____result;
        }
    }


    public sealed class DisplaypositionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Displayposition>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DisplaypositionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Displayposition value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.longitude);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Displayposition Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;

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
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 1:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Displayposition();
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;

            return ____result;
        }
    }


    public sealed class NavigationpositionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Navigationposition>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public NavigationpositionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Navigationposition value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.longitude);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Navigationposition Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;

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
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 1:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Navigationposition();
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;

            return ____result;
        }
    }


    public sealed class TimezoneFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Timezone>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TimezoneFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("offset"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rawOffset"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nameShort"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nameLong"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nameDstShort"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nameDstLong"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("inDaylightTime"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dstSavings"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 8},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("offset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rawOffset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nameShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nameLong"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nameDstShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nameDstLong"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("inDaylightTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dstSavings"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("id"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Timezone value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.offset);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.rawOffset);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.nameShort);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.nameLong);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.nameDstShort);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.nameDstLong);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteBoolean(value.inDaylightTime);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.dstSavings);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.id);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Timezone Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __offset__ = default(int);
            var __offset__b__ = false;
            var __rawOffset__ = default(int);
            var __rawOffset__b__ = false;
            var __nameShort__ = default(string);
            var __nameShort__b__ = false;
            var __nameLong__ = default(string);
            var __nameLong__b__ = false;
            var __nameDstShort__ = default(string);
            var __nameDstShort__b__ = false;
            var __nameDstLong__ = default(string);
            var __nameDstLong__b__ = false;
            var __inDaylightTime__ = default(bool);
            var __inDaylightTime__b__ = false;
            var __dstSavings__ = default(int);
            var __dstSavings__b__ = false;
            var __id__ = default(string);
            var __id__b__ = false;

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
                        __offset__ = reader.ReadInt32();
                        __offset__b__ = true;
                        break;
                    case 1:
                        __rawOffset__ = reader.ReadInt32();
                        __rawOffset__b__ = true;
                        break;
                    case 2:
                        __nameShort__ = reader.ReadString();
                        __nameShort__b__ = true;
                        break;
                    case 3:
                        __nameLong__ = reader.ReadString();
                        __nameLong__b__ = true;
                        break;
                    case 4:
                        __nameDstShort__ = reader.ReadString();
                        __nameDstShort__b__ = true;
                        break;
                    case 5:
                        __nameDstLong__ = reader.ReadString();
                        __nameDstLong__b__ = true;
                        break;
                    case 6:
                        __inDaylightTime__ = reader.ReadBoolean();
                        __inDaylightTime__b__ = true;
                        break;
                    case 7:
                        __dstSavings__ = reader.ReadInt32();
                        __dstSavings__b__ = true;
                        break;
                    case 8:
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Timezone();
            if(__offset__b__) ____result.offset = __offset__;
            if(__rawOffset__b__) ____result.rawOffset = __rawOffset__;
            if(__nameShort__b__) ____result.nameShort = __nameShort__;
            if(__nameLong__b__) ____result.nameLong = __nameLong__;
            if(__nameDstShort__b__) ____result.nameDstShort = __nameDstShort__;
            if(__nameDstLong__b__) ____result.nameDstLong = __nameDstLong__;
            if(__inDaylightTime__b__) ____result.inDaylightTime = __inDaylightTime__;
            if(__dstSavings__b__) ____result.dstSavings = __dstSavings__;
            if(__id__b__) ____result.id = __id__;

            return ____result;
        }
    }


    public sealed class AdmininfoFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Admininfo>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AdmininfoFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("localTime"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("currency"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("drivingSide"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("systemOfMeasure"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timeZone"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("localTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("currency"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("drivingSide"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("systemOfMeasure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timeZone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Admininfo value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.localTime);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.currency);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.drivingSide);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.systemOfMeasure);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Timezone>().Serialize(ref writer, value.timeZone, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Admininfo Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __localTime__ = default(string);
            var __localTime__b__ = false;
            var __currency__ = default(string);
            var __currency__b__ = false;
            var __drivingSide__ = default(string);
            var __drivingSide__b__ = false;
            var __systemOfMeasure__ = default(string);
            var __systemOfMeasure__b__ = false;
            var __timeZone__ = default(global::SimpleWeather.HERE.Timezone);
            var __timeZone__b__ = false;

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
                        __localTime__ = reader.ReadString();
                        __localTime__b__ = true;
                        break;
                    case 1:
                        __currency__ = reader.ReadString();
                        __currency__b__ = true;
                        break;
                    case 2:
                        __drivingSide__ = reader.ReadString();
                        __drivingSide__b__ = true;
                        break;
                    case 3:
                        __systemOfMeasure__ = reader.ReadString();
                        __systemOfMeasure__b__ = true;
                        break;
                    case 4:
                        __timeZone__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Timezone>().Deserialize(ref reader, formatterResolver);
                        __timeZone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Admininfo();
            if(__localTime__b__) ____result.localTime = __localTime__;
            if(__currency__b__) ____result.currency = __currency__;
            if(__drivingSide__b__) ____result.drivingSide = __drivingSide__;
            if(__systemOfMeasure__b__) ____result.systemOfMeasure = __systemOfMeasure__;
            if(__timeZone__b__) ____result.timeZone = __timeZone__;

            return ____result;
        }
    }


    public sealed class GeoLocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.GeoLocation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public GeoLocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locationId"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locationType"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("displayPosition"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("navigationPosition"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("address"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("adminInfo"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("locationId"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("locationType"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("displayPosition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("navigationPosition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("address"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("adminInfo"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.GeoLocation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.locationId);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.locationType);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Displayposition>().Serialize(ref writer, value.displayPosition, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Navigationposition[]>().Serialize(ref writer, value.navigationPosition, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Address>().Serialize(ref writer, value.address, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Admininfo>().Serialize(ref writer, value.adminInfo, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.GeoLocation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __locationId__ = default(string);
            var __locationId__b__ = false;
            var __locationType__ = default(string);
            var __locationType__b__ = false;
            var __displayPosition__ = default(global::SimpleWeather.HERE.Displayposition);
            var __displayPosition__b__ = false;
            var __navigationPosition__ = default(global::SimpleWeather.HERE.Navigationposition[]);
            var __navigationPosition__b__ = false;
            var __address__ = default(global::SimpleWeather.HERE.Address);
            var __address__b__ = false;
            var __adminInfo__ = default(global::SimpleWeather.HERE.Admininfo);
            var __adminInfo__b__ = false;

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
                        __locationId__ = reader.ReadString();
                        __locationId__b__ = true;
                        break;
                    case 1:
                        __locationType__ = reader.ReadString();
                        __locationType__b__ = true;
                        break;
                    case 2:
                        __displayPosition__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Displayposition>().Deserialize(ref reader, formatterResolver);
                        __displayPosition__b__ = true;
                        break;
                    case 3:
                        __navigationPosition__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Navigationposition[]>().Deserialize(ref reader, formatterResolver);
                        __navigationPosition__b__ = true;
                        break;
                    case 4:
                        __address__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Address>().Deserialize(ref reader, formatterResolver);
                        __address__b__ = true;
                        break;
                    case 5:
                        __adminInfo__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Admininfo>().Deserialize(ref reader, formatterResolver);
                        __adminInfo__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.GeoLocation();
            if(__locationId__b__) ____result.locationId = __locationId__;
            if(__locationType__b__) ____result.locationType = __locationType__;
            if(__displayPosition__b__) ____result.displayPosition = __displayPosition__;
            if(__navigationPosition__b__) ____result.navigationPosition = __navigationPosition__;
            if(__address__b__) ____result.address = __address__;
            if(__adminInfo__b__) ____result.adminInfo = __adminInfo__;

            return ____result;
        }
    }


    public sealed class ResultFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Result>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ResultFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("relevance"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("matchLevel"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("matchQuality"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("matchType"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("location"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("relevance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("matchLevel"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("matchQuality"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("matchType"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("location"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Result value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.relevance);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.matchLevel);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Matchquality>().Serialize(ref writer, value.matchQuality, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.matchType);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.GeoLocation>().Serialize(ref writer, value.location, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Result Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __relevance__ = default(float);
            var __relevance__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __matchLevel__ = default(string);
            var __matchLevel__b__ = false;
            var __matchQuality__ = default(global::SimpleWeather.HERE.Matchquality);
            var __matchQuality__b__ = false;
            var __matchType__ = default(string);
            var __matchType__b__ = false;
            var __location__ = default(global::SimpleWeather.HERE.GeoLocation);
            var __location__b__ = false;

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
                        __relevance__ = reader.ReadSingle();
                        __relevance__b__ = true;
                        break;
                    case 1:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 2:
                        __matchLevel__ = reader.ReadString();
                        __matchLevel__b__ = true;
                        break;
                    case 3:
                        __matchQuality__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Matchquality>().Deserialize(ref reader, formatterResolver);
                        __matchQuality__b__ = true;
                        break;
                    case 4:
                        __matchType__ = reader.ReadString();
                        __matchType__b__ = true;
                        break;
                    case 5:
                        __location__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.GeoLocation>().Deserialize(ref reader, formatterResolver);
                        __location__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Result();
            if(__relevance__b__) ____result.relevance = __relevance__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__matchLevel__b__) ____result.matchLevel = __matchLevel__;
            if(__matchQuality__b__) ____result.matchQuality = __matchQuality__;
            if(__matchType__b__) ____result.matchType = __matchType__;
            if(__location__b__) ____result.location = __location__;

            return ____result;
        }
    }


    public sealed class ViewFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.View>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ViewFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("result"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("viewId"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("result"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("viewId"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.View value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Result[]>().Serialize(ref writer, value.result, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.viewId);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.View Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __result__ = default(global::SimpleWeather.HERE.Result[]);
            var __result__b__ = false;
            var __viewId__ = default(int);
            var __viewId__b__ = false;

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
                        __result__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Result[]>().Deserialize(ref reader, formatterResolver);
                        __result__b__ = true;
                        break;
                    case 1:
                        __viewId__ = reader.ReadInt32();
                        __viewId__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.View();
            if(__result__b__) ____result.result = __result__;
            if(__viewId__b__) ____result.viewId = __viewId__;

            return ____result;
        }
    }


    public sealed class ResponseFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Response>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ResponseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metaInfo"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("view"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("metaInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("view"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Response value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Metainfo>().Serialize(ref writer, value.metaInfo, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.View[]>().Serialize(ref writer, value.view, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Response Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __metaInfo__ = default(global::SimpleWeather.HERE.Metainfo);
            var __metaInfo__b__ = false;
            var __view__ = default(global::SimpleWeather.HERE.View[]);
            var __view__b__ = false;

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
                        __metaInfo__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Metainfo>().Deserialize(ref reader, formatterResolver);
                        __metaInfo__b__ = true;
                        break;
                    case 1:
                        __view__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.View[]>().Deserialize(ref reader, formatterResolver);
                        __view__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Response();
            if(__metaInfo__b__) ____result.metaInfo = __metaInfo__;
            if(__view__b__) ____result.view = __view__;

            return ____result;
        }
    }


    public sealed class Geo_RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Geo_Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Geo_RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("response"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("response"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Geo_Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Response>().Serialize(ref writer, value.response, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Geo_Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __response__ = default(global::SimpleWeather.HERE.Response);
            var __response__b__ = false;

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
                        __response__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Response>().Deserialize(ref reader, formatterResolver);
                        __response__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Geo_Rootobject();
            if(__response__b__) ____result.response = __response__;

            return ____result;
        }
    }


    public sealed class TokenRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.TokenRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TokenRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("access_token"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("token_type"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expires_in"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("access_token"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("token_type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expires_in"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.TokenRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.access_token);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.token_type);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.expires_in);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.TokenRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __access_token__ = default(string);
            var __access_token__b__ = false;
            var __token_type__ = default(string);
            var __token_type__b__ = false;
            var __expires_in__ = default(int);
            var __expires_in__b__ = false;

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
                        __access_token__ = reader.ReadString();
                        __access_token__b__ = true;
                        break;
                    case 1:
                        __token_type__ = reader.ReadString();
                        __token_type__b__ = true;
                        break;
                    case 2:
                        __expires_in__ = reader.ReadInt32();
                        __expires_in__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.TokenRootobject();
            if(__access_token__b__) ____result.access_token = __access_token__;
            if(__token_type__b__) ____result.token_type = __token_type__;
            if(__expires_in__b__) ____result.expires_in = __expires_in__;

            return ____result;
        }
    }


    internal sealed class TokenFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Token>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TokenFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("access_token"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expiration_date"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("access_token"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expiration_date"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Token value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.access_token);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Serialize(ref writer, value.expiration_date, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Token Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __access_token__ = default(string);
            var __access_token__b__ = false;
            var __expiration_date__ = default(global::System.DateTime);
            var __expiration_date__b__ = false;

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
                        __access_token__ = reader.ReadString();
                        __access_token__b__ = true;
                        break;
                    case 1:
                        __expiration_date__ = formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Deserialize(ref reader, formatterResolver);
                        __expiration_date__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Token();
            if(__access_token__b__) ____result.access_token = __access_token__;
            if(__expiration_date__b__) ____result.expiration_date = __expiration_date__;

            return ____result;
        }
    }


    public sealed class ObservationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Observation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObservationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("daylight"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyInfo"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyDescription"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureDesc"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("comfort"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("highTemperature"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lowTemperature"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("humidity"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewPoint"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation1H"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation3H"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation6H"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation12H"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation24H"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationDesc"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airInfo"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airDescription"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDesc"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDescShort"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometerPressure"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometerTrend"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snowCover"), 26},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 27},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconName"), 28},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconLink"), 29},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ageMinutes"), 30},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("activeAlerts"), 31},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 32},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 33},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 34},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 35},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 36},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 37},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("elevation"), 38},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("utcTime"), 39},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("daylight"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("comfort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("highTemperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lowTemperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewPoint"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation1H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation3H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation6H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation12H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation24H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDescShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometerPressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometerTrend"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snowCover"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconLink"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ageMinutes"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("activeAlerts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("elevation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("utcTime"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Observation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.daylight);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.skyInfo);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.skyDescription);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.temperature);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.temperatureDesc);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.comfort);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.highTemperature);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.lowTemperature);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.humidity);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.dewPoint);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.precipitation1H);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.precipitation3H);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.precipitation6H);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.precipitation12H);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value.precipitation24H);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.precipitationDesc);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.airInfo);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.airDescription);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value.windSpeed);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value.windDirection);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteString(value.windDesc);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteString(value.windDescShort);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteString(value.barometerPressure);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value.barometerTrend);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteString(value.visibility);
            writer.WriteRaw(this.____stringByteKeys[26]);
            writer.WriteString(value.snowCover);
            writer.WriteRaw(this.____stringByteKeys[27]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[28]);
            writer.WriteString(value.iconName);
            writer.WriteRaw(this.____stringByteKeys[29]);
            writer.WriteString(value.iconLink);
            writer.WriteRaw(this.____stringByteKeys[30]);
            writer.WriteString(value.ageMinutes);
            writer.WriteRaw(this.____stringByteKeys[31]);
            writer.WriteString(value.activeAlerts);
            writer.WriteRaw(this.____stringByteKeys[32]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[33]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[34]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[35]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[36]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[37]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[38]);
            writer.WriteSingle(value.elevation);
            writer.WriteRaw(this.____stringByteKeys[39]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.utcTime, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Observation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __daylight__ = default(string);
            var __daylight__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __skyInfo__ = default(string);
            var __skyInfo__b__ = false;
            var __skyDescription__ = default(string);
            var __skyDescription__b__ = false;
            var __temperature__ = default(string);
            var __temperature__b__ = false;
            var __temperatureDesc__ = default(string);
            var __temperatureDesc__b__ = false;
            var __comfort__ = default(string);
            var __comfort__b__ = false;
            var __highTemperature__ = default(string);
            var __highTemperature__b__ = false;
            var __lowTemperature__ = default(string);
            var __lowTemperature__b__ = false;
            var __humidity__ = default(string);
            var __humidity__b__ = false;
            var __dewPoint__ = default(string);
            var __dewPoint__b__ = false;
            var __precipitation1H__ = default(string);
            var __precipitation1H__b__ = false;
            var __precipitation3H__ = default(string);
            var __precipitation3H__b__ = false;
            var __precipitation6H__ = default(string);
            var __precipitation6H__b__ = false;
            var __precipitation12H__ = default(string);
            var __precipitation12H__b__ = false;
            var __precipitation24H__ = default(string);
            var __precipitation24H__b__ = false;
            var __precipitationDesc__ = default(string);
            var __precipitationDesc__b__ = false;
            var __airInfo__ = default(string);
            var __airInfo__b__ = false;
            var __airDescription__ = default(string);
            var __airDescription__b__ = false;
            var __windSpeed__ = default(string);
            var __windSpeed__b__ = false;
            var __windDirection__ = default(string);
            var __windDirection__b__ = false;
            var __windDesc__ = default(string);
            var __windDesc__b__ = false;
            var __windDescShort__ = default(string);
            var __windDescShort__b__ = false;
            var __barometerPressure__ = default(string);
            var __barometerPressure__b__ = false;
            var __barometerTrend__ = default(string);
            var __barometerTrend__b__ = false;
            var __visibility__ = default(string);
            var __visibility__b__ = false;
            var __snowCover__ = default(string);
            var __snowCover__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __iconName__ = default(string);
            var __iconName__b__ = false;
            var __iconLink__ = default(string);
            var __iconLink__b__ = false;
            var __ageMinutes__ = default(string);
            var __ageMinutes__b__ = false;
            var __activeAlerts__ = default(string);
            var __activeAlerts__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __elevation__ = default(float);
            var __elevation__b__ = false;
            var __utcTime__ = default(global::System.DateTimeOffset);
            var __utcTime__b__ = false;

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
                        __daylight__ = reader.ReadString();
                        __daylight__b__ = true;
                        break;
                    case 1:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 2:
                        __skyInfo__ = reader.ReadString();
                        __skyInfo__b__ = true;
                        break;
                    case 3:
                        __skyDescription__ = reader.ReadString();
                        __skyDescription__b__ = true;
                        break;
                    case 4:
                        __temperature__ = reader.ReadString();
                        __temperature__b__ = true;
                        break;
                    case 5:
                        __temperatureDesc__ = reader.ReadString();
                        __temperatureDesc__b__ = true;
                        break;
                    case 6:
                        __comfort__ = reader.ReadString();
                        __comfort__b__ = true;
                        break;
                    case 7:
                        __highTemperature__ = reader.ReadString();
                        __highTemperature__b__ = true;
                        break;
                    case 8:
                        __lowTemperature__ = reader.ReadString();
                        __lowTemperature__b__ = true;
                        break;
                    case 9:
                        __humidity__ = reader.ReadString();
                        __humidity__b__ = true;
                        break;
                    case 10:
                        __dewPoint__ = reader.ReadString();
                        __dewPoint__b__ = true;
                        break;
                    case 11:
                        __precipitation1H__ = reader.ReadString();
                        __precipitation1H__b__ = true;
                        break;
                    case 12:
                        __precipitation3H__ = reader.ReadString();
                        __precipitation3H__b__ = true;
                        break;
                    case 13:
                        __precipitation6H__ = reader.ReadString();
                        __precipitation6H__b__ = true;
                        break;
                    case 14:
                        __precipitation12H__ = reader.ReadString();
                        __precipitation12H__b__ = true;
                        break;
                    case 15:
                        __precipitation24H__ = reader.ReadString();
                        __precipitation24H__b__ = true;
                        break;
                    case 16:
                        __precipitationDesc__ = reader.ReadString();
                        __precipitationDesc__b__ = true;
                        break;
                    case 17:
                        __airInfo__ = reader.ReadString();
                        __airInfo__b__ = true;
                        break;
                    case 18:
                        __airDescription__ = reader.ReadString();
                        __airDescription__b__ = true;
                        break;
                    case 19:
                        __windSpeed__ = reader.ReadString();
                        __windSpeed__b__ = true;
                        break;
                    case 20:
                        __windDirection__ = reader.ReadString();
                        __windDirection__b__ = true;
                        break;
                    case 21:
                        __windDesc__ = reader.ReadString();
                        __windDesc__b__ = true;
                        break;
                    case 22:
                        __windDescShort__ = reader.ReadString();
                        __windDescShort__b__ = true;
                        break;
                    case 23:
                        __barometerPressure__ = reader.ReadString();
                        __barometerPressure__b__ = true;
                        break;
                    case 24:
                        __barometerTrend__ = reader.ReadString();
                        __barometerTrend__b__ = true;
                        break;
                    case 25:
                        __visibility__ = reader.ReadString();
                        __visibility__b__ = true;
                        break;
                    case 26:
                        __snowCover__ = reader.ReadString();
                        __snowCover__b__ = true;
                        break;
                    case 27:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 28:
                        __iconName__ = reader.ReadString();
                        __iconName__b__ = true;
                        break;
                    case 29:
                        __iconLink__ = reader.ReadString();
                        __iconLink__b__ = true;
                        break;
                    case 30:
                        __ageMinutes__ = reader.ReadString();
                        __ageMinutes__b__ = true;
                        break;
                    case 31:
                        __activeAlerts__ = reader.ReadString();
                        __activeAlerts__b__ = true;
                        break;
                    case 32:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 33:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 34:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 35:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 36:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 37:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 38:
                        __elevation__ = reader.ReadSingle();
                        __elevation__b__ = true;
                        break;
                    case 39:
                        __utcTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __utcTime__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Observation();
            if(__daylight__b__) ____result.daylight = __daylight__;
            if(__description__b__) ____result.description = __description__;
            if(__skyInfo__b__) ____result.skyInfo = __skyInfo__;
            if(__skyDescription__b__) ____result.skyDescription = __skyDescription__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__temperatureDesc__b__) ____result.temperatureDesc = __temperatureDesc__;
            if(__comfort__b__) ____result.comfort = __comfort__;
            if(__highTemperature__b__) ____result.highTemperature = __highTemperature__;
            if(__lowTemperature__b__) ____result.lowTemperature = __lowTemperature__;
            if(__humidity__b__) ____result.humidity = __humidity__;
            if(__dewPoint__b__) ____result.dewPoint = __dewPoint__;
            if(__precipitation1H__b__) ____result.precipitation1H = __precipitation1H__;
            if(__precipitation3H__b__) ____result.precipitation3H = __precipitation3H__;
            if(__precipitation6H__b__) ____result.precipitation6H = __precipitation6H__;
            if(__precipitation12H__b__) ____result.precipitation12H = __precipitation12H__;
            if(__precipitation24H__b__) ____result.precipitation24H = __precipitation24H__;
            if(__precipitationDesc__b__) ____result.precipitationDesc = __precipitationDesc__;
            if(__airInfo__b__) ____result.airInfo = __airInfo__;
            if(__airDescription__b__) ____result.airDescription = __airDescription__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__windDesc__b__) ____result.windDesc = __windDesc__;
            if(__windDescShort__b__) ____result.windDescShort = __windDescShort__;
            if(__barometerPressure__b__) ____result.barometerPressure = __barometerPressure__;
            if(__barometerTrend__b__) ____result.barometerTrend = __barometerTrend__;
            if(__visibility__b__) ____result.visibility = __visibility__;
            if(__snowCover__b__) ____result.snowCover = __snowCover__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__iconName__b__) ____result.iconName = __iconName__;
            if(__iconLink__b__) ____result.iconLink = __iconLink__;
            if(__ageMinutes__b__) ____result.ageMinutes = __ageMinutes__;
            if(__activeAlerts__b__) ____result.activeAlerts = __activeAlerts__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__elevation__b__) ____result.elevation = __elevation__;
            if(__utcTime__b__) ____result.utcTime = __utcTime__;

            return ____result;
        }
    }


    public sealed class LocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Location>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public LocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observation"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("observation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Location value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Observation[]>().Serialize(ref writer, value.observation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Location Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __observation__ = default(global::SimpleWeather.HERE.Observation[]);
            var __observation__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

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
                        __observation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Observation[]>().Deserialize(ref reader, formatterResolver);
                        __observation__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 7:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Location();
            if(__observation__b__) ____result.observation = __observation__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class ObservationsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Observations>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObservationsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("location"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("location"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Observations value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Location[]>().Serialize(ref writer, value.location, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Observations Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __location__ = default(global::SimpleWeather.HERE.Location[]);
            var __location__b__ = false;

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
                        __location__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Location[]>().Deserialize(ref reader, formatterResolver);
                        __location__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Observations();
            if(__location__b__) ____result.location = __location__;

            return ____result;
        }
    }


    public sealed class ForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Forecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("daylight"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyInfo"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyDescription"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureDesc"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("comfort"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("highTemperature"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lowTemperature"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("humidity"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewPoint"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationProbability"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationDesc"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rainFall"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snowFall"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airInfo"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airDescription"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDesc"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDescShort"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("beaufortScale"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("beaufortDescription"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uvIndex"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uvDesc"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometerPressure"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconName"), 26},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconLink"), 27},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dayOfWeek"), 28},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday"), 29},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("utcTime"), 30},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("daylight"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("comfort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("highTemperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lowTemperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewPoint"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationProbability"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rainFall"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snowFall"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDescShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("beaufortScale"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("beaufortDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uvIndex"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uvDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometerPressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconLink"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dayOfWeek"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("utcTime"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Forecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.daylight);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.skyInfo);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.skyDescription);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.temperatureDesc);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.comfort);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.highTemperature);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.lowTemperature);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.humidity);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.dewPoint);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.precipitationProbability);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.precipitationDesc);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.rainFall);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.snowFall);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.airInfo);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value.airDescription);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.windSpeed);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.windDirection);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.windDesc);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value.windDescShort);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value.beaufortScale);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteString(value.beaufortDescription);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteString(value.uvIndex);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteString(value.uvDesc);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value.barometerPressure);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[26]);
            writer.WriteString(value.iconName);
            writer.WriteRaw(this.____stringByteKeys[27]);
            writer.WriteString(value.iconLink);
            writer.WriteRaw(this.____stringByteKeys[28]);
            writer.WriteString(value.dayOfWeek);
            writer.WriteRaw(this.____stringByteKeys[29]);
            writer.WriteString(value.weekday);
            writer.WriteRaw(this.____stringByteKeys[30]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.utcTime, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Forecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __daylight__ = default(string);
            var __daylight__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __skyInfo__ = default(string);
            var __skyInfo__b__ = false;
            var __skyDescription__ = default(string);
            var __skyDescription__b__ = false;
            var __temperatureDesc__ = default(string);
            var __temperatureDesc__b__ = false;
            var __comfort__ = default(string);
            var __comfort__b__ = false;
            var __highTemperature__ = default(string);
            var __highTemperature__b__ = false;
            var __lowTemperature__ = default(string);
            var __lowTemperature__b__ = false;
            var __humidity__ = default(string);
            var __humidity__b__ = false;
            var __dewPoint__ = default(string);
            var __dewPoint__b__ = false;
            var __precipitationProbability__ = default(string);
            var __precipitationProbability__b__ = false;
            var __precipitationDesc__ = default(string);
            var __precipitationDesc__b__ = false;
            var __rainFall__ = default(string);
            var __rainFall__b__ = false;
            var __snowFall__ = default(string);
            var __snowFall__b__ = false;
            var __airInfo__ = default(string);
            var __airInfo__b__ = false;
            var __airDescription__ = default(string);
            var __airDescription__b__ = false;
            var __windSpeed__ = default(string);
            var __windSpeed__b__ = false;
            var __windDirection__ = default(string);
            var __windDirection__b__ = false;
            var __windDesc__ = default(string);
            var __windDesc__b__ = false;
            var __windDescShort__ = default(string);
            var __windDescShort__b__ = false;
            var __beaufortScale__ = default(string);
            var __beaufortScale__b__ = false;
            var __beaufortDescription__ = default(string);
            var __beaufortDescription__b__ = false;
            var __uvIndex__ = default(string);
            var __uvIndex__b__ = false;
            var __uvDesc__ = default(string);
            var __uvDesc__b__ = false;
            var __barometerPressure__ = default(string);
            var __barometerPressure__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __iconName__ = default(string);
            var __iconName__b__ = false;
            var __iconLink__ = default(string);
            var __iconLink__b__ = false;
            var __dayOfWeek__ = default(string);
            var __dayOfWeek__b__ = false;
            var __weekday__ = default(string);
            var __weekday__b__ = false;
            var __utcTime__ = default(global::System.DateTimeOffset);
            var __utcTime__b__ = false;

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
                        __daylight__ = reader.ReadString();
                        __daylight__b__ = true;
                        break;
                    case 1:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 2:
                        __skyInfo__ = reader.ReadString();
                        __skyInfo__b__ = true;
                        break;
                    case 3:
                        __skyDescription__ = reader.ReadString();
                        __skyDescription__b__ = true;
                        break;
                    case 4:
                        __temperatureDesc__ = reader.ReadString();
                        __temperatureDesc__b__ = true;
                        break;
                    case 5:
                        __comfort__ = reader.ReadString();
                        __comfort__b__ = true;
                        break;
                    case 6:
                        __highTemperature__ = reader.ReadString();
                        __highTemperature__b__ = true;
                        break;
                    case 7:
                        __lowTemperature__ = reader.ReadString();
                        __lowTemperature__b__ = true;
                        break;
                    case 8:
                        __humidity__ = reader.ReadString();
                        __humidity__b__ = true;
                        break;
                    case 9:
                        __dewPoint__ = reader.ReadString();
                        __dewPoint__b__ = true;
                        break;
                    case 10:
                        __precipitationProbability__ = reader.ReadString();
                        __precipitationProbability__b__ = true;
                        break;
                    case 11:
                        __precipitationDesc__ = reader.ReadString();
                        __precipitationDesc__b__ = true;
                        break;
                    case 12:
                        __rainFall__ = reader.ReadString();
                        __rainFall__b__ = true;
                        break;
                    case 13:
                        __snowFall__ = reader.ReadString();
                        __snowFall__b__ = true;
                        break;
                    case 14:
                        __airInfo__ = reader.ReadString();
                        __airInfo__b__ = true;
                        break;
                    case 15:
                        __airDescription__ = reader.ReadString();
                        __airDescription__b__ = true;
                        break;
                    case 16:
                        __windSpeed__ = reader.ReadString();
                        __windSpeed__b__ = true;
                        break;
                    case 17:
                        __windDirection__ = reader.ReadString();
                        __windDirection__b__ = true;
                        break;
                    case 18:
                        __windDesc__ = reader.ReadString();
                        __windDesc__b__ = true;
                        break;
                    case 19:
                        __windDescShort__ = reader.ReadString();
                        __windDescShort__b__ = true;
                        break;
                    case 20:
                        __beaufortScale__ = reader.ReadString();
                        __beaufortScale__b__ = true;
                        break;
                    case 21:
                        __beaufortDescription__ = reader.ReadString();
                        __beaufortDescription__b__ = true;
                        break;
                    case 22:
                        __uvIndex__ = reader.ReadString();
                        __uvIndex__b__ = true;
                        break;
                    case 23:
                        __uvDesc__ = reader.ReadString();
                        __uvDesc__b__ = true;
                        break;
                    case 24:
                        __barometerPressure__ = reader.ReadString();
                        __barometerPressure__b__ = true;
                        break;
                    case 25:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 26:
                        __iconName__ = reader.ReadString();
                        __iconName__b__ = true;
                        break;
                    case 27:
                        __iconLink__ = reader.ReadString();
                        __iconLink__b__ = true;
                        break;
                    case 28:
                        __dayOfWeek__ = reader.ReadString();
                        __dayOfWeek__b__ = true;
                        break;
                    case 29:
                        __weekday__ = reader.ReadString();
                        __weekday__b__ = true;
                        break;
                    case 30:
                        __utcTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __utcTime__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Forecast();
            if(__daylight__b__) ____result.daylight = __daylight__;
            if(__description__b__) ____result.description = __description__;
            if(__skyInfo__b__) ____result.skyInfo = __skyInfo__;
            if(__skyDescription__b__) ____result.skyDescription = __skyDescription__;
            if(__temperatureDesc__b__) ____result.temperatureDesc = __temperatureDesc__;
            if(__comfort__b__) ____result.comfort = __comfort__;
            if(__highTemperature__b__) ____result.highTemperature = __highTemperature__;
            if(__lowTemperature__b__) ____result.lowTemperature = __lowTemperature__;
            if(__humidity__b__) ____result.humidity = __humidity__;
            if(__dewPoint__b__) ____result.dewPoint = __dewPoint__;
            if(__precipitationProbability__b__) ____result.precipitationProbability = __precipitationProbability__;
            if(__precipitationDesc__b__) ____result.precipitationDesc = __precipitationDesc__;
            if(__rainFall__b__) ____result.rainFall = __rainFall__;
            if(__snowFall__b__) ____result.snowFall = __snowFall__;
            if(__airInfo__b__) ____result.airInfo = __airInfo__;
            if(__airDescription__b__) ____result.airDescription = __airDescription__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__windDesc__b__) ____result.windDesc = __windDesc__;
            if(__windDescShort__b__) ____result.windDescShort = __windDescShort__;
            if(__beaufortScale__b__) ____result.beaufortScale = __beaufortScale__;
            if(__beaufortDescription__b__) ____result.beaufortDescription = __beaufortDescription__;
            if(__uvIndex__b__) ____result.uvIndex = __uvIndex__;
            if(__uvDesc__b__) ____result.uvDesc = __uvDesc__;
            if(__barometerPressure__b__) ____result.barometerPressure = __barometerPressure__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__iconName__b__) ____result.iconName = __iconName__;
            if(__iconLink__b__) ____result.iconLink = __iconLink__;
            if(__dayOfWeek__b__) ____result.dayOfWeek = __dayOfWeek__;
            if(__weekday__b__) ____result.weekday = __weekday__;
            if(__utcTime__b__) ____result.utcTime = __utcTime__;

            return ____result;
        }
    }


    public sealed class ForecastlocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Forecastlocation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastlocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Forecastlocation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecast[]>().Serialize(ref writer, value.forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Forecastlocation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecast__ = default(global::SimpleWeather.HERE.Forecast[]);
            var __forecast__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

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
                        __forecast__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecast[]>().Deserialize(ref reader, formatterResolver);
                        __forecast__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 7:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Forecastlocation();
            if(__forecast__b__) ____result.forecast = __forecast__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class DailyforecastsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Dailyforecasts>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DailyforecastsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastLocation"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecastLocation"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Dailyforecasts value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecastlocation>().Serialize(ref writer, value.forecastLocation, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Dailyforecasts Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecastLocation__ = default(global::SimpleWeather.HERE.Forecastlocation);
            var __forecastLocation__b__ = false;

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
                        __forecastLocation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecastlocation>().Deserialize(ref reader, formatterResolver);
                        __forecastLocation__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Dailyforecasts();
            if(__forecastLocation__b__) ____result.forecastLocation = __forecastLocation__;

            return ____result;
        }
    }


    public sealed class Forecast1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Forecast1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Forecast1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("daylight"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyInfo"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyDescription"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureDesc"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("comfort"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("humidity"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewPoint"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationProbability"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationDesc"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rainFall"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snowFall"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airInfo"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airDescription"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDesc"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDescShort"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("beaufortScale"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("beaufortDescription"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uvIndex"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uvDesc"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometerPressure"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconName"), 26},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconLink"), 27},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dayOfWeek"), 28},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday"), 29},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("utcTime"), 30},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("localTime"), 31},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("localTimeFormat"), 32},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("daylight"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("comfort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewPoint"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationProbability"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rainFall"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snowFall"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDescShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("beaufortScale"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("beaufortDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uvIndex"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uvDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometerPressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconLink"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dayOfWeek"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("utcTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("localTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("localTimeFormat"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Forecast1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.daylight);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.skyInfo);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.skyDescription);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.temperature);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.temperatureDesc);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.comfort);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.humidity);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.dewPoint);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.precipitationProbability);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.precipitationDesc);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.rainFall);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.snowFall);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.airInfo);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.airDescription);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value.windSpeed);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.windDirection);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.windDesc);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.windDescShort);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value.beaufortScale);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value.beaufortDescription);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteString(value.uvIndex);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteString(value.uvDesc);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteString(value.visibility);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value.barometerPressure);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[26]);
            writer.WriteString(value.iconName);
            writer.WriteRaw(this.____stringByteKeys[27]);
            writer.WriteString(value.iconLink);
            writer.WriteRaw(this.____stringByteKeys[28]);
            writer.WriteString(value.dayOfWeek);
            writer.WriteRaw(this.____stringByteKeys[29]);
            writer.WriteString(value.weekday);
            writer.WriteRaw(this.____stringByteKeys[30]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.utcTime, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[31]);
            writer.WriteString(value.localTime);
            writer.WriteRaw(this.____stringByteKeys[32]);
            writer.WriteString(value.localTimeFormat);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Forecast1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __daylight__ = default(string);
            var __daylight__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __skyInfo__ = default(string);
            var __skyInfo__b__ = false;
            var __skyDescription__ = default(string);
            var __skyDescription__b__ = false;
            var __temperature__ = default(string);
            var __temperature__b__ = false;
            var __temperatureDesc__ = default(string);
            var __temperatureDesc__b__ = false;
            var __comfort__ = default(string);
            var __comfort__b__ = false;
            var __humidity__ = default(string);
            var __humidity__b__ = false;
            var __dewPoint__ = default(string);
            var __dewPoint__b__ = false;
            var __precipitationProbability__ = default(string);
            var __precipitationProbability__b__ = false;
            var __precipitationDesc__ = default(string);
            var __precipitationDesc__b__ = false;
            var __rainFall__ = default(string);
            var __rainFall__b__ = false;
            var __snowFall__ = default(string);
            var __snowFall__b__ = false;
            var __airInfo__ = default(string);
            var __airInfo__b__ = false;
            var __airDescription__ = default(string);
            var __airDescription__b__ = false;
            var __windSpeed__ = default(string);
            var __windSpeed__b__ = false;
            var __windDirection__ = default(string);
            var __windDirection__b__ = false;
            var __windDesc__ = default(string);
            var __windDesc__b__ = false;
            var __windDescShort__ = default(string);
            var __windDescShort__b__ = false;
            var __beaufortScale__ = default(string);
            var __beaufortScale__b__ = false;
            var __beaufortDescription__ = default(string);
            var __beaufortDescription__b__ = false;
            var __uvIndex__ = default(string);
            var __uvIndex__b__ = false;
            var __uvDesc__ = default(string);
            var __uvDesc__b__ = false;
            var __visibility__ = default(string);
            var __visibility__b__ = false;
            var __barometerPressure__ = default(string);
            var __barometerPressure__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __iconName__ = default(string);
            var __iconName__b__ = false;
            var __iconLink__ = default(string);
            var __iconLink__b__ = false;
            var __dayOfWeek__ = default(string);
            var __dayOfWeek__b__ = false;
            var __weekday__ = default(string);
            var __weekday__b__ = false;
            var __utcTime__ = default(global::System.DateTimeOffset);
            var __utcTime__b__ = false;
            var __localTime__ = default(string);
            var __localTime__b__ = false;
            var __localTimeFormat__ = default(string);
            var __localTimeFormat__b__ = false;

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
                        __daylight__ = reader.ReadString();
                        __daylight__b__ = true;
                        break;
                    case 1:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 2:
                        __skyInfo__ = reader.ReadString();
                        __skyInfo__b__ = true;
                        break;
                    case 3:
                        __skyDescription__ = reader.ReadString();
                        __skyDescription__b__ = true;
                        break;
                    case 4:
                        __temperature__ = reader.ReadString();
                        __temperature__b__ = true;
                        break;
                    case 5:
                        __temperatureDesc__ = reader.ReadString();
                        __temperatureDesc__b__ = true;
                        break;
                    case 6:
                        __comfort__ = reader.ReadString();
                        __comfort__b__ = true;
                        break;
                    case 7:
                        __humidity__ = reader.ReadString();
                        __humidity__b__ = true;
                        break;
                    case 8:
                        __dewPoint__ = reader.ReadString();
                        __dewPoint__b__ = true;
                        break;
                    case 9:
                        __precipitationProbability__ = reader.ReadString();
                        __precipitationProbability__b__ = true;
                        break;
                    case 10:
                        __precipitationDesc__ = reader.ReadString();
                        __precipitationDesc__b__ = true;
                        break;
                    case 11:
                        __rainFall__ = reader.ReadString();
                        __rainFall__b__ = true;
                        break;
                    case 12:
                        __snowFall__ = reader.ReadString();
                        __snowFall__b__ = true;
                        break;
                    case 13:
                        __airInfo__ = reader.ReadString();
                        __airInfo__b__ = true;
                        break;
                    case 14:
                        __airDescription__ = reader.ReadString();
                        __airDescription__b__ = true;
                        break;
                    case 15:
                        __windSpeed__ = reader.ReadString();
                        __windSpeed__b__ = true;
                        break;
                    case 16:
                        __windDirection__ = reader.ReadString();
                        __windDirection__b__ = true;
                        break;
                    case 17:
                        __windDesc__ = reader.ReadString();
                        __windDesc__b__ = true;
                        break;
                    case 18:
                        __windDescShort__ = reader.ReadString();
                        __windDescShort__b__ = true;
                        break;
                    case 19:
                        __beaufortScale__ = reader.ReadString();
                        __beaufortScale__b__ = true;
                        break;
                    case 20:
                        __beaufortDescription__ = reader.ReadString();
                        __beaufortDescription__b__ = true;
                        break;
                    case 21:
                        __uvIndex__ = reader.ReadString();
                        __uvIndex__b__ = true;
                        break;
                    case 22:
                        __uvDesc__ = reader.ReadString();
                        __uvDesc__b__ = true;
                        break;
                    case 23:
                        __visibility__ = reader.ReadString();
                        __visibility__b__ = true;
                        break;
                    case 24:
                        __barometerPressure__ = reader.ReadString();
                        __barometerPressure__b__ = true;
                        break;
                    case 25:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 26:
                        __iconName__ = reader.ReadString();
                        __iconName__b__ = true;
                        break;
                    case 27:
                        __iconLink__ = reader.ReadString();
                        __iconLink__b__ = true;
                        break;
                    case 28:
                        __dayOfWeek__ = reader.ReadString();
                        __dayOfWeek__b__ = true;
                        break;
                    case 29:
                        __weekday__ = reader.ReadString();
                        __weekday__b__ = true;
                        break;
                    case 30:
                        __utcTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __utcTime__b__ = true;
                        break;
                    case 31:
                        __localTime__ = reader.ReadString();
                        __localTime__b__ = true;
                        break;
                    case 32:
                        __localTimeFormat__ = reader.ReadString();
                        __localTimeFormat__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Forecast1();
            if(__daylight__b__) ____result.daylight = __daylight__;
            if(__description__b__) ____result.description = __description__;
            if(__skyInfo__b__) ____result.skyInfo = __skyInfo__;
            if(__skyDescription__b__) ____result.skyDescription = __skyDescription__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__temperatureDesc__b__) ____result.temperatureDesc = __temperatureDesc__;
            if(__comfort__b__) ____result.comfort = __comfort__;
            if(__humidity__b__) ____result.humidity = __humidity__;
            if(__dewPoint__b__) ____result.dewPoint = __dewPoint__;
            if(__precipitationProbability__b__) ____result.precipitationProbability = __precipitationProbability__;
            if(__precipitationDesc__b__) ____result.precipitationDesc = __precipitationDesc__;
            if(__rainFall__b__) ____result.rainFall = __rainFall__;
            if(__snowFall__b__) ____result.snowFall = __snowFall__;
            if(__airInfo__b__) ____result.airInfo = __airInfo__;
            if(__airDescription__b__) ____result.airDescription = __airDescription__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__windDesc__b__) ____result.windDesc = __windDesc__;
            if(__windDescShort__b__) ____result.windDescShort = __windDescShort__;
            if(__beaufortScale__b__) ____result.beaufortScale = __beaufortScale__;
            if(__beaufortDescription__b__) ____result.beaufortDescription = __beaufortDescription__;
            if(__uvIndex__b__) ____result.uvIndex = __uvIndex__;
            if(__uvDesc__b__) ____result.uvDesc = __uvDesc__;
            if(__visibility__b__) ____result.visibility = __visibility__;
            if(__barometerPressure__b__) ____result.barometerPressure = __barometerPressure__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__iconName__b__) ____result.iconName = __iconName__;
            if(__iconLink__b__) ____result.iconLink = __iconLink__;
            if(__dayOfWeek__b__) ____result.dayOfWeek = __dayOfWeek__;
            if(__weekday__b__) ____result.weekday = __weekday__;
            if(__utcTime__b__) ____result.utcTime = __utcTime__;
            if(__localTime__b__) ____result.localTime = __localTime__;
            if(__localTimeFormat__b__) ____result.localTimeFormat = __localTimeFormat__;

            return ____result;
        }
    }


    public sealed class Forecastlocation1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Forecastlocation1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Forecastlocation1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Forecastlocation1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecast1[]>().Serialize(ref writer, value.forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Forecastlocation1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecast__ = default(global::SimpleWeather.HERE.Forecast1[]);
            var __forecast__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

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
                        __forecast__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecast1[]>().Deserialize(ref reader, formatterResolver);
                        __forecast__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 7:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Forecastlocation1();
            if(__forecast__b__) ____result.forecast = __forecast__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class HourlyforecastsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Hourlyforecasts>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public HourlyforecastsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastLocation"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecastLocation"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Hourlyforecasts value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecastlocation1>().Serialize(ref writer, value.forecastLocation, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Hourlyforecasts Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecastLocation__ = default(global::SimpleWeather.HERE.Forecastlocation1);
            var __forecastLocation__b__ = false;

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
                        __forecastLocation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecastlocation1>().Deserialize(ref reader, formatterResolver);
                        __forecastLocation__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Hourlyforecasts();
            if(__forecastLocation__b__) ____result.forecastLocation = __forecastLocation__;

            return ____result;
        }
    }


    public sealed class Astronomy1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Astronomy1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Astronomy1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunrise"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunset"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonrise"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonset"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonPhase"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonPhaseDesc"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconName"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("utcTime"), 10},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("sunrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonPhase"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonPhaseDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("utcTime"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Astronomy1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.sunrise);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.sunset);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.moonrise);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.moonset);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.moonPhase);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.moonPhaseDesc);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.iconName);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[10]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.utcTime, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Astronomy1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __sunrise__ = default(string);
            var __sunrise__b__ = false;
            var __sunset__ = default(string);
            var __sunset__b__ = false;
            var __moonrise__ = default(string);
            var __moonrise__b__ = false;
            var __moonset__ = default(string);
            var __moonset__b__ = false;
            var __moonPhase__ = default(float);
            var __moonPhase__b__ = false;
            var __moonPhaseDesc__ = default(string);
            var __moonPhaseDesc__b__ = false;
            var __iconName__ = default(string);
            var __iconName__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __utcTime__ = default(global::System.DateTimeOffset);
            var __utcTime__b__ = false;

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
                        __sunrise__ = reader.ReadString();
                        __sunrise__b__ = true;
                        break;
                    case 1:
                        __sunset__ = reader.ReadString();
                        __sunset__b__ = true;
                        break;
                    case 2:
                        __moonrise__ = reader.ReadString();
                        __moonrise__b__ = true;
                        break;
                    case 3:
                        __moonset__ = reader.ReadString();
                        __moonset__b__ = true;
                        break;
                    case 4:
                        __moonPhase__ = reader.ReadSingle();
                        __moonPhase__b__ = true;
                        break;
                    case 5:
                        __moonPhaseDesc__ = reader.ReadString();
                        __moonPhaseDesc__b__ = true;
                        break;
                    case 6:
                        __iconName__ = reader.ReadString();
                        __iconName__b__ = true;
                        break;
                    case 7:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 8:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 9:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 10:
                        __utcTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __utcTime__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Astronomy1();
            if(__sunrise__b__) ____result.sunrise = __sunrise__;
            if(__sunset__b__) ____result.sunset = __sunset__;
            if(__moonrise__b__) ____result.moonrise = __moonrise__;
            if(__moonset__b__) ____result.moonset = __moonset__;
            if(__moonPhase__b__) ____result.moonPhase = __moonPhase__;
            if(__moonPhaseDesc__b__) ____result.moonPhaseDesc = __moonPhaseDesc__;
            if(__iconName__b__) ____result.iconName = __iconName__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__utcTime__b__) ____result.utcTime = __utcTime__;

            return ____result;
        }
    }


    public sealed class AstronomyFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Astronomy>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AstronomyFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("astronomy"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("astronomy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Astronomy value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Astronomy1[]>().Serialize(ref writer, value.astronomy, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Astronomy Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __astronomy__ = default(global::SimpleWeather.HERE.Astronomy1[]);
            var __astronomy__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

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
                        __astronomy__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Astronomy1[]>().Deserialize(ref reader, formatterResolver);
                        __astronomy__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Astronomy();
            if(__astronomy__b__) ____result.astronomy = __astronomy__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observations"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dailyForecasts"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hourlyForecasts"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("alerts"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("astronomy"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feedCreation"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Type"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Message"), 8},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("observations"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dailyForecasts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hourlyForecasts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("alerts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("astronomy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("feedCreation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Message"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Observations>().Serialize(ref writer, value.observations, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Dailyforecasts>().Serialize(ref writer, value.dailyForecasts, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Hourlyforecasts>().Serialize(ref writer, value.hourlyForecasts, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Alerts>().Serialize(ref writer, value.alerts, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Astronomy>().Serialize(ref writer, value.astronomy, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.feedCreation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteBoolean(value.metric);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.Type);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.Message, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __observations__ = default(global::SimpleWeather.HERE.Observations);
            var __observations__b__ = false;
            var __dailyForecasts__ = default(global::SimpleWeather.HERE.Dailyforecasts);
            var __dailyForecasts__b__ = false;
            var __hourlyForecasts__ = default(global::SimpleWeather.HERE.Hourlyforecasts);
            var __hourlyForecasts__b__ = false;
            var __alerts__ = default(global::SimpleWeather.HERE.Alerts);
            var __alerts__b__ = false;
            var __astronomy__ = default(global::SimpleWeather.HERE.Astronomy);
            var __astronomy__b__ = false;
            var __feedCreation__ = default(global::System.DateTimeOffset);
            var __feedCreation__b__ = false;
            var __metric__ = default(bool);
            var __metric__b__ = false;
            var __Type__ = default(string);
            var __Type__b__ = false;
            var __Message__ = default(string[]);
            var __Message__b__ = false;

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
                        __observations__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Observations>().Deserialize(ref reader, formatterResolver);
                        __observations__b__ = true;
                        break;
                    case 1:
                        __dailyForecasts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Dailyforecasts>().Deserialize(ref reader, formatterResolver);
                        __dailyForecasts__b__ = true;
                        break;
                    case 2:
                        __hourlyForecasts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Hourlyforecasts>().Deserialize(ref reader, formatterResolver);
                        __hourlyForecasts__b__ = true;
                        break;
                    case 3:
                        __alerts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Alerts>().Deserialize(ref reader, formatterResolver);
                        __alerts__b__ = true;
                        break;
                    case 4:
                        __astronomy__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Astronomy>().Deserialize(ref reader, formatterResolver);
                        __astronomy__b__ = true;
                        break;
                    case 5:
                        __feedCreation__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __feedCreation__b__ = true;
                        break;
                    case 6:
                        __metric__ = reader.ReadBoolean();
                        __metric__b__ = true;
                        break;
                    case 7:
                        __Type__ = reader.ReadString();
                        __Type__b__ = true;
                        break;
                    case 8:
                        __Message__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __Message__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Rootobject();
            if(__observations__b__) ____result.observations = __observations__;
            if(__dailyForecasts__b__) ____result.dailyForecasts = __dailyForecasts__;
            if(__hourlyForecasts__b__) ____result.hourlyForecasts = __hourlyForecasts__;
            if(__alerts__b__) ____result.alerts = __alerts__;
            if(__astronomy__b__) ____result.astronomy = __astronomy__;
            if(__feedCreation__b__) ____result.feedCreation = __feedCreation__;
            if(__metric__b__) ____result.metric = __metric__;
            if(__Type__b__) ____result.Type = __Type__;
            if(__Message__b__) ____result.Message = __Message__;

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

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS
{
    using System;
    using Utf8Json;


    public sealed class GeometryFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Geometry>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public GeometryFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Geometry value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Geometry Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __id__ = default(string);
            var __id__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;

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
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    case 1:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Geometry();
            if(__id__b__) ____result.id = __id__;
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class DistanceFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Distance>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DistanceFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Distance value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Distance Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __id__ = default(string);
            var __id__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;

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
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    case 1:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Distance();
            if(__id__b__) ____result.id = __id__;
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class BearingFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Bearing>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BearingFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Bearing value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Bearing Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __type__ = default(string);
            var __type__b__ = false;

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
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Bearing();
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class ValueFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Value>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ValueFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@id"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@id"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Value value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.id);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Value Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __id__ = default(string);
            var __id__b__ = false;

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
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Value();
            if(__id__b__) ____result.id = __id__;

            return ____result;
        }
    }


    public sealed class UnitcodeFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Unitcode>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public UnitcodeFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Unitcode value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Unitcode Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __id__ = default(string);
            var __id__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;

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
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    case 1:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Unitcode();
            if(__id__b__) ____result.id = __id__;
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class ForecastofficeFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Forecastoffice>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastofficeFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Forecastoffice value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Forecastoffice Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __type__ = default(string);
            var __type__b__ = false;

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
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Forecastoffice();
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class ForecastgriddataFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Forecastgriddata>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastgriddataFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Forecastgriddata value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Forecastgriddata Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __type__ = default(string);
            var __type__b__ = false;

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
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Forecastgriddata();
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class PubliczoneFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Publiczone>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public PubliczoneFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Publiczone value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Publiczone Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __type__ = default(string);
            var __type__b__ = false;

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
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Publiczone();
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class CountyFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.County>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CountyFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.County value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.County Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __type__ = default(string);
            var __type__b__ = false;

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
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.County();
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class ContextFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Context>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ContextFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wx"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@vocab"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("s"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("geo"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unit"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("geometry"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("bearing"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastOffice"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastGridData"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("publicZone"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("county"), 15},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("wx"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@vocab"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("s"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("geo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unit"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("geometry"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("bearing"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastOffice"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastGridData"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("publicZone"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("county"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Context value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.wx);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.vocab);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.s);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.geo);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.unit);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Geometry>().Serialize(ref writer, value.geometry, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Distance>().Serialize(ref writer, value.distance, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Bearing>().Serialize(ref writer, value.bearing, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[10]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Value>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[11]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Unitcode>().Serialize(ref writer, value.unitCode, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[12]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Forecastoffice>().Serialize(ref writer, value.forecastOffice, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[13]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Forecastgriddata>().Serialize(ref writer, value.forecastGridData, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[14]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Publiczone>().Serialize(ref writer, value.publicZone, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[15]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.County>().Serialize(ref writer, value.county, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Context Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __wx__ = default(string);
            var __wx__b__ = false;
            var __vocab__ = default(string);
            var __vocab__b__ = false;
            var __s__ = default(string);
            var __s__b__ = false;
            var __geo__ = default(string);
            var __geo__b__ = false;
            var __unit__ = default(string);
            var __unit__b__ = false;
            var __geometry__ = default(global::SimpleWeather.NWS.Geometry);
            var __geometry__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __distance__ = default(global::SimpleWeather.NWS.Distance);
            var __distance__b__ = false;
            var __bearing__ = default(global::SimpleWeather.NWS.Bearing);
            var __bearing__b__ = false;
            var __value__ = default(global::SimpleWeather.NWS.Value);
            var __value__b__ = false;
            var __unitCode__ = default(global::SimpleWeather.NWS.Unitcode);
            var __unitCode__b__ = false;
            var __forecastOffice__ = default(global::SimpleWeather.NWS.Forecastoffice);
            var __forecastOffice__b__ = false;
            var __forecastGridData__ = default(global::SimpleWeather.NWS.Forecastgriddata);
            var __forecastGridData__b__ = false;
            var __publicZone__ = default(global::SimpleWeather.NWS.Publiczone);
            var __publicZone__b__ = false;
            var __county__ = default(global::SimpleWeather.NWS.County);
            var __county__b__ = false;

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
                        __wx__ = reader.ReadString();
                        __wx__b__ = true;
                        break;
                    case 1:
                        __vocab__ = reader.ReadString();
                        __vocab__b__ = true;
                        break;
                    case 2:
                        __s__ = reader.ReadString();
                        __s__b__ = true;
                        break;
                    case 3:
                        __geo__ = reader.ReadString();
                        __geo__b__ = true;
                        break;
                    case 4:
                        __unit__ = reader.ReadString();
                        __unit__b__ = true;
                        break;
                    case 5:
                        __geometry__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Geometry>().Deserialize(ref reader, formatterResolver);
                        __geometry__b__ = true;
                        break;
                    case 6:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 7:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 8:
                        __distance__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Distance>().Deserialize(ref reader, formatterResolver);
                        __distance__b__ = true;
                        break;
                    case 9:
                        __bearing__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Bearing>().Deserialize(ref reader, formatterResolver);
                        __bearing__b__ = true;
                        break;
                    case 10:
                        __value__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Value>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 11:
                        __unitCode__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Unitcode>().Deserialize(ref reader, formatterResolver);
                        __unitCode__b__ = true;
                        break;
                    case 12:
                        __forecastOffice__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Forecastoffice>().Deserialize(ref reader, formatterResolver);
                        __forecastOffice__b__ = true;
                        break;
                    case 13:
                        __forecastGridData__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Forecastgriddata>().Deserialize(ref reader, formatterResolver);
                        __forecastGridData__b__ = true;
                        break;
                    case 14:
                        __publicZone__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Publiczone>().Deserialize(ref reader, formatterResolver);
                        __publicZone__b__ = true;
                        break;
                    case 15:
                        __county__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.County>().Deserialize(ref reader, formatterResolver);
                        __county__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Context();
            if(__wx__b__) ____result.wx = __wx__;
            if(__vocab__b__) ____result.vocab = __vocab__;
            if(__s__b__) ____result.s = __s__;
            if(__geo__b__) ____result.geo = __geo__;
            if(__unit__b__) ____result.unit = __unit__;
            if(__geometry__b__) ____result.geometry = __geometry__;
            if(__city__b__) ____result.city = __city__;
            if(__state__b__) ____result.state = __state__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__bearing__b__) ____result.bearing = __bearing__;
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__forecastOffice__b__) ____result.forecastOffice = __forecastOffice__;
            if(__forecastGridData__b__) ____result.forecastGridData = __forecastGridData__;
            if(__publicZone__b__) ____result.publicZone = __publicZone__;
            if(__county__b__) ____result.county = __county__;

            return ____result;
        }
    }


    public sealed class GeocodeFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Geocode>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public GeocodeFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("UGC"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("SAME"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("UGC"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("SAME"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Geocode value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.UGC, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.SAME, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Geocode Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __UGC__ = default(string[]);
            var __UGC__b__ = false;
            var __SAME__ = default(string[]);
            var __SAME__b__ = false;

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
                        __UGC__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __UGC__b__ = true;
                        break;
                    case 1:
                        __SAME__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __SAME__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Geocode();
            if(__UGC__b__) ____result.UGC = __UGC__;
            if(__SAME__b__) ____result.SAME = __SAME__;

            return ____result;
        }
    }


    public sealed class ParametersFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Parameters>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ParametersFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("NWSheadline"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("EASORG"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("PIL"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("BLOCKCHANNEL"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("NWSheadline"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("EASORG"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("PIL"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("BLOCKCHANNEL"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Parameters value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.NWSheadline, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.EASORG, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.PIL, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.BLOCKCHANNEL, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Parameters Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __NWSheadline__ = default(string[]);
            var __NWSheadline__b__ = false;
            var __EASORG__ = default(string[]);
            var __EASORG__b__ = false;
            var __PIL__ = default(string[]);
            var __PIL__b__ = false;
            var __BLOCKCHANNEL__ = default(string[]);
            var __BLOCKCHANNEL__b__ = false;

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
                        __NWSheadline__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __NWSheadline__b__ = true;
                        break;
                    case 1:
                        __EASORG__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __EASORG__b__ = true;
                        break;
                    case 2:
                        __PIL__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __PIL__b__ = true;
                        break;
                    case 3:
                        __BLOCKCHANNEL__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __BLOCKCHANNEL__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Parameters();
            if(__NWSheadline__b__) ____result.NWSheadline = __NWSheadline__;
            if(__EASORG__b__) ____result.EASORG = __EASORG__;
            if(__PIL__b__) ____result.PIL = __PIL__;
            if(__BLOCKCHANNEL__b__) ____result.BLOCKCHANNEL = __BLOCKCHANNEL__;

            return ____result;
        }
    }


    public sealed class AlertGraphFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.AlertGraph>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertGraphFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("areaDesc"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("geocode"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sent"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("effective"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("onset"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expires"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("status"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("messageType"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("category"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("severity"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("certainty"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("urgency"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("event"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sender"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("headline"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("instruction"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("response"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("parameters"), 21},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("areaDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("geocode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sent"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("effective"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("onset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expires"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("status"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("messageType"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("category"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("severity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("certainty"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("urgency"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("event"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sender"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("headline"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("instruction"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("response"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("parameters"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.AlertGraph value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.atId);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.type);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.id);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.areaDesc);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Geocode>().Serialize(ref writer, value.geocode, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.sent, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.effective, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.onset, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.expires, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.status);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.messageType);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.category);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.severity);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.certainty);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.urgency);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value._event);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.sender);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.headline);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value.instruction);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value.response);
            writer.WriteRaw(this.____stringByteKeys[21]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Parameters>().Serialize(ref writer, value.parameters, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.AlertGraph Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __atId__ = default(string);
            var __atId__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;
            var __id__ = default(string);
            var __id__b__ = false;
            var __areaDesc__ = default(string);
            var __areaDesc__b__ = false;
            var __geocode__ = default(global::SimpleWeather.NWS.Geocode);
            var __geocode__b__ = false;
            var __sent__ = default(global::System.DateTimeOffset);
            var __sent__b__ = false;
            var __effective__ = default(global::System.DateTimeOffset);
            var __effective__b__ = false;
            var __onset__ = default(global::System.DateTimeOffset);
            var __onset__b__ = false;
            var __expires__ = default(global::System.DateTimeOffset);
            var __expires__b__ = false;
            var __status__ = default(string);
            var __status__b__ = false;
            var __messageType__ = default(string);
            var __messageType__b__ = false;
            var __category__ = default(string);
            var __category__b__ = false;
            var __severity__ = default(string);
            var __severity__b__ = false;
            var __certainty__ = default(string);
            var __certainty__b__ = false;
            var __urgency__ = default(string);
            var __urgency__b__ = false;
            var ___event__ = default(string);
            var ___event__b__ = false;
            var __sender__ = default(string);
            var __sender__b__ = false;
            var __headline__ = default(string);
            var __headline__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __instruction__ = default(string);
            var __instruction__b__ = false;
            var __response__ = default(string);
            var __response__b__ = false;
            var __parameters__ = default(global::SimpleWeather.NWS.Parameters);
            var __parameters__b__ = false;

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
                        __atId__ = reader.ReadString();
                        __atId__b__ = true;
                        break;
                    case 1:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    case 2:
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    case 3:
                        __areaDesc__ = reader.ReadString();
                        __areaDesc__b__ = true;
                        break;
                    case 4:
                        __geocode__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Geocode>().Deserialize(ref reader, formatterResolver);
                        __geocode__b__ = true;
                        break;
                    case 5:
                        __sent__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __sent__b__ = true;
                        break;
                    case 6:
                        __effective__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __effective__b__ = true;
                        break;
                    case 7:
                        __onset__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __onset__b__ = true;
                        break;
                    case 8:
                        __expires__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __expires__b__ = true;
                        break;
                    case 9:
                        __status__ = reader.ReadString();
                        __status__b__ = true;
                        break;
                    case 10:
                        __messageType__ = reader.ReadString();
                        __messageType__b__ = true;
                        break;
                    case 11:
                        __category__ = reader.ReadString();
                        __category__b__ = true;
                        break;
                    case 12:
                        __severity__ = reader.ReadString();
                        __severity__b__ = true;
                        break;
                    case 13:
                        __certainty__ = reader.ReadString();
                        __certainty__b__ = true;
                        break;
                    case 14:
                        __urgency__ = reader.ReadString();
                        __urgency__b__ = true;
                        break;
                    case 15:
                        ___event__ = reader.ReadString();
                        ___event__b__ = true;
                        break;
                    case 16:
                        __sender__ = reader.ReadString();
                        __sender__b__ = true;
                        break;
                    case 17:
                        __headline__ = reader.ReadString();
                        __headline__b__ = true;
                        break;
                    case 18:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 19:
                        __instruction__ = reader.ReadString();
                        __instruction__b__ = true;
                        break;
                    case 20:
                        __response__ = reader.ReadString();
                        __response__b__ = true;
                        break;
                    case 21:
                        __parameters__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Parameters>().Deserialize(ref reader, formatterResolver);
                        __parameters__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.AlertGraph();
            if(__atId__b__) ____result.atId = __atId__;
            if(__type__b__) ____result.type = __type__;
            if(__id__b__) ____result.id = __id__;
            if(__areaDesc__b__) ____result.areaDesc = __areaDesc__;
            if(__geocode__b__) ____result.geocode = __geocode__;
            if(__sent__b__) ____result.sent = __sent__;
            if(__effective__b__) ____result.effective = __effective__;
            if(__onset__b__) ____result.onset = __onset__;
            if(__expires__b__) ____result.expires = __expires__;
            if(__status__b__) ____result.status = __status__;
            if(__messageType__b__) ____result.messageType = __messageType__;
            if(__category__b__) ____result.category = __category__;
            if(__severity__b__) ____result.severity = __severity__;
            if(__certainty__b__) ____result.certainty = __certainty__;
            if(__urgency__b__) ____result.urgency = __urgency__;
            if(___event__b__) ____result._event = ___event__;
            if(__sender__b__) ____result.sender = __sender__;
            if(__headline__b__) ____result.headline = __headline__;
            if(__description__b__) ____result.description = __description__;
            if(__instruction__b__) ____result.instruction = __instruction__;
            if(__response__b__) ____result.response = __response__;
            if(__parameters__b__) ____result.parameters = __parameters__;

            return ____result;
        }
    }


    public sealed class AlertRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.AlertRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@context"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@graph"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("title"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@context"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@graph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("title"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.AlertRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Serialize(ref writer, value.context, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.AlertGraph[]>().Serialize(ref writer, value.graph, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.title);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.AlertRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __context__ = default(global::SimpleWeather.NWS.Context);
            var __context__b__ = false;
            var __graph__ = default(global::SimpleWeather.NWS.AlertGraph[]);
            var __graph__b__ = false;
            var __title__ = default(string);
            var __title__b__ = false;

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
                        __context__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Deserialize(ref reader, formatterResolver);
                        __context__b__ = true;
                        break;
                    case 1:
                        __graph__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.AlertGraph[]>().Deserialize(ref reader, formatterResolver);
                        __graph__b__ = true;
                        break;
                    case 2:
                        __title__ = reader.ReadString();
                        __title__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.AlertRootobject();
            if(__context__b__) ____result.context = __context__;
            if(__graph__b__) ____result.graph = __graph__;
            if(__title__b__) ____result.title = __title__;

            return ____result;
        }
    }


    public sealed class Distance1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Distance1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Distance1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Distance1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.value);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Distance1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;

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
                        __value__ = reader.ReadSingle();
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Distance1();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;

            return ____result;
        }
    }


    public sealed class Bearing1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Bearing1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Bearing1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Bearing1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.value);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Bearing1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(int);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;

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
                        __value__ = reader.ReadInt32();
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Bearing1();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;

            return ____result;
        }
    }


    public sealed class RelativelocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Relativelocation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RelativelocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("geometry"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("bearing"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("geometry"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("bearing"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Relativelocation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.geometry);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Distance1>().Serialize(ref writer, value.distance, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Bearing1>().Serialize(ref writer, value.bearing, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Relativelocation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __city__ = default(string);
            var __city__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __geometry__ = default(string);
            var __geometry__b__ = false;
            var __distance__ = default(global::SimpleWeather.NWS.Distance1);
            var __distance__b__ = false;
            var __bearing__ = default(global::SimpleWeather.NWS.Bearing1);
            var __bearing__b__ = false;

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
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 1:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 2:
                        __geometry__ = reader.ReadString();
                        __geometry__b__ = true;
                        break;
                    case 3:
                        __distance__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Distance1>().Deserialize(ref reader, formatterResolver);
                        __distance__b__ = true;
                        break;
                    case 4:
                        __bearing__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Bearing1>().Deserialize(ref reader, formatterResolver);
                        __bearing__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Relativelocation();
            if(__city__b__) ____result.city = __city__;
            if(__state__b__) ____result.state = __state__;
            if(__geometry__b__) ____result.geometry = __geometry__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__bearing__b__) ____result.bearing = __bearing__;

            return ____result;
        }
    }


    public sealed class PointsRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.PointsRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public PointsRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@context"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@id"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("geometry"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cwa"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastOffice"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("gridX"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("gridY"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastHourly"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastGridData"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observationStations"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("relativeLocation"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastZone"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("county"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("fireWeatherZone"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timeZone"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("radarStation"), 17},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@context"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("geometry"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cwa"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastOffice"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("gridX"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("gridY"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastHourly"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastGridData"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("observationStations"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("relativeLocation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastZone"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("county"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("fireWeatherZone"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timeZone"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("radarStation"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.PointsRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Serialize(ref writer, value.context, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.id);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.type);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.geometry);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.cwa);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.forecastOffice);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value.gridX);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.gridY);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.forecast);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.forecastHourly);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.forecastGridData);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.observationStations);
            writer.WriteRaw(this.____stringByteKeys[12]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Relativelocation>().Serialize(ref writer, value.relativeLocation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.forecastZone);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.county);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value.fireWeatherZone);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.timeZone);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.radarStation);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.PointsRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __context__ = default(global::SimpleWeather.NWS.Context);
            var __context__b__ = false;
            var __id__ = default(string);
            var __id__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;
            var __geometry__ = default(string);
            var __geometry__b__ = false;
            var __cwa__ = default(string);
            var __cwa__b__ = false;
            var __forecastOffice__ = default(string);
            var __forecastOffice__b__ = false;
            var __gridX__ = default(int);
            var __gridX__b__ = false;
            var __gridY__ = default(int);
            var __gridY__b__ = false;
            var __forecast__ = default(string);
            var __forecast__b__ = false;
            var __forecastHourly__ = default(string);
            var __forecastHourly__b__ = false;
            var __forecastGridData__ = default(string);
            var __forecastGridData__b__ = false;
            var __observationStations__ = default(string);
            var __observationStations__b__ = false;
            var __relativeLocation__ = default(global::SimpleWeather.NWS.Relativelocation);
            var __relativeLocation__b__ = false;
            var __forecastZone__ = default(string);
            var __forecastZone__b__ = false;
            var __county__ = default(string);
            var __county__b__ = false;
            var __fireWeatherZone__ = default(string);
            var __fireWeatherZone__b__ = false;
            var __timeZone__ = default(string);
            var __timeZone__b__ = false;
            var __radarStation__ = default(string);
            var __radarStation__b__ = false;

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
                        __context__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Deserialize(ref reader, formatterResolver);
                        __context__b__ = true;
                        break;
                    case 1:
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    case 2:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    case 3:
                        __geometry__ = reader.ReadString();
                        __geometry__b__ = true;
                        break;
                    case 4:
                        __cwa__ = reader.ReadString();
                        __cwa__b__ = true;
                        break;
                    case 5:
                        __forecastOffice__ = reader.ReadString();
                        __forecastOffice__b__ = true;
                        break;
                    case 6:
                        __gridX__ = reader.ReadInt32();
                        __gridX__b__ = true;
                        break;
                    case 7:
                        __gridY__ = reader.ReadInt32();
                        __gridY__b__ = true;
                        break;
                    case 8:
                        __forecast__ = reader.ReadString();
                        __forecast__b__ = true;
                        break;
                    case 9:
                        __forecastHourly__ = reader.ReadString();
                        __forecastHourly__b__ = true;
                        break;
                    case 10:
                        __forecastGridData__ = reader.ReadString();
                        __forecastGridData__b__ = true;
                        break;
                    case 11:
                        __observationStations__ = reader.ReadString();
                        __observationStations__b__ = true;
                        break;
                    case 12:
                        __relativeLocation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Relativelocation>().Deserialize(ref reader, formatterResolver);
                        __relativeLocation__b__ = true;
                        break;
                    case 13:
                        __forecastZone__ = reader.ReadString();
                        __forecastZone__b__ = true;
                        break;
                    case 14:
                        __county__ = reader.ReadString();
                        __county__b__ = true;
                        break;
                    case 15:
                        __fireWeatherZone__ = reader.ReadString();
                        __fireWeatherZone__b__ = true;
                        break;
                    case 16:
                        __timeZone__ = reader.ReadString();
                        __timeZone__b__ = true;
                        break;
                    case 17:
                        __radarStation__ = reader.ReadString();
                        __radarStation__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.PointsRootobject();
            if(__context__b__) ____result.context = __context__;
            if(__id__b__) ____result.id = __id__;
            if(__type__b__) ____result.type = __type__;
            if(__geometry__b__) ____result.geometry = __geometry__;
            if(__cwa__b__) ____result.cwa = __cwa__;
            if(__forecastOffice__b__) ____result.forecastOffice = __forecastOffice__;
            if(__gridX__b__) ____result.gridX = __gridX__;
            if(__gridY__b__) ____result.gridY = __gridY__;
            if(__forecast__b__) ____result.forecast = __forecast__;
            if(__forecastHourly__b__) ____result.forecastHourly = __forecastHourly__;
            if(__forecastGridData__b__) ____result.forecastGridData = __forecastGridData__;
            if(__observationStations__b__) ____result.observationStations = __observationStations__;
            if(__relativeLocation__b__) ____result.relativeLocation = __relativeLocation__;
            if(__forecastZone__b__) ____result.forecastZone = __forecastZone__;
            if(__county__b__) ____result.county = __county__;
            if(__fireWeatherZone__b__) ____result.fireWeatherZone = __fireWeatherZone__;
            if(__timeZone__b__) ____result.timeZone = __timeZone__;
            if(__radarStation__b__) ____result.radarStation = __radarStation__;

            return ____result;
        }
    }


    public sealed class ElevationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Elevation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ElevationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Elevation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.value);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Elevation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;

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
                        __value__ = reader.ReadSingle();
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Elevation();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;

            return ____result;
        }
    }


    public sealed class PeriodFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Period>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public PeriodFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("number"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("startTime"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("endTime"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("isDaytime"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureUnit"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureTrend"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("shortForecast"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("detailedForecast"), 12},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("number"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("startTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("endTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("isDaytime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureUnit"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureTrend"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("shortForecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("detailedForecast"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Period value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.number);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.startTime, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.endTime, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteBoolean(value.isDaytime);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteInt32(value.temperature);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.temperatureUnit);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.temperatureTrend);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.windSpeed);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.windDirection);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.shortForecast);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.detailedForecast);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Period Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __number__ = default(int);
            var __number__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;
            var __startTime__ = default(global::System.DateTimeOffset);
            var __startTime__b__ = false;
            var __endTime__ = default(global::System.DateTimeOffset);
            var __endTime__b__ = false;
            var __isDaytime__ = default(bool);
            var __isDaytime__b__ = false;
            var __temperature__ = default(int);
            var __temperature__b__ = false;
            var __temperatureUnit__ = default(string);
            var __temperatureUnit__b__ = false;
            var __temperatureTrend__ = default(string);
            var __temperatureTrend__b__ = false;
            var __windSpeed__ = default(string);
            var __windSpeed__b__ = false;
            var __windDirection__ = default(string);
            var __windDirection__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __shortForecast__ = default(string);
            var __shortForecast__b__ = false;
            var __detailedForecast__ = default(string);
            var __detailedForecast__b__ = false;

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
                        __number__ = reader.ReadInt32();
                        __number__b__ = true;
                        break;
                    case 1:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    case 2:
                        __startTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __startTime__b__ = true;
                        break;
                    case 3:
                        __endTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __endTime__b__ = true;
                        break;
                    case 4:
                        __isDaytime__ = reader.ReadBoolean();
                        __isDaytime__b__ = true;
                        break;
                    case 5:
                        __temperature__ = reader.ReadInt32();
                        __temperature__b__ = true;
                        break;
                    case 6:
                        __temperatureUnit__ = reader.ReadString();
                        __temperatureUnit__b__ = true;
                        break;
                    case 7:
                        __temperatureTrend__ = reader.ReadString();
                        __temperatureTrend__b__ = true;
                        break;
                    case 8:
                        __windSpeed__ = reader.ReadString();
                        __windSpeed__b__ = true;
                        break;
                    case 9:
                        __windDirection__ = reader.ReadString();
                        __windDirection__b__ = true;
                        break;
                    case 10:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 11:
                        __shortForecast__ = reader.ReadString();
                        __shortForecast__b__ = true;
                        break;
                    case 12:
                        __detailedForecast__ = reader.ReadString();
                        __detailedForecast__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Period();
            if(__number__b__) ____result.number = __number__;
            if(__name__b__) ____result.name = __name__;
            if(__startTime__b__) ____result.startTime = __startTime__;
            if(__endTime__b__) ____result.endTime = __endTime__;
            if(__isDaytime__b__) ____result.isDaytime = __isDaytime__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__temperatureUnit__b__) ____result.temperatureUnit = __temperatureUnit__;
            if(__temperatureTrend__b__) ____result.temperatureTrend = __temperatureTrend__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__shortForecast__b__) ____result.shortForecast = __shortForecast__;
            if(__detailedForecast__b__) ____result.detailedForecast = __detailedForecast__;

            return ____result;
        }
    }


    public sealed class ForecastRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.ForecastRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("context"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("geometry"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("updated"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("units"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastGenerator"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("generatedAt"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("updateTime"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("validTimes"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("elevation"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("periods"), 9},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("context"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("geometry"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("updated"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("units"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastGenerator"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("generatedAt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("updateTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("validTimes"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("elevation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("periods"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.ForecastRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Serialize(ref writer, value.context, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.geometry);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.updated, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.units);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.forecastGenerator);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.generatedAt, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.updateTime, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.validTimes);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Elevation>().Serialize(ref writer, value.elevation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Period[]>().Serialize(ref writer, value.periods, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.ForecastRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __context__ = default(global::SimpleWeather.NWS.Context);
            var __context__b__ = false;
            var __geometry__ = default(string);
            var __geometry__b__ = false;
            var __updated__ = default(global::System.DateTimeOffset);
            var __updated__b__ = false;
            var __units__ = default(string);
            var __units__b__ = false;
            var __forecastGenerator__ = default(string);
            var __forecastGenerator__b__ = false;
            var __generatedAt__ = default(global::System.DateTimeOffset);
            var __generatedAt__b__ = false;
            var __updateTime__ = default(global::System.DateTimeOffset);
            var __updateTime__b__ = false;
            var __validTimes__ = default(string);
            var __validTimes__b__ = false;
            var __elevation__ = default(global::SimpleWeather.NWS.Elevation);
            var __elevation__b__ = false;
            var __periods__ = default(global::SimpleWeather.NWS.Period[]);
            var __periods__b__ = false;

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
                        __context__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Deserialize(ref reader, formatterResolver);
                        __context__b__ = true;
                        break;
                    case 1:
                        __geometry__ = reader.ReadString();
                        __geometry__b__ = true;
                        break;
                    case 2:
                        __updated__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __updated__b__ = true;
                        break;
                    case 3:
                        __units__ = reader.ReadString();
                        __units__b__ = true;
                        break;
                    case 4:
                        __forecastGenerator__ = reader.ReadString();
                        __forecastGenerator__b__ = true;
                        break;
                    case 5:
                        __generatedAt__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __generatedAt__b__ = true;
                        break;
                    case 6:
                        __updateTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __updateTime__b__ = true;
                        break;
                    case 7:
                        __validTimes__ = reader.ReadString();
                        __validTimes__b__ = true;
                        break;
                    case 8:
                        __elevation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Elevation>().Deserialize(ref reader, formatterResolver);
                        __elevation__b__ = true;
                        break;
                    case 9:
                        __periods__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Period[]>().Deserialize(ref reader, formatterResolver);
                        __periods__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.ForecastRootobject();
            if(__context__b__) ____result.context = __context__;
            if(__geometry__b__) ____result.geometry = __geometry__;
            if(__updated__b__) ____result.updated = __updated__;
            if(__units__b__) ____result.units = __units__;
            if(__forecastGenerator__b__) ____result.forecastGenerator = __forecastGenerator__;
            if(__generatedAt__b__) ____result.generatedAt = __generatedAt__;
            if(__updateTime__b__) ____result.updateTime = __updateTime__;
            if(__validTimes__b__) ____result.validTimes = __validTimes__;
            if(__elevation__b__) ____result.elevation = __elevation__;
            if(__periods__b__) ____result.periods = __periods__;

            return ____result;
        }
    }


    public sealed class ObsGraphFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.ObsGraph>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObsGraphFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("elevation"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("stationIdentifier"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timeZone"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("elevation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("stationIdentifier"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timeZone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.ObsGraph value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Elevation>().Serialize(ref writer, value.elevation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.stationIdentifier);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.timeZone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.ObsGraph Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __elevation__ = default(global::SimpleWeather.NWS.Elevation);
            var __elevation__b__ = false;
            var __stationIdentifier__ = default(string);
            var __stationIdentifier__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;
            var __timeZone__ = default(string);
            var __timeZone__b__ = false;

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
                        __elevation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Elevation>().Deserialize(ref reader, formatterResolver);
                        __elevation__b__ = true;
                        break;
                    case 1:
                        __stationIdentifier__ = reader.ReadString();
                        __stationIdentifier__b__ = true;
                        break;
                    case 2:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    case 3:
                        __timeZone__ = reader.ReadString();
                        __timeZone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.ObsGraph();
            if(__elevation__b__) ____result.elevation = __elevation__;
            if(__stationIdentifier__b__) ____result.stationIdentifier = __stationIdentifier__;
            if(__name__b__) ____result.name = __name__;
            if(__timeZone__b__) ____result.timeZone = __timeZone__;

            return ____result;
        }
    }


    public sealed class ObservationsStationsRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.ObservationsStationsRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObservationsStationsRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("context"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("graph"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observationStations"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("context"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("graph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("observationStations"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.ObservationsStationsRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Serialize(ref writer, value.context, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.ObsGraph[]>().Serialize(ref writer, value.graph, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.observationStations, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.ObservationsStationsRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __context__ = default(global::SimpleWeather.NWS.Context);
            var __context__b__ = false;
            var __graph__ = default(global::SimpleWeather.NWS.ObsGraph[]);
            var __graph__b__ = false;
            var __observationStations__ = default(string[]);
            var __observationStations__b__ = false;

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
                        __context__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Deserialize(ref reader, formatterResolver);
                        __context__b__ = true;
                        break;
                    case 1:
                        __graph__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.ObsGraph[]>().Deserialize(ref reader, formatterResolver);
                        __graph__b__ = true;
                        break;
                    case 2:
                        __observationStations__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __observationStations__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.ObservationsStationsRootobject();
            if(__context__b__) ____result.context = __context__;
            if(__graph__b__) ____result.graph = __graph__;
            if(__observationStations__b__) ____result.observationStations = __observationStations__;

            return ____result;
        }
    }


    public sealed class ObservationstationsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Observationstations>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObservationstationsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("container"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("container"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Observationstations value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.container);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Observationstations Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __container__ = default(string);
            var __container__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;

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
                        __container__ = reader.ReadString();
                        __container__b__ = true;
                        break;
                    case 1:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Observationstations();
            if(__container__b__) ____result.container = __container__;
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class TemperatureFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Temperature>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TemperatureFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Temperature value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Temperature Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Temperature();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class DewpointFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Dewpoint>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DewpointFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Dewpoint value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Dewpoint Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Dewpoint();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class WinddirectionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Winddirection>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WinddirectionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Winddirection value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Winddirection Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Winddirection();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class WindspeedFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Windspeed>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WindspeedFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Windspeed value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Windspeed Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Windspeed();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class WindgustFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Windgust>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WindgustFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Windgust value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Windgust Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Windgust();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class BarometricpressureFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Barometricpressure>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BarometricpressureFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Barometricpressure value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Barometricpressure Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Barometricpressure();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class SealevelpressureFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Sealevelpressure>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SealevelpressureFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Sealevelpressure value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Sealevelpressure Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Sealevelpressure();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class VisibilityFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Visibility>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public VisibilityFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Visibility value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Visibility Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Visibility();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class Maxtemperaturelast24hoursFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Maxtemperaturelast24hours>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Maxtemperaturelast24hoursFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Maxtemperaturelast24hours value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Maxtemperaturelast24hours Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Maxtemperaturelast24hours();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class Mintemperaturelast24hoursFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Mintemperaturelast24hours>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Mintemperaturelast24hoursFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Mintemperaturelast24hours value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Mintemperaturelast24hours Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Mintemperaturelast24hours();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class PrecipitationlasthourFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Precipitationlasthour>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public PrecipitationlasthourFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Precipitationlasthour value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Precipitationlasthour Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Precipitationlasthour();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class Precipitationlast3hoursFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Precipitationlast3hours>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Precipitationlast3hoursFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Precipitationlast3hours value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Precipitationlast3hours Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Precipitationlast3hours();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class Precipitationlast6hoursFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Precipitationlast6hours>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Precipitationlast6hoursFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Precipitationlast6hours value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Precipitationlast6hours Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Precipitationlast6hours();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class RelativehumidityFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Relativehumidity>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RelativehumidityFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Relativehumidity value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Relativehumidity Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Relativehumidity();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class WindchillFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Windchill>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WindchillFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Windchill value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Windchill Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Windchill();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class HeatindexFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Heatindex>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public HeatindexFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Heatindex value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Heatindex Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

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
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Heatindex();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class BaseFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Base>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BaseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Base value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.value);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Base Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(int);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;

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
                        __value__ = reader.ReadInt32();
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Base();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;

            return ____result;
        }
    }


    public sealed class CloudlayerFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Cloudlayer>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CloudlayerFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_base"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("amount"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_base"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("amount"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Cloudlayer value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Base>().Serialize(ref writer, value._base, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.amount);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Cloudlayer Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___base__ = default(global::SimpleWeather.NWS.Base);
            var ___base__b__ = false;
            var __amount__ = default(string);
            var __amount__b__ = false;

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
                        ___base__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Base>().Deserialize(ref reader, formatterResolver);
                        ___base__b__ = true;
                        break;
                    case 1:
                        __amount__ = reader.ReadString();
                        __amount__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Cloudlayer();
            if(___base__b__) ____result._base = ___base__;
            if(__amount__b__) ____result.amount = __amount__;

            return ____result;
        }
    }


    public sealed class ObservationsCurrentRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.ObservationsCurrentRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObservationsCurrentRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("context"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@id"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@type"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("geometry"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("elevation"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("station"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timestamp"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rawMessage"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("textDescription"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windGust"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometricPressure"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("seaLevelPressure"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("maxTemperatureLast24Hours"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minTemperatureLast24Hours"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationLastHour"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationLast3Hours"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationLast6Hours"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("relativeHumidity"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windChill"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("heatIndex"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cloudLayers"), 26},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("context"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("@type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("geometry"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("elevation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("station"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timestamp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rawMessage"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("textDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windGust"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometricPressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("seaLevelPressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("maxTemperatureLast24Hours"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minTemperatureLast24Hours"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationLastHour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationLast3Hours"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationLast6Hours"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("relativeHumidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windChill"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("heatIndex"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cloudLayers"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.ObservationsCurrentRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Serialize(ref writer, value.context, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.id);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.type);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.geometry);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Elevation>().Serialize(ref writer, value.elevation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.station);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.timestamp, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.rawMessage);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.textDescription);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[10]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Temperature>().Serialize(ref writer, value.temperature, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[11]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Dewpoint>().Serialize(ref writer, value.dewpoint, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[12]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Winddirection>().Serialize(ref writer, value.windDirection, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[13]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Windspeed>().Serialize(ref writer, value.windSpeed, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[14]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Windgust>().Serialize(ref writer, value.windGust, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[15]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Barometricpressure>().Serialize(ref writer, value.barometricPressure, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[16]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Sealevelpressure>().Serialize(ref writer, value.seaLevelPressure, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[17]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Visibility>().Serialize(ref writer, value.visibility, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[18]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Maxtemperaturelast24hours>().Serialize(ref writer, value.maxTemperatureLast24Hours, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[19]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Mintemperaturelast24hours>().Serialize(ref writer, value.minTemperatureLast24Hours, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[20]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Precipitationlasthour>().Serialize(ref writer, value.precipitationLastHour, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[21]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Precipitationlast3hours>().Serialize(ref writer, value.precipitationLast3Hours, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[22]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Precipitationlast6hours>().Serialize(ref writer, value.precipitationLast6Hours, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[23]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Relativehumidity>().Serialize(ref writer, value.relativeHumidity, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[24]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Windchill>().Serialize(ref writer, value.windChill, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[25]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Heatindex>().Serialize(ref writer, value.heatIndex, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[26]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Cloudlayer[]>().Serialize(ref writer, value.cloudLayers, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.ObservationsCurrentRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __context__ = default(global::SimpleWeather.NWS.Context);
            var __context__b__ = false;
            var __id__ = default(string);
            var __id__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;
            var __geometry__ = default(string);
            var __geometry__b__ = false;
            var __elevation__ = default(global::SimpleWeather.NWS.Elevation);
            var __elevation__b__ = false;
            var __station__ = default(string);
            var __station__b__ = false;
            var __timestamp__ = default(global::System.DateTimeOffset);
            var __timestamp__b__ = false;
            var __rawMessage__ = default(string);
            var __rawMessage__b__ = false;
            var __textDescription__ = default(string);
            var __textDescription__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __temperature__ = default(global::SimpleWeather.NWS.Temperature);
            var __temperature__b__ = false;
            var __dewpoint__ = default(global::SimpleWeather.NWS.Dewpoint);
            var __dewpoint__b__ = false;
            var __windDirection__ = default(global::SimpleWeather.NWS.Winddirection);
            var __windDirection__b__ = false;
            var __windSpeed__ = default(global::SimpleWeather.NWS.Windspeed);
            var __windSpeed__b__ = false;
            var __windGust__ = default(global::SimpleWeather.NWS.Windgust);
            var __windGust__b__ = false;
            var __barometricPressure__ = default(global::SimpleWeather.NWS.Barometricpressure);
            var __barometricPressure__b__ = false;
            var __seaLevelPressure__ = default(global::SimpleWeather.NWS.Sealevelpressure);
            var __seaLevelPressure__b__ = false;
            var __visibility__ = default(global::SimpleWeather.NWS.Visibility);
            var __visibility__b__ = false;
            var __maxTemperatureLast24Hours__ = default(global::SimpleWeather.NWS.Maxtemperaturelast24hours);
            var __maxTemperatureLast24Hours__b__ = false;
            var __minTemperatureLast24Hours__ = default(global::SimpleWeather.NWS.Mintemperaturelast24hours);
            var __minTemperatureLast24Hours__b__ = false;
            var __precipitationLastHour__ = default(global::SimpleWeather.NWS.Precipitationlasthour);
            var __precipitationLastHour__b__ = false;
            var __precipitationLast3Hours__ = default(global::SimpleWeather.NWS.Precipitationlast3hours);
            var __precipitationLast3Hours__b__ = false;
            var __precipitationLast6Hours__ = default(global::SimpleWeather.NWS.Precipitationlast6hours);
            var __precipitationLast6Hours__b__ = false;
            var __relativeHumidity__ = default(global::SimpleWeather.NWS.Relativehumidity);
            var __relativeHumidity__b__ = false;
            var __windChill__ = default(global::SimpleWeather.NWS.Windchill);
            var __windChill__b__ = false;
            var __heatIndex__ = default(global::SimpleWeather.NWS.Heatindex);
            var __heatIndex__b__ = false;
            var __cloudLayers__ = default(global::SimpleWeather.NWS.Cloudlayer[]);
            var __cloudLayers__b__ = false;

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
                        __context__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Context>().Deserialize(ref reader, formatterResolver);
                        __context__b__ = true;
                        break;
                    case 1:
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    case 2:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    case 3:
                        __geometry__ = reader.ReadString();
                        __geometry__b__ = true;
                        break;
                    case 4:
                        __elevation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Elevation>().Deserialize(ref reader, formatterResolver);
                        __elevation__b__ = true;
                        break;
                    case 5:
                        __station__ = reader.ReadString();
                        __station__b__ = true;
                        break;
                    case 6:
                        __timestamp__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __timestamp__b__ = true;
                        break;
                    case 7:
                        __rawMessage__ = reader.ReadString();
                        __rawMessage__b__ = true;
                        break;
                    case 8:
                        __textDescription__ = reader.ReadString();
                        __textDescription__b__ = true;
                        break;
                    case 9:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 10:
                        __temperature__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Temperature>().Deserialize(ref reader, formatterResolver);
                        __temperature__b__ = true;
                        break;
                    case 11:
                        __dewpoint__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Dewpoint>().Deserialize(ref reader, formatterResolver);
                        __dewpoint__b__ = true;
                        break;
                    case 12:
                        __windDirection__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Winddirection>().Deserialize(ref reader, formatterResolver);
                        __windDirection__b__ = true;
                        break;
                    case 13:
                        __windSpeed__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Windspeed>().Deserialize(ref reader, formatterResolver);
                        __windSpeed__b__ = true;
                        break;
                    case 14:
                        __windGust__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Windgust>().Deserialize(ref reader, formatterResolver);
                        __windGust__b__ = true;
                        break;
                    case 15:
                        __barometricPressure__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Barometricpressure>().Deserialize(ref reader, formatterResolver);
                        __barometricPressure__b__ = true;
                        break;
                    case 16:
                        __seaLevelPressure__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Sealevelpressure>().Deserialize(ref reader, formatterResolver);
                        __seaLevelPressure__b__ = true;
                        break;
                    case 17:
                        __visibility__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Visibility>().Deserialize(ref reader, formatterResolver);
                        __visibility__b__ = true;
                        break;
                    case 18:
                        __maxTemperatureLast24Hours__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Maxtemperaturelast24hours>().Deserialize(ref reader, formatterResolver);
                        __maxTemperatureLast24Hours__b__ = true;
                        break;
                    case 19:
                        __minTemperatureLast24Hours__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Mintemperaturelast24hours>().Deserialize(ref reader, formatterResolver);
                        __minTemperatureLast24Hours__b__ = true;
                        break;
                    case 20:
                        __precipitationLastHour__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Precipitationlasthour>().Deserialize(ref reader, formatterResolver);
                        __precipitationLastHour__b__ = true;
                        break;
                    case 21:
                        __precipitationLast3Hours__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Precipitationlast3hours>().Deserialize(ref reader, formatterResolver);
                        __precipitationLast3Hours__b__ = true;
                        break;
                    case 22:
                        __precipitationLast6Hours__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Precipitationlast6hours>().Deserialize(ref reader, formatterResolver);
                        __precipitationLast6Hours__b__ = true;
                        break;
                    case 23:
                        __relativeHumidity__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Relativehumidity>().Deserialize(ref reader, formatterResolver);
                        __relativeHumidity__b__ = true;
                        break;
                    case 24:
                        __windChill__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Windchill>().Deserialize(ref reader, formatterResolver);
                        __windChill__b__ = true;
                        break;
                    case 25:
                        __heatIndex__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Heatindex>().Deserialize(ref reader, formatterResolver);
                        __heatIndex__b__ = true;
                        break;
                    case 26:
                        __cloudLayers__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Cloudlayer[]>().Deserialize(ref reader, formatterResolver);
                        __cloudLayers__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.ObservationsCurrentRootobject();
            if(__context__b__) ____result.context = __context__;
            if(__id__b__) ____result.id = __id__;
            if(__type__b__) ____result.type = __type__;
            if(__geometry__b__) ____result.geometry = __geometry__;
            if(__elevation__b__) ____result.elevation = __elevation__;
            if(__station__b__) ____result.station = __station__;
            if(__timestamp__b__) ____result.timestamp = __timestamp__;
            if(__rawMessage__b__) ____result.rawMessage = __rawMessage__;
            if(__textDescription__b__) ____result.textDescription = __textDescription__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__dewpoint__b__) ____result.dewpoint = __dewpoint__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__windGust__b__) ____result.windGust = __windGust__;
            if(__barometricPressure__b__) ____result.barometricPressure = __barometricPressure__;
            if(__seaLevelPressure__b__) ____result.seaLevelPressure = __seaLevelPressure__;
            if(__visibility__b__) ____result.visibility = __visibility__;
            if(__maxTemperatureLast24Hours__b__) ____result.maxTemperatureLast24Hours = __maxTemperatureLast24Hours__;
            if(__minTemperatureLast24Hours__b__) ____result.minTemperatureLast24Hours = __minTemperatureLast24Hours__;
            if(__precipitationLastHour__b__) ____result.precipitationLastHour = __precipitationLastHour__;
            if(__precipitationLast3Hours__b__) ____result.precipitationLast3Hours = __precipitationLast3Hours__;
            if(__precipitationLast6Hours__b__) ____result.precipitationLast6Hours = __precipitationLast6Hours__;
            if(__relativeHumidity__b__) ____result.relativeHumidity = __relativeHumidity__;
            if(__windChill__b__) ____result.windChill = __windChill__;
            if(__heatIndex__b__) ____result.heatIndex = __heatIndex__;
            if(__cloudLayers__b__) ____result.cloudLayers = __cloudLayers__;

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

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather
{
    using System;
    using Utf8Json;


    public sealed class CoordFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Coord>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CoordFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lon"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lat"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("lon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lat"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Coord value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.lon);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.lat);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Coord Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __lon__ = default(float);
            var __lon__b__ = false;
            var __lat__ = default(float);
            var __lat__b__ = false;

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
                        __lon__ = reader.ReadSingle();
                        __lon__b__ = true;
                        break;
                    case 1:
                        __lat__ = reader.ReadSingle();
                        __lat__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Coord();
            if(__lon__b__) ____result.lon = __lon__;
            if(__lat__b__) ____result.lat = __lat__;

            return ____result;
        }
    }


    public sealed class WeatherFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Weather>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WeatherFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("main"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("main"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Weather value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.main);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.icon);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Weather Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __id__ = default(int);
            var __id__b__ = false;
            var __main__ = default(string);
            var __main__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;

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
                        __id__ = reader.ReadInt32();
                        __id__b__ = true;
                        break;
                    case 1:
                        __main__ = reader.ReadString();
                        __main__b__ = true;
                        break;
                    case 2:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 3:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Weather();
            if(__id__b__) ____result.id = __id__;
            if(__main__b__) ____result.main = __main__;
            if(__description__b__) ____result.description = __description__;
            if(__icon__b__) ____result.icon = __icon__;

            return ____result;
        }
    }


    public sealed class MainFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Main>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MainFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_min"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_max"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sea_level"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("grnd_level"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_kf"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("temp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_min"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_max"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sea_level"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("grnd_level"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_kf"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Main value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.temp);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.temp_min);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.temp_max);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteSingle(value.pressure);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.sea_level);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.grnd_level);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.temp_kf);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Main Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __temp__ = default(float);
            var __temp__b__ = false;
            var __temp_min__ = default(float);
            var __temp_min__b__ = false;
            var __temp_max__ = default(float);
            var __temp_max__b__ = false;
            var __pressure__ = default(float);
            var __pressure__b__ = false;
            var __sea_level__ = default(float);
            var __sea_level__b__ = false;
            var __grnd_level__ = default(float);
            var __grnd_level__b__ = false;
            var __temp_kf__ = default(float);
            var __temp_kf__b__ = false;

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
                        __temp__ = reader.ReadSingle();
                        __temp__b__ = true;
                        break;
                    case 1:
                        __temp_min__ = reader.ReadSingle();
                        __temp_min__b__ = true;
                        break;
                    case 2:
                        __temp_max__ = reader.ReadSingle();
                        __temp_max__b__ = true;
                        break;
                    case 3:
                        __pressure__ = reader.ReadSingle();
                        __pressure__b__ = true;
                        break;
                    case 4:
                        __sea_level__ = reader.ReadSingle();
                        __sea_level__b__ = true;
                        break;
                    case 5:
                        __grnd_level__ = reader.ReadSingle();
                        __grnd_level__b__ = true;
                        break;
                    case 6:
                        __temp_kf__ = reader.ReadSingle();
                        __temp_kf__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Main();
            if(__temp__b__) ____result.temp = __temp__;
            if(__temp_min__b__) ____result.temp_min = __temp_min__;
            if(__temp_max__b__) ____result.temp_max = __temp_max__;
            if(__pressure__b__) ____result.pressure = __pressure__;
            if(__sea_level__b__) ____result.sea_level = __sea_level__;
            if(__grnd_level__b__) ____result.grnd_level = __grnd_level__;
            if(__temp_kf__b__) ____result.temp_kf = __temp_kf__;

            return ____result;
        }
    }


    public sealed class WindFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Wind>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WindFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("speed"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("deg"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("speed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("deg"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Wind value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.speed);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.deg);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Wind Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __speed__ = default(float);
            var __speed__b__ = false;
            var __deg__ = default(float);
            var __deg__b__ = false;

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
                        __speed__ = reader.ReadSingle();
                        __speed__b__ = true;
                        break;
                    case 1:
                        __deg__ = reader.ReadSingle();
                        __deg__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Wind();
            if(__speed__b__) ____result.speed = __speed__;
            if(__deg__b__) ____result.deg = __deg__;

            return ____result;
        }
    }


    public sealed class CloudsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Clouds>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CloudsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("all"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("all"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Clouds value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.all);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Clouds Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __all__ = default(int);
            var __all__b__ = false;

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
                        __all__ = reader.ReadInt32();
                        __all__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Clouds();
            if(__all__b__) ____result.all = __all__;

            return ____result;
        }
    }


    public sealed class RainFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Rain>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RainFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_3h"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_3h"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Rain value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value._3h);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Rain Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___3h__ = default(float);
            var ___3h__b__ = false;

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
                        ___3h__ = reader.ReadSingle();
                        ___3h__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Rain();
            if(___3h__b__) ____result._3h = ___3h__;

            return ____result;
        }
    }


    public sealed class SnowFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Snow>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SnowFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_3h"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_3h"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Snow value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value._3h);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Snow Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___3h__ = default(float);
            var ___3h__b__ = false;

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
                        ___3h__ = reader.ReadSingle();
                        ___3h__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Snow();
            if(___3h__b__) ____result._3h = ___3h__;

            return ____result;
        }
    }


    public sealed class SysFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Sys>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SysFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("message"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunrise"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunset"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("message"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunset"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Sys value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.id);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.message);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt64(value.sunrise);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteInt64(value.sunset);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Sys Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __type__ = default(int);
            var __type__b__ = false;
            var __id__ = default(int);
            var __id__b__ = false;
            var __message__ = default(float);
            var __message__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __sunrise__ = default(long);
            var __sunrise__b__ = false;
            var __sunset__ = default(long);
            var __sunset__b__ = false;

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
                        __type__ = reader.ReadInt32();
                        __type__b__ = true;
                        break;
                    case 1:
                        __id__ = reader.ReadInt32();
                        __id__b__ = true;
                        break;
                    case 2:
                        __message__ = reader.ReadSingle();
                        __message__b__ = true;
                        break;
                    case 3:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 4:
                        __sunrise__ = reader.ReadInt64();
                        __sunrise__b__ = true;
                        break;
                    case 5:
                        __sunset__ = reader.ReadInt64();
                        __sunset__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Sys();
            if(__type__b__) ____result.type = __type__;
            if(__id__b__) ____result.id = __id__;
            if(__message__b__) ____result.message = __message__;
            if(__country__b__) ____result.country = __country__;
            if(__sunrise__b__) ____result.sunrise = __sunrise__;
            if(__sunset__b__) ____result.sunset = __sunset__;

            return ____result;
        }
    }


    public sealed class CurrentRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.CurrentRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CurrentRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("coord"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weather"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_base"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("main"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("clouds"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rain"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snow"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dt"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sys"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cod"), 13},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("coord"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weather"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("_base"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("main"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("clouds"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rain"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snow"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sys"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cod"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.CurrentRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Coord>().Serialize(ref writer, value.coord, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Weather[]>().Serialize(ref writer, value.weather, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value._base);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Main>().Serialize(ref writer, value.main, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value.visibility);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Wind>().Serialize(ref writer, value.wind, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Clouds>().Serialize(ref writer, value.clouds, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Rain>().Serialize(ref writer, value.rain, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Snow>().Serialize(ref writer, value.snow, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteInt64(value.dt);
            writer.WriteRaw(this.____stringByteKeys[10]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Sys>().Serialize(ref writer, value.sys, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteInt32(value.id);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteInt32(value.cod);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.CurrentRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __coord__ = default(global::SimpleWeather.OpenWeather.Coord);
            var __coord__b__ = false;
            var __weather__ = default(global::SimpleWeather.OpenWeather.Weather[]);
            var __weather__b__ = false;
            var ___base__ = default(string);
            var ___base__b__ = false;
            var __main__ = default(global::SimpleWeather.OpenWeather.Main);
            var __main__b__ = false;
            var __visibility__ = default(int);
            var __visibility__b__ = false;
            var __wind__ = default(global::SimpleWeather.OpenWeather.Wind);
            var __wind__b__ = false;
            var __clouds__ = default(global::SimpleWeather.OpenWeather.Clouds);
            var __clouds__b__ = false;
            var __rain__ = default(global::SimpleWeather.OpenWeather.Rain);
            var __rain__b__ = false;
            var __snow__ = default(global::SimpleWeather.OpenWeather.Snow);
            var __snow__b__ = false;
            var __dt__ = default(long);
            var __dt__b__ = false;
            var __sys__ = default(global::SimpleWeather.OpenWeather.Sys);
            var __sys__b__ = false;
            var __id__ = default(int);
            var __id__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;
            var __cod__ = default(int);
            var __cod__b__ = false;

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
                        __coord__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Coord>().Deserialize(ref reader, formatterResolver);
                        __coord__b__ = true;
                        break;
                    case 1:
                        __weather__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Weather[]>().Deserialize(ref reader, formatterResolver);
                        __weather__b__ = true;
                        break;
                    case 2:
                        ___base__ = reader.ReadString();
                        ___base__b__ = true;
                        break;
                    case 3:
                        __main__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Main>().Deserialize(ref reader, formatterResolver);
                        __main__b__ = true;
                        break;
                    case 4:
                        __visibility__ = reader.ReadInt32();
                        __visibility__b__ = true;
                        break;
                    case 5:
                        __wind__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Wind>().Deserialize(ref reader, formatterResolver);
                        __wind__b__ = true;
                        break;
                    case 6:
                        __clouds__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Clouds>().Deserialize(ref reader, formatterResolver);
                        __clouds__b__ = true;
                        break;
                    case 7:
                        __rain__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Rain>().Deserialize(ref reader, formatterResolver);
                        __rain__b__ = true;
                        break;
                    case 8:
                        __snow__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Snow>().Deserialize(ref reader, formatterResolver);
                        __snow__b__ = true;
                        break;
                    case 9:
                        __dt__ = reader.ReadInt64();
                        __dt__b__ = true;
                        break;
                    case 10:
                        __sys__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Sys>().Deserialize(ref reader, formatterResolver);
                        __sys__b__ = true;
                        break;
                    case 11:
                        __id__ = reader.ReadInt32();
                        __id__b__ = true;
                        break;
                    case 12:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    case 13:
                        __cod__ = reader.ReadInt32();
                        __cod__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.CurrentRootobject();
            if(__coord__b__) ____result.coord = __coord__;
            if(__weather__b__) ____result.weather = __weather__;
            if(___base__b__) ____result._base = ___base__;
            if(__main__b__) ____result.main = __main__;
            if(__visibility__b__) ____result.visibility = __visibility__;
            if(__wind__b__) ____result.wind = __wind__;
            if(__clouds__b__) ____result.clouds = __clouds__;
            if(__rain__b__) ____result.rain = __rain__;
            if(__snow__b__) ____result.snow = __snow__;
            if(__dt__b__) ____result.dt = __dt__;
            if(__sys__b__) ____result.sys = __sys__;
            if(__id__b__) ____result.id = __id__;
            if(__name__b__) ____result.name = __name__;
            if(__cod__b__) ____result.cod = __cod__;

            return ____result;
        }
    }


    public sealed class ForecastSysFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.ForecastSys>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastSysFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pod"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("pod"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.ForecastSys value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.pod);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.ForecastSys Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __pod__ = default(string);
            var __pod__b__ = false;

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
                        __pod__ = reader.ReadString();
                        __pod__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.ForecastSys();
            if(__pod__b__) ____result.pod = __pod__;

            return ____result;
        }
    }


    public sealed class ListFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.List>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ListFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dt"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("main"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weather"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("clouds"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rain"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snow"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sys"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dt_txt"), 8},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("dt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("main"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weather"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("clouds"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rain"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snow"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sys"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dt_txt"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.List value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt64(value.dt);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Main>().Serialize(ref writer, value.main, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Weather[]>().Serialize(ref writer, value.weather, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Clouds>().Serialize(ref writer, value.clouds, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Wind>().Serialize(ref writer, value.wind, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Rain>().Serialize(ref writer, value.rain, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Snow>().Serialize(ref writer, value.snow, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.ForecastSys>().Serialize(ref writer, value.sys, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.dt_txt);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.List Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __dt__ = default(long);
            var __dt__b__ = false;
            var __main__ = default(global::SimpleWeather.OpenWeather.Main);
            var __main__b__ = false;
            var __weather__ = default(global::SimpleWeather.OpenWeather.Weather[]);
            var __weather__b__ = false;
            var __clouds__ = default(global::SimpleWeather.OpenWeather.Clouds);
            var __clouds__b__ = false;
            var __wind__ = default(global::SimpleWeather.OpenWeather.Wind);
            var __wind__b__ = false;
            var __rain__ = default(global::SimpleWeather.OpenWeather.Rain);
            var __rain__b__ = false;
            var __snow__ = default(global::SimpleWeather.OpenWeather.Snow);
            var __snow__b__ = false;
            var __sys__ = default(global::SimpleWeather.OpenWeather.ForecastSys);
            var __sys__b__ = false;
            var __dt_txt__ = default(string);
            var __dt_txt__b__ = false;

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
                        __dt__ = reader.ReadInt64();
                        __dt__b__ = true;
                        break;
                    case 1:
                        __main__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Main>().Deserialize(ref reader, formatterResolver);
                        __main__b__ = true;
                        break;
                    case 2:
                        __weather__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Weather[]>().Deserialize(ref reader, formatterResolver);
                        __weather__b__ = true;
                        break;
                    case 3:
                        __clouds__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Clouds>().Deserialize(ref reader, formatterResolver);
                        __clouds__b__ = true;
                        break;
                    case 4:
                        __wind__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Wind>().Deserialize(ref reader, formatterResolver);
                        __wind__b__ = true;
                        break;
                    case 5:
                        __rain__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Rain>().Deserialize(ref reader, formatterResolver);
                        __rain__b__ = true;
                        break;
                    case 6:
                        __snow__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Snow>().Deserialize(ref reader, formatterResolver);
                        __snow__b__ = true;
                        break;
                    case 7:
                        __sys__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.ForecastSys>().Deserialize(ref reader, formatterResolver);
                        __sys__b__ = true;
                        break;
                    case 8:
                        __dt_txt__ = reader.ReadString();
                        __dt_txt__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.List();
            if(__dt__b__) ____result.dt = __dt__;
            if(__main__b__) ____result.main = __main__;
            if(__weather__b__) ____result.weather = __weather__;
            if(__clouds__b__) ____result.clouds = __clouds__;
            if(__wind__b__) ____result.wind = __wind__;
            if(__rain__b__) ____result.rain = __rain__;
            if(__snow__b__) ____result.snow = __snow__;
            if(__sys__b__) ____result.sys = __sys__;
            if(__dt_txt__b__) ____result.dt_txt = __dt_txt__;

            return ____result;
        }
    }


    public sealed class CityFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.City>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CityFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("coord"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("coord"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.City value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Coord>().Serialize(ref writer, value.coord, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.country);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.City Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __id__ = default(int);
            var __id__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;
            var __coord__ = default(global::SimpleWeather.OpenWeather.Coord);
            var __coord__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;

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
                        __id__ = reader.ReadInt32();
                        __id__b__ = true;
                        break;
                    case 1:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    case 2:
                        __coord__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Coord>().Deserialize(ref reader, formatterResolver);
                        __coord__b__ = true;
                        break;
                    case 3:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.City();
            if(__id__b__) ____result.id = __id__;
            if(__name__b__) ____result.name = __name__;
            if(__coord__b__) ____result.coord = __coord__;
            if(__country__b__) ____result.country = __country__;

            return ____result;
        }
    }


    public sealed class ForecastRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.ForecastRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cod"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("message"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cnt"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("list"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("cod"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("message"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cnt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("list"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.ForecastRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.cod);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.message);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.cnt);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.List[]>().Serialize(ref writer, value.list, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.City>().Serialize(ref writer, value.city, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.ForecastRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __cod__ = default(string);
            var __cod__b__ = false;
            var __message__ = default(float);
            var __message__b__ = false;
            var __cnt__ = default(int);
            var __cnt__b__ = false;
            var __list__ = default(global::SimpleWeather.OpenWeather.List[]);
            var __list__b__ = false;
            var __city__ = default(global::SimpleWeather.OpenWeather.City);
            var __city__b__ = false;

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
                        __cod__ = reader.ReadString();
                        __cod__b__ = true;
                        break;
                    case 1:
                        __message__ = reader.ReadSingle();
                        __message__b__ = true;
                        break;
                    case 2:
                        __cnt__ = reader.ReadInt32();
                        __cnt__b__ = true;
                        break;
                    case 3:
                        __list__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.List[]>().Deserialize(ref reader, formatterResolver);
                        __list__b__ = true;
                        break;
                    case 4:
                        __city__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.City>().Deserialize(ref reader, formatterResolver);
                        __city__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.ForecastRootobject();
            if(__cod__b__) ____result.cod = __cod__;
            if(__message__b__) ____result.message = __message__;
            if(__cnt__b__) ____result.cnt = __cnt__;
            if(__list__b__) ____result.list = __list__;
            if(__city__b__) ____result.city = __city__;

            return ____result;
        }
    }


    public sealed class RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cod"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("message"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("cod"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("message"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.cod);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.message);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __cod__ = default(int);
            var __cod__b__ = false;
            var __message__ = default(string);
            var __message__b__ = false;

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
                        __cod__ = reader.ReadInt32();
                        __cod__b__ = true;
                        break;
                    case 1:
                        __message__ = reader.ReadString();
                        __message__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Rootobject();
            if(__cod__b__) ____result.cod = __cod__;
            if(__message__b__) ____result.message = __message__;

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

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherUnderground
{
    using System;
    using Utf8Json;


    public sealed class FeaturesFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Features>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public FeaturesFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("astronomy"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("conditions"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast10day"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hourly"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("astronomy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("conditions"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecast10day"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hourly"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Features value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.astronomy);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.conditions);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.forecast10day);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.hourly);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Features Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __astronomy__ = default(int);
            var __astronomy__b__ = false;
            var __conditions__ = default(int);
            var __conditions__b__ = false;
            var __forecast10day__ = default(int);
            var __forecast10day__b__ = false;
            var __hourly__ = default(int);
            var __hourly__b__ = false;

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
                        __astronomy__ = reader.ReadInt32();
                        __astronomy__b__ = true;
                        break;
                    case 1:
                        __conditions__ = reader.ReadInt32();
                        __conditions__b__ = true;
                        break;
                    case 2:
                        __forecast10day__ = reader.ReadInt32();
                        __forecast10day__b__ = true;
                        break;
                    case 3:
                        __hourly__ = reader.ReadInt32();
                        __hourly__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Features();
            if(__astronomy__b__) ____result.astronomy = __astronomy__;
            if(__conditions__b__) ____result.conditions = __conditions__;
            if(__forecast10day__b__) ____result.forecast10day = __forecast10day__;
            if(__hourly__b__) ____result.hourly = __hourly__;

            return ____result;
        }
    }


    public sealed class ErrorFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Error>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ErrorFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Error value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.description);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Error Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __type__ = default(string);
            var __type__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;

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
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    case 1:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Error();
            if(__type__b__) ____result.type = __type__;
            if(__description__b__) ____result.description = __description__;

            return ____result;
        }
    }


    public sealed class ResponseFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Response>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ResponseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("version"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("termsofService"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("features"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("error"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("version"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("termsofService"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("features"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("error"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Response value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.version);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.termsofService);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Features>().Serialize(ref writer, value.features, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Error>().Serialize(ref writer, value.error, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Response Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __version__ = default(string);
            var __version__b__ = false;
            var __termsofService__ = default(string);
            var __termsofService__b__ = false;
            var __features__ = default(global::SimpleWeather.WeatherUnderground.Features);
            var __features__b__ = false;
            var __error__ = default(global::SimpleWeather.WeatherUnderground.Error);
            var __error__b__ = false;

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
                        __version__ = reader.ReadString();
                        __version__b__ = true;
                        break;
                    case 1:
                        __termsofService__ = reader.ReadString();
                        __termsofService__b__ = true;
                        break;
                    case 2:
                        __features__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Features>().Deserialize(ref reader, formatterResolver);
                        __features__b__ = true;
                        break;
                    case 3:
                        __error__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Error>().Deserialize(ref reader, formatterResolver);
                        __error__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Response();
            if(__version__b__) ____result.version = __version__;
            if(__termsofService__b__) ____result.termsofService = __termsofService__;
            if(__features__b__) ____result.features = __features__;
            if(__error__b__) ____result.error = __error__;

            return ____result;
        }
    }


    public sealed class AlertFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Alert>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("date"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("date_epoch"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expires"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expires_epoch"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("message"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("phenomena"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("significance"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wtype_meteoalarm"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wtype_meteoalarm_name"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("level_meteoalarm"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("level_meteoalarm_name"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("level_meteoalarm_description"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("attribution"), 14},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("date"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("date_epoch"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expires"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expires_epoch"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("message"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("phenomena"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("significance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wtype_meteoalarm"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wtype_meteoalarm_name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("level_meteoalarm"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("level_meteoalarm_name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("level_meteoalarm_description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("attribution"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Alert value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.date);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.date_epoch);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.expires);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.expires_epoch);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.message);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.phenomena);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.significance);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.wtype_meteoalarm);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.wtype_meteoalarm_name);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.level_meteoalarm);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.level_meteoalarm_name);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.level_meteoalarm_description);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.attribution);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Alert Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __type__ = default(string);
            var __type__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __date__ = default(string);
            var __date__b__ = false;
            var __date_epoch__ = default(string);
            var __date_epoch__b__ = false;
            var __expires__ = default(string);
            var __expires__b__ = false;
            var __expires_epoch__ = default(string);
            var __expires_epoch__b__ = false;
            var __message__ = default(string);
            var __message__b__ = false;
            var __phenomena__ = default(string);
            var __phenomena__b__ = false;
            var __significance__ = default(string);
            var __significance__b__ = false;
            var __wtype_meteoalarm__ = default(string);
            var __wtype_meteoalarm__b__ = false;
            var __wtype_meteoalarm_name__ = default(string);
            var __wtype_meteoalarm_name__b__ = false;
            var __level_meteoalarm__ = default(string);
            var __level_meteoalarm__b__ = false;
            var __level_meteoalarm_name__ = default(string);
            var __level_meteoalarm_name__b__ = false;
            var __level_meteoalarm_description__ = default(string);
            var __level_meteoalarm_description__b__ = false;
            var __attribution__ = default(string);
            var __attribution__b__ = false;

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
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    case 1:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 2:
                        __date__ = reader.ReadString();
                        __date__b__ = true;
                        break;
                    case 3:
                        __date_epoch__ = reader.ReadString();
                        __date_epoch__b__ = true;
                        break;
                    case 4:
                        __expires__ = reader.ReadString();
                        __expires__b__ = true;
                        break;
                    case 5:
                        __expires_epoch__ = reader.ReadString();
                        __expires_epoch__b__ = true;
                        break;
                    case 6:
                        __message__ = reader.ReadString();
                        __message__b__ = true;
                        break;
                    case 7:
                        __phenomena__ = reader.ReadString();
                        __phenomena__b__ = true;
                        break;
                    case 8:
                        __significance__ = reader.ReadString();
                        __significance__b__ = true;
                        break;
                    case 9:
                        __wtype_meteoalarm__ = reader.ReadString();
                        __wtype_meteoalarm__b__ = true;
                        break;
                    case 10:
                        __wtype_meteoalarm_name__ = reader.ReadString();
                        __wtype_meteoalarm_name__b__ = true;
                        break;
                    case 11:
                        __level_meteoalarm__ = reader.ReadString();
                        __level_meteoalarm__b__ = true;
                        break;
                    case 12:
                        __level_meteoalarm_name__ = reader.ReadString();
                        __level_meteoalarm_name__b__ = true;
                        break;
                    case 13:
                        __level_meteoalarm_description__ = reader.ReadString();
                        __level_meteoalarm_description__b__ = true;
                        break;
                    case 14:
                        __attribution__ = reader.ReadString();
                        __attribution__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Alert();
            if(__type__b__) ____result.type = __type__;
            if(__description__b__) ____result.description = __description__;
            if(__date__b__) ____result.date = __date__;
            if(__date_epoch__b__) ____result.date_epoch = __date_epoch__;
            if(__expires__b__) ____result.expires = __expires__;
            if(__expires_epoch__b__) ____result.expires_epoch = __expires_epoch__;
            if(__message__b__) ____result.message = __message__;
            if(__phenomena__b__) ____result.phenomena = __phenomena__;
            if(__significance__b__) ____result.significance = __significance__;
            if(__wtype_meteoalarm__b__) ____result.wtype_meteoalarm = __wtype_meteoalarm__;
            if(__wtype_meteoalarm_name__b__) ____result.wtype_meteoalarm_name = __wtype_meteoalarm_name__;
            if(__level_meteoalarm__b__) ____result.level_meteoalarm = __level_meteoalarm__;
            if(__level_meteoalarm_name__b__) ____result.level_meteoalarm_name = __level_meteoalarm_name__;
            if(__level_meteoalarm_description__b__) ____result.level_meteoalarm_description = __level_meteoalarm_description__;
            if(__attribution__b__) ____result.attribution = __attribution__;

            return ____result;
        }
    }


    public sealed class AlertRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.AlertRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("response"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("alerts"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("response"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("alerts"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.AlertRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Response>().Serialize(ref writer, value.response, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Alert[]>().Serialize(ref writer, value.alerts, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.AlertRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __response__ = default(global::SimpleWeather.WeatherUnderground.Response);
            var __response__b__ = false;
            var __alerts__ = default(global::SimpleWeather.WeatherUnderground.Alert[]);
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
                        __response__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Response>().Deserialize(ref reader, formatterResolver);
                        __response__b__ = true;
                        break;
                    case 1:
                        __alerts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Alert[]>().Deserialize(ref reader, formatterResolver);
                        __alerts__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.AlertRootobject();
            if(__response__b__) ____result.response = __response__;
            if(__alerts__b__) ____result.alerts = __alerts__;

            return ____result;
        }
    }


    public sealed class AlertFeaturesFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.AlertFeatures>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertFeaturesFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("alerts"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("alerts"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.AlertFeatures value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.alerts);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.AlertFeatures Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __alerts__ = default(int);
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
                        __alerts__ = reader.ReadInt32();
                        __alerts__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.AlertFeatures();
            if(__alerts__b__) ____result.alerts = __alerts__;

            return ____result;
        }
    }


    public sealed class VertexFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Vertex>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public VertexFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lat"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lon"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("lat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lon"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Vertex value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.lat);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.lon);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Vertex Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __lat__ = default(string);
            var __lat__b__ = false;
            var __lon__ = default(string);
            var __lon__b__ = false;

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
                        __lat__ = reader.ReadString();
                        __lat__b__ = true;
                        break;
                    case 1:
                        __lon__ = reader.ReadString();
                        __lon__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Vertex();
            if(__lat__b__) ____result.lat = __lat__;
            if(__lon__b__) ____result.lon = __lon__;

            return ____result;
        }
    }


    public sealed class StorminfoFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Storminfo>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public StorminfoFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("time_epoch"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Motion_deg"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Motion_spd"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("position_lat"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("position_lon"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("time_epoch"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Motion_deg"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Motion_spd"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("position_lat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("position_lon"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Storminfo value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.time_epoch);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.Motion_deg);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.Motion_spd);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteSingle(value.position_lat);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.position_lon);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Storminfo Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __time_epoch__ = default(int);
            var __time_epoch__b__ = false;
            var __Motion_deg__ = default(int);
            var __Motion_deg__b__ = false;
            var __Motion_spd__ = default(int);
            var __Motion_spd__b__ = false;
            var __position_lat__ = default(float);
            var __position_lat__b__ = false;
            var __position_lon__ = default(float);
            var __position_lon__b__ = false;

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
                        __time_epoch__ = reader.ReadInt32();
                        __time_epoch__b__ = true;
                        break;
                    case 1:
                        __Motion_deg__ = reader.ReadInt32();
                        __Motion_deg__b__ = true;
                        break;
                    case 2:
                        __Motion_spd__ = reader.ReadInt32();
                        __Motion_spd__b__ = true;
                        break;
                    case 3:
                        __position_lat__ = reader.ReadSingle();
                        __position_lat__b__ = true;
                        break;
                    case 4:
                        __position_lon__ = reader.ReadSingle();
                        __position_lon__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Storminfo();
            if(__time_epoch__b__) ____result.time_epoch = __time_epoch__;
            if(__Motion_deg__b__) ____result.Motion_deg = __Motion_deg__;
            if(__Motion_spd__b__) ____result.Motion_spd = __Motion_spd__;
            if(__position_lat__b__) ____result.position_lat = __position_lat__;
            if(__position_lon__b__) ____result.position_lon = __position_lon__;

            return ____result;
        }
    }


    public sealed class StormbasedFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Stormbased>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public StormbasedFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("vertices"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Vertex_count"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("stormInfo"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("vertices"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Vertex_count"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("stormInfo"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Stormbased value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Vertex[]>().Serialize(ref writer, value.vertices, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.Vertex_count);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Storminfo>().Serialize(ref writer, value.stormInfo, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Stormbased Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __vertices__ = default(global::SimpleWeather.WeatherUnderground.Vertex[]);
            var __vertices__b__ = false;
            var __Vertex_count__ = default(int);
            var __Vertex_count__b__ = false;
            var __stormInfo__ = default(global::SimpleWeather.WeatherUnderground.Storminfo);
            var __stormInfo__b__ = false;

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
                        __vertices__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Vertex[]>().Deserialize(ref reader, formatterResolver);
                        __vertices__b__ = true;
                        break;
                    case 1:
                        __Vertex_count__ = reader.ReadInt32();
                        __Vertex_count__b__ = true;
                        break;
                    case 2:
                        __stormInfo__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Storminfo>().Deserialize(ref reader, formatterResolver);
                        __stormInfo__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Stormbased();
            if(__vertices__b__) ____result.vertices = __vertices__;
            if(__Vertex_count__b__) ____result.Vertex_count = __Vertex_count__;
            if(__stormInfo__b__) ____result.stormInfo = __stormInfo__;

            return ____result;
        }
    }


    public sealed class AlertZONEFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.AlertZONE>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertZONEFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ZONE"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ZONE"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.AlertZONE value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.ZONE);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.AlertZONE Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __state__ = default(string);
            var __state__b__ = false;
            var __ZONE__ = default(string);
            var __ZONE__b__ = false;

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
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 1:
                        __ZONE__ = reader.ReadString();
                        __ZONE__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.AlertZONE();
            if(__state__b__) ____result.state = __state__;
            if(__ZONE__b__) ____result.ZONE = __ZONE__;

            return ____result;
        }
    }


    public sealed class AC_RESULTFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.AC_RESULT>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AC_RESULTFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("c"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("zmw"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tzs"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("l"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lat"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lon"), 8},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("zmw"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tzs"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("l"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lon"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.AC_RESULT value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.type);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.c);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.zmw);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.tz);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.tzs);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.l);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.lat);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.lon);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.AC_RESULT Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __name__ = default(string);
            var __name__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;
            var __c__ = default(string);
            var __c__b__ = false;
            var __zmw__ = default(string);
            var __zmw__b__ = false;
            var __tz__ = default(string);
            var __tz__b__ = false;
            var __tzs__ = default(string);
            var __tzs__b__ = false;
            var __l__ = default(string);
            var __l__b__ = false;
            var __lat__ = default(string);
            var __lat__b__ = false;
            var __lon__ = default(string);
            var __lon__b__ = false;

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
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    case 2:
                        __c__ = reader.ReadString();
                        __c__b__ = true;
                        break;
                    case 3:
                        __zmw__ = reader.ReadString();
                        __zmw__b__ = true;
                        break;
                    case 4:
                        __tz__ = reader.ReadString();
                        __tz__b__ = true;
                        break;
                    case 5:
                        __tzs__ = reader.ReadString();
                        __tzs__b__ = true;
                        break;
                    case 6:
                        __l__ = reader.ReadString();
                        __l__b__ = true;
                        break;
                    case 7:
                        __lat__ = reader.ReadString();
                        __lat__b__ = true;
                        break;
                    case 8:
                        __lon__ = reader.ReadString();
                        __lon__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.AC_RESULT();
            if(__name__b__) ____result.name = __name__;
            if(__type__b__) ____result.type = __type__;
            if(__c__b__) ____result.c = __c__;
            if(__zmw__b__) ____result.zmw = __zmw__;
            if(__tz__b__) ____result.tz = __tz__;
            if(__tzs__b__) ____result.tzs = __tzs__;
            if(__l__b__) ____result.l = __l__;
            if(__lat__b__) ____result.lat = __lat__;
            if(__lon__b__) ____result.lon = __lon__;

            return ____result;
        }
    }


    public sealed class AC_RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.AC_Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AC_RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("RESULTS"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("RESULTS"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.AC_Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.AC_RESULT[]>().Serialize(ref writer, value.RESULTS, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.AC_Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __RESULTS__ = default(global::SimpleWeather.WeatherUnderground.AC_RESULT[]);
            var __RESULTS__b__ = false;

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
                        __RESULTS__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.AC_RESULT[]>().Deserialize(ref reader, formatterResolver);
                        __RESULTS__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.AC_Rootobject();
            if(__RESULTS__b__) ____result.RESULTS = __RESULTS__;

            return ____result;
        }
    }


    public sealed class locationTermsofserviceFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.locationTermsofservice>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public locationTermsofserviceFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("link"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Value"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("link"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Value"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.locationTermsofservice value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.link);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.Value);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.locationTermsofservice Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __link__ = default(string);
            var __link__b__ = false;
            var __Value__ = default(string);
            var __Value__b__ = false;

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
                        __link__ = reader.ReadString();
                        __link__b__ = true;
                        break;
                    case 1:
                        __Value__ = reader.ReadString();
                        __Value__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.locationTermsofservice();
            if(__link__b__) ____result.link = __link__;
            if(__Value__b__) ____result.Value = __Value__;

            return ____result;
        }
    }


    public sealed class locationRadarFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.locationRadar>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public locationRadarFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("image_url"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("url"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("image_url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("url"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.locationRadar value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.image_url);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.url);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.locationRadar Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __image_url__ = default(string);
            var __image_url__b__ = false;
            var __url__ = default(string);
            var __url__b__ = false;

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
                        __image_url__ = reader.ReadString();
                        __image_url__b__ = true;
                        break;
                    case 1:
                        __url__ = reader.ReadString();
                        __url__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.locationRadar();
            if(__image_url__b__) ____result.image_url = __image_url__;
            if(__url__b__) ____result.url = __url__;

            return ____result;
        }
    }


    public sealed class locationNearby_weather_stationsStationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public locationNearby_weather_stationsStationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icao"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lat"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lon"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icao"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lon"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.icao);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<decimal>().Serialize(ref writer, value.lat, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<decimal>().Serialize(ref writer, value.lon, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __city__ = default(string);
            var __city__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __icao__ = default(string);
            var __icao__b__ = false;
            var __lat__ = default(decimal);
            var __lat__b__ = false;
            var __lon__ = default(decimal);
            var __lon__b__ = false;

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
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 1:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 2:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 3:
                        __icao__ = reader.ReadString();
                        __icao__b__ = true;
                        break;
                    case 4:
                        __lat__ = formatterResolver.GetFormatterWithVerify<decimal>().Deserialize(ref reader, formatterResolver);
                        __lat__b__ = true;
                        break;
                    case 5:
                        __lon__ = formatterResolver.GetFormatterWithVerify<decimal>().Deserialize(ref reader, formatterResolver);
                        __lon__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation();
            if(__city__b__) ____result.city = __city__;
            if(__state__b__) ____result.state = __state__;
            if(__country__b__) ____result.country = __country__;
            if(__icao__b__) ____result.icao = __icao__;
            if(__lat__b__) ____result.lat = __lat__;
            if(__lon__b__) ____result.lon = __lon__;

            return ____result;
        }
    }


    public sealed class locationNearby_weather_stationsStation1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public locationNearby_weather_stationsStation1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("neighborhood"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance_km"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance_mi"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("neighborhood"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance_km"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance_mi"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.neighborhood);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.id);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.distance_km);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.distance_mi);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __neighborhood__ = default(string);
            var __neighborhood__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __id__ = default(string);
            var __id__b__ = false;
            var __distance_km__ = default(string);
            var __distance_km__b__ = false;
            var __distance_mi__ = default(string);
            var __distance_mi__b__ = false;

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
                        __neighborhood__ = reader.ReadString();
                        __neighborhood__b__ = true;
                        break;
                    case 1:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 4:
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    case 5:
                        __distance_km__ = reader.ReadString();
                        __distance_km__b__ = true;
                        break;
                    case 6:
                        __distance_mi__ = reader.ReadString();
                        __distance_mi__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1();
            if(__neighborhood__b__) ____result.neighborhood = __neighborhood__;
            if(__city__b__) ____result.city = __city__;
            if(__state__b__) ____result.state = __state__;
            if(__country__b__) ____result.country = __country__;
            if(__id__b__) ____result.id = __id__;
            if(__distance_km__b__) ____result.distance_km = __distance_km__;
            if(__distance_mi__b__) ____result.distance_mi = __distance_mi__;

            return ____result;
        }
    }


    public sealed class locationNearby_weather_stationsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stations>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public locationNearby_weather_stationsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airport"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pws"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("airport"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pws"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.locationNearby_weather_stations value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation[]>().Serialize(ref writer, value.airport, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1[]>().Serialize(ref writer, value.pws, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.locationNearby_weather_stations Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __airport__ = default(global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation[]);
            var __airport__b__ = false;
            var __pws__ = default(global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1[]);
            var __pws__b__ = false;

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
                        __airport__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation[]>().Deserialize(ref reader, formatterResolver);
                        __airport__b__ = true;
                        break;
                    case 1:
                        __pws__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stationsStation1[]>().Deserialize(ref reader, formatterResolver);
                        __pws__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.locationNearby_weather_stations();
            if(__airport__b__) ____result.airport = __airport__;
            if(__pws__b__) ____result.pws = __pws__;

            return ____result;
        }
    }


    public sealed class locationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.location>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public locationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("query"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("termsofservice"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz_short"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz_unix"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lat"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lon"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("zip"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("magic"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wmo"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("requesturl"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wuiurl"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("radar"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nearby_weather_stations"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 16},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("query"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("termsofservice"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz_short"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz_unix"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("zip"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("magic"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wmo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("requesturl"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wuiurl"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("radar"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nearby_weather_stations"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("type"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.location value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.query);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationTermsofservice>().Serialize(ref writer, value.termsofservice, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.tz_short);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.tz_unix);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.lat);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.lon);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.zip);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.magic);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.wmo);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.requesturl);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.wuiurl);
            writer.WriteRaw(this.____stringByteKeys[14]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationRadar>().Serialize(ref writer, value.radar, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[15]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stations>().Serialize(ref writer, value.nearby_weather_stations, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.type);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.location Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __query__ = default(string);
            var __query__b__ = false;
            var __termsofservice__ = default(global::SimpleWeather.WeatherUnderground.locationTermsofservice);
            var __termsofservice__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __tz_short__ = default(string);
            var __tz_short__b__ = false;
            var __tz_unix__ = default(string);
            var __tz_unix__b__ = false;
            var __lat__ = default(string);
            var __lat__b__ = false;
            var __lon__ = default(string);
            var __lon__b__ = false;
            var __zip__ = default(string);
            var __zip__b__ = false;
            var __magic__ = default(string);
            var __magic__b__ = false;
            var __wmo__ = default(string);
            var __wmo__b__ = false;
            var __requesturl__ = default(string);
            var __requesturl__b__ = false;
            var __wuiurl__ = default(string);
            var __wuiurl__b__ = false;
            var __radar__ = default(global::SimpleWeather.WeatherUnderground.locationRadar);
            var __radar__b__ = false;
            var __nearby_weather_stations__ = default(global::SimpleWeather.WeatherUnderground.locationNearby_weather_stations);
            var __nearby_weather_stations__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;

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
                        __termsofservice__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationTermsofservice>().Deserialize(ref reader, formatterResolver);
                        __termsofservice__b__ = true;
                        break;
                    case 2:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 3:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 4:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 5:
                        __tz_short__ = reader.ReadString();
                        __tz_short__b__ = true;
                        break;
                    case 6:
                        __tz_unix__ = reader.ReadString();
                        __tz_unix__b__ = true;
                        break;
                    case 7:
                        __lat__ = reader.ReadString();
                        __lat__b__ = true;
                        break;
                    case 8:
                        __lon__ = reader.ReadString();
                        __lon__b__ = true;
                        break;
                    case 9:
                        __zip__ = reader.ReadString();
                        __zip__b__ = true;
                        break;
                    case 10:
                        __magic__ = reader.ReadString();
                        __magic__b__ = true;
                        break;
                    case 11:
                        __wmo__ = reader.ReadString();
                        __wmo__b__ = true;
                        break;
                    case 12:
                        __requesturl__ = reader.ReadString();
                        __requesturl__b__ = true;
                        break;
                    case 13:
                        __wuiurl__ = reader.ReadString();
                        __wuiurl__b__ = true;
                        break;
                    case 14:
                        __radar__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationRadar>().Deserialize(ref reader, formatterResolver);
                        __radar__b__ = true;
                        break;
                    case 15:
                        __nearby_weather_stations__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.locationNearby_weather_stations>().Deserialize(ref reader, formatterResolver);
                        __nearby_weather_stations__b__ = true;
                        break;
                    case 16:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.location();
            if(__termsofservice__b__) ____result.termsofservice = __termsofservice__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__tz_short__b__) ____result.tz_short = __tz_short__;
            if(__tz_unix__b__) ____result.tz_unix = __tz_unix__;
            if(__lat__b__) ____result.lat = __lat__;
            if(__lon__b__) ____result.lon = __lon__;
            if(__zip__b__) ____result.zip = __zip__;
            if(__magic__b__) ____result.magic = __magic__;
            if(__wmo__b__) ____result.wmo = __wmo__;
            if(__requesturl__b__) ____result.requesturl = __requesturl__;
            if(__wuiurl__b__) ____result.wuiurl = __wuiurl__;
            if(__radar__b__) ____result.radar = __radar__;
            if(__nearby_weather_stations__b__) ____result.nearby_weather_stations = __nearby_weather_stations__;
            if(__type__b__) ____result.type = __type__;

            return ____result;
        }
    }


    public sealed class ImageFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Image>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ImageFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("url"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("title"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("link"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("title"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("link"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Image value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.url);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.title);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.link);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Image Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __url__ = default(string);
            var __url__b__ = false;
            var __title__ = default(string);
            var __title__b__ = false;
            var __link__ = default(string);
            var __link__b__ = false;

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
                        __url__ = reader.ReadString();
                        __url__b__ = true;
                        break;
                    case 1:
                        __title__ = reader.ReadString();
                        __title__b__ = true;
                        break;
                    case 2:
                        __link__ = reader.ReadString();
                        __link__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Image();
            if(__url__b__) ____result.url = __url__;
            if(__title__b__) ____result.title = __title__;
            if(__link__b__) ____result.link = __link__;

            return ____result;
        }
    }


    public sealed class Display_LocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Display_Location>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Display_LocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("full"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state_name"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country_iso3166"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("zip"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("magic"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wmo"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("elevation"), 11},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("full"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state_name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country_iso3166"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("zip"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("magic"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wmo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("elevation"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Display_Location value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.full);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.state_name);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.country_iso3166);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.zip);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.magic);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.wmo);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.elevation);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Display_Location Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __full__ = default(string);
            var __full__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __state_name__ = default(string);
            var __state_name__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __country_iso3166__ = default(string);
            var __country_iso3166__b__ = false;
            var __zip__ = default(string);
            var __zip__b__ = false;
            var __magic__ = default(string);
            var __magic__b__ = false;
            var __wmo__ = default(string);
            var __wmo__b__ = false;
            var __latitude__ = default(string);
            var __latitude__b__ = false;
            var __longitude__ = default(string);
            var __longitude__b__ = false;
            var __elevation__ = default(string);
            var __elevation__b__ = false;

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
                        __full__ = reader.ReadString();
                        __full__b__ = true;
                        break;
                    case 1:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __state_name__ = reader.ReadString();
                        __state_name__b__ = true;
                        break;
                    case 4:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 5:
                        __country_iso3166__ = reader.ReadString();
                        __country_iso3166__b__ = true;
                        break;
                    case 6:
                        __zip__ = reader.ReadString();
                        __zip__b__ = true;
                        break;
                    case 7:
                        __magic__ = reader.ReadString();
                        __magic__b__ = true;
                        break;
                    case 8:
                        __wmo__ = reader.ReadString();
                        __wmo__b__ = true;
                        break;
                    case 9:
                        __latitude__ = reader.ReadString();
                        __latitude__b__ = true;
                        break;
                    case 10:
                        __longitude__ = reader.ReadString();
                        __longitude__b__ = true;
                        break;
                    case 11:
                        __elevation__ = reader.ReadString();
                        __elevation__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Display_Location();
            if(__full__b__) ____result.full = __full__;
            if(__city__b__) ____result.city = __city__;
            if(__state__b__) ____result.state = __state__;
            if(__state_name__b__) ____result.state_name = __state_name__;
            if(__country__b__) ____result.country = __country__;
            if(__country_iso3166__b__) ____result.country_iso3166 = __country_iso3166__;
            if(__zip__b__) ____result.zip = __zip__;
            if(__magic__b__) ____result.magic = __magic__;
            if(__wmo__b__) ____result.wmo = __wmo__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__elevation__b__) ____result.elevation = __elevation__;

            return ____result;
        }
    }


    public sealed class Observation_LocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Observation_Location>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Observation_LocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("full"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country_iso3166"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("elevation"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("full"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country_iso3166"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("elevation"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Observation_Location value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.full);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.country_iso3166);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.elevation);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Observation_Location Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __full__ = default(string);
            var __full__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __country_iso3166__ = default(string);
            var __country_iso3166__b__ = false;
            var __latitude__ = default(string);
            var __latitude__b__ = false;
            var __longitude__ = default(string);
            var __longitude__b__ = false;
            var __elevation__ = default(string);
            var __elevation__b__ = false;

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
                        __full__ = reader.ReadString();
                        __full__b__ = true;
                        break;
                    case 1:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 4:
                        __country_iso3166__ = reader.ReadString();
                        __country_iso3166__b__ = true;
                        break;
                    case 5:
                        __latitude__ = reader.ReadString();
                        __latitude__b__ = true;
                        break;
                    case 6:
                        __longitude__ = reader.ReadString();
                        __longitude__b__ = true;
                        break;
                    case 7:
                        __elevation__ = reader.ReadString();
                        __elevation__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Observation_Location();
            if(__full__b__) ____result.full = __full__;
            if(__city__b__) ____result.city = __city__;
            if(__state__b__) ____result.state = __state__;
            if(__country__b__) ____result.country = __country__;
            if(__country_iso3166__b__) ____result.country_iso3166 = __country_iso3166__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__elevation__b__) ____result.elevation = __elevation__;

            return ____result;
        }
    }


    public sealed class Current_ObservationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Current_Observation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Current_ObservationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("image"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("display_location"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observation_location"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("estimated"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("station_id"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observation_time"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observation_time_rfc822"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observation_epoch"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("local_time_rfc822"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("local_epoch"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("local_tz_short"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("local_tz_long"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("local_tz_offset"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weather"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature_string"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_f"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_c"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("relative_humidity"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_string"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_dir"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_degrees"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_mph"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_gust_mph"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_kph"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind_gust_kph"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure_mb"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure_in"), 26},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure_trend"), 27},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint_string"), 28},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint_f"), 29},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint_c"), 30},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("heat_index_string"), 31},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("heat_index_f"), 32},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("heat_index_c"), 33},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windchill_string"), 34},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windchill_f"), 35},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windchill_c"), 36},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feelslike_string"), 37},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feelslike_f"), 38},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feelslike_c"), 39},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility_mi"), 40},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility_km"), 41},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("solarradiation"), 42},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("UV"), 43},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precip_1hr_string"), 44},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precip_1hr_in"), 45},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precip_1hr_metric"), 46},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precip_today_string"), 47},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precip_today_in"), 48},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precip_today_metric"), 49},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 50},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon_url"), 51},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast_url"), 52},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("history_url"), 53},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ob_url"), 54},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nowcast"), 55},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("image"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("display_location"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("observation_location"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("estimated"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("station_id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("observation_time"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("observation_time_rfc822"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("observation_epoch"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("local_time_rfc822"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("local_epoch"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("local_tz_short"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("local_tz_long"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("local_tz_offset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weather"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature_string"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("relative_humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_string"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_dir"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_degrees"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_mph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_gust_mph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_kph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind_gust_kph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure_mb"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure_trend"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint_string"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("heat_index_string"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("heat_index_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("heat_index_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windchill_string"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windchill_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windchill_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("feelslike_string"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("feelslike_f"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("feelslike_c"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility_mi"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility_km"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("solarradiation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("UV"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precip_1hr_string"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precip_1hr_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precip_1hr_metric"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precip_today_string"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precip_today_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precip_today_metric"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon_url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecast_url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("history_url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ob_url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nowcast"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Current_Observation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Image>().Serialize(ref writer, value.image, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Display_Location>().Serialize(ref writer, value.display_location, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Observation_Location>().Serialize(ref writer, value.observation_location, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Estimated>().Serialize(ref writer, value.estimated, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.station_id);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.observation_time);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.observation_time_rfc822);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.observation_epoch);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.local_time_rfc822);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.local_epoch);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.local_tz_short);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.local_tz_long);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.local_tz_offset);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.weather);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.temperature_string);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteSingle(value.temp_f);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteSingle(value.temp_c);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.relative_humidity);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.wind_string);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value.wind_dir);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteInt32(value.wind_degrees);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteSingle(value.wind_mph);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteString(value.wind_gust_mph);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteSingle(value.wind_kph);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value.wind_gust_kph);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteString(value.pressure_mb);
            writer.WriteRaw(this.____stringByteKeys[26]);
            writer.WriteString(value.pressure_in);
            writer.WriteRaw(this.____stringByteKeys[27]);
            writer.WriteString(value.pressure_trend);
            writer.WriteRaw(this.____stringByteKeys[28]);
            writer.WriteString(value.dewpoint_string);
            writer.WriteRaw(this.____stringByteKeys[29]);
            writer.WriteString(value.dewpoint_f);
            writer.WriteRaw(this.____stringByteKeys[30]);
            writer.WriteString(value.dewpoint_c);
            writer.WriteRaw(this.____stringByteKeys[31]);
            writer.WriteString(value.heat_index_string);
            writer.WriteRaw(this.____stringByteKeys[32]);
            writer.WriteString(value.heat_index_f);
            writer.WriteRaw(this.____stringByteKeys[33]);
            writer.WriteString(value.heat_index_c);
            writer.WriteRaw(this.____stringByteKeys[34]);
            writer.WriteString(value.windchill_string);
            writer.WriteRaw(this.____stringByteKeys[35]);
            writer.WriteString(value.windchill_f);
            writer.WriteRaw(this.____stringByteKeys[36]);
            writer.WriteString(value.windchill_c);
            writer.WriteRaw(this.____stringByteKeys[37]);
            writer.WriteString(value.feelslike_string);
            writer.WriteRaw(this.____stringByteKeys[38]);
            writer.WriteSingle(value.feelslike_f);
            writer.WriteRaw(this.____stringByteKeys[39]);
            writer.WriteSingle(value.feelslike_c);
            writer.WriteRaw(this.____stringByteKeys[40]);
            writer.WriteString(value.visibility_mi);
            writer.WriteRaw(this.____stringByteKeys[41]);
            writer.WriteString(value.visibility_km);
            writer.WriteRaw(this.____stringByteKeys[42]);
            writer.WriteString(value.solarradiation);
            writer.WriteRaw(this.____stringByteKeys[43]);
            writer.WriteString(value.UV);
            writer.WriteRaw(this.____stringByteKeys[44]);
            writer.WriteString(value.precip_1hr_string);
            writer.WriteRaw(this.____stringByteKeys[45]);
            writer.WriteString(value.precip_1hr_in);
            writer.WriteRaw(this.____stringByteKeys[46]);
            writer.WriteString(value.precip_1hr_metric);
            writer.WriteRaw(this.____stringByteKeys[47]);
            writer.WriteString(value.precip_today_string);
            writer.WriteRaw(this.____stringByteKeys[48]);
            writer.WriteString(value.precip_today_in);
            writer.WriteRaw(this.____stringByteKeys[49]);
            writer.WriteString(value.precip_today_metric);
            writer.WriteRaw(this.____stringByteKeys[50]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[51]);
            writer.WriteString(value.icon_url);
            writer.WriteRaw(this.____stringByteKeys[52]);
            writer.WriteString(value.forecast_url);
            writer.WriteRaw(this.____stringByteKeys[53]);
            writer.WriteString(value.history_url);
            writer.WriteRaw(this.____stringByteKeys[54]);
            writer.WriteString(value.ob_url);
            writer.WriteRaw(this.____stringByteKeys[55]);
            writer.WriteString(value.nowcast);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Current_Observation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __image__ = default(global::SimpleWeather.WeatherUnderground.Image);
            var __image__b__ = false;
            var __display_location__ = default(global::SimpleWeather.WeatherUnderground.Display_Location);
            var __display_location__b__ = false;
            var __observation_location__ = default(global::SimpleWeather.WeatherUnderground.Observation_Location);
            var __observation_location__b__ = false;
            var __estimated__ = default(global::SimpleWeather.WeatherUnderground.Estimated);
            var __estimated__b__ = false;
            var __station_id__ = default(string);
            var __station_id__b__ = false;
            var __observation_time__ = default(string);
            var __observation_time__b__ = false;
            var __observation_time_rfc822__ = default(string);
            var __observation_time_rfc822__b__ = false;
            var __observation_epoch__ = default(string);
            var __observation_epoch__b__ = false;
            var __local_time_rfc822__ = default(string);
            var __local_time_rfc822__b__ = false;
            var __local_epoch__ = default(string);
            var __local_epoch__b__ = false;
            var __local_tz_short__ = default(string);
            var __local_tz_short__b__ = false;
            var __local_tz_long__ = default(string);
            var __local_tz_long__b__ = false;
            var __local_tz_offset__ = default(string);
            var __local_tz_offset__b__ = false;
            var __weather__ = default(string);
            var __weather__b__ = false;
            var __temperature_string__ = default(string);
            var __temperature_string__b__ = false;
            var __temp_f__ = default(float);
            var __temp_f__b__ = false;
            var __temp_c__ = default(float);
            var __temp_c__b__ = false;
            var __relative_humidity__ = default(string);
            var __relative_humidity__b__ = false;
            var __wind_string__ = default(string);
            var __wind_string__b__ = false;
            var __wind_dir__ = default(string);
            var __wind_dir__b__ = false;
            var __wind_degrees__ = default(int);
            var __wind_degrees__b__ = false;
            var __wind_mph__ = default(float);
            var __wind_mph__b__ = false;
            var __wind_gust_mph__ = default(string);
            var __wind_gust_mph__b__ = false;
            var __wind_kph__ = default(float);
            var __wind_kph__b__ = false;
            var __wind_gust_kph__ = default(string);
            var __wind_gust_kph__b__ = false;
            var __pressure_mb__ = default(string);
            var __pressure_mb__b__ = false;
            var __pressure_in__ = default(string);
            var __pressure_in__b__ = false;
            var __pressure_trend__ = default(string);
            var __pressure_trend__b__ = false;
            var __dewpoint_string__ = default(string);
            var __dewpoint_string__b__ = false;
            var __dewpoint_f__ = default(string);
            var __dewpoint_f__b__ = false;
            var __dewpoint_c__ = default(string);
            var __dewpoint_c__b__ = false;
            var __heat_index_string__ = default(string);
            var __heat_index_string__b__ = false;
            var __heat_index_f__ = default(string);
            var __heat_index_f__b__ = false;
            var __heat_index_c__ = default(string);
            var __heat_index_c__b__ = false;
            var __windchill_string__ = default(string);
            var __windchill_string__b__ = false;
            var __windchill_f__ = default(string);
            var __windchill_f__b__ = false;
            var __windchill_c__ = default(string);
            var __windchill_c__b__ = false;
            var __feelslike_string__ = default(string);
            var __feelslike_string__b__ = false;
            var __feelslike_f__ = default(float);
            var __feelslike_f__b__ = false;
            var __feelslike_c__ = default(float);
            var __feelslike_c__b__ = false;
            var __visibility_mi__ = default(string);
            var __visibility_mi__b__ = false;
            var __visibility_km__ = default(string);
            var __visibility_km__b__ = false;
            var __solarradiation__ = default(string);
            var __solarradiation__b__ = false;
            var __UV__ = default(string);
            var __UV__b__ = false;
            var __precip_1hr_string__ = default(string);
            var __precip_1hr_string__b__ = false;
            var __precip_1hr_in__ = default(string);
            var __precip_1hr_in__b__ = false;
            var __precip_1hr_metric__ = default(string);
            var __precip_1hr_metric__b__ = false;
            var __precip_today_string__ = default(string);
            var __precip_today_string__b__ = false;
            var __precip_today_in__ = default(string);
            var __precip_today_in__b__ = false;
            var __precip_today_metric__ = default(string);
            var __precip_today_metric__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __icon_url__ = default(string);
            var __icon_url__b__ = false;
            var __forecast_url__ = default(string);
            var __forecast_url__b__ = false;
            var __history_url__ = default(string);
            var __history_url__b__ = false;
            var __ob_url__ = default(string);
            var __ob_url__b__ = false;
            var __nowcast__ = default(string);
            var __nowcast__b__ = false;

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
                        __image__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Image>().Deserialize(ref reader, formatterResolver);
                        __image__b__ = true;
                        break;
                    case 1:
                        __display_location__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Display_Location>().Deserialize(ref reader, formatterResolver);
                        __display_location__b__ = true;
                        break;
                    case 2:
                        __observation_location__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Observation_Location>().Deserialize(ref reader, formatterResolver);
                        __observation_location__b__ = true;
                        break;
                    case 3:
                        __estimated__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Estimated>().Deserialize(ref reader, formatterResolver);
                        __estimated__b__ = true;
                        break;
                    case 4:
                        __station_id__ = reader.ReadString();
                        __station_id__b__ = true;
                        break;
                    case 5:
                        __observation_time__ = reader.ReadString();
                        __observation_time__b__ = true;
                        break;
                    case 6:
                        __observation_time_rfc822__ = reader.ReadString();
                        __observation_time_rfc822__b__ = true;
                        break;
                    case 7:
                        __observation_epoch__ = reader.ReadString();
                        __observation_epoch__b__ = true;
                        break;
                    case 8:
                        __local_time_rfc822__ = reader.ReadString();
                        __local_time_rfc822__b__ = true;
                        break;
                    case 9:
                        __local_epoch__ = reader.ReadString();
                        __local_epoch__b__ = true;
                        break;
                    case 10:
                        __local_tz_short__ = reader.ReadString();
                        __local_tz_short__b__ = true;
                        break;
                    case 11:
                        __local_tz_long__ = reader.ReadString();
                        __local_tz_long__b__ = true;
                        break;
                    case 12:
                        __local_tz_offset__ = reader.ReadString();
                        __local_tz_offset__b__ = true;
                        break;
                    case 13:
                        __weather__ = reader.ReadString();
                        __weather__b__ = true;
                        break;
                    case 14:
                        __temperature_string__ = reader.ReadString();
                        __temperature_string__b__ = true;
                        break;
                    case 15:
                        __temp_f__ = reader.ReadSingle();
                        __temp_f__b__ = true;
                        break;
                    case 16:
                        __temp_c__ = reader.ReadSingle();
                        __temp_c__b__ = true;
                        break;
                    case 17:
                        __relative_humidity__ = reader.ReadString();
                        __relative_humidity__b__ = true;
                        break;
                    case 18:
                        __wind_string__ = reader.ReadString();
                        __wind_string__b__ = true;
                        break;
                    case 19:
                        __wind_dir__ = reader.ReadString();
                        __wind_dir__b__ = true;
                        break;
                    case 20:
                        __wind_degrees__ = reader.ReadInt32();
                        __wind_degrees__b__ = true;
                        break;
                    case 21:
                        __wind_mph__ = reader.ReadSingle();
                        __wind_mph__b__ = true;
                        break;
                    case 22:
                        __wind_gust_mph__ = reader.ReadString();
                        __wind_gust_mph__b__ = true;
                        break;
                    case 23:
                        __wind_kph__ = reader.ReadSingle();
                        __wind_kph__b__ = true;
                        break;
                    case 24:
                        __wind_gust_kph__ = reader.ReadString();
                        __wind_gust_kph__b__ = true;
                        break;
                    case 25:
                        __pressure_mb__ = reader.ReadString();
                        __pressure_mb__b__ = true;
                        break;
                    case 26:
                        __pressure_in__ = reader.ReadString();
                        __pressure_in__b__ = true;
                        break;
                    case 27:
                        __pressure_trend__ = reader.ReadString();
                        __pressure_trend__b__ = true;
                        break;
                    case 28:
                        __dewpoint_string__ = reader.ReadString();
                        __dewpoint_string__b__ = true;
                        break;
                    case 29:
                        __dewpoint_f__ = reader.ReadString();
                        __dewpoint_f__b__ = true;
                        break;
                    case 30:
                        __dewpoint_c__ = reader.ReadString();
                        __dewpoint_c__b__ = true;
                        break;
                    case 31:
                        __heat_index_string__ = reader.ReadString();
                        __heat_index_string__b__ = true;
                        break;
                    case 32:
                        __heat_index_f__ = reader.ReadString();
                        __heat_index_f__b__ = true;
                        break;
                    case 33:
                        __heat_index_c__ = reader.ReadString();
                        __heat_index_c__b__ = true;
                        break;
                    case 34:
                        __windchill_string__ = reader.ReadString();
                        __windchill_string__b__ = true;
                        break;
                    case 35:
                        __windchill_f__ = reader.ReadString();
                        __windchill_f__b__ = true;
                        break;
                    case 36:
                        __windchill_c__ = reader.ReadString();
                        __windchill_c__b__ = true;
                        break;
                    case 37:
                        __feelslike_string__ = reader.ReadString();
                        __feelslike_string__b__ = true;
                        break;
                    case 38:
                        __feelslike_f__ = reader.ReadSingle();
                        __feelslike_f__b__ = true;
                        break;
                    case 39:
                        __feelslike_c__ = reader.ReadSingle();
                        __feelslike_c__b__ = true;
                        break;
                    case 40:
                        __visibility_mi__ = reader.ReadString();
                        __visibility_mi__b__ = true;
                        break;
                    case 41:
                        __visibility_km__ = reader.ReadString();
                        __visibility_km__b__ = true;
                        break;
                    case 42:
                        __solarradiation__ = reader.ReadString();
                        __solarradiation__b__ = true;
                        break;
                    case 43:
                        __UV__ = reader.ReadString();
                        __UV__b__ = true;
                        break;
                    case 44:
                        __precip_1hr_string__ = reader.ReadString();
                        __precip_1hr_string__b__ = true;
                        break;
                    case 45:
                        __precip_1hr_in__ = reader.ReadString();
                        __precip_1hr_in__b__ = true;
                        break;
                    case 46:
                        __precip_1hr_metric__ = reader.ReadString();
                        __precip_1hr_metric__b__ = true;
                        break;
                    case 47:
                        __precip_today_string__ = reader.ReadString();
                        __precip_today_string__b__ = true;
                        break;
                    case 48:
                        __precip_today_in__ = reader.ReadString();
                        __precip_today_in__b__ = true;
                        break;
                    case 49:
                        __precip_today_metric__ = reader.ReadString();
                        __precip_today_metric__b__ = true;
                        break;
                    case 50:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 51:
                        __icon_url__ = reader.ReadString();
                        __icon_url__b__ = true;
                        break;
                    case 52:
                        __forecast_url__ = reader.ReadString();
                        __forecast_url__b__ = true;
                        break;
                    case 53:
                        __history_url__ = reader.ReadString();
                        __history_url__b__ = true;
                        break;
                    case 54:
                        __ob_url__ = reader.ReadString();
                        __ob_url__b__ = true;
                        break;
                    case 55:
                        __nowcast__ = reader.ReadString();
                        __nowcast__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Current_Observation();
            if(__image__b__) ____result.image = __image__;
            if(__display_location__b__) ____result.display_location = __display_location__;
            if(__observation_location__b__) ____result.observation_location = __observation_location__;
            if(__estimated__b__) ____result.estimated = __estimated__;
            if(__station_id__b__) ____result.station_id = __station_id__;
            if(__observation_time__b__) ____result.observation_time = __observation_time__;
            if(__observation_time_rfc822__b__) ____result.observation_time_rfc822 = __observation_time_rfc822__;
            if(__observation_epoch__b__) ____result.observation_epoch = __observation_epoch__;
            if(__local_time_rfc822__b__) ____result.local_time_rfc822 = __local_time_rfc822__;
            if(__local_epoch__b__) ____result.local_epoch = __local_epoch__;
            if(__local_tz_short__b__) ____result.local_tz_short = __local_tz_short__;
            if(__local_tz_long__b__) ____result.local_tz_long = __local_tz_long__;
            if(__local_tz_offset__b__) ____result.local_tz_offset = __local_tz_offset__;
            if(__weather__b__) ____result.weather = __weather__;
            if(__temperature_string__b__) ____result.temperature_string = __temperature_string__;
            if(__temp_f__b__) ____result.temp_f = __temp_f__;
            if(__temp_c__b__) ____result.temp_c = __temp_c__;
            if(__relative_humidity__b__) ____result.relative_humidity = __relative_humidity__;
            if(__wind_string__b__) ____result.wind_string = __wind_string__;
            if(__wind_dir__b__) ____result.wind_dir = __wind_dir__;
            if(__wind_degrees__b__) ____result.wind_degrees = __wind_degrees__;
            if(__wind_mph__b__) ____result.wind_mph = __wind_mph__;
            if(__wind_gust_mph__b__) ____result.wind_gust_mph = __wind_gust_mph__;
            if(__wind_kph__b__) ____result.wind_kph = __wind_kph__;
            if(__wind_gust_kph__b__) ____result.wind_gust_kph = __wind_gust_kph__;
            if(__pressure_mb__b__) ____result.pressure_mb = __pressure_mb__;
            if(__pressure_in__b__) ____result.pressure_in = __pressure_in__;
            if(__pressure_trend__b__) ____result.pressure_trend = __pressure_trend__;
            if(__dewpoint_string__b__) ____result.dewpoint_string = __dewpoint_string__;
            if(__dewpoint_f__b__) ____result.dewpoint_f = __dewpoint_f__;
            if(__dewpoint_c__b__) ____result.dewpoint_c = __dewpoint_c__;
            if(__heat_index_string__b__) ____result.heat_index_string = __heat_index_string__;
            if(__heat_index_f__b__) ____result.heat_index_f = __heat_index_f__;
            if(__heat_index_c__b__) ____result.heat_index_c = __heat_index_c__;
            if(__windchill_string__b__) ____result.windchill_string = __windchill_string__;
            if(__windchill_f__b__) ____result.windchill_f = __windchill_f__;
            if(__windchill_c__b__) ____result.windchill_c = __windchill_c__;
            if(__feelslike_string__b__) ____result.feelslike_string = __feelslike_string__;
            if(__feelslike_f__b__) ____result.feelslike_f = __feelslike_f__;
            if(__feelslike_c__b__) ____result.feelslike_c = __feelslike_c__;
            if(__visibility_mi__b__) ____result.visibility_mi = __visibility_mi__;
            if(__visibility_km__b__) ____result.visibility_km = __visibility_km__;
            if(__solarradiation__b__) ____result.solarradiation = __solarradiation__;
            if(__UV__b__) ____result.UV = __UV__;
            if(__precip_1hr_string__b__) ____result.precip_1hr_string = __precip_1hr_string__;
            if(__precip_1hr_in__b__) ____result.precip_1hr_in = __precip_1hr_in__;
            if(__precip_1hr_metric__b__) ____result.precip_1hr_metric = __precip_1hr_metric__;
            if(__precip_today_string__b__) ____result.precip_today_string = __precip_today_string__;
            if(__precip_today_in__b__) ____result.precip_today_in = __precip_today_in__;
            if(__precip_today_metric__b__) ____result.precip_today_metric = __precip_today_metric__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__icon_url__b__) ____result.icon_url = __icon_url__;
            if(__forecast_url__b__) ____result.forecast_url = __forecast_url__;
            if(__history_url__b__) ____result.history_url = __history_url__;
            if(__ob_url__b__) ____result.ob_url = __ob_url__;
            if(__nowcast__b__) ____result.nowcast = __nowcast__;

            return ____result;
        }
    }


    public sealed class ForecastdayFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Forecastday>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastdayFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("period"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon_url"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("title"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("fcttext"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("fcttext_metric"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pop"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("period"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon_url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("title"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("fcttext"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("fcttext_metric"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pop"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Forecastday value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.period);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.icon_url);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.title);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.fcttext);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.fcttext_metric);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.pop);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Forecastday Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __period__ = default(int);
            var __period__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __icon_url__ = default(string);
            var __icon_url__b__ = false;
            var __title__ = default(string);
            var __title__b__ = false;
            var __fcttext__ = default(string);
            var __fcttext__b__ = false;
            var __fcttext_metric__ = default(string);
            var __fcttext_metric__b__ = false;
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
                        __period__ = reader.ReadInt32();
                        __period__b__ = true;
                        break;
                    case 1:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 2:
                        __icon_url__ = reader.ReadString();
                        __icon_url__b__ = true;
                        break;
                    case 3:
                        __title__ = reader.ReadString();
                        __title__b__ = true;
                        break;
                    case 4:
                        __fcttext__ = reader.ReadString();
                        __fcttext__b__ = true;
                        break;
                    case 5:
                        __fcttext_metric__ = reader.ReadString();
                        __fcttext_metric__b__ = true;
                        break;
                    case 6:
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

            var ____result = new global::SimpleWeather.WeatherUnderground.Forecastday();
            if(__period__b__) ____result.period = __period__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__icon_url__b__) ____result.icon_url = __icon_url__;
            if(__title__b__) ____result.title = __title__;
            if(__fcttext__b__) ____result.fcttext = __fcttext__;
            if(__fcttext_metric__b__) ____result.fcttext_metric = __fcttext_metric__;
            if(__pop__b__) ____result.pop = __pop__;

            return ____result;
        }
    }


    public sealed class Txt_ForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Txt_Forecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Txt_ForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("date"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastday"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("date"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastday"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Txt_Forecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.date);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Forecastday[]>().Serialize(ref writer, value.forecastday, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Txt_Forecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __date__ = default(string);
            var __date__b__ = false;
            var __forecastday__ = default(global::SimpleWeather.WeatherUnderground.Forecastday[]);
            var __forecastday__b__ = false;

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
                        __date__ = reader.ReadString();
                        __date__b__ = true;
                        break;
                    case 1:
                        __forecastday__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Forecastday[]>().Deserialize(ref reader, formatterResolver);
                        __forecastday__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Txt_Forecast();
            if(__date__b__) ____result.date = __date__;
            if(__forecastday__b__) ____result.forecastday = __forecastday__;

            return ____result;
        }
    }


    public sealed class DateFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Date>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DateFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("epoch"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pretty"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("day"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("month"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("year"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("yday"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("min"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sec"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("isdst"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("monthname"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("monthname_short"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday_short"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ampm"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz_short"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz_long"), 16},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("epoch"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pretty"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("day"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("month"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("year"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("yday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("min"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sec"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("isdst"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("monthname"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("monthname_short"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday_short"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ampm"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz_short"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz_long"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Date value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.epoch);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.pretty);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.day);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.month);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value.year);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteInt32(value.yday);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value.hour);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.min);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteInt32(value.sec);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.isdst);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.monthname);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.monthname_short);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.weekday_short);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.weekday);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.ampm);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value.tz_short);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.tz_long);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Date Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __epoch__ = default(string);
            var __epoch__b__ = false;
            var __pretty__ = default(string);
            var __pretty__b__ = false;
            var __day__ = default(int);
            var __day__b__ = false;
            var __month__ = default(int);
            var __month__b__ = false;
            var __year__ = default(int);
            var __year__b__ = false;
            var __yday__ = default(int);
            var __yday__b__ = false;
            var __hour__ = default(int);
            var __hour__b__ = false;
            var __min__ = default(string);
            var __min__b__ = false;
            var __sec__ = default(int);
            var __sec__b__ = false;
            var __isdst__ = default(string);
            var __isdst__b__ = false;
            var __monthname__ = default(string);
            var __monthname__b__ = false;
            var __monthname_short__ = default(string);
            var __monthname_short__b__ = false;
            var __weekday_short__ = default(string);
            var __weekday_short__b__ = false;
            var __weekday__ = default(string);
            var __weekday__b__ = false;
            var __ampm__ = default(string);
            var __ampm__b__ = false;
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
                        __epoch__ = reader.ReadString();
                        __epoch__b__ = true;
                        break;
                    case 1:
                        __pretty__ = reader.ReadString();
                        __pretty__b__ = true;
                        break;
                    case 2:
                        __day__ = reader.ReadInt32();
                        __day__b__ = true;
                        break;
                    case 3:
                        __month__ = reader.ReadInt32();
                        __month__b__ = true;
                        break;
                    case 4:
                        __year__ = reader.ReadInt32();
                        __year__b__ = true;
                        break;
                    case 5:
                        __yday__ = reader.ReadInt32();
                        __yday__b__ = true;
                        break;
                    case 6:
                        __hour__ = reader.ReadInt32();
                        __hour__b__ = true;
                        break;
                    case 7:
                        __min__ = reader.ReadString();
                        __min__b__ = true;
                        break;
                    case 8:
                        __sec__ = reader.ReadInt32();
                        __sec__b__ = true;
                        break;
                    case 9:
                        __isdst__ = reader.ReadString();
                        __isdst__b__ = true;
                        break;
                    case 10:
                        __monthname__ = reader.ReadString();
                        __monthname__b__ = true;
                        break;
                    case 11:
                        __monthname_short__ = reader.ReadString();
                        __monthname_short__b__ = true;
                        break;
                    case 12:
                        __weekday_short__ = reader.ReadString();
                        __weekday_short__b__ = true;
                        break;
                    case 13:
                        __weekday__ = reader.ReadString();
                        __weekday__b__ = true;
                        break;
                    case 14:
                        __ampm__ = reader.ReadString();
                        __ampm__b__ = true;
                        break;
                    case 15:
                        __tz_short__ = reader.ReadString();
                        __tz_short__b__ = true;
                        break;
                    case 16:
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

            var ____result = new global::SimpleWeather.WeatherUnderground.Date();
            if(__epoch__b__) ____result.epoch = __epoch__;
            if(__pretty__b__) ____result.pretty = __pretty__;
            if(__day__b__) ____result.day = __day__;
            if(__month__b__) ____result.month = __month__;
            if(__year__b__) ____result.year = __year__;
            if(__yday__b__) ____result.yday = __yday__;
            if(__hour__b__) ____result.hour = __hour__;
            if(__min__b__) ____result.min = __min__;
            if(__sec__b__) ____result.sec = __sec__;
            if(__isdst__b__) ____result.isdst = __isdst__;
            if(__monthname__b__) ____result.monthname = __monthname__;
            if(__monthname_short__b__) ____result.monthname_short = __monthname_short__;
            if(__weekday_short__b__) ____result.weekday_short = __weekday_short__;
            if(__weekday__b__) ____result.weekday = __weekday__;
            if(__ampm__b__) ____result.ampm = __ampm__;
            if(__tz_short__b__) ____result.tz_short = __tz_short__;
            if(__tz_long__b__) ____result.tz_long = __tz_long__;

            return ____result;
        }
    }


    public sealed class HighFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.High>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public HighFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("fahrenheit"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("celsius"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("fahrenheit"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("celsius"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.High value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.fahrenheit);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.celsius);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.High Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __fahrenheit__ = default(string);
            var __fahrenheit__b__ = false;
            var __celsius__ = default(string);
            var __celsius__b__ = false;

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
                        __fahrenheit__ = reader.ReadString();
                        __fahrenheit__b__ = true;
                        break;
                    case 1:
                        __celsius__ = reader.ReadString();
                        __celsius__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.High();
            if(__fahrenheit__b__) ____result.fahrenheit = __fahrenheit__;
            if(__celsius__b__) ____result.celsius = __celsius__;

            return ____result;
        }
    }


    public sealed class LowFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Low>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public LowFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("fahrenheit"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("celsius"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("fahrenheit"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("celsius"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Low value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.fahrenheit);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.celsius);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Low Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __fahrenheit__ = default(string);
            var __fahrenheit__b__ = false;
            var __celsius__ = default(string);
            var __celsius__b__ = false;

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
                        __fahrenheit__ = reader.ReadString();
                        __fahrenheit__b__ = true;
                        break;
                    case 1:
                        __celsius__ = reader.ReadString();
                        __celsius__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Low();
            if(__fahrenheit__b__) ____result.fahrenheit = __fahrenheit__;
            if(__celsius__b__) ____result.celsius = __celsius__;

            return ____result;
        }
    }


    public sealed class Qpf_AlldayFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Qpf_Allday>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Qpf_AlldayFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_in"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mm"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mm"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Qpf_Allday value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value._in, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<int?>().Serialize(ref writer, value.mm, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Qpf_Allday Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___in__ = default(float?);
            var ___in__b__ = false;
            var __mm__ = default(int?);
            var __mm__b__ = false;

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
                        ___in__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        ___in__b__ = true;
                        break;
                    case 1:
                        __mm__ = formatterResolver.GetFormatterWithVerify<int?>().Deserialize(ref reader, formatterResolver);
                        __mm__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Qpf_Allday();
            if(___in__b__) ____result._in = ___in__;
            if(__mm__b__) ____result.mm = __mm__;

            return ____result;
        }
    }


    public sealed class Qpf_DayFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Qpf_Day>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Qpf_DayFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_in"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mm"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mm"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Qpf_Day value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value._in, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<int?>().Serialize(ref writer, value.mm, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Qpf_Day Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___in__ = default(float?);
            var ___in__b__ = false;
            var __mm__ = default(int?);
            var __mm__b__ = false;

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
                        ___in__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        ___in__b__ = true;
                        break;
                    case 1:
                        __mm__ = formatterResolver.GetFormatterWithVerify<int?>().Deserialize(ref reader, formatterResolver);
                        __mm__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Qpf_Day();
            if(___in__b__) ____result._in = ___in__;
            if(__mm__b__) ____result.mm = __mm__;

            return ____result;
        }
    }


    public sealed class Qpf_NightFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Qpf_Night>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Qpf_NightFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_in"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mm"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mm"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Qpf_Night value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value._in, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<int?>().Serialize(ref writer, value.mm, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Qpf_Night Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___in__ = default(float?);
            var ___in__b__ = false;
            var __mm__ = default(int?);
            var __mm__b__ = false;

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
                        ___in__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        ___in__b__ = true;
                        break;
                    case 1:
                        __mm__ = formatterResolver.GetFormatterWithVerify<int?>().Deserialize(ref reader, formatterResolver);
                        __mm__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Qpf_Night();
            if(___in__b__) ____result._in = ___in__;
            if(__mm__b__) ____result.mm = __mm__;

            return ____result;
        }
    }


    public sealed class Snow_AlldayFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Snow_Allday>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Snow_AlldayFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_in"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cm"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cm"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Snow_Allday value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value._in, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.cm, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Snow_Allday Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___in__ = default(float?);
            var ___in__b__ = false;
            var __cm__ = default(float?);
            var __cm__b__ = false;

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
                        ___in__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        ___in__b__ = true;
                        break;
                    case 1:
                        __cm__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __cm__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Snow_Allday();
            if(___in__b__) ____result._in = ___in__;
            if(__cm__b__) ____result.cm = __cm__;

            return ____result;
        }
    }


    public sealed class Snow_DayFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Snow_Day>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Snow_DayFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_in"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cm"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cm"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Snow_Day value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value._in, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.cm, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Snow_Day Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___in__ = default(float?);
            var ___in__b__ = false;
            var __cm__ = default(float?);
            var __cm__b__ = false;

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
                        ___in__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        ___in__b__ = true;
                        break;
                    case 1:
                        __cm__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __cm__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Snow_Day();
            if(___in__b__) ____result._in = ___in__;
            if(__cm__b__) ____result.cm = __cm__;

            return ____result;
        }
    }


    public sealed class Snow_NightFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Snow_Night>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Snow_NightFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_in"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cm"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_in"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cm"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Snow_Night value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value._in, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.cm, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Snow_Night Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___in__ = default(float?);
            var ___in__b__ = false;
            var __cm__ = default(float?);
            var __cm__b__ = false;

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
                        ___in__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        ___in__b__ = true;
                        break;
                    case 1:
                        __cm__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __cm__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Snow_Night();
            if(___in__b__) ____result._in = ___in__;
            if(__cm__b__) ____result.cm = __cm__;

            return ____result;
        }
    }


    public sealed class MaxwindFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Maxwind>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MaxwindFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mph"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("kph"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dir"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("degrees"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("mph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("kph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dir"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("degrees"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Maxwind value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.mph);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.kph);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.dir);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.degrees);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Maxwind Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __mph__ = default(int);
            var __mph__b__ = false;
            var __kph__ = default(int);
            var __kph__b__ = false;
            var __dir__ = default(string);
            var __dir__b__ = false;
            var __degrees__ = default(int);
            var __degrees__b__ = false;

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
                        __mph__ = reader.ReadInt32();
                        __mph__b__ = true;
                        break;
                    case 1:
                        __kph__ = reader.ReadInt32();
                        __kph__b__ = true;
                        break;
                    case 2:
                        __dir__ = reader.ReadString();
                        __dir__b__ = true;
                        break;
                    case 3:
                        __degrees__ = reader.ReadInt32();
                        __degrees__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Maxwind();
            if(__mph__b__) ____result.mph = __mph__;
            if(__kph__b__) ____result.kph = __kph__;
            if(__dir__b__) ____result.dir = __dir__;
            if(__degrees__b__) ____result.degrees = __degrees__;

            return ____result;
        }
    }


    public sealed class AvewindFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Avewind>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AvewindFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mph"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("kph"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dir"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("degrees"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("mph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("kph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dir"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("degrees"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Avewind value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.mph);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.kph);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.dir);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.degrees);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Avewind Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __mph__ = default(int);
            var __mph__b__ = false;
            var __kph__ = default(int);
            var __kph__b__ = false;
            var __dir__ = default(string);
            var __dir__b__ = false;
            var __degrees__ = default(int);
            var __degrees__b__ = false;

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
                        __mph__ = reader.ReadInt32();
                        __mph__b__ = true;
                        break;
                    case 1:
                        __kph__ = reader.ReadInt32();
                        __kph__b__ = true;
                        break;
                    case 2:
                        __dir__ = reader.ReadString();
                        __dir__b__ = true;
                        break;
                    case 3:
                        __degrees__ = reader.ReadInt32();
                        __degrees__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Avewind();
            if(__mph__b__) ____result.mph = __mph__;
            if(__kph__b__) ____result.kph = __kph__;
            if(__dir__b__) ____result.dir = __dir__;
            if(__degrees__b__) ____result.degrees = __degrees__;

            return ____result;
        }
    }


    public sealed class Forecastday1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Forecastday1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Forecastday1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("date"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("period"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("high"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("low"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("conditions"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon_url"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyicon"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pop"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_allday"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_day"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf_night"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snow_allday"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snow_day"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snow_night"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("maxwind"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("avewind"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("avehumidity"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("maxhumidity"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minhumidity"), 19},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("date"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("period"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("high"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("low"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("conditions"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon_url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyicon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pop"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_allday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_day"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf_night"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snow_allday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snow_day"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snow_night"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("maxwind"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("avewind"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("avehumidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("maxhumidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minhumidity"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Forecastday1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Date>().Serialize(ref writer, value.date, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.period);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.High>().Serialize(ref writer, value.high, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Low>().Serialize(ref writer, value.low, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.conditions);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.icon_url);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.skyicon);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteInt32(value.pop);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Qpf_Allday>().Serialize(ref writer, value.qpf_allday, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[10]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Qpf_Day>().Serialize(ref writer, value.qpf_day, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[11]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Qpf_Night>().Serialize(ref writer, value.qpf_night, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[12]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Snow_Allday>().Serialize(ref writer, value.snow_allday, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[13]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Snow_Day>().Serialize(ref writer, value.snow_day, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[14]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Snow_Night>().Serialize(ref writer, value.snow_night, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[15]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Maxwind>().Serialize(ref writer, value.maxwind, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[16]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Avewind>().Serialize(ref writer, value.avewind, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteInt32(value.avehumidity);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteInt32(value.maxhumidity);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteInt32(value.minhumidity);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Forecastday1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __date__ = default(global::SimpleWeather.WeatherUnderground.Date);
            var __date__b__ = false;
            var __period__ = default(int);
            var __period__b__ = false;
            var __high__ = default(global::SimpleWeather.WeatherUnderground.High);
            var __high__b__ = false;
            var __low__ = default(global::SimpleWeather.WeatherUnderground.Low);
            var __low__b__ = false;
            var __conditions__ = default(string);
            var __conditions__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __icon_url__ = default(string);
            var __icon_url__b__ = false;
            var __skyicon__ = default(string);
            var __skyicon__b__ = false;
            var __pop__ = default(int);
            var __pop__b__ = false;
            var __qpf_allday__ = default(global::SimpleWeather.WeatherUnderground.Qpf_Allday);
            var __qpf_allday__b__ = false;
            var __qpf_day__ = default(global::SimpleWeather.WeatherUnderground.Qpf_Day);
            var __qpf_day__b__ = false;
            var __qpf_night__ = default(global::SimpleWeather.WeatherUnderground.Qpf_Night);
            var __qpf_night__b__ = false;
            var __snow_allday__ = default(global::SimpleWeather.WeatherUnderground.Snow_Allday);
            var __snow_allday__b__ = false;
            var __snow_day__ = default(global::SimpleWeather.WeatherUnderground.Snow_Day);
            var __snow_day__b__ = false;
            var __snow_night__ = default(global::SimpleWeather.WeatherUnderground.Snow_Night);
            var __snow_night__b__ = false;
            var __maxwind__ = default(global::SimpleWeather.WeatherUnderground.Maxwind);
            var __maxwind__b__ = false;
            var __avewind__ = default(global::SimpleWeather.WeatherUnderground.Avewind);
            var __avewind__b__ = false;
            var __avehumidity__ = default(int);
            var __avehumidity__b__ = false;
            var __maxhumidity__ = default(int);
            var __maxhumidity__b__ = false;
            var __minhumidity__ = default(int);
            var __minhumidity__b__ = false;

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
                        __date__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Date>().Deserialize(ref reader, formatterResolver);
                        __date__b__ = true;
                        break;
                    case 1:
                        __period__ = reader.ReadInt32();
                        __period__b__ = true;
                        break;
                    case 2:
                        __high__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.High>().Deserialize(ref reader, formatterResolver);
                        __high__b__ = true;
                        break;
                    case 3:
                        __low__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Low>().Deserialize(ref reader, formatterResolver);
                        __low__b__ = true;
                        break;
                    case 4:
                        __conditions__ = reader.ReadString();
                        __conditions__b__ = true;
                        break;
                    case 5:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 6:
                        __icon_url__ = reader.ReadString();
                        __icon_url__b__ = true;
                        break;
                    case 7:
                        __skyicon__ = reader.ReadString();
                        __skyicon__b__ = true;
                        break;
                    case 8:
                        __pop__ = reader.ReadInt32();
                        __pop__b__ = true;
                        break;
                    case 9:
                        __qpf_allday__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Qpf_Allday>().Deserialize(ref reader, formatterResolver);
                        __qpf_allday__b__ = true;
                        break;
                    case 10:
                        __qpf_day__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Qpf_Day>().Deserialize(ref reader, formatterResolver);
                        __qpf_day__b__ = true;
                        break;
                    case 11:
                        __qpf_night__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Qpf_Night>().Deserialize(ref reader, formatterResolver);
                        __qpf_night__b__ = true;
                        break;
                    case 12:
                        __snow_allday__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Snow_Allday>().Deserialize(ref reader, formatterResolver);
                        __snow_allday__b__ = true;
                        break;
                    case 13:
                        __snow_day__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Snow_Day>().Deserialize(ref reader, formatterResolver);
                        __snow_day__b__ = true;
                        break;
                    case 14:
                        __snow_night__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Snow_Night>().Deserialize(ref reader, formatterResolver);
                        __snow_night__b__ = true;
                        break;
                    case 15:
                        __maxwind__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Maxwind>().Deserialize(ref reader, formatterResolver);
                        __maxwind__b__ = true;
                        break;
                    case 16:
                        __avewind__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Avewind>().Deserialize(ref reader, formatterResolver);
                        __avewind__b__ = true;
                        break;
                    case 17:
                        __avehumidity__ = reader.ReadInt32();
                        __avehumidity__b__ = true;
                        break;
                    case 18:
                        __maxhumidity__ = reader.ReadInt32();
                        __maxhumidity__b__ = true;
                        break;
                    case 19:
                        __minhumidity__ = reader.ReadInt32();
                        __minhumidity__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Forecastday1();
            if(__date__b__) ____result.date = __date__;
            if(__period__b__) ____result.period = __period__;
            if(__high__b__) ____result.high = __high__;
            if(__low__b__) ____result.low = __low__;
            if(__conditions__b__) ____result.conditions = __conditions__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__icon_url__b__) ____result.icon_url = __icon_url__;
            if(__skyicon__b__) ____result.skyicon = __skyicon__;
            if(__pop__b__) ____result.pop = __pop__;
            if(__qpf_allday__b__) ____result.qpf_allday = __qpf_allday__;
            if(__qpf_day__b__) ____result.qpf_day = __qpf_day__;
            if(__qpf_night__b__) ____result.qpf_night = __qpf_night__;
            if(__snow_allday__b__) ____result.snow_allday = __snow_allday__;
            if(__snow_day__b__) ____result.snow_day = __snow_day__;
            if(__snow_night__b__) ____result.snow_night = __snow_night__;
            if(__maxwind__b__) ____result.maxwind = __maxwind__;
            if(__avewind__b__) ____result.avewind = __avewind__;
            if(__avehumidity__b__) ____result.avehumidity = __avehumidity__;
            if(__maxhumidity__b__) ____result.maxhumidity = __maxhumidity__;
            if(__minhumidity__b__) ____result.minhumidity = __minhumidity__;

            return ____result;
        }
    }


    public sealed class SimpleforecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Simpleforecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SimpleforecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastday"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecastday"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Simpleforecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Forecastday1[]>().Serialize(ref writer, value.forecastday, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Simpleforecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecastday__ = default(global::SimpleWeather.WeatherUnderground.Forecastday1[]);
            var __forecastday__b__ = false;

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
                        __forecastday__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Forecastday1[]>().Deserialize(ref reader, formatterResolver);
                        __forecastday__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Simpleforecast();
            if(__forecastday__b__) ____result.forecastday = __forecastday__;

            return ____result;
        }
    }


    public sealed class ForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Forecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("txt_forecast"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("simpleforecast"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("txt_forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("simpleforecast"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Forecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Txt_Forecast>().Serialize(ref writer, value.txt_forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Simpleforecast>().Serialize(ref writer, value.simpleforecast, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Forecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __txt_forecast__ = default(global::SimpleWeather.WeatherUnderground.Txt_Forecast);
            var __txt_forecast__b__ = false;
            var __simpleforecast__ = default(global::SimpleWeather.WeatherUnderground.Simpleforecast);
            var __simpleforecast__b__ = false;

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
                        __txt_forecast__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Txt_Forecast>().Deserialize(ref reader, formatterResolver);
                        __txt_forecast__b__ = true;
                        break;
                    case 1:
                        __simpleforecast__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Simpleforecast>().Deserialize(ref reader, formatterResolver);
                        __simpleforecast__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Forecast();
            if(__txt_forecast__b__) ____result.txt_forecast = __txt_forecast__;
            if(__simpleforecast__b__) ____result.simpleforecast = __simpleforecast__;

            return ____result;
        }
    }


    public sealed class FCTTIMEFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.FCTTIME>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public FCTTIMEFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour_padded"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("min"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("min_unpadded"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sec"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("year"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mon"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mon_padded"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mon_abbrev"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mday"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mday_padded"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("yday"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("isdst"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("epoch"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pretty"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("civil"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("month_name"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("month_name_abbrev"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday_name"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday_name_night"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday_name_abbrev"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday_name_unlang"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday_name_night_unlang"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ampm"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tz"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("age"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("UTCDATE"), 26},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("hour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hour_padded"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("min"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("min_unpadded"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sec"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("year"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mon_padded"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mon_abbrev"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mday_padded"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("yday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("isdst"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("epoch"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pretty"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("civil"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("month_name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("month_name_abbrev"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday_name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday_name_night"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday_name_abbrev"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday_name_unlang"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday_name_night_unlang"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ampm"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tz"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("age"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("UTCDATE"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.FCTTIME value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.hour);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.hour_padded);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.min);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.min_unpadded);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.sec);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.year);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.mon);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.mon_padded);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.mon_abbrev);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.mday);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.mday_padded);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.yday);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.isdst);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.epoch);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.pretty);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value.civil);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.month_name);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.month_name_abbrev);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.weekday_name);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value.weekday_name_night);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value.weekday_name_abbrev);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteString(value.weekday_name_unlang);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteString(value.weekday_name_night_unlang);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteString(value.ampm);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value.tz);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteString(value.age);
            writer.WriteRaw(this.____stringByteKeys[26]);
            writer.WriteString(value.UTCDATE);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.FCTTIME Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __hour__ = default(string);
            var __hour__b__ = false;
            var __hour_padded__ = default(string);
            var __hour_padded__b__ = false;
            var __min__ = default(string);
            var __min__b__ = false;
            var __min_unpadded__ = default(string);
            var __min_unpadded__b__ = false;
            var __sec__ = default(string);
            var __sec__b__ = false;
            var __year__ = default(string);
            var __year__b__ = false;
            var __mon__ = default(string);
            var __mon__b__ = false;
            var __mon_padded__ = default(string);
            var __mon_padded__b__ = false;
            var __mon_abbrev__ = default(string);
            var __mon_abbrev__b__ = false;
            var __mday__ = default(string);
            var __mday__b__ = false;
            var __mday_padded__ = default(string);
            var __mday_padded__b__ = false;
            var __yday__ = default(string);
            var __yday__b__ = false;
            var __isdst__ = default(string);
            var __isdst__b__ = false;
            var __epoch__ = default(string);
            var __epoch__b__ = false;
            var __pretty__ = default(string);
            var __pretty__b__ = false;
            var __civil__ = default(string);
            var __civil__b__ = false;
            var __month_name__ = default(string);
            var __month_name__b__ = false;
            var __month_name_abbrev__ = default(string);
            var __month_name_abbrev__b__ = false;
            var __weekday_name__ = default(string);
            var __weekday_name__b__ = false;
            var __weekday_name_night__ = default(string);
            var __weekday_name_night__b__ = false;
            var __weekday_name_abbrev__ = default(string);
            var __weekday_name_abbrev__b__ = false;
            var __weekday_name_unlang__ = default(string);
            var __weekday_name_unlang__b__ = false;
            var __weekday_name_night_unlang__ = default(string);
            var __weekday_name_night_unlang__b__ = false;
            var __ampm__ = default(string);
            var __ampm__b__ = false;
            var __tz__ = default(string);
            var __tz__b__ = false;
            var __age__ = default(string);
            var __age__b__ = false;
            var __UTCDATE__ = default(string);
            var __UTCDATE__b__ = false;

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
                        __hour__ = reader.ReadString();
                        __hour__b__ = true;
                        break;
                    case 1:
                        __hour_padded__ = reader.ReadString();
                        __hour_padded__b__ = true;
                        break;
                    case 2:
                        __min__ = reader.ReadString();
                        __min__b__ = true;
                        break;
                    case 3:
                        __min_unpadded__ = reader.ReadString();
                        __min_unpadded__b__ = true;
                        break;
                    case 4:
                        __sec__ = reader.ReadString();
                        __sec__b__ = true;
                        break;
                    case 5:
                        __year__ = reader.ReadString();
                        __year__b__ = true;
                        break;
                    case 6:
                        __mon__ = reader.ReadString();
                        __mon__b__ = true;
                        break;
                    case 7:
                        __mon_padded__ = reader.ReadString();
                        __mon_padded__b__ = true;
                        break;
                    case 8:
                        __mon_abbrev__ = reader.ReadString();
                        __mon_abbrev__b__ = true;
                        break;
                    case 9:
                        __mday__ = reader.ReadString();
                        __mday__b__ = true;
                        break;
                    case 10:
                        __mday_padded__ = reader.ReadString();
                        __mday_padded__b__ = true;
                        break;
                    case 11:
                        __yday__ = reader.ReadString();
                        __yday__b__ = true;
                        break;
                    case 12:
                        __isdst__ = reader.ReadString();
                        __isdst__b__ = true;
                        break;
                    case 13:
                        __epoch__ = reader.ReadString();
                        __epoch__b__ = true;
                        break;
                    case 14:
                        __pretty__ = reader.ReadString();
                        __pretty__b__ = true;
                        break;
                    case 15:
                        __civil__ = reader.ReadString();
                        __civil__b__ = true;
                        break;
                    case 16:
                        __month_name__ = reader.ReadString();
                        __month_name__b__ = true;
                        break;
                    case 17:
                        __month_name_abbrev__ = reader.ReadString();
                        __month_name_abbrev__b__ = true;
                        break;
                    case 18:
                        __weekday_name__ = reader.ReadString();
                        __weekday_name__b__ = true;
                        break;
                    case 19:
                        __weekday_name_night__ = reader.ReadString();
                        __weekday_name_night__b__ = true;
                        break;
                    case 20:
                        __weekday_name_abbrev__ = reader.ReadString();
                        __weekday_name_abbrev__b__ = true;
                        break;
                    case 21:
                        __weekday_name_unlang__ = reader.ReadString();
                        __weekday_name_unlang__b__ = true;
                        break;
                    case 22:
                        __weekday_name_night_unlang__ = reader.ReadString();
                        __weekday_name_night_unlang__b__ = true;
                        break;
                    case 23:
                        __ampm__ = reader.ReadString();
                        __ampm__b__ = true;
                        break;
                    case 24:
                        __tz__ = reader.ReadString();
                        __tz__b__ = true;
                        break;
                    case 25:
                        __age__ = reader.ReadString();
                        __age__b__ = true;
                        break;
                    case 26:
                        __UTCDATE__ = reader.ReadString();
                        __UTCDATE__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.FCTTIME();
            if(__hour__b__) ____result.hour = __hour__;
            if(__hour_padded__b__) ____result.hour_padded = __hour_padded__;
            if(__min__b__) ____result.min = __min__;
            if(__min_unpadded__b__) ____result.min_unpadded = __min_unpadded__;
            if(__sec__b__) ____result.sec = __sec__;
            if(__year__b__) ____result.year = __year__;
            if(__mon__b__) ____result.mon = __mon__;
            if(__mon_padded__b__) ____result.mon_padded = __mon_padded__;
            if(__mon_abbrev__b__) ____result.mon_abbrev = __mon_abbrev__;
            if(__mday__b__) ____result.mday = __mday__;
            if(__mday_padded__b__) ____result.mday_padded = __mday_padded__;
            if(__yday__b__) ____result.yday = __yday__;
            if(__isdst__b__) ____result.isdst = __isdst__;
            if(__epoch__b__) ____result.epoch = __epoch__;
            if(__pretty__b__) ____result.pretty = __pretty__;
            if(__civil__b__) ____result.civil = __civil__;
            if(__month_name__b__) ____result.month_name = __month_name__;
            if(__month_name_abbrev__b__) ____result.month_name_abbrev = __month_name_abbrev__;
            if(__weekday_name__b__) ____result.weekday_name = __weekday_name__;
            if(__weekday_name_night__b__) ____result.weekday_name_night = __weekday_name_night__;
            if(__weekday_name_abbrev__b__) ____result.weekday_name_abbrev = __weekday_name_abbrev__;
            if(__weekday_name_unlang__b__) ____result.weekday_name_unlang = __weekday_name_unlang__;
            if(__weekday_name_night_unlang__b__) ____result.weekday_name_night_unlang = __weekday_name_night_unlang__;
            if(__ampm__b__) ____result.ampm = __ampm__;
            if(__tz__b__) ____result.tz = __tz__;
            if(__age__b__) ____result.age = __age__;
            if(__UTCDATE__b__) ____result.UTCDATE = __UTCDATE__;

            return ____result;
        }
    }


    public sealed class TempFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Temp>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TempFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("english"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("english"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Temp value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.english);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.metric);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Temp Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __english__ = default(string);
            var __english__b__ = false;
            var __metric__ = default(string);
            var __metric__b__ = false;

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
                        __english__ = reader.ReadString();
                        __english__b__ = true;
                        break;
                    case 1:
                        __metric__ = reader.ReadString();
                        __metric__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Temp();
            if(__english__b__) ____result.english = __english__;
            if(__metric__b__) ____result.metric = __metric__;

            return ____result;
        }
    }


    public sealed class DewpointFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Dewpoint>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DewpointFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("english"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("english"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Dewpoint value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.english);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.metric);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Dewpoint Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __english__ = default(string);
            var __english__b__ = false;
            var __metric__ = default(string);
            var __metric__b__ = false;

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
                        __english__ = reader.ReadString();
                        __english__b__ = true;
                        break;
                    case 1:
                        __metric__ = reader.ReadString();
                        __metric__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Dewpoint();
            if(__english__b__) ____result.english = __english__;
            if(__metric__b__) ____result.metric = __metric__;

            return ____result;
        }
    }


    public sealed class WspdFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Wspd>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WspdFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("english"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("english"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Wspd value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.english);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.metric);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Wspd Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __english__ = default(string);
            var __english__b__ = false;
            var __metric__ = default(string);
            var __metric__b__ = false;

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
                        __english__ = reader.ReadString();
                        __english__b__ = true;
                        break;
                    case 1:
                        __metric__ = reader.ReadString();
                        __metric__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Wspd();
            if(__english__b__) ____result.english = __english__;
            if(__metric__b__) ____result.metric = __metric__;

            return ____result;
        }
    }


    public sealed class WdirFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Wdir>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WdirFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dir"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("degrees"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("dir"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("degrees"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Wdir value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.dir);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.degrees);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Wdir Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __dir__ = default(string);
            var __dir__b__ = false;
            var __degrees__ = default(string);
            var __degrees__b__ = false;

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
                        __dir__ = reader.ReadString();
                        __dir__b__ = true;
                        break;
                    case 1:
                        __degrees__ = reader.ReadString();
                        __degrees__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Wdir();
            if(__dir__b__) ____result.dir = __dir__;
            if(__degrees__b__) ____result.degrees = __degrees__;

            return ____result;
        }
    }


    public sealed class WindchillFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Windchill>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WindchillFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("english"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("english"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Windchill value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.english);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.metric);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Windchill Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __english__ = default(string);
            var __english__b__ = false;
            var __metric__ = default(string);
            var __metric__b__ = false;

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
                        __english__ = reader.ReadString();
                        __english__b__ = true;
                        break;
                    case 1:
                        __metric__ = reader.ReadString();
                        __metric__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Windchill();
            if(__english__b__) ____result.english = __english__;
            if(__metric__b__) ____result.metric = __metric__;

            return ____result;
        }
    }


    public sealed class HeatindexFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Heatindex>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public HeatindexFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("english"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("english"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Heatindex value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.english);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.metric);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Heatindex Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __english__ = default(string);
            var __english__b__ = false;
            var __metric__ = default(string);
            var __metric__b__ = false;

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
                        __english__ = reader.ReadString();
                        __english__b__ = true;
                        break;
                    case 1:
                        __metric__ = reader.ReadString();
                        __metric__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Heatindex();
            if(__english__b__) ____result.english = __english__;
            if(__metric__b__) ____result.metric = __metric__;

            return ____result;
        }
    }


    public sealed class FeelslikeFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Feelslike>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public FeelslikeFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("english"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("english"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Feelslike value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.english);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.metric);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Feelslike Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __english__ = default(string);
            var __english__b__ = false;
            var __metric__ = default(string);
            var __metric__b__ = false;

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
                        __english__ = reader.ReadString();
                        __english__b__ = true;
                        break;
                    case 1:
                        __metric__ = reader.ReadString();
                        __metric__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Feelslike();
            if(__english__b__) ____result.english = __english__;
            if(__metric__b__) ____result.metric = __metric__;

            return ____result;
        }
    }


    public sealed class QpfFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Qpf>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public QpfFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("english"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("english"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Qpf value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.english);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.metric);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Qpf Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __english__ = default(string);
            var __english__b__ = false;
            var __metric__ = default(string);
            var __metric__b__ = false;

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
                        __english__ = reader.ReadString();
                        __english__b__ = true;
                        break;
                    case 1:
                        __metric__ = reader.ReadString();
                        __metric__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Qpf();
            if(__english__b__) ____result.english = __english__;
            if(__metric__b__) ____result.metric = __metric__;

            return ____result;
        }
    }


    public sealed class SnowFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Snow>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SnowFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("english"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("english"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Snow value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.english);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.metric);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Snow Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __english__ = default(string);
            var __english__b__ = false;
            var __metric__ = default(string);
            var __metric__b__ = false;

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
                        __english__ = reader.ReadString();
                        __english__b__ = true;
                        break;
                    case 1:
                        __metric__ = reader.ReadString();
                        __metric__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Snow();
            if(__english__b__) ____result.english = __english__;
            if(__metric__b__) ____result.metric = __metric__;

            return ____result;
        }
    }


    public sealed class MslpFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Mslp>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MslpFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("english"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("english"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Mslp value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.english);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.metric);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Mslp Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __english__ = default(string);
            var __english__b__ = false;
            var __metric__ = default(string);
            var __metric__b__ = false;

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
                        __english__ = reader.ReadString();
                        __english__b__ = true;
                        break;
                    case 1:
                        __metric__ = reader.ReadString();
                        __metric__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Mslp();
            if(__english__b__) ____result.english = __english__;
            if(__metric__b__) ____result.metric = __metric__;

            return ____result;
        }
    }


    public sealed class Hourly_ForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Hourly_Forecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Hourly_ForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("FCTTIME"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("condition"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon_url"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("fctcode"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sky"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wspd"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wdir"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wx"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uvi"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("humidity"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windchill"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("heatindex"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feelslike"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qpf"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snow"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pop"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mslp"), 19},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("FCTTIME"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("condition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon_url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("fctcode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sky"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wspd"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wdir"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wx"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uvi"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windchill"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("heatindex"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("feelslike"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qpf"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snow"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pop"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mslp"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Hourly_Forecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.FCTTIME>().Serialize(ref writer, value.FCTTIME, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Temp>().Serialize(ref writer, value.temp, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Dewpoint>().Serialize(ref writer, value.dewpoint, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.condition);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.icon_url);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.fctcode);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.sky);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Wspd>().Serialize(ref writer, value.wspd, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Wdir>().Serialize(ref writer, value.wdir, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.wx);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.uvi);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.humidity);
            writer.WriteRaw(this.____stringByteKeys[13]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Windchill>().Serialize(ref writer, value.windchill, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[14]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Heatindex>().Serialize(ref writer, value.heatindex, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[15]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Feelslike>().Serialize(ref writer, value.feelslike, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[16]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Qpf>().Serialize(ref writer, value.qpf, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[17]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Snow>().Serialize(ref writer, value.snow, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.pop);
            writer.WriteRaw(this.____stringByteKeys[19]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Mslp>().Serialize(ref writer, value.mslp, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Hourly_Forecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __FCTTIME__ = default(global::SimpleWeather.WeatherUnderground.FCTTIME);
            var __FCTTIME__b__ = false;
            var __temp__ = default(global::SimpleWeather.WeatherUnderground.Temp);
            var __temp__b__ = false;
            var __dewpoint__ = default(global::SimpleWeather.WeatherUnderground.Dewpoint);
            var __dewpoint__b__ = false;
            var __condition__ = default(string);
            var __condition__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __icon_url__ = default(string);
            var __icon_url__b__ = false;
            var __fctcode__ = default(string);
            var __fctcode__b__ = false;
            var __sky__ = default(string);
            var __sky__b__ = false;
            var __wspd__ = default(global::SimpleWeather.WeatherUnderground.Wspd);
            var __wspd__b__ = false;
            var __wdir__ = default(global::SimpleWeather.WeatherUnderground.Wdir);
            var __wdir__b__ = false;
            var __wx__ = default(string);
            var __wx__b__ = false;
            var __uvi__ = default(string);
            var __uvi__b__ = false;
            var __humidity__ = default(string);
            var __humidity__b__ = false;
            var __windchill__ = default(global::SimpleWeather.WeatherUnderground.Windchill);
            var __windchill__b__ = false;
            var __heatindex__ = default(global::SimpleWeather.WeatherUnderground.Heatindex);
            var __heatindex__b__ = false;
            var __feelslike__ = default(global::SimpleWeather.WeatherUnderground.Feelslike);
            var __feelslike__b__ = false;
            var __qpf__ = default(global::SimpleWeather.WeatherUnderground.Qpf);
            var __qpf__b__ = false;
            var __snow__ = default(global::SimpleWeather.WeatherUnderground.Snow);
            var __snow__b__ = false;
            var __pop__ = default(string);
            var __pop__b__ = false;
            var __mslp__ = default(global::SimpleWeather.WeatherUnderground.Mslp);
            var __mslp__b__ = false;

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
                        __FCTTIME__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.FCTTIME>().Deserialize(ref reader, formatterResolver);
                        __FCTTIME__b__ = true;
                        break;
                    case 1:
                        __temp__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Temp>().Deserialize(ref reader, formatterResolver);
                        __temp__b__ = true;
                        break;
                    case 2:
                        __dewpoint__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Dewpoint>().Deserialize(ref reader, formatterResolver);
                        __dewpoint__b__ = true;
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
                        __icon_url__ = reader.ReadString();
                        __icon_url__b__ = true;
                        break;
                    case 6:
                        __fctcode__ = reader.ReadString();
                        __fctcode__b__ = true;
                        break;
                    case 7:
                        __sky__ = reader.ReadString();
                        __sky__b__ = true;
                        break;
                    case 8:
                        __wspd__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Wspd>().Deserialize(ref reader, formatterResolver);
                        __wspd__b__ = true;
                        break;
                    case 9:
                        __wdir__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Wdir>().Deserialize(ref reader, formatterResolver);
                        __wdir__b__ = true;
                        break;
                    case 10:
                        __wx__ = reader.ReadString();
                        __wx__b__ = true;
                        break;
                    case 11:
                        __uvi__ = reader.ReadString();
                        __uvi__b__ = true;
                        break;
                    case 12:
                        __humidity__ = reader.ReadString();
                        __humidity__b__ = true;
                        break;
                    case 13:
                        __windchill__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Windchill>().Deserialize(ref reader, formatterResolver);
                        __windchill__b__ = true;
                        break;
                    case 14:
                        __heatindex__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Heatindex>().Deserialize(ref reader, formatterResolver);
                        __heatindex__b__ = true;
                        break;
                    case 15:
                        __feelslike__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Feelslike>().Deserialize(ref reader, formatterResolver);
                        __feelslike__b__ = true;
                        break;
                    case 16:
                        __qpf__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Qpf>().Deserialize(ref reader, formatterResolver);
                        __qpf__b__ = true;
                        break;
                    case 17:
                        __snow__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Snow>().Deserialize(ref reader, formatterResolver);
                        __snow__b__ = true;
                        break;
                    case 18:
                        __pop__ = reader.ReadString();
                        __pop__b__ = true;
                        break;
                    case 19:
                        __mslp__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Mslp>().Deserialize(ref reader, formatterResolver);
                        __mslp__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Hourly_Forecast();
            if(__FCTTIME__b__) ____result.FCTTIME = __FCTTIME__;
            if(__temp__b__) ____result.temp = __temp__;
            if(__dewpoint__b__) ____result.dewpoint = __dewpoint__;
            if(__condition__b__) ____result.condition = __condition__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__icon_url__b__) ____result.icon_url = __icon_url__;
            if(__fctcode__b__) ____result.fctcode = __fctcode__;
            if(__sky__b__) ____result.sky = __sky__;
            if(__wspd__b__) ____result.wspd = __wspd__;
            if(__wdir__b__) ____result.wdir = __wdir__;
            if(__wx__b__) ____result.wx = __wx__;
            if(__uvi__b__) ____result.uvi = __uvi__;
            if(__humidity__b__) ____result.humidity = __humidity__;
            if(__windchill__b__) ____result.windchill = __windchill__;
            if(__heatindex__b__) ____result.heatindex = __heatindex__;
            if(__feelslike__b__) ____result.feelslike = __feelslike__;
            if(__qpf__b__) ____result.qpf = __qpf__;
            if(__snow__b__) ____result.snow = __snow__;
            if(__pop__b__) ____result.pop = __pop__;
            if(__mslp__b__) ____result.mslp = __mslp__;

            return ____result;
        }
    }


    public sealed class Current_TimeFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Current_Time>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Current_TimeFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minute"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("hour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minute"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Current_Time value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.hour);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.minute);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Current_Time Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __hour__ = default(string);
            var __hour__b__ = false;
            var __minute__ = default(string);
            var __minute__b__ = false;

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
                        __hour__ = reader.ReadString();
                        __hour__b__ = true;
                        break;
                    case 1:
                        __minute__ = reader.ReadString();
                        __minute__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Current_Time();
            if(__hour__b__) ____result.hour = __hour__;
            if(__minute__b__) ____result.minute = __minute__;

            return ____result;
        }
    }


    public sealed class SunriseFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Sunrise>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SunriseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minute"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("hour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minute"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Sunrise value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.hour);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.minute);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Sunrise Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __hour__ = default(string);
            var __hour__b__ = false;
            var __minute__ = default(string);
            var __minute__b__ = false;

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
                        __hour__ = reader.ReadString();
                        __hour__b__ = true;
                        break;
                    case 1:
                        __minute__ = reader.ReadString();
                        __minute__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Sunrise();
            if(__hour__b__) ____result.hour = __hour__;
            if(__minute__b__) ____result.minute = __minute__;

            return ____result;
        }
    }


    public sealed class SunsetFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Sunset>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SunsetFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minute"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("hour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minute"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Sunset value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.hour);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.minute);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Sunset Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __hour__ = default(string);
            var __hour__b__ = false;
            var __minute__ = default(string);
            var __minute__b__ = false;

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
                        __hour__ = reader.ReadString();
                        __hour__b__ = true;
                        break;
                    case 1:
                        __minute__ = reader.ReadString();
                        __minute__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Sunset();
            if(__hour__b__) ____result.hour = __hour__;
            if(__minute__b__) ____result.minute = __minute__;

            return ____result;
        }
    }


    public sealed class MoonriseFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Moonrise>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MoonriseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minute"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("hour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minute"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Moonrise value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.hour);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.minute);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Moonrise Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __hour__ = default(string);
            var __hour__b__ = false;
            var __minute__ = default(string);
            var __minute__b__ = false;

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
                        __hour__ = reader.ReadString();
                        __hour__b__ = true;
                        break;
                    case 1:
                        __minute__ = reader.ReadString();
                        __minute__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Moonrise();
            if(__hour__b__) ____result.hour = __hour__;
            if(__minute__b__) ____result.minute = __minute__;

            return ____result;
        }
    }


    public sealed class MoonsetFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Moonset>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MoonsetFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minute"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("hour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minute"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Moonset value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.hour);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.minute);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Moonset Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __hour__ = default(string);
            var __hour__b__ = false;
            var __minute__ = default(string);
            var __minute__b__ = false;

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
                        __hour__ = reader.ReadString();
                        __hour__b__ = true;
                        break;
                    case 1:
                        __minute__ = reader.ReadString();
                        __minute__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Moonset();
            if(__hour__b__) ____result.hour = __hour__;
            if(__minute__b__) ____result.minute = __minute__;

            return ____result;
        }
    }


    public sealed class Moon_PhaseFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Moon_Phase>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Moon_PhaseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("percentIlluminated"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ageOfMoon"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("phaseofMoon"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hemisphere"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("current_time"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunrise"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunset"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonrise"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonset"), 8},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("percentIlluminated"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ageOfMoon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("phaseofMoon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hemisphere"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("current_time"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonset"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Moon_Phase value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.percentIlluminated);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.ageOfMoon);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.phaseofMoon);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.hemisphere);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Current_Time>().Serialize(ref writer, value.current_time, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sunrise>().Serialize(ref writer, value.sunrise, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sunset>().Serialize(ref writer, value.sunset, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Moonrise>().Serialize(ref writer, value.moonrise, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Moonset>().Serialize(ref writer, value.moonset, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Moon_Phase Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __percentIlluminated__ = default(string);
            var __percentIlluminated__b__ = false;
            var __ageOfMoon__ = default(string);
            var __ageOfMoon__b__ = false;
            var __phaseofMoon__ = default(string);
            var __phaseofMoon__b__ = false;
            var __hemisphere__ = default(string);
            var __hemisphere__b__ = false;
            var __current_time__ = default(global::SimpleWeather.WeatherUnderground.Current_Time);
            var __current_time__b__ = false;
            var __sunrise__ = default(global::SimpleWeather.WeatherUnderground.Sunrise);
            var __sunrise__b__ = false;
            var __sunset__ = default(global::SimpleWeather.WeatherUnderground.Sunset);
            var __sunset__b__ = false;
            var __moonrise__ = default(global::SimpleWeather.WeatherUnderground.Moonrise);
            var __moonrise__b__ = false;
            var __moonset__ = default(global::SimpleWeather.WeatherUnderground.Moonset);
            var __moonset__b__ = false;

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
                        __percentIlluminated__ = reader.ReadString();
                        __percentIlluminated__b__ = true;
                        break;
                    case 1:
                        __ageOfMoon__ = reader.ReadString();
                        __ageOfMoon__b__ = true;
                        break;
                    case 2:
                        __phaseofMoon__ = reader.ReadString();
                        __phaseofMoon__b__ = true;
                        break;
                    case 3:
                        __hemisphere__ = reader.ReadString();
                        __hemisphere__b__ = true;
                        break;
                    case 4:
                        __current_time__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Current_Time>().Deserialize(ref reader, formatterResolver);
                        __current_time__b__ = true;
                        break;
                    case 5:
                        __sunrise__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sunrise>().Deserialize(ref reader, formatterResolver);
                        __sunrise__b__ = true;
                        break;
                    case 6:
                        __sunset__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sunset>().Deserialize(ref reader, formatterResolver);
                        __sunset__b__ = true;
                        break;
                    case 7:
                        __moonrise__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Moonrise>().Deserialize(ref reader, formatterResolver);
                        __moonrise__b__ = true;
                        break;
                    case 8:
                        __moonset__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Moonset>().Deserialize(ref reader, formatterResolver);
                        __moonset__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Moon_Phase();
            if(__percentIlluminated__b__) ____result.percentIlluminated = __percentIlluminated__;
            if(__ageOfMoon__b__) ____result.ageOfMoon = __ageOfMoon__;
            if(__phaseofMoon__b__) ____result.phaseofMoon = __phaseofMoon__;
            if(__hemisphere__b__) ____result.hemisphere = __hemisphere__;
            if(__current_time__b__) ____result.current_time = __current_time__;
            if(__sunrise__b__) ____result.sunrise = __sunrise__;
            if(__sunset__b__) ____result.sunset = __sunset__;
            if(__moonrise__b__) ____result.moonrise = __moonrise__;
            if(__moonset__b__) ____result.moonset = __moonset__;

            return ____result;
        }
    }


    public sealed class Sunrise1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Sunrise1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Sunrise1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minute"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("hour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minute"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Sunrise1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.hour);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.minute);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Sunrise1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __hour__ = default(string);
            var __hour__b__ = false;
            var __minute__ = default(string);
            var __minute__b__ = false;

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
                        __hour__ = reader.ReadString();
                        __hour__b__ = true;
                        break;
                    case 1:
                        __minute__ = reader.ReadString();
                        __minute__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Sunrise1();
            if(__hour__b__) ____result.hour = __hour__;
            if(__minute__b__) ____result.minute = __minute__;

            return ____result;
        }
    }


    public sealed class Sunset1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Sunset1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Sunset1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hour"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minute"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("hour"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minute"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Sunset1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.hour);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.minute);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Sunset1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __hour__ = default(string);
            var __hour__b__ = false;
            var __minute__ = default(string);
            var __minute__b__ = false;

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
                        __hour__ = reader.ReadString();
                        __hour__b__ = true;
                        break;
                    case 1:
                        __minute__ = reader.ReadString();
                        __minute__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Sunset1();
            if(__hour__b__) ____result.hour = __hour__;
            if(__minute__b__) ____result.minute = __minute__;

            return ____result;
        }
    }


    public sealed class Sun_PhaseFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Sun_Phase>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Sun_PhaseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunrise"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunset"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("sunrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunset"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Sun_Phase value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sunrise1>().Serialize(ref writer, value.sunrise, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sunset1>().Serialize(ref writer, value.sunset, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Sun_Phase Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __sunrise__ = default(global::SimpleWeather.WeatherUnderground.Sunrise1);
            var __sunrise__b__ = false;
            var __sunset__ = default(global::SimpleWeather.WeatherUnderground.Sunset1);
            var __sunset__b__ = false;

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
                        __sunrise__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sunrise1>().Deserialize(ref reader, formatterResolver);
                        __sunrise__b__ = true;
                        break;
                    case 1:
                        __sunset__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sunset1>().Deserialize(ref reader, formatterResolver);
                        __sunset__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Sun_Phase();
            if(__sunrise__b__) ____result.sunrise = __sunrise__;
            if(__sunset__b__) ____result.sunset = __sunset__;

            return ____result;
        }
    }


    public sealed class RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherUnderground.Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("response"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("current_observation"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hourly_forecast"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moon_phase"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sun_phase"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("query_zone"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("alerts"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("response"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("current_observation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hourly_forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moon_phase"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sun_phase"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("query_zone"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("alerts"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherUnderground.Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Response>().Serialize(ref writer, value.response, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Current_Observation>().Serialize(ref writer, value.current_observation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Forecast>().Serialize(ref writer, value.forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Hourly_Forecast[]>().Serialize(ref writer, value.hourly_forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Moon_Phase>().Serialize(ref writer, value.moon_phase, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sun_Phase>().Serialize(ref writer, value.sun_phase, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.query_zone);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Alert[]>().Serialize(ref writer, value.alerts, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherUnderground.Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __response__ = default(global::SimpleWeather.WeatherUnderground.Response);
            var __response__b__ = false;
            var __current_observation__ = default(global::SimpleWeather.WeatherUnderground.Current_Observation);
            var __current_observation__b__ = false;
            var __forecast__ = default(global::SimpleWeather.WeatherUnderground.Forecast);
            var __forecast__b__ = false;
            var __hourly_forecast__ = default(global::SimpleWeather.WeatherUnderground.Hourly_Forecast[]);
            var __hourly_forecast__b__ = false;
            var __moon_phase__ = default(global::SimpleWeather.WeatherUnderground.Moon_Phase);
            var __moon_phase__b__ = false;
            var __sun_phase__ = default(global::SimpleWeather.WeatherUnderground.Sun_Phase);
            var __sun_phase__b__ = false;
            var __query_zone__ = default(string);
            var __query_zone__b__ = false;
            var __alerts__ = default(global::SimpleWeather.WeatherUnderground.Alert[]);
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
                        __response__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Response>().Deserialize(ref reader, formatterResolver);
                        __response__b__ = true;
                        break;
                    case 1:
                        __current_observation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Current_Observation>().Deserialize(ref reader, formatterResolver);
                        __current_observation__b__ = true;
                        break;
                    case 2:
                        __forecast__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Forecast>().Deserialize(ref reader, formatterResolver);
                        __forecast__b__ = true;
                        break;
                    case 3:
                        __hourly_forecast__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Hourly_Forecast[]>().Deserialize(ref reader, formatterResolver);
                        __hourly_forecast__b__ = true;
                        break;
                    case 4:
                        __moon_phase__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Moon_Phase>().Deserialize(ref reader, formatterResolver);
                        __moon_phase__b__ = true;
                        break;
                    case 5:
                        __sun_phase__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Sun_Phase>().Deserialize(ref reader, formatterResolver);
                        __sun_phase__b__ = true;
                        break;
                    case 6:
                        __query_zone__ = reader.ReadString();
                        __query_zone__b__ = true;
                        break;
                    case 7:
                        __alerts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherUnderground.Alert[]>().Deserialize(ref reader, formatterResolver);
                        __alerts__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherUnderground.Rootobject();
            if(__response__b__) ____result.response = __response__;
            if(__current_observation__b__) ____result.current_observation = __current_observation__;
            if(__forecast__b__) ____result.forecast = __forecast__;
            if(__hourly_forecast__b__) ____result.hourly_forecast = __hourly_forecast__;
            if(__moon_phase__b__) ____result.moon_phase = __moon_phase__;
            if(__sun_phase__b__) ____result.sun_phase = __sun_phase__;
            if(__query_zone__b__) ____result.query_zone = __query_zone__;
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
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo
{
    using System;
    using Utf8Json;


    public sealed class LocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Location>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public LocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("woeid"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("region"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lat"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("long"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone_id"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("woeid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("region"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("long"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone_id"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Location value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.woeid);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.region);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteDouble(value.lat);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteDouble(value._long);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.timezone_id);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Location Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __woeid__ = default(int);
            var __woeid__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __region__ = default(string);
            var __region__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __lat__ = default(double);
            var __lat__b__ = false;
            var ___long__ = default(double);
            var ___long__b__ = false;
            var __timezone_id__ = default(string);
            var __timezone_id__b__ = false;

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
                        __woeid__ = reader.ReadInt32();
                        __woeid__b__ = true;
                        break;
                    case 1:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 2:
                        __region__ = reader.ReadString();
                        __region__b__ = true;
                        break;
                    case 3:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 4:
                        __lat__ = reader.ReadDouble();
                        __lat__b__ = true;
                        break;
                    case 5:
                        ___long__ = reader.ReadDouble();
                        ___long__b__ = true;
                        break;
                    case 6:
                        __timezone_id__ = reader.ReadString();
                        __timezone_id__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Location();
            if(__woeid__b__) ____result.woeid = __woeid__;
            if(__city__b__) ____result.city = __city__;
            if(__region__b__) ____result.region = __region__;
            if(__country__b__) ____result.country = __country__;
            if(__lat__b__) ____result.lat = __lat__;
            if(___long__b__) ____result._long = ___long__;
            if(__timezone_id__b__) ____result.timezone_id = __timezone_id__;

            return ____result;
        }
    }


    public sealed class WindFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Wind>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WindFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("chill"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("direction"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("speed"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("chill"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("direction"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("speed"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Wind value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.chill);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.direction);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.speed);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Wind Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __chill__ = default(int);
            var __chill__b__ = false;
            var __direction__ = default(int);
            var __direction__b__ = false;
            var __speed__ = default(float);
            var __speed__b__ = false;

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
                        __chill__ = reader.ReadInt32();
                        __chill__b__ = true;
                        break;
                    case 1:
                        __direction__ = reader.ReadInt32();
                        __direction__b__ = true;
                        break;
                    case 2:
                        __speed__ = reader.ReadSingle();
                        __speed__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Wind();
            if(__chill__b__) ____result.chill = __chill__;
            if(__direction__b__) ____result.direction = __direction__;
            if(__speed__b__) ____result.speed = __speed__;

            return ____result;
        }
    }


    public sealed class AtmosphereFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Atmosphere>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AtmosphereFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rising"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("pressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rising"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Atmosphere value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.pressure);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.rising);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.visibility);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Atmosphere Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __pressure__ = default(float);
            var __pressure__b__ = false;
            var __rising__ = default(int);
            var __rising__b__ = false;
            var __visibility__ = default(float);
            var __visibility__b__ = false;

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
                        __pressure__ = reader.ReadSingle();
                        __pressure__b__ = true;
                        break;
                    case 1:
                        __rising__ = reader.ReadInt32();
                        __rising__b__ = true;
                        break;
                    case 2:
                        __visibility__ = reader.ReadSingle();
                        __visibility__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Atmosphere();
            if(__pressure__b__) ____result.pressure = __pressure__;
            if(__rising__b__) ____result.rising = __rising__;
            if(__visibility__b__) ____result.visibility = __visibility__;

            return ____result;
        }
    }


    public sealed class AstronomyFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Astronomy>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AstronomyFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunrise"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunset"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("sunrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunset"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Astronomy value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.sunrise);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.sunset);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Astronomy Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __sunrise__ = default(string);
            var __sunrise__b__ = false;
            var __sunset__ = default(string);
            var __sunset__b__ = false;

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
                        __sunrise__ = reader.ReadString();
                        __sunrise__b__ = true;
                        break;
                    case 1:
                        __sunset__ = reader.ReadString();
                        __sunset__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Astronomy();
            if(__sunrise__b__) ____result.sunrise = __sunrise__;
            if(__sunset__b__) ____result.sunset = __sunset__;

            return ____result;
        }
    }


    public sealed class ConditionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Condition>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ConditionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("code"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("text"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("code"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("text"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Condition value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.code);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.temperature);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.text);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Condition Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __code__ = default(int);
            var __code__b__ = false;
            var __temperature__ = default(int);
            var __temperature__b__ = false;
            var __text__ = default(string);
            var __text__b__ = false;

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
                        __code__ = reader.ReadInt32();
                        __code__b__ = true;
                        break;
                    case 1:
                        __temperature__ = reader.ReadInt32();
                        __temperature__b__ = true;
                        break;
                    case 2:
                        __text__ = reader.ReadString();
                        __text__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Condition();
            if(__code__b__) ____result.code = __code__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__text__b__) ____result.text = __text__;

            return ____result;
        }
    }


    public sealed class Current_ObservationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Current_Observation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Current_ObservationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("atmosphere"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("astronomy"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("condition"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pubDate"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("wind"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("atmosphere"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("astronomy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("condition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pubDate"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Current_Observation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Wind>().Serialize(ref writer, value.wind, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Atmosphere>().Serialize(ref writer, value.atmosphere, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Astronomy>().Serialize(ref writer, value.astronomy, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Condition>().Serialize(ref writer, value.condition, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt64(value.pubDate);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Current_Observation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __wind__ = default(global::SimpleWeather.WeatherYahoo.Wind);
            var __wind__b__ = false;
            var __atmosphere__ = default(global::SimpleWeather.WeatherYahoo.Atmosphere);
            var __atmosphere__b__ = false;
            var __astronomy__ = default(global::SimpleWeather.WeatherYahoo.Astronomy);
            var __astronomy__b__ = false;
            var __condition__ = default(global::SimpleWeather.WeatherYahoo.Condition);
            var __condition__b__ = false;
            var __pubDate__ = default(long);
            var __pubDate__b__ = false;

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
                        __wind__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Wind>().Deserialize(ref reader, formatterResolver);
                        __wind__b__ = true;
                        break;
                    case 1:
                        __atmosphere__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Atmosphere>().Deserialize(ref reader, formatterResolver);
                        __atmosphere__b__ = true;
                        break;
                    case 2:
                        __astronomy__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Astronomy>().Deserialize(ref reader, formatterResolver);
                        __astronomy__b__ = true;
                        break;
                    case 3:
                        __condition__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Condition>().Deserialize(ref reader, formatterResolver);
                        __condition__b__ = true;
                        break;
                    case 4:
                        __pubDate__ = reader.ReadInt64();
                        __pubDate__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Current_Observation();
            if(__wind__b__) ____result.wind = __wind__;
            if(__atmosphere__b__) ____result.atmosphere = __atmosphere__;
            if(__astronomy__b__) ____result.astronomy = __astronomy__;
            if(__condition__b__) ____result.condition = __condition__;
            if(__pubDate__b__) ____result.pubDate = __pubDate__;

            return ____result;
        }
    }


    public sealed class ForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Forecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("code"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("date"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("day"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("high"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("low"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("text"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("code"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("date"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("day"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("high"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("low"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("text"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Forecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.code);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt64(value.date);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.day);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.high);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value.low);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.text);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Forecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __code__ = default(int);
            var __code__b__ = false;
            var __date__ = default(long);
            var __date__b__ = false;
            var __day__ = default(string);
            var __day__b__ = false;
            var __high__ = default(int);
            var __high__b__ = false;
            var __low__ = default(int);
            var __low__b__ = false;
            var __text__ = default(string);
            var __text__b__ = false;

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
                        __code__ = reader.ReadInt32();
                        __code__b__ = true;
                        break;
                    case 1:
                        __date__ = reader.ReadInt64();
                        __date__b__ = true;
                        break;
                    case 2:
                        __day__ = reader.ReadString();
                        __day__b__ = true;
                        break;
                    case 3:
                        __high__ = reader.ReadInt32();
                        __high__b__ = true;
                        break;
                    case 4:
                        __low__ = reader.ReadInt32();
                        __low__b__ = true;
                        break;
                    case 5:
                        __text__ = reader.ReadString();
                        __text__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Forecast();
            if(__code__b__) ____result.code = __code__;
            if(__date__b__) ____result.date = __date__;
            if(__day__b__) ____result.day = __day__;
            if(__high__b__) ____result.high = __high__;
            if(__low__b__) ____result.low = __low__;
            if(__text__b__) ____result.text = __text__;

            return ____result;
        }
    }


    public sealed class RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("location"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("current_observation"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecasts"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("location"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("current_observation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecasts"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Location>().Serialize(ref writer, value.location, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Current_Observation>().Serialize(ref writer, value.current_observation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Forecast[]>().Serialize(ref writer, value.forecasts, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __location__ = default(global::SimpleWeather.WeatherYahoo.Location);
            var __location__b__ = false;
            var __current_observation__ = default(global::SimpleWeather.WeatherYahoo.Current_Observation);
            var __current_observation__b__ = false;
            var __forecasts__ = default(global::SimpleWeather.WeatherYahoo.Forecast[]);
            var __forecasts__b__ = false;

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
                        __location__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Location>().Deserialize(ref reader, formatterResolver);
                        __location__b__ = true;
                        break;
                    case 1:
                        __current_observation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Current_Observation>().Deserialize(ref reader, formatterResolver);
                        __current_observation__b__ = true;
                        break;
                    case 2:
                        __forecasts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Forecast[]>().Deserialize(ref reader, formatterResolver);
                        __forecasts__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Rootobject();
            if(__location__b__) ____result.location = __location__;
            if(__current_observation__b__) ____result.current_observation = __current_observation__;
            if(__forecasts__b__) ____result.forecasts = __forecasts__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
