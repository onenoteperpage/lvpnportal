using System.Text.Json.Serialization;

namespace LvpnPortal.Models.VultrApi.Shared
{
    public class Meta
    {
        [JsonPropertyName("total")]
        public int? Total { get; set; }

        [JsonPropertyName("links")]
        public Links? Links { get; set; }
    }
}

