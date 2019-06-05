using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace Zambia_Weather
{
    class Weather
    {
        //Main Weather
        public double MainTemp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double Temp_min { get; set; }
        public double Temp_max { get; set; }
        public string Visibility { get; set; }

        //Location
        public string Country { get; set; }
        public string City { get; set; }
        public double Coord_Latitude { get; set; }
        public double Coord_Longitude { get; set; }

        //Wind Data
        public double WindSpeed { get; set; }
        public int WindDeg { get; set; }

        //Clouds
        public double CloudsAll { get; set; }

        public double Dt { get; set; }

        //Sun
        public int Sunrise { get; set; }
        public int Sunset { get; set; }

        //System Details
        public int Type { get; set; }
        public int Id { get; set; }
        public int message { get; set; }
    }
}
