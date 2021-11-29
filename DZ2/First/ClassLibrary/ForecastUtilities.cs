using System;

namespace ClassLibrary
{
    public static class ForecastUtilities
    {
        public static DailyForecast Parse(string dailyWeatherInput)
        {
            string[] values = dailyWeatherInput.Split(',');
            DailyForecast parsedDailyForecast = new DailyForecast();
            
            parsedDailyForecast.Day = DateTime.Parse(values[0]);
            parsedDailyForecast.DailyWeather = new Weather(Convert.ToDouble(values[1]), Convert.ToDouble(values[3]),
                Convert.ToDouble(values[2]));
            return parsedDailyForecast;
        }
    }
}