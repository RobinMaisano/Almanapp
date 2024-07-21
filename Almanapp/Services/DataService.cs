using Almanapp.Models;
using Almanapp.Repository;
using System.Text;
using System.Text.Json;

namespace Almanapp.Services {
    public class DataService {
        private string JSON_PATH;
        private DataRepository DataRepository;

        public DataService() {
            JSON_PATH = Path.Combine(Environment.CurrentDirectory, @"data\test2.json");
            DataRepository = new DataRepository();
        }

        public Almanax GetAlmanaxData() {
            string[] rawData = GetRawDataFromJSON();
            string stringData = FormatRawDataToString(rawData);
            Almanax almanax = DeserializeData(stringData);
            return almanax;
        }

        private string[] GetRawDataFromJSON() {
            string[] rawData = File.ReadAllLines(JSON_PATH);
            return rawData;
        }

        public string FormatRawDataToString(string[] rawData) {
            StringBuilder sb = new StringBuilder();
            foreach (string line in rawData) {
                sb.AppendLine(line);
            }
            return sb.ToString();
        }

        private Almanax DeserializeData(string stringData) {
            return JsonSerializer.Deserialize<Almanax>(stringData, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public Almanax GetAlmanaxDataFromResource() {
            byte[] rawData = DataRepository.LoadJsonResourceAsBytes();
            string stringData = FormatByteArrayDataToString(rawData);
            Almanax almanax = DeserializeData(stringData);
            return almanax;
        }

        private string FormatByteArrayDataToString(byte[] byteArray) {
            string stringData = Encoding.UTF8.GetString(byteArray);
            return stringData;
        }
    }
}
