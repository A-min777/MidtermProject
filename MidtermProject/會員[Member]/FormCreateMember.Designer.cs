namespace MidtermProject
{
	partial class FormCreateMember
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonM = new System.Windows.Forms.RadioButton();
			this.radioButtonF = new System.Windows.Forms.RadioButton();
			this.dateTimePickerBDay = new System.Windows.Forms.DateTimePicker();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxMbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonM);
			this.groupBox1.Controls.Add(this.radioButtonF);
			this.groupBox1.Location = new System.Drawing.Point(134, 86);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(101, 49);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			// 
			// radioButtonM
			// 
			this.radioButtonM.AutoSize = true;
			this.radioButtonM.Checked = true;
			this.radioButtonM.Location = new System.Drawing.Point(10, 18);
			this.radioButtonM.Name = "radioButtonM";
			this.radioButtonM.Size = new System.Drawing.Size(35, 16);
			this.radioButtonM.TabIndex = 10;
			this.radioButtonM.TabStop = true;
			this.radioButtonM.Text = "男";
			this.radioButtonM.UseVisualStyleBackColor = true;
			// 
			// radioButtonF
			// 
			this.radioButtonF.AutoSize = true;
			this.radioButtonF.Location = new System.Drawing.Point(60, 18);
			this.radioButtonF.Name = "radioButtonF";
			this.radioButtonF.Size = new System.Drawing.Size(35, 16);
			this.radioButtonF.TabIndex = 10;
			this.radioButtonF.TabStop = true;
			this.radioButtonF.Text = "女";
			this.radioButtonF.UseVisualStyleBackColor = true;
			// 
			// dateTimePickerBDay
			// 
			this.dateTimePickerBDay.Location = new System.Drawing.Point(134, 150);
			this.dateTimePickerBDay.Name = "dateTimePickerBDay";
			this.dateTimePickerBDay.Size = new System.Drawing.Size(122, 22);
			this.dateTimePickerBDay.TabIndex = 18;
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(77, 197);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(179, 33);
			this.buttonCreate.TabIndex = 17;
			this.buttonCreate.Text = "新增";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(75, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "出生日期";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(75, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 13;
			this.label4.Text = "性別";
			// 
			// textBoxMbName
			// 
			this.textBoxMbName.Location = new System.Drawing.Point(134, 55);
			this.textBoxMbName.Name = "textBoxMbName";
			this.textBoxMbName.Size = new System.Drawing.Size(122, 22);
			this.textBoxMbName.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 14;
			this.label1.Text = "會員姓名";
			// 
			// FormCreateMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 302);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dateTimePickerBDay);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxMbName);
			this.Controls.Add(this.label1);
			this.Name = "FormCreateMember";
			this.Text = "FormCreateMember";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonM;
		private System.Windows.Forms.RadioButton radioButtonF;
		private System.Windows.Forms.DateTimePicker dateTimePickerBDay;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxMbName;
		private System.Windows.Forms.Label label1;
	}
}