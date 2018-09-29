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
            this.workedHoursGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.workedHoursGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(322, 42);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(56, 19);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // hoursTxt
            // 
            this.hoursTxt.Location = new System.Drawing.Point(207, 43);
            this.hoursTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.Size = new System.Drawing.Size(76, 20);
            this.hoursTxt.TabIndex = 7;
            // 
            // employeeDDL
            // 
            this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDDL.FormattingEnabled = true;
            this.employeeDDL.Location = new System.Drawing.Point(77, 41);
            this.employeeDDL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeDDL.Name = "employeeDDL";
            this.employeeDDL.Size = new System.Drawing.Size(92, 21);
            this.employeeDDL.TabIndex = 5;
            this.employeeDDL.SelectedIndexChanged += new System.EventHandler(this.employeeDDL_SelectedIndexChanged);
            // 
            // workedHoursGV
            // 
            this.workedHoursGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workedHoursGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workedHoursGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.workedHoursGV.Location = new System.Drawing.Point(0, 155);
            this.workedHoursGV.Name = "workedHoursGV";
            this.workedHoursGV.Size = new System.Drawing.Size(490, 92);
            this.workedHoursGV.TabIndex = 9;
            // 
            // WorkedHoursAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 247);
            this.Controls.Add(this.workedHoursGV);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.hoursTxt);
            this.Controls.Add(this.employeeDDL);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WorkedHoursAdd";
            this.Text = "WorkedHoursAdd";
            this.Load += new System.EventHandler(this.WorkedHoursAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workedHoursGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.TextBox hoursTxt;
		private System.Windows.Forms.ComboBox employeeDDL;
        private System.Windows.Forms.DataGridView workedHoursGV;
    }
}