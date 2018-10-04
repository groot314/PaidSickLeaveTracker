namespace PaidSickLeaveTracker
{
    partial class CarryOverSickHoursSet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarryOverSickHoursSet));
			this.hourTxt = new System.Windows.Forms.TextBox();
			this.infoTextHours = new System.Windows.Forms.Label();
			this.yearSelect = new System.Windows.Forms.DateTimePicker();
			this.addButton = new System.Windows.Forms.Button();
			this.employeeDDL = new System.Windows.Forms.ComboBox();
			this.outputLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// hourTxt
			// 
			this.hourTxt.Location = new System.Drawing.Point(185, 80);
			this.hourTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.hourTxt.Name = "hourTxt";
			this.hourTxt.Size = new System.Drawing.Size(132, 22);
			this.hourTxt.TabIndex = 0;
			// 
			// infoTextHours
			// 
			this.infoTextHours.AutoSize = true;
			this.infoTextHours.Location = new System.Drawing.Point(327, 86);
			this.infoTextHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.infoTextHours.Name = "infoTextHours";
			this.infoTextHours.Size = new System.Drawing.Size(183, 17);
			this.infoTextHours.TabIndex = 1;
			this.infoTextHours.Text = "addional sick hours for year";
			// 
			// yearSelect
			// 
			this.yearSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.yearSelect.Location = new System.Drawing.Point(523, 80);
			this.yearSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.yearSelect.Name = "yearSelect";
			this.yearSelect.Size = new System.Drawing.Size(159, 22);
			this.yearSelect.TabIndex = 2;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(691, 79);
			this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(100, 28);
			this.addButton.TabIndex = 3;
			this.addButton.Text = "Set";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// employeeDDL
			// 
			this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.employeeDDL.FormattingEnabled = true;
			this.employeeDDL.Location = new System.Drawing.Point(17, 79);
			this.employeeDDL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.employeeDDL.Name = "employeeDDL";
			this.employeeDDL.Size = new System.Drawing.Size(160, 24);
			this.employeeDDL.TabIndex = 4;
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(435, 132);
			this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(0, 17);
			this.outputLabel.TabIndex = 5;
			// 
			// CarryOverSickHoursSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 289);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.employeeDDL);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.yearSelect);
			this.Controls.Add(this.infoTextHours);
			this.Controls.Add(this.hourTxt);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "CarryOverSickHoursSet";
			this.Text = "CarryOverSickHoursAdd";
			this.Load += new System.EventHandler(this.CarryOverSickHoursAdd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hourTxt;
        private System.Windows.Forms.Label infoTextHours;
        private System.Windows.Forms.DateTimePicker yearSelect;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox employeeDDL;
        private System.Windows.Forms.Label outputLabel;
    }
}