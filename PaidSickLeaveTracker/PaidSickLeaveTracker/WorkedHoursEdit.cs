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
            yearSelect.CustomFormat = "yyyy";
            yearSelect.ShowUpDown = true;
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

        private void yearSelect_ValueChanged(object sender, EventArgs e)
        {
            refreshWorkedHours();
        }

        private void EditButton_Click(object sender, EventArgs e)
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

                addSickHours.Parameters.AddWithValue("@hours", Int32.Parse(workedHoursTxt.Text));
                addSickHours.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);
                addSickHours.Parameters.AddWithValue("@year", yearSelect.Value.Date.ToString("yyyy"));

                dbcon.runCommand(addSickHours);
            }
            else//update row since a row does exist
            {
                MySqlCommand addSickHours = new MySqlCommand("Update WorkedHours SET Hours=@hours WHERE EmployeeID=@id AND Year=@year", dbcon.Connection);

                addSickHours.Parameters.AddWithValue("@hours", Int32.Parse(workedHoursTxt.Text));
                addSickHours.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);
                addSickHours.Parameters.AddWithValue("@year", yearSelect.Value.Date.ToString("yyyy"));

                dbcon.runCommand(addSickHours);
            }

        }


        private void refreshWorkedHours()
        {
            ConnectDB dbcon = new ConnectDB();
            MySqlDataAdapter selectHours = new MySqlDataAdapter("Select Hours From WorkedHours WHERE EmployeeID=@employeeID AND Year=@year", dbcon.Connection);

            selectHours.SelectCommand.Parameters.AddWithValue("@employeeID", employeeDDL.SelectedValue);
            selectHours.SelectCommand.Parameters.AddWithValue("@year", yearSelect.Value.Date.ToString("yyyy"));


            DataTable dt = new DataTable();

            selectHours.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                workedHoursTxt.Text = dt.Rows[0]["Hours"].ToString();
            }
            else
            {
                workedHoursTxt.Text = "";
            }
        }
    }
}
