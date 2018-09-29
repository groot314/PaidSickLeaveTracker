namespace PaidSickLeaveTracker
{
	partial class WorkedHoursAdd
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
			this.AddButton = new System.Windows.Forms.Button();
			this.hoursTxt = new System.Windows.Forms.TextBox();
			this.employeeDDL = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(420, 139);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 8;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// hoursTxt
			// 
			this.hoursTxt.Location = new System.Drawing.Point(267, 140);
			this.hoursTxt.Name = "hoursTxt";
			this.hoursTxt.Size = new System.Drawing.Size(100, 22);
			this.hoursTxt.TabIndex = 7;
			// 
			// employeeDDL
			// 
			this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.employeeDDL.FormattingEnabled = true;
			this.employeeDDL.Location = new System.Drawing.Point(93, 138);
			this.employeeDDL.Name = "employeeDDL";
			this.employeeDDL.Size = new System.Drawing.Size(121, 24);
			this.employeeDDL.TabIndex = 5;
			// 
			// WorkedHoursAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 304);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.hoursTxt);
			this.Controls.Add(this.employeeDDL);
			this.Name = "WorkedHoursAdd";
			this.Text = "WorkedHoursAdd";
			this.Load += new System.EventHandler(this.WorkedHoursAdd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.TextBox hoursTxt;
		private System.Windows.Forms.ComboBox employeeDDL;
	}
}