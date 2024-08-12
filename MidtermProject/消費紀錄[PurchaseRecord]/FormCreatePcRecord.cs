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
	public partial class FormCreatePcRecord : Form
	{
		public FormCreatePcRecord()
		{
			InitializeComponent();
			Load += FormCreatePcRecord_Load;
		}

		private void FormCreatePcRecord_Load(object sender, EventArgs e)
		{
			using (var db = new AppDbContext())
			{
				var members = db.Members.ToList();
				var combo = this.comboBoxMbName;
				combo.DataSource = members;
				combo.ValueMember =  "Id";
			}
				
		}

		public bool IsValid()
		{
			if (string.IsNullOrEmpty(textBoxAmount.Text)) { MessageBox.Show("請輸入金額"); return false; }
			if (!int.TryParse(textBoxAmount.Text, out int amount)) { MessageBox.Show("金額格式錯誤"); return false; }
			if (dateTimePickerPcDay.Value.Date > DateTime.Today.Date) { MessageBox.Show("日期輸入錯誤"); return false; }

			return true;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			if (IsValid() != true) return;

			try
			{
				using (var db = new AppDbContext())
				{
					
					int.TryParse(textBoxAmount.Text, out int amount);

					var record = new PurchaseRecord
					{

						MemberId = (int)comboBoxMbName.SelectedValue,
						Amount = amount,
						PurchaseDate = dateTimePickerPcDay.Value,
					};

					db.PurchaseRecords.Add(record);
					db.SaveChanges();
					MessageBox.Show("新增消費紀錄成功");
				}				
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗,原因: " + ex.Message);
			}

			((IGrid)this.Owner).BindData();
			this.Close();
		}
	}
}
