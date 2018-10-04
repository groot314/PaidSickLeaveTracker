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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeEditForm));
			this.removeButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.employeeNameTxt = new System.Windows.Forms.TextBox();
			this.employeeDDL = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(248, 134);
			this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(75, 23);
			this.removeButton.TabIndex = 9;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(165, 134);
			this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(75, 23);
			this.EditButton.TabIndex = 8;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// employeeNameTxt
			// 
			this.employeeNameTxt.Location = new System.Drawing.Point(59, 134);
			this.employeeNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.employeeNameTxt.Name = "employeeNameTxt";
			this.employeeNameTxt.Size = new System.Drawing.Size(100, 22);
			this.employeeNameTxt.TabIndex = 7;
			// 
			// employeeDDL
			// 
			this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.employeeDDL.FormattingEnabled = true;
			this.employeeDDL.Location = new System.Drawing.Point(59, 82);
			this.employeeDDL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.employeeDDL.Name = "employeeDDL";
			this.employeeDDL.Size = new System.Drawing.Size(121, 24);
			this.employeeDDL.TabIndex = 10;
			this.employeeDDL.SelectedIndexChanged += new System.EventHandler(this.employeeDDL_SelectedIndexChanged);
			// 
			// EmployeeEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 303);
			this.Controls.Add(this.employeeDDL);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.employeeNameTxt);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
		private System.Windows.Forms.ComboBox employeeDDL;
	}
}