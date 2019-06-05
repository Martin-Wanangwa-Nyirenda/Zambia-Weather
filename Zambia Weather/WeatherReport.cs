using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Zambia_Weather
{
    class WeatherReport : Weather
    {
        private string weatherAPIReportJson;
        private const string api_key = "";
        public dynamic WeatherJson;

        public void RequestWeatherJson(string city, string country)
        {
            if (InternetWorking())
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"https://api.openweathermap.org/data/2.5/weather?q=" + city + ",zm&lang=en&units=metric&APPID=" + api_key);
                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

                StreamReader jsonStream = new StreamReader(webResponse.GetResponseStream());
                weatherAPIReportJson = jsonStream.ReadToEnd();

                DeserializeJson(weatherAPIReportJson);
            }
            else
            {
                return;
            }
            
        }

        private void DeserializeJson(string json)
        {
            try
            {
                WeatherJson = JsonConvert.DeserializeObject(json);
            }
            catch (JsonException e)
            {
                throw e;
            } 
           
        }

        public void AssignData()
        {
            MainTemp = WeatherJson.main.temp;
            Pressure = WeatherJson.main.pressure;
            Humidity = WeatherJson.main.humidity;
            Temp_max = WeatherJson.main.temp_max;
            Temp_min = WeatherJson.main.temp_min;
            Visibility = WeatherJson.visibility;

            Country = WeatherJson.sys.country;
            City = WeatherJson.name;
            Coord_Longitude = WeatherJson.coord.lon;
            Coord_Latitude = WeatherJson.coord.lat;

            WindSpeed = WeatherJson.wind.speed;
            WindDeg = WeatherJson.wind.deg;

            CloudsAll = WeatherJson.clouds.all;
            Dt = WeatherJson.dt;

            Sunrise = WeatherJson.sys.sunrise;
            Sunset = WeatherJson.sys.sunset;

            //Type = WeatherJson.sys.type;
            //Id = WeatherJson.sys.id;
           //message = WeatherJson.sys.message;

        }

        private bool InternetWorking()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.OpenRead("http://clients3.google.com/generate_204");
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
