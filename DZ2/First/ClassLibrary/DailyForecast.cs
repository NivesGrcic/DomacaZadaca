using System;

namespace ClassLibrary
{
    public class DailyForecast
    {
        public DateTime Day { get;  set; }
        public Weather DailyWeather { get;  set; }


        public DailyForecast(DateTime day, Weather weather)
        {
            this.Day = day;
            this.DailyWeather = weather;
        }
        
        public DailyForecast(){}
        public  string GetAsString()
        {
            return  this.Day.ToString()+","+this.DailyWeather.GetAsString()+"\n";
            
        }
        
    }
}