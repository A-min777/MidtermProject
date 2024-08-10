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
	public partial class FormCreateMember : Form
	{
		public FormCreateMember()
		{
			InitializeComponent();
		}
		private int Age
		{
			get
			{
				DateTime Bday = dateTimePickerBDay.Value;
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

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			var service = new MemberService();
			Member members = new Member
			{
				Name = textBoxMbName.Text,
				Gender = Gender,
				Age = Age,
				Birthday = dateTimePickerBDay.Value.Date,
			};

			try
			{
				service.Create(members);
				MessageBox.Show("會員建立成功");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				MessageBox.Show("更新失敗,原因: " + ex.Message);
			}

			((IGrid)this.Owner).BindData();
			this.Close();
		}
	}
}
