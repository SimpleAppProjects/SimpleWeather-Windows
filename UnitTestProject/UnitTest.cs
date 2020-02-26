using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleWeather.HERE;
using SimpleWeather.Keys;
using SimpleWeather.Location;
using SimpleWeather.Utils;
using SimpleWeather.WeatherData;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestInitialize]
        public void Initialize()
        {
            Settings.LoadIfNeeded().GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetWeather
        /// </summary>
        /// <param name="providerImpl"></param>
        /// <returns></returns>
        /// <exception cref="WeatherException">Ignore.</exception>
        private async Task<Weather> GetWeather(WeatherProviderImpl providerImpl)
        {
            var location = await providerImpl.GetLocation(new WeatherUtils.Coordinate(47.6721646, -122.1706614));
            var locData = new LocationData(location);
            return await providerImpl.GetWeather(locData);
        }

        private async Task<bool> SerializerTest(Weather weather)
        {
            var serialStr = await JSONParser.SerializerAsync(weather);
            var deserialWeather = await JSONParser.DeserializerAsync<Weather>(serialStr);
            var fcast = new Forecasts(weather.query, weather.forecast, weather.txt_forecast);
            var serialFcast = await JSONParser.SerializerAsync(fcast);
            var deserialfcast = await JSONParser.DeserializerAsync<Forecasts>(serialFcast);
            bool testSuccess = Object.Equals(weather, deserialWeather) && string.Equals(fcast?.query, deserialfcast?.query) &&
                fcast?.forecast?.Count == deserialfcast?.forecast?.Count && fcast?.txt_forecast?.Count == deserialfcast?.txt_forecast?.Count;
            if (weather.hr_forecast?.Count > 0)
            {
                var hfcast = new HourlyForecasts(weather.query, weather.hr_forecast?[0]);
                var serialHr = await JSONParser.SerializerAsync(hfcast);
                var deserialHr = await JSONParser.DeserializerAsync<HourlyForecasts>(serialHr);
                testSuccess = testSuccess && string.Equals(fcast?.query, deserialfcast?.query) &&
                    Object.Equals(hfcast?.hr_forecast, deserialHr?.hr_forecast) && hfcast?.date == deserialHr?.date;
            }
            return testSuccess;
        }

        private const int SERIALIZER_RUNS = 5;

        private void SerializerSpeedTest(Weather weather)
        {
            for (int i = 0; i < SERIALIZER_RUNS; i++)
            {
                var watch1 = System.Diagnostics.Stopwatch.StartNew();
                string customJson = weather.ToJson();
                watch1.Stop();
                System.Diagnostics.Debug.WriteLine("Serialize #{2}: Weather - {0} (Custom): {1}", weather.source, watch1.Elapsed, i + 1);

                watch1 = System.Diagnostics.Stopwatch.StartNew();
                var customWeather = new Weather();
                var customReader = new Utf8Json.JsonReader(System.Text.Encoding.UTF8.GetBytes(customJson));
                customWeather.FromJson(ref customReader);
                watch1.Stop();
                System.Diagnostics.Debug.WriteLine("Deserialize #{2}: Weather - {0} (Custom): {1}", customWeather.source, watch1.Elapsed, i + 1);
            }

            System.GC.Collect();
            Task.Delay(5000);

            for (int i = 0; i < SERIALIZER_RUNS; i++)
            {
                var watch2 = System.Diagnostics.Stopwatch.StartNew();
                string utf8Json = JSONParser.Serializer(weather);
                watch2.Stop();
                System.Diagnostics.Debug.WriteLine("Serialize #{2}: Weather - {0} (UTF8JsonGen): {1}", weather.source, watch2.Elapsed, i + 1);

                watch2 = System.Diagnostics.Stopwatch.StartNew();
                var utf8Weather = JSONParser.Deserializer<Weather>(utf8Json);
                watch2.Stop();
                System.Diagnostics.Debug.WriteLine("Deserialize #{2}: Weather - {0} (UTF8JsonGen): {1}", utf8Weather.source, watch2.Elapsed, i + 1);
            }
        }

        [TestMethod]
        public void GetHereWeather()
        {
            var provider = WeatherManager.GetProvider(WeatherAPI.Here);
            var weather = GetWeather(provider).ConfigureAwait(false).GetAwaiter().GetResult();
            Assert.IsTrue(weather?.IsValid() == true);
            //Assert.IsTrue(SerializerTest(weather).ConfigureAwait(false).GetAwaiter().GetResult());
            //SerializerSpeedTest(weather);
        }

        [TestMethod]
        public void GetYahooWeather()
        {
            var provider = WeatherManager.GetProvider(WeatherAPI.Yahoo);
            var weather = GetWeather(provider).ConfigureAwait(false).GetAwaiter().GetResult();
            Assert.IsTrue(weather?.IsValid() == true);
            //Assert.IsTrue(SerializerTest(weather).ConfigureAwait(false).GetAwaiter().GetResult());
            //SerializerSpeedTest(weather);
        }

        [TestMethod]
        public void GetMetNoWeather()
        {
            var provider = WeatherManager.GetProvider(WeatherAPI.MetNo);
            var weather = GetWeather(provider).ConfigureAwait(false).GetAwaiter().GetResult();
            Assert.IsTrue(weather?.IsValid() == true);
            //Assert.IsTrue(SerializerTest(weather).ConfigureAwait(false).GetAwaiter().GetResult());
            //SerializerSpeedTest(weather);
        }

        [TestMethod]
        public void GetNWSWeather()
        {
            var provider = WeatherManager.GetProvider(WeatherAPI.NWS);
            var weather = GetWeather(provider).ConfigureAwait(false).GetAwaiter().GetResult();
            Assert.IsTrue(weather?.IsValid() == true);
            //Assert.IsTrue(SerializerTest(weather).ConfigureAwait(false).GetAwaiter().GetResult());
            //SerializerSpeedTest(weather);
        }

        [TestMethod]
        public void GetOWMWeather()
        {
            var provider = WeatherManager.GetProvider(WeatherAPI.OpenWeatherMap);
            var weather = GetWeather(provider).ConfigureAwait(false).GetAwaiter().GetResult();
            Assert.IsTrue(weather?.IsValid() == true);
            //Assert.IsTrue(SerializerTest(weather).ConfigureAwait(false).GetAwaiter().GetResult());
            //SerializerSpeedTest(weather);
        }

        [TestMethod]
        public void GetHEREOAuthToken()
        {
            var token = HEREOAuthUtils.GetBearerToken(true).ConfigureAwait(false).GetAwaiter().GetResult();
            Assert.IsTrue(!String.IsNullOrWhiteSpace(token));
        }
    }
}