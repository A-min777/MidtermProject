namespace MidtermProject
{
	partial class FormMembers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column2,
            this.NewName,
            this.Gender,
            this.Age,
            this.Birthday,
            this.TotalSpent});
			this.dataGridView1.Location = new System.Drawing.Point(12, 23);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(761, 234);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "MembershipLevel";
			this.Column2.HeaderText = "會員階級";
			this.Column2.Name = "Column2";
			// 
			// NewName
			// 
			this.NewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NewName.DataPropertyName = "Name";
			this.NewName.HeaderText = "會員姓名";
			this.NewName.Name = "NewName";
			// 
			// Gender
			// 
			this.Gender.DataPropertyName = "Gender";
			this.Gender.HeaderText = "性別";
			this.Gender.Name = "Gender";
			// 
			// Age
			// 
			this.Age.DataPropertyName = "Age";
			this.Age.HeaderText = "年齡";
			this.Age.Name = "Age";
			// 
			// Birthday
			// 
			this.Birthday.DataPropertyName = "Birthday";
			this.Birthday.HeaderText = "出生日期";
			this.Birthday.Name = "Birthday";
			// 
			// TotalSpent
			// 
			this.TotalSpent.DataPropertyName = "TotalSpent";
			this.TotalSpent.HeaderText = "累計消費";
			this.TotalSpent.Name = "TotalSpent";
			// 
			// FormMembers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 331);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormMembers";
			this.Text = "FormMembers";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn NewName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalSpent;
	}
}