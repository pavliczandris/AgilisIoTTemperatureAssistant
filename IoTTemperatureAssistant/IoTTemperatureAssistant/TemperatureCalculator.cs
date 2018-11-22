using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTTemperatureAssistant
{
    public class TemperatureCalculator
    {

        private double volumeOfRoom         { get; set; }
        private double enerGyPricing        { get; set; }
        private double outdoorTemperature   { get; set; }
        private double indoorTemperature    { get; set; }
        private double goodnessFactor       { get; set; }

        public double TemperatureDifference()   // Belső és külső hőmérséklet közti különbség számítása
        {
            return 0;
        }

        public double EnergyToMaintain()        // Jelenlegi hőmérséklet fenntartásához szükséges energia, arra számítva, hogy a hőmérséklet azonos marad a jelenlegivel
        {
            return 0;
        }

        public double EnergyToChange(double valueofChange)  // Hőmérséklet megváltoztatásához szükséges energia
        {
            return 0;
        }

        public double PriceToMaintain()         // Jelenlegi hőmérséklet fenntartásából adódó költség a hónapra
        {
            return 0;
        } 

        public double PriceToChange(double valueOfChange)           // A hőmérsékletváltoztatásából adódó költség egyszeri hőmérsékletváltoztatásnál.
        {
            return 0;
        }
    }
}