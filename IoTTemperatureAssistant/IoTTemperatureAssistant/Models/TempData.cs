using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTTemperatureAssistant.Models
{
    public class TempData
    {
        public DateTime Time { get; set; }
        public double Temperature { get; set; }

        public TempData()
        {

        }

        public TempData(DateTime time, double temperature)
        {
            Time = time;
            Temperature = temperature;
        }

        public TempData(string time, string temperature)
        {
            Time = new DateTime(long.Parse(time));
            Temperature = double.Parse(temperature);
        }
    }
}
