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
            this.hourTxt.Location = new System.Drawing.Point(139, 65);
            this.hourTxt.Name = "hourTxt";
            this.hourTxt.Size = new System.Drawing.Size(100, 20);
            this.hourTxt.TabIndex = 0;
            // 
            // infoTextHours
            // 
            this.infoTextHours.AutoSize = true;
            this.infoTextHours.Location = new System.Drawing.Point(245, 70);
            this.infoTextHours.Name = "infoTextHours";
            this.infoTextHours.Size = new System.Drawing.Size(136, 13);
            this.infoTextHours.TabIndex = 1;
            this.infoTextHours.Text = "addional sick hours for year";
            // 
            // yearSelect
            // 
            this.yearSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearSelect.Location = new System.Drawing.Point(392, 65);
            this.yearSelect.Name = "yearSelect";
            this.yearSelect.Size = new System.Drawing.Size(120, 20);
            this.yearSelect.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(518, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Set";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // employeeDDL
            // 
            this.employeeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDDL.FormattingEnabled = true;
            this.employeeDDL.Location = new System.Drawing.Point(13, 64);
            this.employeeDDL.Name = "employeeDDL";
            this.employeeDDL.Size = new System.Drawing.Size(121, 21);
            this.employeeDDL.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(326, 107);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 5;
            // 
            // CarryOverSickHoursAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 235);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.employeeDDL);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.yearSelect);
            this.Controls.Add(this.infoTextHours);
            this.Controls.Add(this.hourTxt);
            this.Name = "CarryOverSickHoursAdd";
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