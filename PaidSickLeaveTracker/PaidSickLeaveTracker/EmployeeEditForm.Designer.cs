namespace PaidSickLeaveTracker
{
	partial class EmployeeEditForm
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
			this.employeeNameTxt = new System.Windows.Forms.TextBox();
			this.EmployeeDDL = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(248, 134);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(75, 23);
			this.removeButton.TabIndex = 9;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(166, 134);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(75, 23);
			this.EditButton.TabIndex = 8;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			// 
			// employeeNameTxt
			// 
			this.employeeNameTxt.Location = new System.Drawing.Point(59, 134);
			this.employeeNameTxt.Name = "employeeNameTxt";
			this.employeeNameTxt.Size = new System.Drawing.Size(100, 22);
			this.employeeNameTxt.TabIndex = 7;
			// 
			// EmployeeDDL
			// 
			this.EmployeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EmployeeDDL.FormattingEnabled = true;
			this.EmployeeDDL.Location = new System.Drawing.Point(59, 83);
			this.EmployeeDDL.Name = "EmployeeDDL";
			this.EmployeeDDL.Size = new System.Drawing.Size(121, 24);
			this.EmployeeDDL.TabIndex = 10;
			// 
			// EmployeeEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 303);
			this.Controls.Add(this.EmployeeDDL);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.employeeNameTxt);
			this.Name = "EmployeeEditForm";
			this.Text = "EditEmployeeForm";
			this.Load += new System.EventHandler(this.EmployeeEditForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.TextBox employeeNameTxt;
		private System.Windows.Forms.ComboBox EmployeeDDL;
	}
}