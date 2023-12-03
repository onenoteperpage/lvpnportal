using System.Security.Cryptography;
using System.Text;

namespace LvpnPortal.Shared.Helper
{
	public class EncryptionHelper
	{
        private static byte[] GetKey()
        {
            string secretKey = "hR7jFvX2LwNp3QcGmZaDqB8sUyP9xK4o";
            byte[] keyBytes = Encoding.UTF8.GetBytes(secretKey);
            Array.Resize(ref keyBytes, 32); // 32 bytes = 256 bits
            return keyBytes;
        }

        public static string GenerateToken(string data)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = GetKey();
                aesAlg.IV = new byte[16];
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                byte[] encryptedBytes;
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(data);
                        }
                    }
                    encryptedBytes = msEncrypt.ToArray();
                }
                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }
}

