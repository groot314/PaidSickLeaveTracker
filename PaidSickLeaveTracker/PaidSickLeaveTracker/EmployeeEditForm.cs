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
using System.Data;


namespace PaidSickLeaveTracker
{
	public partial class EmployeeEditForm : Form
	{
		public EmployeeEditForm()
		{
			InitializeComponent();
		}

		private void EmployeeEditForm_Load(object sender, EventArgs e)
		{
            ConnectDB dbcon = new ConnectDB();
            MySqlDataAdapter selectEmployees = new MySqlDataAdapter("Select * From Employees", dbcon.Connection);


            DataTable dt = new DataTable();

            selectEmployees.Fill(dt);

            employeeDDL.DataSource = dt;
            employeeDDL.DisplayMember = "Name";
            employeeDDL.ValueMember = "EmployeeID";

            
            employeeNameTxt.Text = employeeDDL.Text;
              
		}

        private void EditButton_Click(object sender, EventArgs e)
        {
            ConnectDB dbcon = new ConnectDB();

            MySqlCommand updateEmployee = new MySqlCommand("Update Employees SET Name=@name WHERE EmployeeID=@id", dbcon.Connection);

            updateEmployee.Parameters.AddWithValue("@name", employeeNameTxt.Text);
            updateEmployee.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);

            dbcon.runCommand(updateEmployee);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ConnectDB dbcon = new ConnectDB();

            MySqlCommand updateEmployee = new MySqlCommand("Delete From Employees WHERE EmployeeID=@id", dbcon.Connection);

            updateEmployee.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);

            dbcon.runCommand(updateEmployee);
        }
    }
}
