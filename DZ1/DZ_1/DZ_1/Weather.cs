using System;

namespace DZ_1
{
    public class Weather
    {
        private double temperature;
        private double humidity;
        private double windSpeed;

       public Weather(){}
        
        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
        }

        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }
        
        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }

        public void SetWindSpeed(double windSpeed)
        {
            this.windSpeed = windSpeed;
        }

        public double GetTemperature()
        {
            return temperature;
        }

        public double GetHumidity()
        {
            return humidity;
        }

        public double GetWindSpeed()
        {
            return windSpeed;
        }

        public double CalculateWindChill()
        {
            this.windSpeed /= 3.6;
            return (10 * Math.Sqrt(this.windSpeed) - this.windSpeed + 10.5) * (33 - this.temperature);
        }
        
        public double CalculateFeelsLikeTemperature()
        {
            double c1 = -8.78469475556;
            double c2 = 1.61139411;
            double c3 = 2.33854883889;
            double c4 = -0.14611605;
            double c5 = -0.012308094;
            double c6 = -0.0164248277778;
            double c7 = 0.002211732;
            double c8 = 0.00072546;
            double c9 = -0.000003582;

            return c1 + c2 * temperature + c3 * humidity + c4 * temperature * humidity + c5 * Math.Pow(temperature, 2) +
                   c6 * Math.Pow(humidity, 2) + c7 * humidity * Math.Pow(temperature, 2) +
                   c8 * temperature * Math.Pow(humidity, 2) + c9 * Math.Pow(temperature, 2) * Math.Pow(humidity, 2);
        }


    }
}