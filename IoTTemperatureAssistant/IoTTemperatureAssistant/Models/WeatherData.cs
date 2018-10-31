using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTTemperatureAssistant.Models
{
    public class WeatherData
    {
        public Main Value { get; set; } = new Main();
    }

    public class Main
    {
        public decimal Temp { get; set; }
    }
}
