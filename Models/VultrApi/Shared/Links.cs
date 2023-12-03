using System.Text.Json.Serialization;

namespace LvpnPortal.Models.VultrApi.Shared
{
    public class Links
    {
        [JsonPropertyName("next")]
        public string? Next { get; set; }

        [JsonPropertyName("prev")]
        public string? Prev { get; set; }
    }
}

