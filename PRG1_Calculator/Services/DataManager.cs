using System.IO;
using Newtonsoft.Json;

namespace PRG1_Calculator.Services
{
    internal class DataManager
    {
        private string filePath = "storage.json";
        public void SaveData(DataContainer data) 
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, json);
        }

        public DataContainer LoadData()
        {
            if (!File.Exists(filePath))
            {
                return  new DataContainer(0);
            }
            try
            {
                string json = File.ReadAllText(filePath);
                DataContainer? dataContainer = JsonConvert.DeserializeObject<DataContainer>(json);
                return dataContainer ?? new DataContainer(0);
            }
            catch (JsonException ex)
            {
                LogException(ex);
                return new DataContainer(0);
            }
        }
        // skapar en loggfil om det blir fel med att hämta data från json-filen
        private void LogException(Exception ex)
        {
            string logPath = "errorlog.txt";
            string message = $"{DateTime.Now}: Exception occurred - {ex}\n";
            File.AppendAllText(logPath, message);
        }
    }
}
