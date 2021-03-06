﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaidSickLeaveTracker
{
    public partial class CarryOverSickHoursSet : Form
    {
        public CarryOverSickHoursSet()
        {
            InitializeComponent();
            yearSelect.CustomFormat = "yyyy";
            yearSelect.ShowUpDown = true;
        }

        EmployeeFunctions efun = new EmployeeFunctions();
        SickHoursFunctions sfun = new SickHoursFunctions();

        private void CarryOverSickHoursAdd_Load(object sender, EventArgs e)
        {
            efun.fillEmployeeDDL(ref employeeDDL);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
			double num;
			if (double.TryParse(hourTxt.Text, out num)) {
				sfun.setAdditionSickHours(Convert.ToDouble(hourTxt.Text), yearSelect.Value.ToString("yyyy"), employeeDDL.SelectedValue);

				outputLabel.Text = hourTxt.Text + " hours set for " + yearSelect.Value.ToString("yyyy");

			}
			else
			{
				MessageBox.Show("Enter in a numeric number");
			}
        }
    }
}
