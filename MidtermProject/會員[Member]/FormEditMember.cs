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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MidtermProject
{
	public partial class FormEditMember : Form
	{
		private readonly int id;

		public FormEditMember(int id)
		{
			InitializeComponent();
			Load += FormEditMember_Load;
			this.id = id;
		}

		private void FormEditMember_Load(object sender, EventArgs e)
		{
			LoadDate();
		}
		private int Age
		{
			get
			{
				DateTime Bday =  dateTimePickerBDay.Value;
				return (int)DateTime.Today.Year - Bday.Year;
			}
		}

		private int Gender
		{
			get
			{
				return radioButtonF.Checked == true ? 0 : 1;
			}
		}

		private void LoadDate()
		{
			Member members = new MemberRepo().Get(id);

			textBoxMbName.Text = members.Name;						
			radioButtonF.Checked = members.Gender == 0;
			dateTimePickerBDay.Value = members.Birthday;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var service = new MemberService();
			Member members = new Member
			{
				Id = id,
				Name = textBoxMbName.Text,
				Age = Age,
				Gender = Gender,
				Birthday = dateTimePickerBDay.Value.Date,
			};

			try
			{
				service.Update(members);
				MessageBox.Show("更新會員成功");
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗,原因: " + ex.Message);
			}
			((IGrid)this.Owner).BindData();
			this.Close();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			var repo = new MemberRepo();

			DialogResult result = MessageBox.Show(
				"您確定要刪除這個項目嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				try
				{
					repo.Delete(id);
					MessageBox.Show("成功刪除會員");
				}
				catch (Exception ex)
				{
					MessageBox.Show("刪除失敗,原因:" + ex.Message);
				}

				((IGrid)this.Owner).BindData();
				this.Close();
			}
		}
	}
}
