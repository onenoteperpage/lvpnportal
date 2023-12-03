using LvpnPortal.Shared.Helper;

namespace LvpnPortal.Models.Enums
{
	public enum CloudInstanceProvider
	{
		[EnumStringValue("Vultr")]
		VULTR,

		[EnumStringValue("GCP")]
		GOOGLE_CLOUD_PLATFORM,

		[EnumStringValue("AWS")]
		AMAZON_WEB_SERVICES,

		[EnumStringValue("DigitalOcean")]
		DIGITAL_OCEAN
	}
}

