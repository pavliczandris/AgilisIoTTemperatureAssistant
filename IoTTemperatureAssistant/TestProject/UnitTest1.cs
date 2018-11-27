using System;
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
        public void MaintainEnergyTest()                // Teszt a hőmérséklet fenntartásához szükséges energiát számító függvényhez.
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
        public void MaintainPriceTests()               // Tesztek a fenntartáshoz szükséges költség számításához.
        {
            double expectedPrice = 0;

            SettingsModel TestSettings = new SettingsModel();
            // Paraméterek
            //
            TemperatureService TestService = new TemperatureService();

//            Assert.AreEqual(expectedPrice,);
        }

        [TestMethod]
        public void ChangeAndMaintainEnergyTests()    // Tesztek a hőmérséklet változtatásához és megtartásához szükséges energia számításáshoz.
        {
            double expectedEnergy = 0;

            SettingsModel TestSettings = new SettingsModel();
            // Paraméterek
            //
            TemperatureService TestService = new TemperatureService();

        //    Assert.AreEqual(expectedEnergy, );
        }

        [TestMethod]
        public void ChangeAndMaintainPriceTes()     // Teszt a hőmérséklet változtatásához és annak megtartásához szükséges költség számításához.
        {
            double expectedPrice = 0;

            SettingsModel TestSettings = new SettingsModel();
            // Paraméterek
            //
            TemperatureService TestService = new TemperatureService();
          //  Assert.AreEqual(expectedPrice,);
        }
    }
}
