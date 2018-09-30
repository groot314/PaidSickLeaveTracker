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
	public partial class EmployeeEditForm : Form
	{
		public EmployeeEditForm()
		{
			InitializeComponent();
		}

        private EmployeeFunctions eFun = new EmployeeFunctions();

        private void EmployeeEditForm_Load(object sender, EventArgs e)
		{
			refreshEmployeeDDL();
			 
            employeeNameTxt.Text = employeeDDL.Text;
              
		}

        private void EditButton_Click(object sender, EventArgs e)
        {
            eFun.updateEmployeeName(employeeNameTxt.Text, employeeDDL.SelectedValue);

			int index = employeeDDL.SelectedIndex;

			refreshEmployeeDDL();

			employeeDDL.SelectedIndex = index;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            eFun.removeEmployee(employeeDDL.SelectedValue);

			employeeNameTxt.Text = "";

			refreshEmployeeDDL();
        }

		private void employeeDDL_SelectedIndexChanged(object sender, EventArgs e)
		{
			employeeNameTxt.Text = employeeDDL.Text;
		}



		private void refreshEmployeeDDL()
		{
            eFun.fillEmployeeDDL(ref employeeDDL);
        }
	}
}
