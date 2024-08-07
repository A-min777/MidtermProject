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
	public partial class FormEditMbship : Form
	{
		public readonly int id;

		public FormEditMbship(int id )
		{
			InitializeComponent();
			Load += FormEditMbship_Load;
			this.id = id;
		}

		private void FormEditMbship_Load(object sender, EventArgs e)
		{
			BindDate(id);
		}

		private void BindDate(int id)
		{
			MbshipsDto mbships = new MbshipRepo().GetData(id);

			textBoxMbLv.Text = mbships.MembershipLevel;
			textBoxDiplsayOrder.Text = mbships.DisplayOrder.ToString();
		}
		private int DisplayOrder
		{
			get
			{
				int.TryParse(textBoxDiplsayOrder.Text, out int DisplayOrder);
				return DisplayOrder;
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var service = new MbshipService();
			try
			{
				MbshipsDto mbships = new MbshipsDto
				{
					Id = id,
					MembershipLevel = textBoxMbLv.Text,
					DisplayOrder = DisplayOrder
				};
				service.Update(mbships);
				MessageBox.Show("更新會員階級成功");
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
