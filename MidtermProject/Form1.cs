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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			BindData();
		}

		private void buttonConnDb_Click(object sender, EventArgs e)
		{
			using(var conn = new SqlDb().Getconn("default"))
			{
				conn.Open();
			}
			MessageBox.Show("連結成功");
		}

		public void BindData()
		{
			using (var conn = new SqlDb().Getconn("default"))
			{
				try
				{
					conn.Open();
					DataTable schema = conn.GetSchema("Tables");

					var tablesHide = new[] { "sysdiagrams", "Admins" };

					foreach(DataRow row in schema.Rows)
					{
						string tableName = row["TABLE_NAME"].ToString();

						if (!tablesHide.Contains(tableName))
						{
							comboBox1.Items.Add(tableName);
						}
						
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("錯誤: " + ex.Message);
				}

			}
		}

		private void buttonMbships_Click(object sender, EventArgs e)
		{
			new FormMbships().ShowDialog();
		}

		private void buttonGetAll_Click(object sender, EventArgs e)
		{			

			int selected = comboBox1.SelectedIndex;
			
			switch (selected)
			{
				case -1:
					MessageBox.Show("未選取資料表"); ;
					break;
				case 1:
					new FormMbships().ShowDialog();
					break;
				default:
					MessageBox.Show("未找到資料表");
					return;
			}
		}			

	}
}
