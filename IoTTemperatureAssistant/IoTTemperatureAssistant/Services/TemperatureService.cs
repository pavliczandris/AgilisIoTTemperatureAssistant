using System;
using IoTTemperatureAssistant.Models;

namespace IoTTemperatureAssistant.Services
{
    public class TemperatureService
    {
        public WeatherApiService WeatherApiService { get; set; }

        private double insideActualTemp = 21;
        private double outsideActualTemp = 9;

        private Random rand = new Random();
        private double energyInMonth=0;

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

        public double CountConsumption(SettingsModel SM)        // A hónap eddigi energiafogyasztásának számítása
        {
            return 0;
        }

        private double CountPrice(SettingsModel SM)             // A hónap eddigi energiaköltségei
        {
            return energyInMonth*SM.EnergyPricing;

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
