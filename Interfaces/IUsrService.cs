namespace LvpnPortal.Interfaces
{
	public interface IUsrService
	{
		Task<int> CreateUserAccount(string encryptedUserId);
	}
}

