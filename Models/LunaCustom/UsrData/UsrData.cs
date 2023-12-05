using System.Text.Json.Serialization;
using LvpnPortal.Models.LunaCustom.UsrData.AccountHistory;
using LvpnPortal.Models.LunaCustom.UsrData.Instances;

namespace LvpnPortal.Models.LunaCustom.UsrData
{
    public class UsrData
    {
        public Guid? UsrDataId { get; set; }

        [JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        [JsonPropertyName("available_instances")]
        public int AvailableInstances { get; set; }

        [JsonPropertyName("instance_count")]
        public int InstanceCount { get; set; }

        [JsonPropertyName("instance_purchases")]
        public List<InstancePurchase>? Purchases { get; set; }

        [JsonPropertyName("usr_instances")]
        public List<UsrInstance>? UsrInstances { get; set; }
    }
}

