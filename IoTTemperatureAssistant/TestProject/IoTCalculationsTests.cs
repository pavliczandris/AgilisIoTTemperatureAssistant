using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IoTTemperatureAssistant;
using IoTTemperatureAssistant.Models;
using IoTTemperatureAssistant.Services;


namespace Test
{
    [TestClass]
    public class CalculationsTests
    {
        // Testhez szükséges elemek
        private  TemperatureService TestService = new TemperatureService();
        private  SettingsModel TestSettings = new SettingsModel();
        private  List<double> InTempList = new List<double>();
        private  List<double> OutTempList = new List<double>();
        private  double inAverage;
        private double outAverage;
        private double changeOfInsideTemp;

        [TestMethod]
        public void ConsumptionTests()
        {
            // Test segédváltozók
            double expectedConsumption;

            // Testhez szükséges elemek1
            setupParameters1();

            // Elvárt érték1
            expectedConsumption = 24*3600*((inAverage-outAverage)/0.3)*8*1.4 ;

            // Assert1
            Assert.AreEqual((float)expectedConsumption,(float)TestService.CountConsumption(TestSettings, InTempList, OutTempList));

            // Testhez szükséges elemek2
            setupParameters2();

            // Elvárt érték2
            expectedConsumption = 24 * 3600 * ((inAverage - outAverage) / 0.25) * 12 * 0.9;

            // Assert2
            Assert.AreEqual((float)expectedConsumption, (float)TestService.CountConsumption(TestSettings, InTempList, OutTempList));
        }

        [TestMethod]
        public void CountPriceTest()
        {
            // Test segédváltozók
            double expectedPrice;

            // Testhez szükséges elemek1
            setupParameters1();

            // Elvárt érték1
            expectedPrice = (24 * 3600 * ((inAverage - outAverage) / 0.3) * 8 * 1.4)*TestSettings.EnergyPricing/(3.6e+9);

            // Assert1
            Assert.AreEqual((float)expectedPrice, (float)TestService.CountPrice(TestSettings, InTempList, OutTempList));

            // Testhez szükséges elemek2
            setupParameters2();

            // Elvárt érték2
            expectedPrice = (24 * 3600 * ((inAverage - outAverage) / 0.25) * 12 * 0.9) * TestSettings.EnergyPricing / (3.6e+9);

            // Assert2
            Assert.AreEqual((float)expectedPrice, (float)TestService.CountPrice(TestSettings, InTempList, OutTempList));
        }

        [TestMethod]
        public void EnergyPredictionTest()                // Teszt a hőmérséklet fenntartásához szükséges energiát számító függvényhez.
        {
            // Test segédváltozók
            double expectedEdt;
            long secondsTilMonthsEnd;
            double expectedEnergy;

            // Testhez szükséges elemek1
            setupParameters1();

            // várt érték1
            expectedEdt = ((inAverage - outAverage) / 0.3) * 8 * 1.4;
            secondsTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)-(DateTime.Today.Day-1))*24*3600;
           
            // Elvárt érték1
            expectedEnergy = expectedEdt * secondsTilMonthsEnd;
            
            // Assert1
            Assert.AreEqual((float)expectedEnergy, (float)TestService.EnergyPrediction(TestSettings, InTempList, OutTempList));

            // Testhez szükséges elemek2
            setupParameters2();

