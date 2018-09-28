namespace PaidSickLeaveTracker
{
	partial class EmployeeAddForm
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
			this.employeeNameTxt = new System.Windows.Forms.TextBox();
			this.employeeAddButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// employeeNameTxt
			// 
			this.employeeNameTxt.Location = new System.Drawing.Point(60, 66);
			this.employeeNameTxt.Name = "employeeNameTxt";
			this.employeeNameTxt.Size = new System.Drawing.Size(139, 22);
			this.employeeNameTxt.TabIndex = 0;
			// 
			// employeeAddButton
			// 
			this.employeeAddButton.Location = new System.Drawing.Point(275, 64);
			this.employeeAddButton.Name = "employeeAddButton";
			this.employeeAddButton.Size = new System.Drawing.Size(75, 23);
			this.employeeAddButton.TabIndex = 1;
			this.employeeAddButton.Text = "Add";
			this.employeeAddButton.UseVisualStyleBackColor = true;
			// 
			// EmployeeAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 159);
			this.Controls.Add(this.employeeAddButton);
			this.Controls.Add(this.employeeNameTxt);
			this.Name = "EmployeeAddForm";
			this.Text = " ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox employeeNameTxt;
		private System.Windows.Forms.Button employeeAddButton;
	}
}