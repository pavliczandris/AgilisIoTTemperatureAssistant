using System;
using System.Collections.Generic;
using IoTTemperatureAssistant.Models;

namespace IoTTemperatureAssistant.Services
{
    public class TemperatureService
    {
        public WeatherApiService WeatherApiService { get; set; }

        public double insideActualTemp = 21;
        public double outsideActualTemp = 9;

        private double averageInsideTemperature;
        private double averageOutsideTemperature;

        private Random rand = new Random();
        public double energyInMonth=0;

        public TemperatureService()
        {
            WeatherApiService = new WeatherApiService();
        }

        public double GetInsideTempertaure()
        {
            insideActualTemp = GenerateTemp(insideActualTemp, 22);
            return insideActualTemp;
        }

        public double GetOutsideTempertaure()
        {
            outsideActualTemp = GenerateTemp(outsideActualTemp, 18);
            return outsideActualTemp;
        }

        private double GenerateTemp(double value, double max)
        {
            var number = rand.Next();
            if (value < max)
            {
                if (number % 8 < 5)
                    return value + 0.1;
                if (number == 5)
                    return value;
                return value - 0.1;
            }
            else
            {
                if (number % 8 < 5)
                    return value - 0.1;
                if (number == 5)
                    return value;
                return value + 0.1;
            }
        }

        public double countAverage(List<double> TempList)
        {
            double average=0;
            for (int i=0; i<TempList.Count;i++)
            {
                average = average + (TempList[i] /TempList.Count);
            }
            return average;
        }

        public double CountConsumption(SettingsModel SM)        // A hónap eddigi energiafogyasztásának számítása
        {
            return SM.HeatConduction*((insideActualTemp-outsideActualTemp)/(SM.ThicknessOfWall))*SM.SurfaceOfWall*24*3600;
        }

        public double CountPrice(SettingsModel SM)             // A hónap eddigi energiaköltségei
        {
            return CountConsumption(SM)*SM.EnergyPricing/(3.6e+9);
        }

        public double EnergyPrediction(SettingsModel SM)                      // Jelenlegi hőmérséklet fenntartásához szükséges energia becslése, arra számítva, hogy a hőmérséklet azonos marad a jelenlegivel a hónap végéig.
        {
            return 0;
        }

        public double PricePrediction(SettingsModel SM)                       // Jelenlegi hőmérséklet fenntartásából adódó költség becslése a hónapra
        {
            return EnergyPrediction(SM)*SM.EnergyPricing;
        }

        public double savingPrediction(SettingsModel SM, double valueOfChange)   // A hőmérsékletváltoztatásából adódó költségmegtakarítás becslése.
        {
            return 0;
        }
    }
}
