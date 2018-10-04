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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkedHoursAdd));
			this.AddButton = new System.Windows.Forms.Button();
			this.hoursTxt = new System.Windows.Forms.TextBox();
			this.employeeDDL = new System.Windows.Forms.ComboBox();
			this.workedHoursGV = new System.Windows.Forms.DataGridView();
			this.yearSelect = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.workedHoursGV)).BeginInit();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(541, 53);
			this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 8;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// hoursTxt
			// 
			this.hoursTxt.Location = new System.Drawing.Point(435, 52);
			this.hoursTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.hoursTxt.Name = "hoursTxt";
			this.hoursTxt.Size = new System.Drawing.Size(100, 22);
			this.hoursTxt.TabIndex = 7;
			// 
			// employeeDDL
			// 
			this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.employeeDDL.FormattingEnabled = true;
			this.employeeDDL.Location = new System.Drawing.Point(15, 53);
			this.employeeDDL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.employeeDDL.Name = "employeeDDL";
			this.employeeDDL.Size = new System.Drawing.Size(121, 24);
			this.employeeDDL.TabIndex = 5;
			this.employeeDDL.SelectedIndexChanged += new System.EventHandler(this.employeeDDL_SelectedIndexChanged);
			// 
			// workedHoursGV
			// 
			this.workedHoursGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.workedHoursGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.workedHoursGV.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.workedHoursGV.Location = new System.Drawing.Point(0, 191);
			this.workedHoursGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.workedHoursGV.Name = "workedHoursGV";
			this.workedHoursGV.Size = new System.Drawing.Size(653, 113);
			this.workedHoursGV.TabIndex = 9;
			// 
			// yearSelect
			// 
			this.yearSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.yearSelect.Location = new System.Drawing.Point(144, 54);
			this.yearSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.yearSelect.Name = "yearSelect";
			this.yearSelect.Size = new System.Drawing.Size(265, 22);
			this.yearSelect.TabIndex = 10;
			this.yearSelect.ValueChanged += new System.EventHandler(this.yearSelect_ValueChanged);
			// 
			// WorkedHoursAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 304);
			this.Controls.Add(this.yearSelect);
			this.Controls.Add(this.workedHoursGV);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.hoursTxt);
			this.Controls.Add(this.employeeDDL);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DateTimePicker yearSelect;
    }
}