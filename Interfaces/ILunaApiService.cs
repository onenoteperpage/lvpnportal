using LvpnPortal.Models.LunaCustom;

namespace LvpnPortal.Interfaces
{
	public interface ILunaApiService
	{
        List<LunaCIP> LunaCIPs { get; }
		Task GetRegions();
	}
}

