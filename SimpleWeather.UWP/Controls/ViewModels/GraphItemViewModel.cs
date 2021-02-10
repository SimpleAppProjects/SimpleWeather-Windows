﻿using SimpleWeather.Icons;
using SimpleWeather.Utils;
using SimpleWeather.UWP.Controls.Graphs;
using SimpleWeather.WeatherData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWeather.UWP.Controls
{
    public class GraphItemViewModel
    {
        public EntryData<XLabelData, GraphTemperature> TempEntryData { get; private set; }
        public EntryData<XLabelData, YEntryData> WindEntryData { get; private set; }
        public EntryData<XLabelData, YEntryData> ChanceEntryData { get; private set; }

        public GraphItemViewModel(BaseForecast forecast)
        {
            var isFahrenheit = Units.FAHRENHEIT.Equals(Settings.TemperatureUnit);
            var culture = CultureUtils.UserCulture;

            string date;
            var tempData = new GraphTemperature();

            if (forecast is Forecast fcast)
            {
                date = fcast.date.ToString("ddd dd", culture);
            }
            else if (forecast is HourlyForecast hrfcast)
            {
                if (culture.DateTimeFormat.ShortTimePattern.Contains("H"))
                {
                    date = hrfcast.date.ToString("HH:00", culture);
                }
                else
                {
                    date = hrfcast.date.ToString("h t", culture);
                }
            }
            else
            {
                date = string.Empty;
            }

            // Temp Data
            var xTemp = new XLabelData(date, forecast.icon, 0);
            if (forecast.high_f.HasValue && forecast.high_c.HasValue)
            {
                int value = (int)(isFahrenheit ? Math.Round(forecast.high_f.Value) : Math.Round(forecast.high_c.Value));
                var hiTemp = string.Format(culture, "{0}°", value);
                tempData.HiTempData = new YEntryData(value, hiTemp);
            }
            if ((fcast = forecast as Forecast) != null)
            {
                if (fcast.low_f.HasValue && fcast.low_c.HasValue)
                {
                    int value = (int)(isFahrenheit ? Math.Round(fcast.low_f.Value) : Math.Round(fcast.low_c.Value));
                    var loTemp = string.Format(culture, "{0}°", value);
                    tempData.LoTempData = new YEntryData(value, loTemp);
                }
            }
            TempEntryData = new EntryData<XLabelData, GraphTemperature>(xTemp, tempData);

            if (forecast.extras != null)
            {
                // Wind Data
                if (forecast.extras.wind_mph.HasValue && forecast.extras.wind_mph >= 0 &&
                        forecast.extras.wind_degrees.HasValue && forecast.extras.wind_degrees >= 0)
                {
                    string unit = Settings.SpeedUnit;
                    int speedVal;
                    string speedUnit;

                    switch (unit)
                    {
                        case Units.MILES_PER_HOUR:
                        default:
                            speedVal = (int)Math.Round(forecast.extras.wind_mph.Value);
                            speedUnit = SimpleLibrary.ResLoader.GetString("/Units/unit_mph");
                            break;
                        case Units.KILOMETERS_PER_HOUR:
                            speedVal = (int)Math.Round(forecast.extras.wind_kph.Value);
                            speedUnit = SimpleLibrary.ResLoader.GetString("/Units/unit_kph");
                            break;
                        case Units.METERS_PER_SECOND:
                            speedVal = (int)Math.Round(ConversionMethods.KphToMSec(forecast.extras.wind_kph.Value));
                            speedUnit = SimpleLibrary.ResLoader.GetString("/Units/unit_msec");
                            break;
                    }

                    var windSpeed = string.Format(culture, "{0} {1}", speedVal, speedUnit);
                    int windDirection = forecast.extras.wind_degrees.Value;

                    var y = new YEntryData(speedVal, windSpeed);
                    var x = new XLabelData(date, WeatherIcons.WIND_DIRECTION, windDirection + 180);
                    WindEntryData = new EntryData<XLabelData, YEntryData>(x, y);
                }

                // PoP Chance Data
                if (forecast.extras.pop.HasValue && forecast.extras.pop >= 0)
                {
                    var y = new YEntryData(forecast.extras.pop.Value, forecast.extras.pop.Value + "%");
                    var x = new XLabelData(date, WeatherIcons.RAINDROP, 0);
                    ChanceEntryData = new EntryData<XLabelData, YEntryData>(x, y);
                }
            }
        }

        public class EntryData<X, Y> where X : XLabelData
        {
            public XLabelData LabelData { get; set; }
            public Y Data { get; set; }

            internal EntryData(XLabelData x, Y y)
            {
                LabelData = x;
                Data = y;
            }
        }
    }
}