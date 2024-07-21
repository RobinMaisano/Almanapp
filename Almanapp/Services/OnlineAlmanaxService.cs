using Almanapp.Models;
using Almanapp.Services.Interfaces;
using System.Net.Http.Headers;

namespace Almanapp.Services {
    [Obsolete]
    public class OnlineAlmanaxService : IAlmanaxService {

        private readonly HttpClient client;

        public OnlineAlmanaxService(HttpClient httpClient) {
            client = httpClient;
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Path = AlmanappConstants.ONLINE_ALMANAX_URL;
            client.BaseAddress = uriBuilder.Uri;
        }

        public AlmanaxDay FindAlmanaxDayWithDateTime(DateTime date) {

            var request = GetOneAlmanaxDay(date);
            request.Wait();

            var result = request.Result;

            throw new NotImplementedException();
        }

        private async Task<string> GetOneAlmanaxDay(DateTime date) {
            return await client.GetStringAsync("https://www.krosmoz.com/fr/almanax/2024-01-01");
        }

        public void POC_OnlineAlmanax() {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("text/html"));
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:128.0)");

            var request = GetOneAlmanaxDay(DateTime.Now);
            request.Wait();
            var result = request.Result;
        }
    }
}
