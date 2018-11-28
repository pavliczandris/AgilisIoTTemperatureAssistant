using IoTTemperatureAssistant.Models;
using IoTTemperatureAssistant.Services;
using IoTTemperatureAssistant.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IoTTemperatureAssistant
{
    public partial class MainView : Form
    {
        private TemperatureService tempService;
        private FileService fileService;

        public SettingsModel Settings { get; set; }
        public List<TempData> InsideDataList { get; set; }
        public List<TempData> OutsideDataList { get; set; }
        public MainView()
        {
            InitializeComponent();
            tempService = new TemperatureService();
            fileService = new FileService();

            Settings = fileService.LoadSettingsFromFile();
            lbCity.Text = Settings.City;
            InsideDataList = new List<TempData>();
            OutsideDataList = new List<TempData>();
            NextInsideTemperature();
            NextOutsideTemperature();
        }

        private void NextInsideTemperature()
        {
            var insideTemp = new TempData()
            {
                Time = DateTime.Now,
                Temperature = tempService.GetInsideTempertaure()
            };
            lbInsideTemp.Text = insideTemp.Temperature.ToString();
            InsideDataList.Add(insideTemp);
            chart.Series["Inside"].Points.DataBind(InsideDataList, "Time", "Temperature", "");
        }

        private async void NextOutsideTemperature()
        {
            var outsideTemp = new TempData()
            {
                Time = DateTime.Now,
                Temperature = await tempService.WeatherApiService.GetOutsideTemp(Settings.City)
            };
            lbOutsideTemp.Text = outsideTemp.Temperature.ToString();
            OutsideDataList.Add(outsideTemp);
            chart.Series["Outside"].Points.DataBind(OutsideDataList, "Time", "Temperature", "");
        }

        private void InsideTimer_Tick(object sender, EventArgs e)
        {
            NextInsideTemperature();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fileService.SaveToFile("inside", InsideDataList);
            fileService.SaveToFile("outside", OutsideDataList);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            InsideDataList = fileService.LoadFromFile("inside.csv");
            OutsideDataList = fileService.LoadFromFile("outside.csv");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsView(Settings))
            {
                settingsForm.Settings = Settings;

                if (settingsForm.ShowDialog(this) == DialogResult.OK)
                {
                    Settings = settingsForm.Settings;
                    fileService.SaveSettingsToFile(Settings);

                    lbCity.Text = Settings.City;
                }
            }
        }
               
        private void OutsideTimer_Tick(object sender, EventArgs e)
        {
            NextOutsideTemperature();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void CalculationTimer_Tick(object sender, EventArgs e)
        {
            var insideTemp = new List<double>();
            foreach (var item in InsideDataList)
            {
                insideTemp.Add(item.Temperature);
            }
            lbAvgInsideTemp.Text = Math.Round(tempService.countAverage(insideTemp)).ToString();

            var outsideTemp = new List<double>();
            foreach (var item in OutsideDataList)
            {
                outsideTemp.Add(item.Temperature);
            }
            lbAvgOutsideTemp.Text = Math.Round(tempService.countAverage(outsideTemp)).ToString();

            lbConsumption.Text = (tempService.CountConsumption(Settings, insideTemp, outsideTemp) / 1000000).ToString();
            lbEstimatedConsumption.Text = (tempService.EnergyPrediction(Settings, insideTemp, outsideTemp) / 1000000).ToString();

            lbCost.Text = tempService.CountPrice(Settings, insideTemp, outsideTemp).ToString();
            lbEstimatedCost.Text = tempService.PricePrediction(Settings, insideTemp, outsideTemp).ToString();

        }
    }
}
