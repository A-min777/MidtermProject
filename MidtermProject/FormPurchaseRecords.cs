using MidtermProject.EFModels;
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
	public partial class FormPurchaseRecords : Form , IGrid
	{
		public FormPurchaseRecords()
		{
			InitializeComponent();
			Load += FormPurchaseRecords_Load;
		}

		private void FormPurchaseRecords_Load(object sender, EventArgs e)
		{
			BindData();
		}
		List<PurchaseRecordVM> purchase;
		public void BindData()
		{
			using (var db = new AppDbContext())
			{
				purchase = db.PurchaseRecords
					.AsNoTracking()
					.Select(x => new PurchaseRecordVM
					{
						Id = x.Id,
						Name = x.Member.Name,
						Amount = x.Amount,
						PurchaseDate = x.PurchaseDate,
					}).ToList();
				dataGridView1.DataSource = purchase;
			}		
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			var frm = new FormEditPcRecord(purchase[e.RowIndex].Id);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
