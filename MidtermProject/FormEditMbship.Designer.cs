namespace MidtermProject
{
	partial class FormEditMbship
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxMbLv = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxDiplsayOrder = new System.Windows.Forms.TextBox();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "會員階級";
			// 
			// textBoxMbLv
			// 
			this.textBoxMbLv.Location = new System.Drawing.Point(87, 30);
			this.textBoxMbLv.Name = "textBoxMbLv";
			this.textBoxMbLv.Size = new System.Drawing.Size(107, 22);
			this.textBoxMbLv.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "顯示順序";
			// 
			// textBoxDiplsayOrder
			// 
			this.textBoxDiplsayOrder.Location = new System.Drawing.Point(87, 71);
			this.textBoxDiplsayOrder.Name = "textBoxDiplsayOrder";
			this.textBoxDiplsayOrder.Size = new System.Drawing.Size(107, 22);
			this.textBoxDiplsayOrder.TabIndex = 1;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(30, 112);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(164, 33);
			this.buttonUpdate.TabIndex = 2;
			this.buttonUpdate.Text = "更新";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
			this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.ForeColor = System.Drawing.Color.Snow;
			this.buttonDelete.Location = new System.Drawing.Point(30, 151);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(164, 33);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "刪除";
			this.buttonDelete.UseVisualStyleBackColor = false;
			// 
			// FormEditMbship
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 213);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.textBoxDiplsayOrder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxMbLv);
			this.Controls.Add(this.label1);
			this.Name = "FormEditMbship";
			this.Text = "FormEditMbship";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxMbLv;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxDiplsayOrder;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
	}
}