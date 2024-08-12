using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WA.Estore.SqlDataLayer;

namespace MidtermProject
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			var password = textBoxPassword.Text;
			var account = textBoxAccount.Text;

			var service = new LoginService();
			try
			{
				service.Login(account, password);

				var form = new Form1();
				form.FormClosed += Form_FormClosed;
				this.Hide();
				form.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"登入失敗, {ex.Message}");
			}
		}

		private void Form_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Show();
		}
	}
}
