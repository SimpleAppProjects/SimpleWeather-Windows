using Microsoft.EntityFrameworkCore;
using SimpleWeather.EF.Extensions;
using SimpleWeather.Location;
using SimpleWeather.WeatherData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SimpleWeather.Utils
{
    public static partial class Settings
    {
        // Settings Members
        public static bool WeatherLoaded { get { return IsWeatherLoaded(); } set { SetWeatherLoaded(value); } }
        public static bool OnBoardComplete { get { return IsOnBoardingComplete(); } set { SetOnBoardingComplete(value); } }
        public static string Unit { get { return GetTempUnit(); } set { SetTempUnit(value); } }
        public static string API { get { return GetAPI(); } set { SetAPI(value); } }
        public static string API_KEY { get { return GetAPIKEY(); } set { SetAPIKEY(value); } }
        public static bool KeyVerified { get { return IsKeyVerified(); } set { SetKeyVerified(value); } }
        public static bool IsFahrenheit { get { return Unit == Fahrenheit; } }
        public static bool FollowGPS { get { return UseFollowGPS(); } set { SetFollowGPS(value); } }
        private static string LastGPSLocation { get { return GetLastGPSLocation(); } set { SetLastGPSLocation(value); } }
        public static LocationData HomeData { get { return GetHomeData(); } }
        public static DateTime UpdateTime { get { return GetUpdateTime(); } set { SetUpdateTime(value); } }
        public static int RefreshInterval { get { return GetRefreshInterval(); } set { SetRefreshInterval(value); } }
        public static bool ShowAlerts { get { return UseAlerts(); } set { SetAlerts(value); } }
        public static bool UsePersonalKey { get { return IsPersonalKey(); } set { SetPersonalKey(value); } }
        public static int VersionCode { get { return GetVersionCode(); } set { SetVersionCode(value); } }

        // Database
        internal static int DBVersion { get { return GetDBVersion(); } set { SetDBVersion(value); } }

        // Data
        internal const int CurrentDBVersion = 5;
        internal static String locDBConnStr;
        internal static String wtrDBConnStr;
        private const int CACHE_LIMIT = 25;
        public const int MAX_LOCATIONS = 10;

        // Units
        public const string Fahrenheit = "F";
        public const string Celsius = "C";
        private const string DEFAULT_UPDATE_INTERVAL = "60"; // 60 minutes (1hr)
        public const int DefaultInterval = 60;
        public const int READ_TIMEOUT = 10000; // 10s

        // Settings Keys
        private const string KEY_API = "API";
        private const string KEY_APIKEY = "API_KEY";
        private const string KEY_APIKEY_VERIFIED = "API_KEY_VERIFIED";
        public const string KEY_USECELSIUS = "key_usecelsius";
        public const string KEY_UNITS = "Units";
        private const string KEY_WEATHERLOADED = "weatherLoaded";
        private const string KEY_FOLLOWGPS = "key_followgps";
        private const string KEY_LASTGPSLOCATION = "key_lastgpslocation";
        public const string KEY_REFRESHINTERVAL = "key_refreshinterval";
        private const string KEY_UPDATETIME = "key_updatetime";
        private const string KEY_DBVERSION = "key_dbversion";
        public const string KEY_USEALERTS = "key_usealerts";
        private const string KEY_USEPERSONALKEY = "key_usepersonalkey";
        private const string KEY_CURRENTVERSION = "key_currentversion";
        private const string KEY_ONBOARDINGCOMPLETE = "key_onboardcomplete";
        private const string KEY_USERTHEME = "key_usertheme";

        // Weather Data
        private static LocationData lastGPSLocData = new LocationData();
        private static bool loaded = false;

        static Settings()
        {
            Init();
        }

        public static async Task LoadIfNeeded()
        {
            if (!loaded)
            {
                await Load();
                loaded = true;
            }
        }

        private static async Task Load()
        {
            using (var weatherDB = new WeatherDBContext())
            using (var locationDB = new LocationDBContext())
            {
                if ((await weatherDB.Database.GetPendingMigrationsAsync()).Any())
                    await weatherDB.Database.MigrateAsync();
                if ((await locationDB.Database.GetPendingMigrationsAsync()).Any())
                    await locationDB.Database.MigrateAsync();

                // Migrate old data if available
                await DataMigrations.PerformDBMigrations(weatherDB, locationDB);

                if (!String.IsNullOrWhiteSpace(LastGPSLocation))
                {
                    try
                    {
                        var jsonTextReader = new Utf8Json.JsonReader(System.Text.Encoding.UTF8.GetBytes(LastGPSLocation));
                        lastGPSLocData = new LocationData();
                        lastGPSLocData.FromJson(ref jsonTextReader);
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLine(LoggerLevel.Error, ex, "SimpleWeather: Settings.Load(): LastGPSLocation");
                    }
                    finally
                    {
                        if (lastGPSLocData == null || !lastGPSLocData.IsValid())
                            lastGPSLocData = new LocationData();
                    }
                }

                DataMigrations.PerformVersionMigrations(weatherDB, locationDB);
            }
        }

        public static ConfiguredTaskAwaitable<IEnumerable<LocationData>> GetFavorites()
        {
            return AsyncTask.RunAsync<IEnumerable<LocationData>>(async () =>
            {
                await LoadIfNeeded();

                using (var locationDB = new LocationDBContext())
                {
                    var query = locationDB.Locations.FromSqlRaw<LocationData>(
                        "select locations.* from locations INNER JOIN favorites on locations.query = favorites.query ORDER by favorites.position");
                    return await query.ToListAsync();
                }
            });
        }

        public static ConfiguredTaskAwaitable<IEnumerable<LocationData>> GetLocationData()
        {
            return AsyncTask.RunAsync<IEnumerable<LocationData>>(async () =>
            {
                await LoadIfNeeded();
                using (var locationDB = new LocationDBContext())
                {
                    return await AsyncTask.RunAsync(locationDB.Locations.ToListAsync());
                }
            });
        }

        public static ConfiguredTaskAwaitable<LocationData> GetLocation(string key)
        {
            return AsyncTask.RunAsync(async () =>
            {
                await LoadIfNeeded();
                using (var locationDB = new LocationDBContext())
                {
                    return await AsyncTask.RunAsync(locationDB.Locations.FindAsync(key));
                }
            });
        }

        public static ConfiguredTaskAwaitable<Weather> GetWeatherData(string key)
        {
            return AsyncTask.RunAsync(async () =>
            {
                await LoadIfNeeded();
                using (var weatherDB = new WeatherDBContext())
                {
                    return await AsyncTask.RunAsync(weatherDB.WeatherData.FindAsync(key));
                }
            });
        }

        public static ConfiguredTaskAwaitable<Weather> GetWeatherDataByCoordinate(LocationData location)
        {
            return AsyncTask.RunAsync(async () =>
            {
                await LoadIfNeeded();
                using (var weatherDB = new WeatherDBContext())
                {
                    var culture = System.Globalization.CultureInfo.InvariantCulture;
                    var query = String.Format(culture, "\\\"latitude\\\":\\\"{0}\\\",\\\"longitude\\\":\\\"{1}\\\"",
                            location.latitude.ToString(culture), location.longitude.ToString(culture));
                    var filteredData = await weatherDB.WeatherData.FromSqlRaw("SELECT * FROM weatherdata WHERE `locationblob` LIKE {0} LIMIT 1", "%" + query + "%")
                                                                  .FirstOrDefaultAsync();

                    return filteredData;
                }
            });
        }

        public static ConfiguredTaskAwaitable<ICollection<WeatherAlert>> GetWeatherAlertData(string key)
        {
            return AsyncTask.RunAsync(async () =>
            {
                await LoadIfNeeded();

                using (var weatherDB = new WeatherDBContext())
                {
                    ICollection<WeatherAlert> alerts = null;

                    try
                    {
                        var weatherAlertData = await AsyncTask.RunAsync(weatherDB.WeatherAlerts.FindAsync(key));

                        if (weatherAlertData != null && weatherAlertData.alerts != null)
                            alerts = weatherAlertData.alerts;
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLine(LoggerLevel.Error, ex, "SimpleWeather: Settings.GetWeatherAlertData()");
                    }
                    finally
                    {
                        if (alerts == null)
                            alerts = new List<WeatherAlert>();
                    }

                    return alerts;
                }
            });
        }

        public static ConfiguredTaskAwaitable<Forecasts> GetWeatherForecastData(string key)
        {
            return AsyncTask.RunAsync(async () =>
            {
                await LoadIfNeeded();
                using (var weatherDB = new WeatherDBContext())
                {
                    return await AsyncTask.RunAsync(weatherDB.Forecasts.FindAsync(key));
                }
            });
        }

        public static ConfiguredTaskAwaitable<IList<HourlyForecast>> GetHourlyWeatherForecastData(string key)
        {
            return AsyncTask.RunAsync<IList<HourlyForecast>>(async () =>
            {
                await LoadIfNeeded();
                using (var weatherDB = new WeatherDBContext())
                {
                    return await AsyncTask.RunAsync(weatherDB.HourlyForecasts
                                                             .Where(hrf => hrf.query == key)
                                                             .OrderBy(hrf => hrf.dateblob)
                                                             .Select(hrf => hrf.hr_forecast)
                                                             .ToListAsync());
                }
            });
        }

        public static ConfiguredTaskAwaitable<LocationData> GetLastGPSLocData()
        {
            return AsyncTask.RunAsync(async () =>
            {
                await LoadIfNeeded();

                if (lastGPSLocData != null && lastGPSLocData.locationType != LocationType.GPS)
                    lastGPSLocData.locationType = LocationType.GPS;

                return lastGPSLocData;
            });
        }

        public static ConfiguredTaskAwaitable SaveWeatherData(Weather weather)
        {
            return AsyncTask.RunAsync(async () =>
            {
                using (var weatherDB = new WeatherDBContext())
                {
                    if (weather != null && weather.IsValid())
                    {
                        // InsertOrReplaceAsync
                        await AsyncTask.RunAsync(weatherDB.AddOrUpdateAsync(weather, weather.query));
                        await weatherDB.SaveChangesAsync();
                    }

                    if (await AsyncTask.RunAsync(weatherDB.WeatherData.CountAsync()) > CACHE_LIMIT)
                        CleanupWeatherData();
                }
            });
        }

        public static ConfiguredTaskAwaitable SaveWeatherAlerts(LocationData location, ICollection<WeatherAlert> alerts)
        {
            return AsyncTask.RunAsync(async () =>
            {
                using (var weatherDB = new WeatherDBContext())
                {
                    if (location != null && location.IsValid())
                    {
                        var alertdata = new WeatherAlerts(location.query, alerts);
                        // InsertOrReplaceAsync
                        await AsyncTask.RunAsync(weatherDB.AddOrUpdateAsync(alertdata, alertdata.query));
                        await weatherDB.SaveChangesAsync();
                    }

                    if (await AsyncTask.RunAsync(weatherDB.WeatherAlerts.CountAsync()) > CACHE_LIMIT)
                        CleanupWeatherAlertData();
                }
            });
        }

        public static ConfiguredTaskAwaitable SaveWeatherForecasts(Forecasts forecasts)
        {
            return AsyncTask.RunAsync(async () =>
            {
                using (var weatherDB = new WeatherDBContext())
                {
                    if (forecasts != null)
                    {
                        // InsertOrReplaceAsync
                        await AsyncTask.RunAsync(weatherDB.AddOrUpdateAsync(forecasts, forecasts.query));
                        await weatherDB.SaveChangesAsync();
                    }

                    if (await AsyncTask.RunAsync(weatherDB.Forecasts.CountAsync()) > CACHE_LIMIT / 2)
                    {
                        CleanupWeatherForecastData();
                    }
                }
            });
        }

        public static ConfiguredTaskAwaitable SaveWeatherForecasts(LocationData location, IEnumerable<HourlyForecasts> forecasts)
        {
            return AsyncTask.RunAsync(async () =>
            {
                using (var weatherDB = new WeatherDBContext())
                {
                    await AsyncTask.RunAsync(weatherDB.Database.ExecuteSqlRawAsync("delete from hr_forecasts where query = {0}", location.query));
                    if (forecasts != null)
                    {
                        foreach (var fcast in forecasts)
                        {
                            // InsertOrReplaceAsync
                            await AsyncTask.RunAsync(weatherDB.AddOrUpdateAsync(fcast, fcast.query, fcast.dateblob));
                        }
                    }

                    await weatherDB.SaveChangesAsync();

                    if (await AsyncTask.RunAsync(weatherDB.HourlyForecasts.GroupBy(f => f.query)
                                                                          .Select(f => f.Key)
                                                                          .CountAsync()) > CACHE_LIMIT / 2)
                    {
                        CleanupWeatherForecastData();
                    }
                }
            });
        }

        private static void CleanupWeatherData()
        {
            AsyncTask.Run(async () =>
            {
                using (var locationDB = new LocationDBContext())
                using (var weatherDB = new WeatherDBContext())
                {
                    var locs = await AsyncTask.RunAsync(locationDB.Locations.ToListAsync());
                    if (FollowGPS) locs.Add(lastGPSLocData);
                    var data = weatherDB.WeatherData;
                    var weatherToDelete = data.Where(w => locs.All(l => l.query != w.query));

                    await weatherToDelete.ForEachAsync(async w =>
                    {
                        await AsyncTask.RunAsync(() => weatherDB.Remove(w));
                    });

                    await weatherDB.SaveChangesAsync();
                }
            });
        }

        private static void CleanupWeatherForecastData()
        {
            AsyncTask.Run(async () =>
            {
                using (var locationDB = new LocationDBContext())
                using (var weatherDB = new WeatherDBContext())
                {
                    var locs = await AsyncTask.RunAsync(locationDB.Locations.ToListAsync());
                    if (FollowGPS) locs.Add(lastGPSLocData);
                    var forecastsToDelete = weatherDB.Forecasts.Where(f => locs.All(l => l.query != f.query));
                    var hrForecastsToDelete = weatherDB.HourlyForecasts.Where(hrf => locs.All(l => l.query != hrf.query))
                                                                       .GroupBy(hrf => hrf.query)
                                                                       .Select(hrf => hrf.Key);

                    await forecastsToDelete.ForEachAsync(async w =>
                    {
                        await AsyncTask.RunAsync(() => weatherDB.Remove(w));
                    });

                    await hrForecastsToDelete.ForEachAsync(async q =>
                    {
                        await AsyncTask.RunAsync(weatherDB.Database.ExecuteSqlRawAsync("delete from hr_forecasts where query = {0}", q));
                    });

                    await weatherDB.SaveChangesAsync();
                }
            });
        }

        private static void CleanupWeatherAlertData()
        {
            AsyncTask.Run(async () =>
            {
                using (var locationDB = new LocationDBContext())
                using (var weatherDB = new WeatherDBContext())
                {
                    var locs = await AsyncTask.RunAsync(locationDB.Locations.ToListAsync());
                    if (FollowGPS) locs.Add(lastGPSLocData);
                    var data = weatherDB.WeatherAlerts;
                    var weatherToDelete = data.Where(w => locs.All(l => l.query != w.query));

                    await weatherToDelete.ForEachAsync(async w =>
                    {
                        await AsyncTask.RunAsync(() => weatherDB.Remove(w));
                    });

                    await weatherDB.SaveChangesAsync();
                }
            });
        }

        public static ConfiguredTaskAwaitable SaveLocationData(List<LocationData> locationData)
        {
            return AsyncTask.RunAsync(async () =>
            {
                if (locationData != null)
                {
                    using (var locationDB = new LocationDBContext())
                    {
                        for (int i = 0; i < locationData.Count; i++)
                        {
                            var loc = locationData[i];

                            if (loc != null && loc.IsValid())
                            {
                                // InsertOrReplaceAsync
                                await AsyncTask.RunAsync(locationDB.AddOrUpdateAsync(loc, loc.query));
                                var fav = new Favorites() { query = loc.query, position = i };
                                await AsyncTask.RunAsync(locationDB.AddOrUpdateAsync(fav, fav.query));
                            }
                        }

                        var locs = locationDB.Locations;
                        var locToDelete = locs.Where(l => locationData.All(l2 => !l2.Equals(l)));
                        int count = await locToDelete.CountAsync();

                        if (count > 0)
                        {
                            await locToDelete.ForEachAsync(async loc =>
                            {
                                await AsyncTask.RunAsync(() => locationDB.Remove(loc));
                                await AsyncTask.RunAsync(locationDB.Database.ExecuteSqlRawAsync("delete from favorites where query = {0}", loc.query));
                            });
                        }

                        await locationDB.SaveChangesAsync();
                    }
                }
            });
        }

        public static ConfiguredTaskAwaitable AddLocation(LocationData location)
        {
            return AsyncTask.RunAsync(async () =>
            {
                // We only store searched locations in the db
                // GPS location is stored in [the] local settings [container]
                if (location?.locationType == LocationType.Search && location?.IsValid() == true)
                {
                    using (var locationDB = new LocationDBContext())
                    {
                        // InsertOrReplaceAsync
                        await AsyncTask.RunAsync(locationDB.AddOrUpdateAsync(location, location.query));
                        int pos = await AsyncTask.RunAsync(locationDB.Locations.CountAsync());
                        var f = new Favorites() { query = location.query, position = pos };
                        await AsyncTask.RunAsync(locationDB.AddOrUpdateAsync(f, f.query));
                        await locationDB.SaveChangesAsync();
                    }
                }
            });
        }

        public static ConfiguredTaskAwaitable UpdateLocation(LocationData location)
        {
            return AsyncTask.RunAsync(async () =>
            {
                // We only store searched locations in the db
                // GPS location is stored in [the] local settings [container]
                if (location?.locationType == LocationType.Search && location?.IsValid() == true)
                {
                    using (var locationDB = new LocationDBContext())
                    {
                        // Update
                        await AsyncTask.RunAsync(locationDB.AddOrUpdateAsync(location, location.query));
                        await locationDB.SaveChangesAsync();
                    }
                }
            });
        }

        public static ConfiguredTaskAwaitable UpdateLocationWithKey(LocationData location, string oldKey)
        {
            return AsyncTask.RunAsync(async () =>
            {
                if (location != null && location.IsValid() && !String.IsNullOrWhiteSpace(oldKey))
                {
                    using (var locationDB = new LocationDBContext())
                    {
                        // Get position from favorites table
                        var favs = locationDB.Favorites;
                        var fav = await AsyncTask.RunAsync(favs.FirstOrDefaultAsync(f => f.query == oldKey));

                        if (fav == null)
                        {
                            return;
                        }

                        int pos = fav.position;

                        // Remove location from table
                        await AsyncTask.RunAsync(locationDB.Database.ExecuteSqlRawAsync("delete from locations where query = {0}", oldKey));
                        await AsyncTask.RunAsync(locationDB.Database.ExecuteSqlRawAsync("delete from favorites where query = {0}", oldKey));

                        // Add updated location with new query (pkey)
                        // InsertOrReplaceAsync
                        await AsyncTask.RunAsync(locationDB.AddOrUpdateAsync(location, location.query));
                        var fv = new Favorites() { query = location.query, position = pos };
                        await AsyncTask.RunAsync(locationDB.AddOrUpdateAsync(fv, fv.query));

                        await locationDB.SaveChangesAsync();
                    }
                }
            });
        }

        public static ConfiguredTaskAwaitable DeleteLocations()
        {
            return AsyncTask.RunAsync(async () =>
            {
                using (var locationDB = new LocationDBContext())
                {
                    await AsyncTask.RunAsync(locationDB.Database.ExecuteSqlRawAsync("delete from locations"));
                    await AsyncTask.RunAsync(locationDB.Database.ExecuteSqlRawAsync("delete from favorites"));
                    await locationDB.SaveChangesAsync();
                }
            });
        }

        public static ConfiguredTaskAwaitable DeleteLocation(string key)
        {
            return AsyncTask.RunAsync(async () =>
            {
                if (!String.IsNullOrWhiteSpace(key))
                {
                    using (var locationDB = new LocationDBContext())
                    {
                        await AsyncTask.RunAsync(locationDB.Database.ExecuteSqlRawAsync("delete from locations where query = {0}", key));
                        await AsyncTask.RunAsync(locationDB.Database.ExecuteSqlRawAsync("delete from favorites where query = {0}", key));
                        await ResetPosition();
                        await locationDB.SaveChangesAsync();
                    }
                }
            });
        }

        public static ConfiguredTaskAwaitable MoveLocation(string key, int toPos)
        {
            return AsyncTask.RunAsync(async () =>
            {
                if (!String.IsNullOrWhiteSpace(key))
                {
                    using (var locationDB = new LocationDBContext())
                    {
                        await AsyncTask.RunAsync(locationDB.Database.ExecuteSqlRawAsync("update favorites set position = {0} where query = {1}", toPos, key));
                        await locationDB.SaveChangesAsync();
                    }
                }
            });
        }

        private static ConfiguredTaskAwaitable ResetPosition()
        {
            return AsyncTask.RunAsync(async () =>
            {
                using (var locationDB = new LocationDBContext())
                {
                    var favs = await AsyncTask.RunAsync(locationDB.Favorites.OrderBy(f => f.position).ToListAsync());
                    foreach (Favorites fav in favs)
                    {
                        // UpdateAsync
                        fav.position = favs.IndexOf(fav);
                        await AsyncTask.RunAsync(locationDB.AddOrUpdateAsync(fav, fav.query));
                    }

                    await locationDB.SaveChangesAsync();
                }
            });
        }

        public static void SaveLastGPSLocData(LocationData data)
        {
            lastGPSLocData = data;
            LastGPSLocation = lastGPSLocData?.ToJson();
        }

        private static LocationData GetHomeData()
        {
            LocationData homeData = null;

            if (FollowGPS)
                homeData = AsyncTask.RunAsync(async () => await GetLastGPSLocData()).GetAwaiter().GetResult();
            else
                homeData = AsyncTask.RunAsync(async () => (await GetFavorites()).FirstOrDefault()).GetAwaiter().GetResult();

            return homeData;
        }
    }
}