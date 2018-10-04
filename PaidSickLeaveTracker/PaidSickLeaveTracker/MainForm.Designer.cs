namespace PaidSickLeaveTracker
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.workedHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.viewAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sickHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAddionalSickHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.mainGV = new System.Windows.Forms.DataGridView();
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.searchLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.workedHourToolStripMenuItem,
            this.sickHoursToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(874, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// employeeToolStripMenuItem
			// 
			this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewAllToolStripMenuItem});
			this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
			this.employeeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
			this.employeeToolStripMenuItem.Text = "Employee";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// viewAllToolStripMenuItem
			// 
			this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
			this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
			this.viewAllToolStripMenuItem.Text = "View All";
			this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
			// 
			// workedHourToolStripMenuItem
			// 
			this.workedHourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.viewAllToolStripMenuItem1});
			this.workedHourToolStripMenuItem.Name = "workedHourToolStripMenuItem";
			this.workedHourToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
			this.workedHourToolStripMenuItem.Text = "Worked Hour";
			// 
			// addToolStripMenuItem1
			// 
			this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
			this.addToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
			this.addToolStripMenuItem1.Text = "Add";
			this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
			this.editToolStripMenuItem1.Text = "Edit";
			this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
			// 
			// viewAllToolStripMenuItem1
			// 
			this.viewAllToolStripMenuItem1.Name = "viewAllToolStripMenuItem1";
			this.viewAllToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
			this.viewAllToolStripMenuItem1.Text = "View All";
			this.viewAllToolStripMenuItem1.Click += new System.EventHandler(this.viewAllToolStripMenuItem1_Click);
			// 
			// sickHoursToolStripMenuItem
			// 
			this.sickHoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAddionalSickHoursToolStripMenuItem,
            this.addToolStripMenuItem2,
            this.editToolStripMenuItem2});
			this.sickHoursToolStripMenuItem.Name = "sickHoursToolStripMenuItem";
			this.sickHoursToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
			this.sickHoursToolStripMenuItem.Text = "Sick Hours";
			// 
			// addAddionalSickHoursToolStripMenuItem
			// 
			this.addAddionalSickHoursToolStripMenuItem.Name = "addAddionalSickHoursToolStripMenuItem";
			this.addAddionalSickHoursToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
			this.addAddionalSickHoursToolStripMenuItem.Text = "Set Additonal/Carry Over Hours";
			this.addAddionalSickHoursToolStripMenuItem.Click += new System.EventHandler(this.addAddionalSickHoursToolStripMenuItem_Click);
			// 
			// addToolStripMenuItem2
			// 
			this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
			this.addToolStripMenuItem2.Size = new System.Drawing.Size(293, 26);
			this.addToolStripMenuItem2.Text = "Add Used Hours";
			this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
			// 
			// editToolStripMenuItem2
			// 
			this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
			this.editToolStripMenuItem2.Size = new System.Drawing.Size(293, 26);
			this.editToolStripMenuItem2.Text = "Edit Used Hours";
			this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
			// 
			// mainGV
			// 
			this.mainGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.mainGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mainGV.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mainGV.Location = new System.Drawing.Point(0, 260);
			this.mainGV.Margin = new System.Windows.Forms.Padding(4);
			this.mainGV.Name = "mainGV";
			this.mainGV.ReadOnly = true;
			this.mainGV.Size = new System.Drawing.Size(874, 255);
			this.mainGV.TabIndex = 1;
			// 
			// searchTxt
			// 
			this.searchTxt.Location = new System.Drawing.Point(79, 230);
			this.searchTxt.Margin = new System.Windows.Forms.Padding(4);
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(132, 22);
			this.searchTxt.TabIndex = 2;
			this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
			// 
			// searchLabel
			// 
			this.searchLabel.AutoSize = true;
			this.searchLabel.Location = new System.Drawing.Point(12, 234);
			this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.searchLabel.Name = "searchLabel";
			this.searchLabel.Size = new System.Drawing.Size(57, 17);
			this.searchLabel.TabIndex = 3;
			this.searchLabel.Text = "Search:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PaidSickLeaveTracker.Properties.Resources.mainNamedLogo;
			this.pictureBox1.Location = new System.Drawing.Point(218, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(375, 278);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(874, 515);
			this.Controls.Add(this.searchLabel);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.mainGV);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "Paid Sick Leave Tracker";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem workedHourToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sickHoursToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addAddionalSickHoursToolStripMenuItem;
        private System.Windows.Forms.DataGridView mainGV;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLabel;
		private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

