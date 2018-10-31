using IoTTemperatureAssistant.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IoTTemperatureAssistant.Services
{
    public class FileService
    {
        private readonly string settingsFileName = "settings.stg";
        public void SaveSettingsToFile(SettingsModel settings)
        {
            using (Stream stream = File.Open(settingsFileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, settings);
            }
        }

        public SettingsModel LoadSettingsFromFile()
        {
            try
            {
                using (Stream stream = File.Open(settingsFileName, FileMode.Open))
                {
                    var binaryFormatter = new BinaryFormatter();
                    return (SettingsModel)binaryFormatter.Deserialize(stream);
                }
            }
            catch (Exception)
            {
                return new SettingsModel();
            }
        }

        public void SaveToFile(string fileName, List<TempData> dataList)
        {
            fileName = fileName.Split('.')[0];
            string filePath = $"{fileName}.csv";
            string[] lines = new string[dataList.Count];
            for (int i = 0; i < dataList.Count; i++)
            {
                lines[i] = $"{dataList[i].Time.Ticks};{dataList[i].Temperature}";
            }
            File.WriteAllLines(filePath, lines);
        }

        public List<TempData> LoadFromFile(string filePath)
        {
            string[] lines;
            var dataList = new List<TempData>();
            try
            {
                lines = File.ReadAllLines(filePath);
            }
            catch (FileNotFoundException)
            {
                return dataList;
            }
            foreach (var line in lines)
            {
                var values = line.Split(';');
                if(values.Length == 2)
                    dataList.Add(new TempData(values[0], values[1]));
            }
            return dataList;
        }

        public string CreateDateString(DateTime date, string separator = "-")
        {
            string month = "";
            string day = "";

            if (date.Month < 10)
                month = $"0{date.Month}";
            else month = date.Month.ToString();

            if (date.Day < 10)
                day = $"0{date.Day}";
            else day = date.Day.ToString();

            return $"{date.Year}{separator}{month}{separator}{day}";
        }
    }
}
