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
            yearSelect.CustomFormat = "yyyy";
            yearSelect.ShowUpDown = true;
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

        private void yearSelect_ValueChanged(object sender, EventArgs e)
        {
            refreshViewHours();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ConnectDB dbcon = new ConnectDB();

            MySqlDataAdapter selectRow = new MySqlDataAdapter("Select WorkedID From WorkedHours WHERE EmployeeID=@id AND Year=@year", dbcon.Connection);//select to see if row exist
            selectRow.SelectCommand.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);
            selectRow.SelectCommand.Parameters.AddWithValue("@year", yearSelect.Value.Date.ToString("yyyy"));

            DataTable workedHoursDT = new DataTable();
            selectRow.Fill(workedHoursDT);


            if (workedHoursDT.Rows.Count == 0)//row doesn't exist
            { 
                MySqlCommand addSickHours = new MySqlCommand("Insert Into WorkedHours (EmployeeID, Year, Hours) Values (@id, @year, @hours)", dbcon.Connection);

                addSickHours.Parameters.AddWithValue("@hours", Int32.Parse(hoursTxt.Text));
                addSickHours.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);
                addSickHours.Parameters.AddWithValue("@year", yearSelect.Value.Date.ToString("yyyy"));

                dbcon.runCommand(addSickHours);
            }
            else//update row since a row does exist
            {
                MySqlCommand addSickHours = new MySqlCommand("Update WorkedHours SET Hours=Hours+@hours WHERE EmployeeID=@id AND Year=@year", dbcon.Connection);

                addSickHours.Parameters.AddWithValue("@hours", Int32.Parse(hoursTxt.Text));
                addSickHours.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);
                addSickHours.Parameters.AddWithValue("@year", yearSelect.Value.Date.ToString("yyyy"));

                dbcon.runCommand(addSickHours);
            }

			hoursTxt.Text = "";

            refreshViewHours();
		}


        private void refreshViewHours()
        {
            ConnectDB dbcon = new ConnectDB();
            Functions fun = new Functions();

            MySqlDataAdapter selectEmployeesWorkedHours = new MySqlDataAdapter("Select Employees.Name, WorkedHours.Hours From WorkedHours "+
                "Join Employees On WorkedHours.EmployeeID = Employees.EmployeeID WHERE WorkedHours.EmployeeID=@id AND Year=@year",dbcon.Connection);

            selectEmployeesWorkedHours.SelectCommand.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);
            selectEmployeesWorkedHours.SelectCommand.Parameters.AddWithValue("@year", yearSelect.Value.Date.ToString("yyyy"));

            fun.fillGridView(selectEmployeesWorkedHours, ref workedHoursGV);


        }
    }
}
