using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using LvpnPortal.Interfaces;
using LvpnPortal.Models.LunaCustom.UsrData;

namespace LvpnPortal.Services
{
    public class UsrService : IUsrService
    {
        private readonly MyTypedHttpClient _myTypedHttpClient;
        private readonly IConfiguration _configuration;

        public UsrService(MyTypedHttpClient myTypedHttpClient, IConfiguration configuration)
        {
            _myTypedHttpClient = myTypedHttpClient;
            _configuration = configuration;
            ConfigureHttpClient();
        }

        private void ConfigureHttpClient()
        {
            string apiUrl = _configuration["ApiUrls:LunaApi"]!;
            _myTypedHttpClient.ConfigureHttpClient(apiUrl, _myTypedHttpClient.Configuration["InternalApiKeys:UsrService"]!, client =>
            {
                // No need to set Authorization header here since it's already set in the ConfigureHttpClient method of MyTypedHttpClient
            });
        }

        public async Task<int> CreateUserAccount(string encryptedUserId)
        {
            UsrData usrData = new UsrData()
            {
                AccountId = encryptedUserId,
                InstanceCount = 0,
                AvailableInstances = 0,
            };

            // Create JsonSerializerOptions with DefaultIgnoreCondition
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase, // Optional: Use camelCase for property names
            };

            // Serialize the object into JSON using JsonSerializerOptions
            string jsonBody = JsonSerializer.Serialize(usrData, options);

            try
            {
                using (var request = _myTypedHttpClient.CreateRequest(HttpMethod.Post, "/api/UsrData"))
                {
                    request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    using (var response = await _myTypedHttpClient.Client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            // Handle success
                            return 0;
                        }
                        else
                        {
                            // Handle failure
                            return 1;
                        }
                    }
                }
            }
            catch
            {
                // Handle failure
                return 1;
            }
        }
    }
}

