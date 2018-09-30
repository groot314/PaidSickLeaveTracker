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
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeNameTxt
            // 
            this.employeeNameTxt.Location = new System.Drawing.Point(45, 54);
            this.employeeNameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeNameTxt.Name = "employeeNameTxt";
            this.employeeNameTxt.Size = new System.Drawing.Size(105, 20);
            this.employeeNameTxt.TabIndex = 0;
            // 
            // employeeAddButton
            // 
            this.employeeAddButton.Location = new System.Drawing.Point(206, 52);
            this.employeeAddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeAddButton.Name = "employeeAddButton";
            this.employeeAddButton.Size = new System.Drawing.Size(56, 19);
            this.employeeAddButton.TabIndex = 1;
            this.employeeAddButton.Text = "Add";
            this.employeeAddButton.UseVisualStyleBackColor = true;
            this.employeeAddButton.Click += new System.EventHandler(this.employeeAddButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(203, 96);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 2;
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 129);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.employeeAddButton);
            this.Controls.Add(this.employeeNameTxt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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