using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTTemperatureAssistant.Models
{
    public class WeatherData
    {
        public class main
        {
            public double temp { get; set; }
        }

        public class root
        {
            public main main { get; set; }
        }
    }

}
