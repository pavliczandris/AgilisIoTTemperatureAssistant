using System;

namespace IoTTemperatureAssistant.Models
{
    [Serializable]
    public class SettingsModel
    {
        public string City { get; set; }
        public decimal Size { get; set; }
        public decimal Height { get; set; }
        public double EnergyPricing { get; set; }           // Energia árfolyama Ft/MWh
        public double HeatConduction { get; set; }           // Fal hővezetési tényezője
        public double SurfaceOfWall { get; set; }           // Bel, és külteret elválasztó falak összfelülete
        public double ThicknessOfWall { get; set; }        // Falvastagság
    }
}
