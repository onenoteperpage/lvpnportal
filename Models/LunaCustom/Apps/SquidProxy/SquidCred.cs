using System.Text.Json.Serialization;

namespace LvpnPortal.Models.LunaCustom.Apps.SquidProxy
{
    public class SquidCred
    {
        public Guid? SquidCredId { get; set; }

        [JsonPropertyName("ipv4")]
        public string? IPv4 { get; set; }

        [JsonPropertyName("ipv6")]
        public string? IPv6 { get; set; }

        [JsonPropertyName("squid_user")]
        public string? SquidUser { get; set; }

        [JsonPropertyName("squid_pass")]
        public string? SquidPass { get; set; }

        public Guid? UsrInstanceId { get; set; }
    }
}

