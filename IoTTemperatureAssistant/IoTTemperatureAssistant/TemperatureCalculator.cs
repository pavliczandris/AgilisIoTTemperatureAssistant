using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTTemperatureAssistant
{
    public class TemperatureCalculator
    {
        private double VolumeOfRoom         { get; set; }   // Szoba térfogata
        private double EnergyPricing        { get; set; }   // Energia árfolyama
        private double OutdoorTemperature   { get; set; }   // Külső hőmérséklet
        private double IndoorTemperature    { get; set; }   //Belső hőmérséklet
        private double HeatConduction       { get; set; }   // Jóségi tényező a bel- és kültér közötti fal szigetelésére. 1=teljesen szigetel; 0=teljesen átadja a hőt
        private double SurfaceOfWall        { get; set; }   // Bel, és külteret elválasztó falak összfelülete

        /*public double TemperatureDifference()   // Belső és külső hőmérséklet közti különbség számítása
        {
            //return indoorTemperature-outdoorTemperature;
        }*/

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
            return EnergyPricing * EnergyToMaintain();
        } 

        public double PriceToChange(double valueOfChange)  // A hőmérsékletváltoztatásából adódó költség egyszeri hőmérsékletváltoztatásnál.
        {
            return EnergyPricing*EnergyToChange(valueOfChange);
        }

    }
}