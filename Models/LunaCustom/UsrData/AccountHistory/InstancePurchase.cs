using System.Text.Json.Serialization;

namespace LvpnPortal.Models.LunaCustom.UsrData.AccountHistory
{
    public class InstancePurchase
    {
        public Guid? InstancePurchaseId { get; set; }

        [JsonPropertyName("expiration_date")]
        public DateTime Expiry { get; set; }

        [JsonPropertyName("purchase_method")]
        public string? PurchaseMethod { get; set; }

        public Guid? UsrDataId { get; set; }
    }
}

