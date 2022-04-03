using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherwithAPI.Model
{

    public class WeatherModel
    {
        public Datum[] data { get; set; }
        public double count { get; set; }
    }

    public class Datum
    {
        public double rh { get; set; }
        public string pod { get; set; }
        public float lon { get; set; }
        public float pres { get; set; }
        public string timezone { get; set; }
        public string ob_time { get; set; }
        public string country_code { get; set; }
        public double clouds { get; set; }
        public double ts { get; set; }
        public double solar_rad { get; set; }
        public string state_code { get; set; }
        public string city_name { get; set; }
        public float wind_spd { get; set; }
        public string wind_cdir_full { get; set; }
        public string wind_cdir { get; set; }
        public float slp { get; set; }
        public double vis { get; set; }
        public double h_angle { get; set; }
        public string sunset { get; set; }
        public double dni { get; set; }
        public float dewpt { get; set; }
        public double snow { get; set; }
        public double uv { get; set; }
        public double precip { get; set; }
        public double wind_dir { get; set; }
        public string sunrise { get; set; }
        public double ghi { get; set; }
        public double dhi { get; set; }
        public double aqi { get; set; }
        public float lat { get; set; }
        public Weather weather { get; set; }
        public string datetime { get; set; }
        public float temp { get; set; }
        public string station { get; set; }
        public float elev_angle { get; set; }
        public float app_temp { get; set; }
    }

    public class Weather
    {
        public string icon { get; set; }
        public double code { get; set; }
        public string description { get; set; }
    }

}
