using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WA.Estore.SqlDataLayer;

namespace MidtermProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonConnDb_Click(object sender, EventArgs e)
		{
			using(var conn = new SqlDb().Getconn("default"))
			{
				conn.Open();
			}
			MessageBox.Show("連結成功");
		}
	}
}
