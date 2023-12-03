using System.Text.Json.Serialization;
using LvpnPortal.Models.VultrApi.Shared;

namespace LvpnPortal.Models.VultrApi.Regions
{
	public class VultrRegion
	{
        [JsonPropertyName("regions")]
        public List<Region>? Regions { get; set; }

        [JsonPropertyName("meta")]
        public Meta? Meta { get; set; }
    }
}

