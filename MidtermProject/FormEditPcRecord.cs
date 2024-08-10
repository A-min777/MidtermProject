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

namespace MidtermProject
{
	public partial class FormEditPcRecord : Form
	{
		private readonly int id;

		public FormEditPcRecord(int id)
		{
			InitializeComponent();
			Load += FormEditPcRecord_Load;
			this.id = id;
		}

		private void FormEditPcRecord_Load(object sender, EventArgs e)
		{
			LoadDate();
			this.membersTableAdapter1.Fill(this.midtermDataSet1.Members);
		}

		private void LoadDate()
		{
			using (var db = new AppDbContext())
			{
				PurchaseRecord record = db.PurchaseRecords
					.AsNoTracking()
					.FirstOrDefault(x => x.Id == id);				
				textBoxAmount.Text = record.Amount.ToString();
				comboBoxMbName.Text = record.Member.Name;
				dateTimePickerPcDay.Value = (DateTime)record.PurchaseDate;
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBoxAmount.Text)) { MessageBox.Show("請輸入金額"); }
			int.TryParse(textBoxAmount.Text, out int amount);
			if (dateTimePickerPcDay.Value > DateTime.Today) { MessageBox.Show("日期輸入錯誤"); }

			using (var db = new AppDbContext())
			{
				PurchaseRecord record = db.PurchaseRecords					
					.FirstOrDefault(x => x.Id == id);
				try
				{
					record.MemberId= (int)comboBoxMbName.SelectedValue;
					record.Amount = amount;
					record.PurchaseDate = dateTimePickerPcDay.Value;

					db.SaveChanges();
					MessageBox.Show("更新消費紀錄成功");
				}
				catch(Exception ex)
				{
					MessageBox.Show("錯誤: " + ex.Message);
				}				
			}
			((IGrid)this.Owner).BindData();
			this.Close();
		}

		
	}
}
