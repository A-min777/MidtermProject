using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WA.Estore.SqlDataLayer;

namespace MidtermProject
{
	public partial class FormMembers : Form , IGrid
	{
		public FormMembers()
		{
			InitializeComponent();
			Load += FormMembers_Load;
		}

		private void FormMembers_Load(object sender, EventArgs e)
		{
			BindData();
		}

		List<Member> members;
		public void BindData()
		{						
			string sql = "SELECT * FROM Members ORDER BY id";
			using (var conn = new SqlConnection(SqlDb.GetconnString("default")))
			{
				members = conn.Query<Member>(sql).ToList();
			}
			dataGridView1.DataSource = members;							
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.RowIndex < 0) return;

			var frm = new FormEditMember(members[e.RowIndex].Id);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
