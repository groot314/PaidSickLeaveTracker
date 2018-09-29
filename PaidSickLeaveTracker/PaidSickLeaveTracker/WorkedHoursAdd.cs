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
	public partial class WorkedHoursAdd : Form
	{
		public WorkedHoursAdd()
		{
			InitializeComponent();
		}

		private void WorkedHoursAdd_Load(object sender, EventArgs e)
		{
			ConnectDB dbcon = new ConnectDB();
			MySqlDataAdapter selectEmployees = new MySqlDataAdapter("Select * From Employees", dbcon.Connection);


			DataTable dt = new DataTable();

			selectEmployees.Fill(dt);

			employeeDDL.DataSource = dt;
			employeeDDL.DisplayMember = "Name";
			employeeDDL.ValueMember = "EmployeeID";

            refreshViewHours();
		}

        private void employeeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshViewHours();
        }

        private void AddButton_Click(object sender, EventArgs e)
		{
			ConnectDB dbcon = new ConnectDB();

			MySqlCommand addSickHours = new MySqlCommand("Update Employees SET EmployeeHours=EmployeeHours+@hours WHERE EmployeeID=@id", dbcon.Connection);

			addSickHours.Parameters.AddWithValue("@hours", Int32.Parse(hoursTxt.Text));
			addSickHours.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);

			dbcon.runCommand(addSickHours);


			hoursTxt.Text = "";

            refreshViewHours();
		}


        private void refreshViewHours()
        {
            ConnectDB dbcon = new ConnectDB();
            Functions fun = new Functions();

            MySqlDataAdapter selectEmployeesWorkedHours = new MySqlDataAdapter("Select Name, EmployeeHours As Hours From Employees WHERE EmployeeID=@id",dbcon.Connection);

            selectEmployeesWorkedHours.SelectCommand.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);

            fun.fillGridView(selectEmployeesWorkedHours, ref workedHoursGV);


        }
    }
}
