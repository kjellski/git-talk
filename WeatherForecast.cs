using System;

namespace GitTalk
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public int TemperatureFeeling {
            get {
                var rng = new Random();
                return TemperatureC + rng.Next(-5, 5);
            }
        }

        public string Summary { get; set; }
    }
}
