using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
	public class LoginService
	{
		private readonly LoginRepo _repo;

		public LoginService()
		{
			_repo = new LoginRepo();
		}

		private void ValueCheck(string text)
		{
			if (string.IsNullOrEmpty(text)) { throw new Exception("輸入名稱不可為空白"); }
		}

		public void Login(string account, string password)
		{
			ValueCheck(account);
			ValueCheck(password);

			var adminInDb = _repo.GetData(account);
			if (adminInDb.Password != password)
			{
				throw new Exception("帳號或密碼錯誤");
			}
		}
	}
}
