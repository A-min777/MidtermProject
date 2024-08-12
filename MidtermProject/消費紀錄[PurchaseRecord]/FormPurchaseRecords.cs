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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidtermProject
{
	public partial class FormPurchaseRecords : Form , IGrid
	{
		public FormPurchaseRecords()
		{
			InitializeComponent();
			Load += FormPurchaseRecords_Load;
			comboBoxOrderBy.SelectedIndexChanged += ComboBoxOrderBy_SelectedIndexChanged;
		}

		private void ComboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindData();
		}

		private void FormPurchaseRecords_Load(object sender, EventArgs e)
		{
			InitCombo();			
		}	

		private void InitCombo()
		{
			var order = new List<Order>
			{
				new Order {Id = 1 , Text = "預設" },
				new Order {Id = 2 , Text = "以會員姓名排序" },
				new Order {Id = 3 , Text = "以消費日期排序" },
			};
			var combo = this.comboBoxOrderBy;	
			combo.DataSource = order;
			combo.DisplayMember = "Text";
		}

		public void BindData()
		{
			int selected = comboBoxOrderBy.SelectedIndex;

			switch (selected)
			{
				
				case 0:
					OrderByDefault();
					break;
				case 1:
					OrderByMember();
					break;
				case 2:
					OrderByPurchase();
					break;				
			}
		}

		List<PurchaseRecordVM> purchase;
		public void OrderByDefault()
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
		public void OrderByMember()
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
					})
					.OrderBy(x => x.Name)
					.ToList();
				dataGridView1.DataSource = purchase;
			}
		}
		public void OrderByPurchase()
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
					})
					.OrderBy(x => x.PurchaseDate)
					.ToList();
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

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			var frm = new FormCreatePcRecord();
			frm.Owner = this;
			frm.ShowDialog();
		}
	}

	public class Order
	{
		public int Id { get; set; }
		public string Text { get; set; }
	}
}
