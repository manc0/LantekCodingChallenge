using LantekCodingChallenge.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace LantekCodingChallenge.Services
{
    public class LantekAPIService
    {
        private readonly HttpClient _client;

        public LantekAPIService()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://app-academy-neu-codechallenge.azurewebsites.net")
            };
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<CuttingMachine>?> GetMachinesAsync(string resource, BasicAuth auth)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(auth.Bytes));
            using HttpResponseMessage response = await _client.GetAsync(resource);
            response.EnsureSuccessStatusCode();

            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<CuttingMachine>>(result);
        }
    }
}