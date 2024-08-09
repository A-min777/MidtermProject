using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
	public class Member
	{
		public Member()
		{
			Mbships = new List<Mbship>();
			MembershipId = 1;
			TotalSpent = 0;
		}
		public int Id { get; set; }
		public int MembershipId { get; set; }
		public string Name { get; set; }
		public int Gender { get; set; }
		public int Age { get; set; }
		public DateTime Birthday { get; set; }
        public int TotalSpent { get; set; }

		public List<Mbship> Mbships { get; set; }

    }
}
