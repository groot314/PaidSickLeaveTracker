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
			this.removeButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.hoursTxt = new System.Windows.Forms.TextBox();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.employeeDDL = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(542, 152);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(75, 23);
			this.removeButton.TabIndex = 9;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(460, 152);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(75, 23);
			this.EditButton.TabIndex = 8;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			// 
			// hoursTxt
			// 
			this.hoursTxt.Location = new System.Drawing.Point(353, 152);
			this.hoursTxt.Name = "hoursTxt";
			this.hoursTxt.Size = new System.Drawing.Size(100, 22);
			this.hoursTxt.TabIndex = 7;
			// 
			// datePicker
			// 
			this.datePicker.Location = new System.Drawing.Point(146, 153);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(200, 22);
			this.datePicker.TabIndex = 6;
			// 
			// employeeDDL
			// 
			this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.employeeDDL.FormattingEnabled = true;
			this.employeeDDL.Location = new System.Drawing.Point(18, 152);
			this.employeeDDL.Name = "employeeDDL";
			this.employeeDDL.Size = new System.Drawing.Size(121, 24);
			this.employeeDDL.TabIndex = 5;
			// 
			// WorkedHoursEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 329);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.hoursTxt);
			this.Controls.Add(this.datePicker);
			this.Controls.Add(this.employeeDDL);
			this.Name = "WorkedHoursEdit";
			this.Text = "WorkedHoursEdit";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.TextBox hoursTxt;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.ComboBox employeeDDL;
	}
}