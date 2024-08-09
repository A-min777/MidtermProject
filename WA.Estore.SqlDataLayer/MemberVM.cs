using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
	public class MemberVM
	{
		public int Id { get; set; }
		public string MembershipLevel { get; set; }
		public string Name { get; set; }
		public int Gender { get; set; }
		public int Age { get; set; }
		public DateTime Birthday { get; set; }
		public int TotalSpent { get; set; }
	}
}
