namespace MidtermProject
{
	partial class FormCreateMbship
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
			this.buttonCreate = new System.Windows.Forms.Button();
			this.textBoxDiplsayOrder = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxMbLv = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(38, 129);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(164, 33);
			this.buttonCreate.TabIndex = 7;
			this.buttonCreate.Text = "新增";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// textBoxDiplsayOrder
			// 
			this.textBoxDiplsayOrder.Location = new System.Drawing.Point(95, 83);
			this.textBoxDiplsayOrder.Name = "textBoxDiplsayOrder";
			this.textBoxDiplsayOrder.Size = new System.Drawing.Size(107, 22);
			this.textBoxDiplsayOrder.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "顯示順序";
			// 
			// textBoxMbLv
			// 
			this.textBoxMbLv.Location = new System.Drawing.Point(95, 42);
			this.textBoxMbLv.Name = "textBoxMbLv";
			this.textBoxMbLv.Size = new System.Drawing.Size(107, 22);
			this.textBoxMbLv.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "新增階級";
			// 
			// FormCreateMbship
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 200);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.textBoxDiplsayOrder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxMbLv);
			this.Controls.Add(this.label1);
			this.Name = "FormCreateMbship";
			this.Text = "FormCreateMbship";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.TextBox textBoxDiplsayOrder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxMbLv;
		private System.Windows.Forms.Label label1;
	}
}