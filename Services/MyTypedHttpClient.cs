using System.Net.Http.Headers;

public class MyTypedHttpClient
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public MyTypedHttpClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    public void ConfigureHttpClient(string baseAddress, string bearerToken)
    {
        _httpClient.BaseAddress = new Uri(baseAddress);
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
    }

    public void ConfigureHttpClient(string baseAddress, string bearerToken, Action<HttpClient> configurator)
    {
        ConfigureHttpClient(baseAddress, bearerToken);
        configurator?.Invoke(_httpClient);
    }

    public HttpClient Client => _httpClient;

    public HttpRequestMessage CreateRequest(HttpMethod method, string endpoint)
    {
        return new HttpRequestMessage(method, endpoint);
    }

    public IConfiguration Configuration => _configuration;
}
