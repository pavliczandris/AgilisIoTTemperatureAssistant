using System;

namespace IoTTemperatureAssistant.Models
{
    [Serializable]
    public class SettingsModel
    {
        public string City { get; set; }
        public decimal Size { get; set; }
        public decimal Height { get; set; }
    }
}
