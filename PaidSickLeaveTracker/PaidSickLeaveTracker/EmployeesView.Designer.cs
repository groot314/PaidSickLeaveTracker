namespace PaidSickLeaveTracker
{
	partial class EmployeesView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesView));
			this.employeesGV = new System.Windows.Forms.DataGridView();
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.searchLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.employeesGV)).BeginInit();
			this.SuspendLayout();
			// 
			// employeesGV
			// 
			this.employeesGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.employeesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeesGV.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.employeesGV.Location = new System.Drawing.Point(0, 52);
			this.employeesGV.Name = "employeesGV";
			this.employeesGV.ReadOnly = true;
			this.employeesGV.RowTemplate.Height = 24;
			this.employeesGV.Size = new System.Drawing.Size(632, 291);
			this.employeesGV.TabIndex = 0;
			// 
			// searchTxt
			// 
			this.searchTxt.Location = new System.Drawing.Point(75, 24);
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(100, 22);
			this.searchTxt.TabIndex = 1;
			this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
			// 
			// searchLabel
			// 
			this.searchLabel.AutoSize = true;
			this.searchLabel.Location = new System.Drawing.Point(12, 24);
			this.searchLabel.Name = "searchLabel";
			this.searchLabel.Size = new System.Drawing.Size(57, 17);
			this.searchLabel.TabIndex = 2;
			this.searchLabel.Text = "Search:";
			// 
			// EmployeesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 343);
			this.Controls.Add(this.searchLabel);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.employeesGV);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EmployeesView";
			this.Text = "EmployeesView";
			this.Load += new System.EventHandler(this.EmployeesView_Load);
			((System.ComponentModel.ISupportInitialize)(this.employeesGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView employeesGV;
		private System.Windows.Forms.TextBox searchTxt;
		private System.Windows.Forms.Label searchLabel;
	}
}