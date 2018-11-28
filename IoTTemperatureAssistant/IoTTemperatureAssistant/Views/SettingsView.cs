using IoTTemperatureAssistant.Models;
using System;
using System.Windows.Forms;

namespace IoTTemperatureAssistant.Views
{
    public partial class SettingsView : Form
    {
        public SettingsModel Settings { get; set; }

        public SettingsView(SettingsModel settings)
        {
            InitializeComponent();
            Settings = settings;
            tbCity.Text = Settings.City;
            nuSize.Value = Settings.Size;
            nuHeight.Value = Settings.Height;
            nuEnergyPricing.Value = (decimal)Settings.EnergyPricing;
            nuHeatConduction.Value = (decimal)Settings.HeatConduction;
            nuSurfaceOfWall.Value = (decimal)Settings.SurfaceOfWall;
            nuThicknessOfWall.Value = (decimal)Settings.ThicknessOfWall;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings = new SettingsModel
            {
                City = tbCity.Text,
                Height = nuHeight.Value,
                Size = nuSize.Value,
                EnergyPricing = (double)nuEnergyPricing.Value,
                HeatConduction = (double)nuHeatConduction.Value,
                SurfaceOfWall = (double)nuSurfaceOfWall.Value,
                ThicknessOfWall = (double)nuThicknessOfWall.Value
            };
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {

        }
    }
}
