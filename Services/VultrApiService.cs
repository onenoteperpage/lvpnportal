using System.Text.Json;
using LvpnPortal.Interfaces;
using LvpnPortal.Models.VultrApi.Regions;

namespace LvpnPortal.Services
{
    public class VultrApiService : IVultrApiService
    {
        private readonly MyTypedHttpClient _myTypedHttpClient;

        public VultrApiService(MyTypedHttpClient myTypedHttpClient)
        {
            _myTypedHttpClient = myTypedHttpClient;
            ConfigureHttpClient();
        }

        private void ConfigureHttpClient()
        {
            _myTypedHttpClient.ConfigureHttpClient("https://api.vultr.com/v2", _myTypedHttpClient.Configuration["ExternalApiKeys:Vultr"]!, client =>
            {
                // No need to set Authorization header here since it's already set in the ConfigureHttpClient method of MyTypedHttpClient
            });
        }

        public VultrRegion VultrRegionData { get; set; } = new VultrRegion();

        public async Task GetRegionsData()
        {
            using (var request = _myTypedHttpClient.CreateRequest(HttpMethod.Get, "/v2/regions"))
            {
                Console.WriteLine($"Request URL: {_myTypedHttpClient.Client.BaseAddress}{request.RequestUri}");

                using (var response = await _myTypedHttpClient.Client.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        VultrRegionData = JsonSerializer.Deserialize<VultrRegion>(jsonString)!;
                    }
                }
            }
        }
    }
}
