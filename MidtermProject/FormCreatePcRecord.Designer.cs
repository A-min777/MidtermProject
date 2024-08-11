namespace MidtermProject
{
	partial class FormCreatePcRecord
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
			this.comboBoxMbName = new System.Windows.Forms.ComboBox();
			this.dateTimePickerPcDay = new System.Windows.Forms.DateTimePicker();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBoxMbName
			// 
			this.comboBoxMbName.DisplayMember = "Name";
			this.comboBoxMbName.FormattingEnabled = true;
			this.comboBoxMbName.Location = new System.Drawing.Point(108, 37);
			this.comboBoxMbName.Name = "comboBoxMbName";
			this.comboBoxMbName.Size = new System.Drawing.Size(121, 20);
			this.comboBoxMbName.TabIndex = 23;
			this.comboBoxMbName.ValueMember = "Id";
			// 
			// dateTimePickerPcDay
			// 
			this.dateTimePickerPcDay.Location = new System.Drawing.Point(107, 130);
			this.dateTimePickerPcDay.Name = "dateTimePickerPcDay";
			this.dateTimePickerPcDay.Size = new System.Drawing.Size(122, 22);
			this.dateTimePickerPcDay.TabIndex = 22;
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(50, 177);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(179, 33);
			this.buttonCreate.TabIndex = 21;
			this.buttonCreate.Text = "新增";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 17;
			this.label3.Text = "消費日期";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Location = new System.Drawing.Point(107, 83);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(122, 22);
			this.textBoxAmount.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 18;
			this.label2.Text = "消費金額";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 19;
			this.label1.Text = "會員姓名";
			// 
			// FormCreatePcRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 249);
			this.Controls.Add(this.comboBoxMbName);
			this.Controls.Add(this.dateTimePickerPcDay);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormCreatePcRecord";
			this.Text = "FormCreatePcRecord";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxMbName;
		private System.Windows.Forms.DateTimePicker dateTimePickerPcDay;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}