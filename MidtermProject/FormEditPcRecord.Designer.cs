namespace MidtermProject
{
	partial class FormEditPcRecord
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
			this.components = new System.ComponentModel.Container();
			this.dateTimePickerPcDay = new System.Windows.Forms.DateTimePicker();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.comboBoxMbName = new System.Windows.Forms.ComboBox();
			this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.membersTableAdapter = new MidtermProject.MidtermDataSetTableAdapters.MembersTableAdapter();
			this.midtermDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.midtermDataSet1 = new MidtermProject.MidtermDataSet1();
			this.membersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.membersTableAdapter1 = new MidtermProject.MidtermDataSet1TableAdapters.MembersTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.midtermDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.midtermDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePickerPcDay
			// 
			this.dateTimePickerPcDay.Location = new System.Drawing.Point(137, 145);
			this.dateTimePickerPcDay.Name = "dateTimePickerPcDay";
			this.dateTimePickerPcDay.Size = new System.Drawing.Size(122, 22);
			this.dateTimePickerPcDay.TabIndex = 15;
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
			this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.ForeColor = System.Drawing.Color.Snow;
			this.buttonDelete.Location = new System.Drawing.Point(80, 231);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(179, 33);
			this.buttonDelete.TabIndex = 13;
			this.buttonDelete.Text = "刪除";
			this.buttonDelete.UseVisualStyleBackColor = false;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(80, 192);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(179, 33);
			this.buttonUpdate.TabIndex = 14;
			this.buttonUpdate.Text = "更新";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(78, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "消費日期";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(78, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "會員姓名";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(78, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "消費金額";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Location = new System.Drawing.Point(137, 98);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(122, 22);
			this.textBoxAmount.TabIndex = 12;
			// 
			// comboBoxMbName
			// 
			this.comboBoxMbName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.membersBindingSource1, "Id", true));
			this.comboBoxMbName.DataSource = this.membersBindingSource1;
			this.comboBoxMbName.DisplayMember = "Name";
			this.comboBoxMbName.FormattingEnabled = true;
			this.comboBoxMbName.Location = new System.Drawing.Point(138, 52);
			this.comboBoxMbName.Name = "comboBoxMbName";
			this.comboBoxMbName.Size = new System.Drawing.Size(121, 20);
			this.comboBoxMbName.TabIndex = 16;
			this.comboBoxMbName.ValueMember = "Id";
			// 
			// membersTableAdapter
			// 
			this.membersTableAdapter.ClearBeforeFill = true;
			// 
			// midtermDataSet1
			// 
			this.midtermDataSet1.DataSetName = "MidtermDataSet1";
			this.midtermDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// membersBindingSource1
			// 
			this.membersBindingSource1.DataMember = "Members";
			this.membersBindingSource1.DataSource = this.midtermDataSet1;
			// 
			// membersTableAdapter1
			// 
			this.membersTableAdapter1.ClearBeforeFill = true;
			// 
			// FormEditPcRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 322);
			this.Controls.Add(this.comboBoxMbName);
			this.Controls.Add(this.dateTimePickerPcDay);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormEditPcRecord";
			this.Text = "FormEditPcRecord";
			this.Load += new System.EventHandler(this.FormEditPcRecord_Load);
			((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.midtermDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.midtermDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerPcDay;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.ComboBox comboBoxMbName;
		private System.Windows.Forms.BindingSource membersBindingSource;
		private MidtermDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
		private System.Windows.Forms.BindingSource midtermDataSetBindingSource;
		private MidtermDataSet1 midtermDataSet1;
		private System.Windows.Forms.BindingSource membersBindingSource1;
		private MidtermDataSet1TableAdapters.MembersTableAdapter membersTableAdapter1;
	}
}