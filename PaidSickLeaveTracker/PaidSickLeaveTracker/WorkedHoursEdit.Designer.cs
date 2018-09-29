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
            this.EditButton = new System.Windows.Forms.Button();
            this.employeeDDL = new System.Windows.Forms.ComboBox();
            this.workedHoursTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(345, 124);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(56, 19);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // employeeDDL
            // 
            this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDDL.FormattingEnabled = true;
            this.employeeDDL.Location = new System.Drawing.Point(29, 122);
            this.employeeDDL.Margin = new System.Windows.Forms.Padding(2);
            this.employeeDDL.Name = "employeeDDL";
            this.employeeDDL.Size = new System.Drawing.Size(92, 21);
            this.employeeDDL.TabIndex = 5;
            this.employeeDDL.SelectedIndexChanged += new System.EventHandler(this.employeeDDL_SelectedIndexChanged);
            // 
            // workedHoursTxt
            // 
            this.workedHoursTxt.Location = new System.Drawing.Point(186, 123);
            this.workedHoursTxt.Name = "workedHoursTxt";
            this.workedHoursTxt.Size = new System.Drawing.Size(100, 20);
            this.workedHoursTxt.TabIndex = 10;
            // 
            // WorkedHoursEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 267);
            this.Controls.Add(this.workedHoursTxt);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.employeeDDL);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}