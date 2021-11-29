using System.Text;

namespace ClassLibrary
{
    public class WeeklyForecast
    {
        private DailyForecast[] dailyForecasts;

        public WeeklyForecast()
        {
            dailyForecasts = new DailyForecast[7];
        }
        public WeeklyForecast(DailyForecast[] dailyForecasts)
        {
            this.dailyForecasts = dailyForecasts;
        }

        public string GetAsString()
        {

            StringBuilder weatherString = new StringBuilder();
            for (int i = 0; i < dailyForecasts.Length; i++)
            {
                weatherString.Append(" " + dailyForecasts[i].GetAsString());
            }

            return weatherString.ToString();
        }

        public double GetMaxTemperature()
        {
            double MaxTemperature= dailyForecasts[0].DailyWeather.GetTemperature();
            for (int i = 0; i < dailyForecasts.Length; i++)
            {
                if (MaxTemperature < dailyForecasts[i].DailyWeather.GetTemperature())
                {
                    MaxTemperature = dailyForecasts[i].DailyWeather.GetTemperature();
                }
            }

            return MaxTemperature;
        }

        public DailyForecast this[int dayIndex]
        {
            get { return dailyForecasts[dayIndex]; }
            set { dailyForecasts[dayIndex] = value; }
        }
    }
}