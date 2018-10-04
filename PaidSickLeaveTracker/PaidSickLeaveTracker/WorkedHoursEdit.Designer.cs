namespace PaidSickLeaveTracker
{
	partial class WorkedHoursEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkedHoursEdit));
			this.EditButton = new System.Windows.Forms.Button();
			this.employeeDDL = new System.Windows.Forms.ComboBox();
			this.workedHoursTxt = new System.Windows.Forms.TextBox();
			this.yearSelect = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(556, 145);
			this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(75, 23);
			this.EditButton.TabIndex = 8;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// employeeDDL
			// 
			this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.employeeDDL.FormattingEnabled = true;
			this.employeeDDL.Location = new System.Drawing.Point(12, 142);
			this.employeeDDL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.employeeDDL.Name = "employeeDDL";
			this.employeeDDL.Size = new System.Drawing.Size(121, 24);
			this.employeeDDL.TabIndex = 5;
			this.employeeDDL.SelectedIndexChanged += new System.EventHandler(this.employeeDDL_SelectedIndexChanged);
			// 
			// workedHoursTxt
			// 
			this.workedHoursTxt.Location = new System.Drawing.Point(416, 144);
			this.workedHoursTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.workedHoursTxt.Name = "workedHoursTxt";
			this.workedHoursTxt.Size = new System.Drawing.Size(132, 22);
			this.workedHoursTxt.TabIndex = 10;
			// 
			// yearSelect
			// 
			this.yearSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.yearSelect.Location = new System.Drawing.Point(141, 143);
			this.yearSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.yearSelect.Name = "yearSelect";
			this.yearSelect.Size = new System.Drawing.Size(265, 22);
			this.yearSelect.TabIndex = 11;
			this.yearSelect.ValueChanged += new System.EventHandler(this.yearSelect_ValueChanged);
			// 
			// WorkedHoursEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 329);
			this.Controls.Add(this.yearSelect);
			this.Controls.Add(this.workedHoursTxt);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.employeeDDL);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "WorkedHoursEdit";
			this.Text = "WorkedHoursEdit";
			this.Load += new System.EventHandler(this.WorkedHoursEdit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.ComboBox employeeDDL;
        private System.Windows.Forms.TextBox workedHoursTxt;
        private System.Windows.Forms.DateTimePicker yearSelect;
    }
}