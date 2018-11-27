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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings = new SettingsModel
            {
                City = tbCity.Text,
                Height = nuHeight.Value,
                Size = nuSize.Value
            };
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {

        }
    }
}
