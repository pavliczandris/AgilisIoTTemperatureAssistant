using System;
using System.Collections.Generic;
using IoTTemperatureAssistant.Models;

namespace IoTTemperatureAssistant.Services
{
    public class TemperatureService
    {
        public WeatherApiService WeatherApiService { get; set; }

        private double insideActualTemp = 21;
        private double outsideActualTemp = 9;

        private Random rand = new Random();

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

        public double CountConsumption(SettingsModel SM, List<double> InTemp, List<double> OutTemp)        // A hónap eddigi energiafogyasztásának számítása
        {
            return SM.HeatConduction*((countAverage(InTemp)-countAverage(OutTemp))/(SM.ThicknessOfWall))*SM.SurfaceOfWall*24*3600;
        }

        public double CountPrice(SettingsModel SM, List<double> InTemp, List<double> OutTemp)             // A hónap eddigi energiaköltségei
        {
            return CountConsumption(SM, InTemp, OutTemp)*SM.EnergyPricing/(3.6e+9);
        }

        public double EnergyPrediction(SettingsModel SM, List<double> InTemp, List<double> OutTemp)                      // Jelenlegi hőmérséklet fenntartásához szükséges energia becslése, arra számítva, hogy a hőmérséklet azonos marad a jelenlegivel a hónap végéig.
        {
            double Energydt = SM.HeatConduction * ((countAverage(InTemp) - countAverage(OutTemp)) / (SM.ThicknessOfWall)) * SM.SurfaceOfWall;
            long TimeTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - (DateTime.Today.Day - 1)) * 24 * 3600;
            return Energydt * TimeTilMonthsEnd;
        }

        public double PricePrediction(SettingsModel SM, List<double> InTemp, List<double> OutTemp)                       // Jelenlegi hőmérséklet fenntartásából adódó költség becslése a hónapra
        {
            return EnergyPrediction(SM, InTemp, OutTemp) *SM.EnergyPricing/(3.6e+9);
        }

        public double savingPrediction(SettingsModel SM, double valueOfChange, List<double> InTemp, List<double> OutTemp)   // A hőmérsékletváltoztatásából adódó költségmegtakarítás becslése.
        {
            double ChangedEnergydt = SM.HeatConduction * ((countAverage(InTemp) - countAverage(OutTemp) + valueOfChange) / (SM.ThicknessOfWall)) * SM.SurfaceOfWall;
            long TimeTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - (DateTime.Today.Day - 1)) * 24 * 3600;
            double energySavings = EnergyPrediction(SM, InTemp, OutTemp) - (ChangedEnergydt*TimeTilMonthsEnd);
            return energySavings*SM.EnergyPricing/(3.6e+9);
        }
    }
}
