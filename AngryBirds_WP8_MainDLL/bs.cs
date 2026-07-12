using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class bs
{
	public static string b(string A_0, string A_1, string A_2)
	{
		AesManaged aesManaged = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(A_1, Encoding.UTF8.GetBytes(A_2), 1000);
			aesManaged = new AesManaged();
			((SymmetricAlgorithm)(object)aesManaged).Key = rfc2898DeriveBytes.GetBytes(32);
			((SymmetricAlgorithm)(object)aesManaged).IV = rfc2898DeriveBytes.GetBytes(16);
			memoryStream = new MemoryStream();
			cryptoStream = new CryptoStream(memoryStream, ((SymmetricAlgorithm)(object)aesManaged).CreateEncryptor(), CryptoStreamMode.Write);
			byte[] bytes = Encoding.UTF8.GetBytes(A_0);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
		finally
		{
			cryptoStream?.Close();
			memoryStream?.Close();
			((SymmetricAlgorithm)(object)aesManaged)?.Clear();
		}
	}

	public static string a(string A_0, string A_1, string A_2)
	{
		AesManaged aesManaged = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(A_1, Encoding.UTF8.GetBytes(A_2), 1000);
			aesManaged = new AesManaged();
			((SymmetricAlgorithm)(object)aesManaged).Key = rfc2898DeriveBytes.GetBytes(32);
			((SymmetricAlgorithm)(object)aesManaged).IV = rfc2898DeriveBytes.GetBytes(16);
			memoryStream = new MemoryStream();
			cryptoStream = new CryptoStream(memoryStream, ((SymmetricAlgorithm)(object)aesManaged).CreateDecryptor(), CryptoStreamMode.Write);
			byte[] array = Convert.FromBase64String(A_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			return Encoding.UTF8.GetString(array2, 0, array2.Length);
		}
		finally
		{
			cryptoStream?.Close();
			memoryStream?.Close();
			((SymmetricAlgorithm)(object)aesManaged)?.Clear();
		}
	}
}
