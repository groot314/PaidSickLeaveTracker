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
            this.employeeDDL.Location = new System.Drawing.Point(36, 48);
            this.employeeDDL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeDDL.Name = "employeeDDL";
            this.employeeDDL.Size = new System.Drawing.Size(92, 21);
            this.employeeDDL.TabIndex = 5;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(132, 49);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(151, 20);
            this.datePicker.TabIndex = 6;
            // 
            // hoursTxt
            // 
            this.hoursTxt.Location = new System.Drawing.Point(287, 48);
            this.hoursTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.Size = new System.Drawing.Size(76, 20);
            this.hoursTxt.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(367, 48);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(56, 19);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // sickHourGV
            // 
            this.sickHourGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sickHourGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sickHourGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sickHourGV.Location = new System.Drawing.Point(0, 99);
            this.sickHourGV.Name = "sickHourGV";
            this.sickHourGV.Size = new System.Drawing.Size(478, 150);
            this.sickHourGV.TabIndex = 9;
            // 
            // SickHoursAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 249);
            this.Controls.Add(this.sickHourGV);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.hoursTxt);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.employeeDDL);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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