namespace PaidSickLeaveTracker
{
	partial class SickHoursAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SickHoursAdd));
			this.employeeDDL = new System.Windows.Forms.ComboBox();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.hoursTxt = new System.Windows.Forms.TextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.sickHourGV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.sickHourGV)).BeginInit();
			this.SuspendLayout();
			// 
			// employeeDDL
			// 
			this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.employeeDDL.FormattingEnabled = true;
			this.employeeDDL.Location = new System.Drawing.Point(48, 59);
			this.employeeDDL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.employeeDDL.Name = "employeeDDL";
			this.employeeDDL.Size = new System.Drawing.Size(121, 24);
			this.employeeDDL.TabIndex = 5;
			this.employeeDDL.SelectedIndexChanged += new System.EventHandler(this.employeeDDL_SelectedIndexChanged);
			// 
			// datePicker
			// 
			this.datePicker.Location = new System.Drawing.Point(176, 60);
			this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(200, 22);
			this.datePicker.TabIndex = 6;
			// 
			// hoursTxt
			// 
			this.hoursTxt.Location = new System.Drawing.Point(383, 59);
			this.hoursTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.hoursTxt.Name = "hoursTxt";
			this.hoursTxt.Size = new System.Drawing.Size(100, 22);
			this.hoursTxt.TabIndex = 7;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(489, 59);
			this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(112, 23);
			this.AddButton.TabIndex = 8;
			this.AddButton.Text = "Add Used";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// sickHourGV
			// 
			this.sickHourGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.sickHourGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sickHourGV.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sickHourGV.Location = new System.Drawing.Point(0, 121);
			this.sickHourGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.sickHourGV.Name = "sickHourGV";
			this.sickHourGV.Size = new System.Drawing.Size(637, 185);
			this.sickHourGV.TabIndex = 9;
			// 
			// SickHoursAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 306);
			this.Controls.Add(this.sickHourGV);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.hoursTxt);
			this.Controls.Add(this.datePicker);
			this.Controls.Add(this.employeeDDL);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "SickHoursAdd";
			this.Text = "SickHoursAdd";
			this.Load += new System.EventHandler(this.SickHoursAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.sickHourGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox employeeDDL;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.TextBox hoursTxt;
		private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView sickHourGV;
    }
}