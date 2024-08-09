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

		List<MemberVM> memberVM;
		public void BindData()
		{						
			string sql = @"SELECT M.* , MS.MembershipLevel
FROM Members AS M 
INNER JOIN Memberships AS  MS ON M.MembershipId = MS.Id
ORDER BY MembershipLevel";
			using (var conn = new SqlConnection(SqlDb.GetconnString("default")))
			{
				memberVM = conn.Query<MemberVM>(sql).ToList();
			}
			dataGridView1.DataSource = memberVM;							
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.RowIndex < 0) return;

			var frm = new FormEditMember(memberVM[e.RowIndex].Id);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
