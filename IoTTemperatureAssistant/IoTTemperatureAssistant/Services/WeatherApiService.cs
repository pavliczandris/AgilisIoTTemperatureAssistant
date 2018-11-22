using IoTTemperatureAssistant.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace IoTTemperatureAssistant.Services
{
    public class WeatherApiService
    {
        private readonly string baseUrl = "http://api.openweathermap.org/data/2.5/weather";
        private readonly string appID = "ee4e9a3c11553b7c44b138fd3629f496";

        public async Task<double> GetOutsideTemp(string cityName)
        {
            if (cityName == null || cityName == "")
                return default(double);

            string apiPath = $"{baseUrl}?q={cityName}&APPID={appID}";
            HttpWebRequest request = WebRequest.Create(apiPath) as HttpWebRequest;
            request.ContentType = "application/json";
            try
            {
                var response = await request.GetResponseAsync() as HttpWebResponse;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string jsonResult = reader.ReadToEnd();
                        var weatherData = JsonConvert.DeserializeObject<WeatherData.root>(jsonResult);
                        return weatherData.main.temp - 273.15;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return default(double);
            }
            return default(double);
        }
    }
}
