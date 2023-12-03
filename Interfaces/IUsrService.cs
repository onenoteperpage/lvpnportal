namespace LvpnPortal.Interfaces
{
	public interface IUsrService
	{
		Task CreateUserAccount(string encryptedUserId);
	}
}

