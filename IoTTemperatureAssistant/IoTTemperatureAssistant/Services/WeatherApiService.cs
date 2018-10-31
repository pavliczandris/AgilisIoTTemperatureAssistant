using IoTTemperatureAssistant.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IoTTemperatureAssistant.Services
{
    public class WeatherApiService
    {
        private readonly string baseUrl = "http://api.openweathermap.org/data/2.5/weather";
        private readonly string appID = "ee4e9a3c11553b7c44b138fd3629f496";

        public async Task<decimal> GetOutsideTemp(string cityName)
        {
            string apiPath = $"{baseUrl}?q={cityName}&APPID={appID}";
            HttpWebRequest request = WebRequest.Create(apiPath) as HttpWebRequest;
            request.ContentType = "application/json";
            var response = await request.GetResponseAsync() as HttpWebResponse;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string jsonResult = reader.ReadToEnd();
                    var weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonResult);
                    return weatherData.Value.Temp - (decimal)273.15;
                }
            }
            return default(decimal);
        }
    }
}
