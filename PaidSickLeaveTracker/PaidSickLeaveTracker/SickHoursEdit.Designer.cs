namespace PaidSickLeaveTracker
{
	partial class SickHoursEdit
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
            this.hoursTxt = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.datesDDL = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // employeeDDL
            // 
            this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDDL.FormattingEnabled = true;
            this.employeeDDL.Location = new System.Drawing.Point(10, 63);
            this.employeeDDL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeDDL.Name = "employeeDDL";
            this.employeeDDL.Size = new System.Drawing.Size(92, 21);
            this.employeeDDL.TabIndex = 0;
            this.employeeDDL.SelectedIndexChanged += new System.EventHandler(this.employeeDDL_SelectedIndexChanged);
            // 
            // hoursTxt
            // 
            this.hoursTxt.Location = new System.Drawing.Point(261, 63);
            this.hoursTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.Size = new System.Drawing.Size(76, 20);
            this.hoursTxt.TabIndex = 2;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(341, 63);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(56, 19);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(403, 63);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(56, 19);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // datesDDL
            // 
            this.datesDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datesDDL.FormattingEnabled = true;
            this.datesDDL.Location = new System.Drawing.Point(122, 63);
            this.datesDDL.Name = "datesDDL";
            this.datesDDL.Size = new System.Drawing.Size(121, 21);
            this.datesDDL.TabIndex = 5;
            this.datesDDL.SelectedIndexChanged += new System.EventHandler(this.datesDDL_SelectedIndexChanged);
            // 
            // SickHoursEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 168);
            this.Controls.Add(this.datesDDL);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.hoursTxt);
            this.Controls.Add(this.employeeDDL);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SickHoursEdit";
            this.Text = "SickHoursEdit";
            this.Load += new System.EventHandler(this.SickHoursEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox employeeDDL;
		private System.Windows.Forms.TextBox hoursTxt;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox datesDDL;
    }
}