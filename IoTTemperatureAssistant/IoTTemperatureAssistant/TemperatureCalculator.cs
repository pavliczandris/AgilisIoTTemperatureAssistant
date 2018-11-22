using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTTemperatureAssistant
{
    public class TemperatureCalculator
    {
        private double volumeOfRoom         { get; set; }   // Szoba térfogata
        private double energyPricing        { get; set; }   // Energia árfolyama
        private double outdoorTemperature   { get; set; }   // Külső hőmérséklet
        private double indoorTemperature    { get; set; }   // Belső hőmérséklet
        private double goodnessFactor       { get; set; }   // Jósági tényező a bel- és kültér közötti fal szigetelésére. 1=teljesen szigetel; 0=teljesen átadja a hőt
        private double surfaceOfWall        { get; set; }   // Bel, és külteret elválasztó falak összfelülete

        public TemperatureCalculator()
        {
            volumeOfRoom = 0;
            energyPricing = 0;
            outdoorTemperature = 0;
            indoorTemperature = 0;
            goodnessFactor = 1;
            surfaceOfWall = 0;
        }

        public double TemperatureDifference()   // Belső és külső hőmérséklet közti különbség számítása
        {
            return indoorTemperature-outdoorTemperature;
        }

        public double EnergyToMaintain()        // Jelenlegi hőmérséklet fenntartásához szükséges energia, arra számítva, hogy a hőmérséklet azonos marad a jelenlegivel.
        {
            return 0;
        }

        public double EnergyToChange(double valueofChange)  // Hőmérséklet megváltoztatásához szükséges energia
        {
            return 0;
        }

        public double PriceToMaintain()                    // Jelenlegi hőmérséklet fenntartásából adódó költség a hónapra
        {
            return enerGyPricing * EnergyToMaintain();
        } 

        public double PriceToChange(double valueOfChange)  // A hőmérsékletváltoztatásából adódó költség egyszeri hőmérsékletváltoztatásnál.
        {
            return enerGyPricing*EnergyToChange(valueOfChange);
        }

    }
}