using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
	public class PurchaseRecordVM
	{
       
        public int Id { get; set; }

		public string Name { get; set; }

		public int? Amount { get; set; }

		public DateTime? PurchaseDate { get; set; }
	}
}
