using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IoTTemperatureAssistant;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TempDiffTests() // Hőmérsékletkülönbség számításához teszt.
        {
            double expectedDiff =0;
            TemperatureCalculator tc = new TemperatureCalculator();
            Assert.AreEqual(expectedDiff, tc.TemperatureDifference());
        }

        [TestMethod]
        public void MaintainTests() // Tesztek a fenntartáshoz szükséges energia és költség számításához
        {
            double expectedEnergy = 0;
            double expectedPrice = 0;
            TemperatureCalculator tc = new TemperatureCalculator();
            Assert.AreEqual(expectedEnergy,tc.EnergyToMaintain());
            Assert.AreEqual(expectedPrice,tc.PriceToMaintain());
        }

        [TestMethod]
        public void ChangeAndMaintainTests()   // Tesztek a hőmérséklet változtatásához és megtartásához szükséges energia és költség számításáshoz
        {
            double expectedEnergy = 0;
            double expectedPrice = 0;
            TemperatureCalculator tc = new TemperatureCalculator();
            Assert.AreEqual(expectedEnergy, tc.EnergyToChange(0));
            Assert.AreEqual(expectedPrice, tc.PriceToChange(0));
        }
    }
}
