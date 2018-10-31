using System;
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
    }
}
