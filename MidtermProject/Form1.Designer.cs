namespace MidtermProject
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonConnDb = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.buttonGetAll = new System.Windows.Forms.Button();
			this.buttonMbships = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonConnDb
			// 
			this.buttonConnDb.Location = new System.Drawing.Point(27, 28);
			this.buttonConnDb.Name = "buttonConnDb";
			this.buttonConnDb.Size = new System.Drawing.Size(204, 40);
			this.buttonConnDb.TabIndex = 0;
			this.buttonConnDb.Text = "連結Db";
			this.buttonConnDb.UseVisualStyleBackColor = true;
			this.buttonConnDb.Click += new System.EventHandler(this.buttonConnDb_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(27, 83);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(123, 20);
			this.comboBox1.TabIndex = 1;
			// 
			// buttonGetAll
			// 
			this.buttonGetAll.Location = new System.Drawing.Point(156, 80);
			this.buttonGetAll.Name = "buttonGetAll";
			this.buttonGetAll.Size = new System.Drawing.Size(75, 23);
			this.buttonGetAll.TabIndex = 2;
			this.buttonGetAll.Text = "清單總覽";
			this.buttonGetAll.UseVisualStyleBackColor = true;
			this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
			// 
			// buttonMbships
			// 
			this.buttonMbships.Location = new System.Drawing.Point(27, 126);
			this.buttonMbships.Name = "buttonMbships";
			this.buttonMbships.Size = new System.Drawing.Size(123, 54);
			this.buttonMbships.TabIndex = 3;
			this.buttonMbships.Text = "會員資格編輯";
			this.buttonMbships.UseVisualStyleBackColor = true;
			this.buttonMbships.Click += new System.EventHandler(this.buttonMbships_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonMbships);
			this.Controls.Add(this.buttonGetAll);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.buttonConnDb);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonConnDb;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button buttonGetAll;
		private System.Windows.Forms.Button buttonMbships;
	}
}

