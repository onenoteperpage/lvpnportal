using System.Text.Json.Serialization;
using LvpnPortal.Models.LunaCustom.Apps.SquidProxy;
using LvpnPortal.Models.LunaCustom.Apps.Wireguard;

namespace LvpnPortal.Models.LunaCustom.UsrData.Instances
{
    public class UsrInstance
    {
        public Guid? UsrInstanceId { get; set; }

        [JsonPropertyName("usr_id")]  //who owns this
        public string? UsrId { get; set; }

        [JsonPropertyName("provider")]  //who provides this
        public string? Provider { get; set; }

        [JsonPropertyName("cip_instance_id")]  //which one is it?
        public string? CipInstanceId { get; set; }

        [JsonPropertyName("expiration")]  //when does it expire?
        public DateTime? Expires { get; set; }

        [JsonPropertyName("app")]  //what does it do?
        public string? Application { get; set; }

        [JsonPropertyName("ipv4")]  //ipv4 address
        public string? IPv4 { get; set; }

        [JsonPropertyName("ipv6")]  //ipv6 address
        public string? IPv6 { get; set; }

        [JsonPropertyName("wg_peer")]
        public WgPeer? WgPeer { get; set; }

        [JsonPropertyName("squid_cred")]
        public SquidCred? SquidCred { get; set; }

        public Guid? UsrDataId { get; set; }
    }
}

