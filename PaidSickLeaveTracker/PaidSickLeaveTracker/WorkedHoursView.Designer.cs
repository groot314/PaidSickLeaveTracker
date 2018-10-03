namespace PaidSickLeaveTracker
{
	partial class WorkedHoursView
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
			this.workedHoursGV = new System.Windows.Forms.DataGridView();
			this.searchTxt = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.workedHoursGV)).BeginInit();
			this.SuspendLayout();
			// 
			// workedHoursGV
			// 
			this.workedHoursGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.workedHoursGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.workedHoursGV.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.workedHoursGV.Location = new System.Drawing.Point(0, 53);
			this.workedHoursGV.Name = "workedHoursGV";
			this.workedHoursGV.ReadOnly = true;
			this.workedHoursGV.RowTemplate.Height = 24;
			this.workedHoursGV.Size = new System.Drawing.Size(594, 302);
			this.workedHoursGV.TabIndex = 0;
			// 
			// searchTxt
			// 
			this.searchTxt.Location = new System.Drawing.Point(56, 25);
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(100, 22);
			this.searchTxt.TabIndex = 2;
			this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
			// 
			// WorkedHoursView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 355);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.workedHoursGV);
			this.Name = "WorkedHoursView";
			this.Text = "WorkedHoursView";
			this.Load += new System.EventHandler(this.WorkedHoursView_Load);
			((System.ComponentModel.ISupportInitialize)(this.workedHoursGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView workedHoursGV;
		private System.Windows.Forms.TextBox searchTxt;
	}
}