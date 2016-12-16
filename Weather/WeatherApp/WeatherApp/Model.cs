using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
   public class Model
    {
        private DataService dataService; 
 
 
         public Model(DataService dataService)
         { 
             this.dataService = dataService; 
         } 
  

        public static async Task<Weather> GetWeather()
        {
            //Sign up for a free API key at http://openweathermap.org/appid

            string key = "334697e46cd896224b89789b9786eb9b";
            string latitude = "55.676098";
            string longitude = "12.5683";
                      
            string queryString = "http://api.openweathermap.org/data/2.5/weather?lat="
 + latitude + "&lon=" + longitude + "&units=metric&appid=" + key;


            var results = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}
