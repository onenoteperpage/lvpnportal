using System.Text.Json;
using LvpnPortal.Interfaces;
using LvpnPortal.Models.LunaCustom;

namespace LvpnPortal.Services
{
    public class LunaApiService : ILunaApiService
	{
        private readonly MyTypedHttpClient _myTypedHttpClient;
        private readonly IConfiguration _configuration;

        public LunaApiService(MyTypedHttpClient myTypedHttpClient, IConfiguration configuration)
        {
            _myTypedHttpClient = myTypedHttpClient;
            _configuration = configuration;
            ConfigureHttpClient();
        }

        private void ConfigureHttpClient()
        {
            string apiUrl = _configuration["ApiUrls:LunaApi"]!;
            _myTypedHttpClient.ConfigureHttpClient(apiUrl, _myTypedHttpClient.Configuration["InternalApiKeys:LunaCIP"]!, client =>
            {
                // No need to set Authorization header here since it's already set in the ConfigureHttpClient method of MyTypedHttpClient
            });
        }

        public List<LunaCIP> LunaCIPs { get; set; } = new List<LunaCIP>();

        public async Task GetRegions()
        {
            using (var request = _myTypedHttpClient.CreateRequest(HttpMethod.Get, "/api/LunaCIP"))
            {
                using (var response = await _myTypedHttpClient.Client.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        LunaCIPs = JsonSerializer.Deserialize<List<LunaCIP>>(jsonString)!;
                    }
                }
            }
        }
    }
}

