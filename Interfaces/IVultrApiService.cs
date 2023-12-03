using LvpnPortal.Models.VultrApi.Regions;

namespace LvpnPortal.Interfaces
{
	public interface IVultrApiService
	{
        VultrRegion VultrRegionData { get; }
		Task GetRegionsData();
	}
}

