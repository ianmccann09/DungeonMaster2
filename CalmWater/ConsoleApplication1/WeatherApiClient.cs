using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonApiClient
{
    public static class WeatherApiClient
    {
        public static void GetWeatherForecast()
        {
            var url = "http://api.openweathermap.org/data/2.5/forecast/city?id=524901&APPID={d3da3b303ae310c5f246e55b3c647630}";
            

            //Synchronious Consumption
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

        } 
    }
}
