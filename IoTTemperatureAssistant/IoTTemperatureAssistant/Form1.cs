using IoTTemperatureAssistant.Models;
using IoTTemperatureAssistant.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IoTTemperatureAssistant
{
    public partial class Form1 : Form
    {
        private TemperatureService tempService = new TemperatureService();
        private FileService fileService = new FileService();

        public List<TempData> InsideDataList { get; set; }
        public List<TempData> OutsideDataList { get; set; }

        public Form1()
        {
            InitializeComponent();

            InsideDataList = new List<TempData>();
            OutsideDataList = new List<TempData>();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            var insideTemp = new TempData(time, tempService.GetInsideTempertaure());
            var outsideTemp = new TempData(time, tempService.GetOutsideTempertaure());
            lbInsideTemp.Text = insideTemp.Temperature.ToString();
            lbOutsideTemp.Text = outsideTemp.Temperature.ToString();
            InsideDataList.Add(insideTemp);
            OutsideDataList.Add(outsideTemp);
            chart.Series["Inside"].Points.DataBind(InsideDataList, "Time", "Temperature", "");
            chart.Series["Outside"].Points.DataBind(OutsideDataList, "Time", "Temperature", "");
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
    }
}
