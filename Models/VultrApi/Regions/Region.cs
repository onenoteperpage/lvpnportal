using System.Text.Json.Serialization;

namespace LvpnPortal.Models.VultrApi.Regions
{
    public class Region
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("options")]
        public List<string>? Options { get; set; }

        [JsonPropertyName("continent")]
        public string? Continent { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }
    }
}

