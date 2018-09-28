﻿namespace PaidSickLeaveTracker
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.workedHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sickHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
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
			this.menuStrip1.Size = new System.Drawing.Size(522, 28);
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
			// 
			// employeeToolStripMenuItem
			// 
			this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
			this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
			this.employeeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
			this.employeeToolStripMenuItem.Text = "Employee";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// workedHourToolStripMenuItem
			// 
			this.workedHourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1});
			this.workedHourToolStripMenuItem.Name = "workedHourToolStripMenuItem";
			this.workedHourToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
			this.workedHourToolStripMenuItem.Text = "Worked Hour";
			// 
			// addToolStripMenuItem1
			// 
			this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
			this.addToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
			this.addToolStripMenuItem1.Text = "Add";
			this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
			this.editToolStripMenuItem1.Text = "Edit";
			this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
			// 
			// sickHoursToolStripMenuItem
			// 
			this.sickHoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.editToolStripMenuItem2});
			this.sickHoursToolStripMenuItem.Name = "sickHoursToolStripMenuItem";
			this.sickHoursToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
			this.sickHoursToolStripMenuItem.Text = "Sick Hours";
			// 
			// addToolStripMenuItem2
			// 
			this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
			this.addToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
			this.addToolStripMenuItem2.Text = "Add";
			this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
			// 
			// editToolStripMenuItem2
			// 
			this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
			this.editToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
			this.editToolStripMenuItem2.Text = "Edit";
			this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 471);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Paid Sick Leave Tracker";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
	}
}
