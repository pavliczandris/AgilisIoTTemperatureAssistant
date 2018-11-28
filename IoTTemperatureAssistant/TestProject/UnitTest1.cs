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
        // Testhez szükséges elemek
        private  TemperatureService TestService = new TemperatureService();
        private  SettingsModel TestSettings = new SettingsModel();
        private  List<double> InTempList = new List<double>();
        private  List<double> OutTempList = new List<double>();
        private  double inAverage;
        private double outAverage;

        [TestMethod]
        public void ConsumptionTests()
        {
            setupParameters();

            // Elvárt érték
            double expectedConsumption = 24*3600*((inAverage-outAverage)/0.3)*8*1.4 ;

            // Assert
            Assert.AreEqual((float)expectedConsumption,(float)TestService.CountConsumption(TestSettings, InTempList, OutTempList));
        }

        [TestMethod]
        public void CountPriceTest()
        {
            // Testhez szükséges elemek
            setupParameters();

            // Elvárt érték
            double expectedPrice = (24 * 3600 * ((inAverage - outAverage) / 0.3) * 8 * 1.4)*TestSettings.EnergyPricing/(3.6e+9);

            // Assert
            Assert.AreEqual((float)expectedPrice, (float)TestService.CountPrice(TestSettings, InTempList, OutTempList));
        }

        [TestMethod]
        public void EnergyPredictionTest()                // Teszt a hőmérséklet fenntartásához szükséges energiát számító függvényhez.
        {
            // Testhez szükséges elemek
            setupParameters();

            // várt érték
            double expectedEdt = ((inAverage - outAverage) / 0.3) * 8 * 1.4;
            long secondsTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)-(DateTime.Today.Day-1))*24*3600;
           
            // Elvárt érték
            double expectedEnergy = expectedEdt * secondsTilMonthsEnd;
            
            // Assert
            Assert.AreEqual((float)expectedEnergy, (float)TestService.EnergyPrediction(TestSettings, InTempList, OutTempList));
        }

        [TestMethod]
        public void PricePredictionTests()               // Tesztek a fenntartáshoz szükséges költség számításához.
        {
            // Testhez szükséges elemek
            setupParameters();
            
            // várt érték
            double expectedEdt = ((inAverage - outAverage) / 0.3) * 8 * 1.4;
            long secondsTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - (DateTime.Today.Day - 1)) * 24 * 3600;
           
            // Elvárt érték
            double expectedPrice = expectedEdt * secondsTilMonthsEnd*700/(3.6e+9);
           
            // Assert
            Assert.AreEqual((float)expectedPrice, (float)TestService.PricePrediction(TestSettings, InTempList, OutTempList));
        }

        [TestMethod]
        public void SavingsTests()                       // Teszt a hőmérséklet változtatásához és annak megtartásához szükséges költség számításához.
        {
            // Testhez szükséges elemek
            setupParameters();

            double changeOfInsideTemp = 5;
            double actualEnergydt = ((inAverage - outAverage) / 0.3) * 8 * 1.4;
            double changedEnergydt = ((inAverage - outAverage+changeOfInsideTemp) / 0.3) *8 * 1.4;
            long timeTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - (DateTime.Today.Day - 1)) * 24 * 3600;
            double actualPrediction = timeTilMonthsEnd * actualEnergydt * 700 / (3.6e+9);
            double changedPrediction = timeTilMonthsEnd * changedEnergydt * 700 / (3.6e+9);
           
            // Elvárt érték
            double ExpectedSavings = actualPrediction - changedPrediction; 
           
            // Assert
            Assert.AreEqual((float)ExpectedSavings, (float)TestService.savingPrediction(TestSettings,changeOfInsideTemp, InTempList, OutTempList));            
        }

        [TestMethod]
        public void AverageCounterTests()                // Átlagszámító függvény tesztje
        {
            setupParameters();

            // Elvárt érték
            double expectedOutAverage = 5;
            double expectedInAverage = 25;
           
            // Assert
            Assert.AreEqual((float)expectedOutAverage, (float)TestService.countAverage(OutTempList));
            Assert.AreEqual((float)expectedInAverage, (float)TestService.countAverage(InTempList));
        }

        private void setupParameters()
        {
            TestSettings.ThicknessOfWall = 0.3;
            TestSettings.SurfaceOfWall = 8;
            TestSettings.HeatConduction = 1.4;
            TestService.insideActualTemp = 25;
            TestService.outsideActualTemp = 3;
            TestSettings.EnergyPricing = 700;

            for (int i=0; i<10; i++)
            {
                InTempList.Add(24);
                InTempList.Add(26);
                OutTempList.Add(4);
                OutTempList.Add(6);
            }

            inAverage = TestService.countAverage(InTempList);
            outAverage = TestService.countAverage(OutTempList);
        }
    }
}
