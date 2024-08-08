using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
	public class Mbship
	{
		public int Id { get; set; }
		public string MembershipLevel { get; set; }
		public int DisplayOrder { get; set; }

		public List<Member> Members { get; set; }
	}
}
