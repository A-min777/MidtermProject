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
	public partial class FormCreateMbship : Form
	{
		public FormCreateMbship()
		{
			InitializeComponent();
		}

		private int DisplayOrder
		{
			get
			{
				int.TryParse(textBoxDiplsayOrder.Text, out int DisplayOrder);
				return DisplayOrder;
			}
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			var service = new MbshipService();
			try
			{
				MbshipsDto mbships = new MbshipsDto
				{					
					MembershipLevel = textBoxMbLv.Text,
					DisplayOrder = DisplayOrder
				};
				service.Create(mbships);
				MessageBox.Show("新增階級成功");
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗,原因: " + ex.Message);
			}

			((IGrid)this.Owner).BindData();
			this.Close();
		}
	}
}
