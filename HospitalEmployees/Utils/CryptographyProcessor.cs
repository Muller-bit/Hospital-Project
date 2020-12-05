using System;
using System.Security.Cryptography;
using System.Text;

namespace HospitalEmployees.Classes
{
	static public class CryptographyProcessor
	{
		static public string CreateSalt(int size)
		{
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			byte[] buff = new byte[size];
			rng.GetBytes(buff);
			return Convert.ToBase64String(buff);
		}

		static public string GenerateHash(string input, string salt)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
			return Convert.ToBase64String(new SHA256Managed().ComputeHash(bytes));
		}

		static public bool AreEqual(string plainTextInput, string hashedInput, string salt)
		{
			return GenerateHash(plainTextInput, salt).Equals(hashedInput);
		}
	}
}
