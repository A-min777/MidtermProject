using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
	public class MemberService
	{
		private readonly MemberRepo repo;

		public MemberService()
        {
			repo = new MemberRepo();
        }

		public void Update(Member member)
		{
			if (member == null) throw new ArgumentNullException(nameof(member));
			if(member.Age<0) throw new Exception("輸入年齡不可為負數");
			if (member.Name.Length > 20) throw new Exception("輸入名稱太長");
			if (member.Birthday > DateTime.Now) throw new Exception("出生日期輸入錯誤");

			var memberInDb = repo.Get(member.Name);
			if (memberInDb != null && memberInDb.Id != member.Id) throw new ArgumentException("已存在相同姓名");
			repo.Update(member);
		}

		
    }
}
