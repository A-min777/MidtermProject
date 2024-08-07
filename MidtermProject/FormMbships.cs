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
	public partial class FormMbships : Form , IGrid
	{
		public FormMbships()
		{
			InitializeComponent();
			Load += FormMbships_Load;
		}

		private void FormMbships_Load(object sender, EventArgs e)
		{
			BindData();
		}

		public void BindData()
		{
			List<MbshipsDto> mbships = new MbshipRepo().GetAll();
			dataGridView1.DataSource = mbships;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var data = dataGridView1.DataSource as List<MbshipsDto>;
			int EditId = data[e.RowIndex].Id;

			var frm = new FormEditMbship(EditId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
