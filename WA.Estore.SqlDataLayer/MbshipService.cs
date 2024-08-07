using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
	public class MbshipService
	{
		public void Update(MbshipsDto dto)
		{
			//驗證傳入的數值
			if (string.IsNullOrEmpty(dto.MembershipLevel)) throw new Exception("階級名稱不可為空白");
			if (dto.DisplayOrder < 0) throw new Exception("輸入順序不可為負數");

			var repo = new MbshipRepo();

			//檢查名稱是否長,是否存在(business logic)
			if (dto.MembershipLevel.Length > 20) throw new Exception("輸入名稱太長");
			if (repo.IsExists(dto.MembershipLevel, dto.Id)) throw new Exception("輸入名稱已存在");

			//呼叫repository的Create

			repo.Update(dto);

		}
	}
}
