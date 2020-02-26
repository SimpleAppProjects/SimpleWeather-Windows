using Microsoft.EntityFrameworkCore;
using SimpleWeather.Location;
using SimpleWeather.WeatherData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleWeather.Utils
{
    public class WeatherDBContext : DbContext
    {
        public DbSet<Weather> WeatherData { get; set; }
        public DbSet<Forecasts> Forecasts { get; set; }
        public DbSet<HourlyForecasts> HourlyForecasts { get; set; }
        public DbSet<WeatherAlerts> WeatherAlerts { get; set; }

        public WeatherDBContext()
            : base()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
#if WINDOWS_UWP
            options.UseSqlite($"Data Source={Settings.wtrDBConnStr}");
#else
            options.UseSqlite("Data Source=weatherdata.db");
#endif
#if DEBUG
            options.EnableSensitiveDataLogging();
#endif
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Weather>()
                .Property(w => w.location)
                .HasConversion(
                    value => JSONParser.Serializer(value),
                    value => DBDeserializer<WeatherData.Location>(value));

            modelBuilder.Entity<Weather>()
                .Property(w => w.condition)
                .HasConversion(
                    value => JSONParser.Serializer(value),
                    value => DBDeserializer<Condition>(value));

            modelBuilder.Entity<Weather>()
                .Property(w => w.atmosphere)
                .HasConversion(
                    value => JSONParser.Serializer(value),
                    value => DBDeserializer<Atmosphere>(value));

            modelBuilder.Entity<Weather>()
                .Property(w => w.astronomy)
                .HasConversion(
                    value => JSONParser.Serializer(value),
                    value => DBDeserializer<Astronomy>(value));

            modelBuilder.Entity<Weather>()
                .Property(w => w.precipitation)
                .HasConversion(
                    value => JSONParser.Serializer(value),
                    value => DBDeserializer<Precipitation>(value));

            modelBuilder.Entity<Forecasts>()
                .Property(f => f.forecast)
                .HasConversion(
                    value => JSONParser.Serializer(value),
                    value => DBDeserializer<IList<Forecast>>(value));

            modelBuilder.Entity<Forecasts>()
                .Property(f => f.txt_forecast)
                .HasConversion(
                    value => JSONParser.Serializer(value),
                    value => DBDeserializer<IList<TextForecast>>(value));

            modelBuilder.Entity<HourlyForecasts>()
                .HasKey(f => new { f.query, f.dateblob });

            modelBuilder.Entity<HourlyForecasts>()
                .Property(f => f.hr_forecast)
                .HasConversion(
                    value => JSONParser.Serializer(value),
                    value => DBDeserializer<HourlyForecast>(value));

            modelBuilder.Entity<WeatherAlerts>()
                .Property(a => a.alerts)
                .HasConversion(
                    value => JSONParser.Serializer(value),
                    value => DBDeserializer<ICollection<WeatherAlert>>(value));
        }

        private T DBDeserializer<T>(string value)
        {
            bool useAttrResolver;
            string str;

            // Use our own resolver (custom deserializer) if json string is escaped
            // since the Utf8Json deserializer is alot more strict
            if (value.Contains("\"{\\\""))
            {
                str = value;
                useAttrResolver = true;
            }
            else
            {
                var unescape = new StringBuilder(System.Text.RegularExpressions.Regex.Unescape(value));
                if (unescape.Length > 1 && unescape[0] == '"' && unescape[unescape.Length - 1] == '"')
                {
                    unescape.Remove(0, 1);
                    unescape.Remove(unescape.Length - 1, 1);
                }
                str = unescape.ToString();
                useAttrResolver = str.Contains("\\") || str.Contains("[\"{\"") || str.Contains("\"{\"");
            }

            return Utf8Json.JsonSerializer.Deserialize<T>(str, useAttrResolver ? EF.Utf8JsonGen.AttrFirstUtf8JsonResolver.Instance : JSONParser.Resolver);
        }
    }

    public class LocationDBContext : DbContext
    {
        public DbSet<LocationData> Locations { get; set; }
        public DbSet<Favorites> Favorites { get; set; }

        public LocationDBContext()
            : base()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
#if WINDOWS_UWP
            options.UseSqlite($"Data Source={Settings.locDBConnStr}");
#else
            options.UseSqlite("Data Source=locations.db");
#endif
#if DEBUG
            options.EnableSensitiveDataLogging();
#endif
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationData>()
                .Property(l => l.locationType)
                .HasConversion<int>();
        }
    }
}