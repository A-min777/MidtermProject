using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
	public class LoginRepo
	{
        public static (string Hash, string Salt) CreateHash(string password)
		{
			var salt = GenerateSalt();
			var hash = ComputeHash(password, salt);
			return (Convert.ToBase64String(hash), Convert.ToBase64String(salt));
		}

		public bool VerifyPassword(string password, string storeHash, string sroreSalt)
		{
			var salt = Convert.FromBase64String(sroreSalt);
			var hash = Convert.FromBase64String(storeHash);
			var computedHash = ComputeHash(password, salt);
			return AreEqual(computedHash, hash);
		}

		private static byte[] GenerateSalt()
		{
			var salt = new byte[16];
			using (var rng = RandomNumberGenerator.Create())
			{
				rng.GetBytes(salt);
			}
			return salt;
		}

		private static byte[] ComputeHash(string password, byte[] salt)
		{
			using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
			{
				return pbkdf2.GetBytes(32);
			}
		}

		private static bool AreEqual(byte[] computedHash, byte[] hash)
		{
			if (computedHash.Length != hash.Length) return false;
			for (int i = 0; i < computedHash.Length; i++)
			{
				if (computedHash[i] != hash[i]) return false;
			}
			return true;
		}

		public adminDto GetData(string account)
		{
			var sql = $"SELECT * FROM Admins Where Account = @account";
			var db = new SqlDb();

			Func<SqlDataReader, adminDto> func = (reader) =>
			{
				if (reader.Read()) // 確保有讀取到資料
				{
					int id = (int)reader["Id"];
					account = reader["Account"].ToString();
					string password = reader["Password"].ToString();
					
					return new adminDto { Id = id, Account = account, Password = password };
				}
				return new adminDto { Id = 1, Account = "NotFound", Password = "NotFound" };
			};
			var parameters = new SqlParameter[]
			{
				new SqlParameter ("@account",account)
			};

			adminDto dto = db.Get("default", sql, func, parameters);
			return dto;
		}
	}

}

