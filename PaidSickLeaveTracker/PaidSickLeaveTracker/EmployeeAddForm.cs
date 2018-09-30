using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PaidSickLeaveTracker
{
	public partial class EmployeeAddForm : Form
	{
		public EmployeeAddForm()
		{
			InitializeComponent();
		}

        private void employeeAddButton_Click(object sender, EventArgs e)
		{
            outputLabel.Text = employeeNameTxt.Text + " Added";

			employeeNameTxt.Text = "";
		}
	}
}
