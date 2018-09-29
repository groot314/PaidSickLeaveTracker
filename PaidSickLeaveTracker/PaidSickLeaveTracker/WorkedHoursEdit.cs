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
	public partial class WorkedHoursEdit : Form
	{
		public WorkedHoursEdit()
		{
			InitializeComponent();
		}

        private void WorkedHoursEdit_Load(object sender, EventArgs e)
        {
            Functions fun = new Functions();
            fun.fillEmployeeDDL(ref employeeDDL);

            refreshWorkedHours();
        }

        private void employeeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshWorkedHours();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ConnectDB dbcon = new ConnectDB();

            MySqlCommand updateEmployee = new MySqlCommand("Update Employees SET EmployeeHours=@hours WHERE EmployeeID=@id", dbcon.Connection);

            updateEmployee.Parameters.AddWithValue("@hours", Int32.Parse(workedHoursTxt.Text));
            updateEmployee.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);

            dbcon.runCommand(updateEmployee);
        }


        private void refreshWorkedHours()
        {
            ConnectDB dbcon = new ConnectDB();
            MySqlDataAdapter selectHours = new MySqlDataAdapter("Select EmployeeHours From Employees WHERE EmployeeID=@employeeID", dbcon.Connection);

            selectHours.SelectCommand.Parameters.AddWithValue("@employeeID", employeeDDL.SelectedValue);


            DataTable dt = new DataTable();

            selectHours.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                workedHoursTxt.Text = dt.Rows[0]["EmployeeHours"].ToString();
            }
            else
            {
                workedHoursTxt.Text = "";
            }
        }
    }
}
