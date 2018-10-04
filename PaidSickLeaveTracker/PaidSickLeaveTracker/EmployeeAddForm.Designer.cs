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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAddForm));
			this.employeeNameTxt = new System.Windows.Forms.TextBox();
			this.employeeAddButton = new System.Windows.Forms.Button();
			this.outputLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// employeeNameTxt
			// 
			this.employeeNameTxt.Location = new System.Drawing.Point(60, 66);
			this.employeeNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.employeeNameTxt.Name = "employeeNameTxt";
			this.employeeNameTxt.Size = new System.Drawing.Size(139, 22);
			this.employeeNameTxt.TabIndex = 0;
			// 
			// employeeAddButton
			// 
			this.employeeAddButton.Location = new System.Drawing.Point(275, 64);
			this.employeeAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.employeeAddButton.Name = "employeeAddButton";
			this.employeeAddButton.Size = new System.Drawing.Size(75, 23);
			this.employeeAddButton.TabIndex = 1;
			this.employeeAddButton.Text = "Add";
			this.employeeAddButton.UseVisualStyleBackColor = true;
			this.employeeAddButton.Click += new System.EventHandler(this.employeeAddButton_Click);
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(271, 118);
			this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(0, 17);
			this.outputLabel.TabIndex = 2;
			// 
			// EmployeeAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 159);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.employeeAddButton);
			this.Controls.Add(this.employeeNameTxt);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "EmployeeAddForm";
			this.Text = " ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox employeeNameTxt;
		private System.Windows.Forms.Button employeeAddButton;
        private System.Windows.Forms.Label outputLabel;
    }
}