using LvpnPortal.Models.LunaCustom.UsrData.Instances;

namespace LvpnPortal.Interfaces
{
	public interface IUsrService
	{
		Task<int> CreateUserAccount(string encryptedUserId);

        List<UsrInstance> UsrInstances { get; }
		Task LoadUsrInstances(string encryptedUserId);
	}
}

