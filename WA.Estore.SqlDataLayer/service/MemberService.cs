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

		public void ValueCheck(Member member)
		{
			if (string.IsNullOrEmpty(member.Name)) throw new Exception("輸入名稱不可為空白");
			if (member.Name.Length > 15) throw new Exception("輸入名稱太長");
			if (member.Birthday > DateTime.Today.AddDays(1)) throw new Exception("出生日期輸入錯誤");

			var memberInDb = repo.Get(member.Name);
			if (memberInDb != null && memberInDb.Id != member.Id) throw new ArgumentException("已存在相同姓名");
						
		} 
		public void Update(Member member)
		{
			ValueCheck(member);
			repo.Update(member);
		}

		public void Create(Member member)
		{
			ValueCheck(member);
			repo.Create(member);
		}

	}
}