            // várt érték2
            expectedEdt = ((inAverage - outAverage) / 0.25) * 12 * 0.9;
            secondsTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - (DateTime.Today.Day - 1)) * 24 * 3600;

            // Elvárt érték2
            expectedEnergy = expectedEdt * secondsTilMonthsEnd;

            // Assert2
            Assert.AreEqual((float)expectedEnergy, (float)TestService.EnergyPrediction(TestSettings, InTempList, OutTempList));
        }

        [TestMethod]
        public void PricePredictionTests()               // Tesztek a fenntartáshoz szükséges költség számításához.
        {
            // Test segédváltozók
            double expectedEdt;
            long secondsTilMonthsEnd;
            double expectedPrice;

            // Testhez szükséges elemek1
            setupParameters1();
            
            // várt érték1
            expectedEdt = ((inAverage - outAverage) / 0.3) * 8 * 1.4;
            secondsTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - (DateTime.Today.Day - 1)) * 24 * 3600;
           
            // Elvárt érték1
            expectedPrice = expectedEdt * secondsTilMonthsEnd*700/(3.6e+9);
           
            // Assert1
            Assert.AreEqual((float)expectedPrice, (float)TestService.PricePrediction(TestSettings, InTempList, OutTempList));

            // Testhez szükséges elemek2
            setupParameters2();

            // várt érték2
            expectedEdt = ((inAverage - outAverage) / 0.25) * 12 * 0.9;
            secondsTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - (DateTime.Today.Day - 1)) * 24 * 3600;

            // Elvárt érték2
            expectedPrice = expectedEdt * secondsTilMonthsEnd * 825 / (3.6e+9);

            // Assert2
            Assert.AreEqual((float)expectedPrice, (float)TestService.PricePrediction(TestSettings, InTempList, OutTempList));
        }

        [TestMethod]
        public void SavingsTests()                       // Teszt a hőmérséklet változtatásához és annak megtartásához szükséges költség számításához.
        {
            // Test segédváltozók
            double actualEnergydt;
            double changedEnergydt;
            long timeTilMonthsEnd;
            double actualPrediction;
            double changedPrediction;
            double ExpectedSavings;

            // Testhez szükséges elemek1
            setupParameters1();

            actualEnergydt = ((inAverage - outAverage) / 0.3) * 8 * 1.4;
            changedEnergydt = ((inAverage - outAverage+changeOfInsideTemp) / 0.3) *8 * 1.4;
            timeTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - (DateTime.Today.Day - 1)) * 24 * 3600;
            actualPrediction = timeTilMonthsEnd * actualEnergydt * 700 / (3.6e+9);
            changedPrediction = timeTilMonthsEnd * changedEnergydt * 700 / (3.6e+9);
           
            // Elvárt érték1
            ExpectedSavings = actualPrediction - changedPrediction; 
           
            // Assert1
            Assert.AreEqual((float)ExpectedSavings, (float)TestService.savingPrediction(TestSettings,changeOfInsideTemp, InTempList, OutTempList));

            // Testhez szükséges elemek2
            setupParameters2();

            actualEnergydt = ((inAverage - outAverage) / 0.25) * 12 * 0.9;
            changedEnergydt = ((inAverage - outAverage + changeOfInsideTemp) / 0.25) * 12 * 0.9;
            timeTilMonthsEnd = (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - (DateTime.Today.Day - 1)) * 24 * 3600;
            actualPrediction = timeTilMonthsEnd * actualEnergydt * 825 / (3.6e+9);
            changedPrediction = timeTilMonthsEnd * changedEnergydt * 825 / (3.6e+9);

            // Elvárt érték2
            ExpectedSavings = actualPrediction - changedPrediction;

            // Assert2
            Assert.AreEqual((float)ExpectedSavings, (float)TestService.savingPrediction(TestSettings, changeOfInsideTemp, InTempList, OutTempList));
        }

        [TestMethod]
        public void AverageCounterTests()                // Átlagszámító függvény tesztje
        {
            setupParameters1();

            // Elvárt érték
            double expectedOutAverage = 5;
            double expectedInAverage = 25;
           
            // Assert
            Assert.AreEqual((float)expectedOutAverage, (float)TestService.countAverage(OutTempList));
            Assert.AreEqual((float)expectedInAverage, (float)TestService.countAverage(InTempList));
        }

        private void setupParameters1()
        {
            TestSettings.ThicknessOfWall = 0.3;
            TestSettings.SurfaceOfWall = 8;
            TestSettings.HeatConduction = 1.4;
            TestSettings.EnergyPricing = 700;
            changeOfInsideTemp = 5;

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

        private void setupParameters2()
        {
            TestSettings.ThicknessOfWall = 0.25;
            TestSettings.SurfaceOfWall = 12;
            TestSettings.HeatConduction = 0.9;
            TestSettings.EnergyPricing = 825;
            changeOfInsideTemp = 3;

            for (int i = 0; i < 10; i++)
            {
                InTempList.Add(22);
                InTempList.Add(24);
                OutTempList.Add(2);
                OutTempList.Add(12);
            }

            inAverage = TestService.countAverage(InTempList);
            outAverage = TestService.countAverage(OutTempList);
        }
    }
}
