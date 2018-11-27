using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IoTTemperatureAssistant;
using IoTTemperatureAssistant.Models;
using IoTTemperatureAssistant.Services;


namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConsumptionTests()
        {
            // Testhez szükséges elemek
            TemperatureService TestService = new TemperatureService();
            TestService.insideActualTemp    = 25;
            TestService.outsideActualTemp = 3;

            SettingsModel TestSettings = new SettingsModel();
            TestSettings.ThicknessOfWall = 0.3;
            TestSettings.SurfaceOfWall = 8;
            TestSettings.HeatConduction = 1.4;
            // várt érték
            double expectedConsumption = 24*3600*(22/0.3)*8*1.4 ;

            // Assert
            Assert.AreEqual(expectedConsumption,TestService.CountConsumption(TestSettings));
        }

        [TestMethod]
        public void CountPriceTest()
        {
            // Testhez szükséges elemek
            TemperatureService TestService = new TemperatureService();
            TestService.insideActualTemp = 25;
            TestService.outsideActualTemp = 3;

            SettingsModel TestSettings = new SettingsModel();
            TestSettings.ThicknessOfWall = 0.3;
            TestSettings.SurfaceOfWall = 8;
            TestSettings.HeatConduction = 1.4;
            TestSettings.EnergyPricing = 700;
            // várt érték
            double expectedPrice = (24 * 3600 * (22 / 0.3) * 8 * 1.4)*TestSettings.EnergyPricing/(3.6e+9);

            // Assert
            Assert.AreEqual(expectedPrice, TestService.CountPrice(TestSettings));
        }

        [TestMethod]
        public void EnergyPredictionTest()                // Teszt a hőmérséklet fenntartásához szükséges energiát számító függvényhez.
        {
            double expectedEnergy = 0;
            long secondsTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * 24 * 3600);
            SettingsModel TestSettings = new SettingsModel();
            // Paraméterek beállítása

            //
            TemperatureService TestService = new TemperatureService();
           // Assert.AreEqual(expectedEnergy, TestService.EnergyToMaintain(TestSettings));
        }

        [TestMethod]
        public void PricePredictionTests()               // Tesztek a fenntartáshoz szükséges költség számításához.
        {
            double expectedPrice = 0;

            SettingsModel TestSettings = new SettingsModel();
            // Paraméterek
            //
            TemperatureService TestService = new TemperatureService();

//            Assert.AreEqual(expectedPrice,);
        }

        [TestMethod]
        public void SavingsTests()                       // Teszt a hőmérséklet változtatásához és annak megtartásához szükséges költség számításához.
        {
            double expectedPrice = 0;

            SettingsModel TestSettings = new SettingsModel();
            // Paraméterek
            //
            TemperatureService TestService = new TemperatureService();
          //  Assert.AreEqual(expectedPrice,);
        }

        [TestMethod]
        public void AverageCounterTests()                // Átlagszámító függvény tesztje
        {
            List<double> TestList = new List<double>();
            TemperatureService TestService = new TemperatureService();

            for(int i = 0; i < 20; i++)
            {
                TestList.Add(2);
            }

            double expectedAverage = 2;

            Assert.AreEqual((float)expectedAverage, (float)TestService.countAverage(TestList));
        }
    }
}
