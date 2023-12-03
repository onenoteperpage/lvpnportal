//using LvpnPortal.Interfaces;

//namespace LvpnPortal.Services
//{
//    public class UsrService : IUsrService
//	{
//        private readonly LvHttpClient _lvHttpClient;

//        public UsrService(LvHttpClient lvHttpClient)
//        {
//            _lvHttpClient = lvHttpClient ?? throw new ArgumentNullException(nameof(lvHttpClient));
//        }

//        public async Task CreateUserAccount(string encryptedUserId)
//        {
//            var endpoint = $"/api/UsrData/NewUser/{encryptedUserId}";

//            var response = await _lvHttpClient.PostAsync(endpoint, new StringContent(""));

//            // Process the response as needed
//            if (response.IsSuccessStatusCode)
//            {
//                //TODO: Add a response handler for the GUI
//            }
//            else
//            {
//                //TODO: Add a response handler for the GUI
//                Console.WriteLine($"Error: {response.StatusCode}");
//            }
//        }
//    }
//}

