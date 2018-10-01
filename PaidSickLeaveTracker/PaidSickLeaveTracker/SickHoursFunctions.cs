using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace PaidSickLeaveTracker
{
    class SickHoursFunctions
    {
        private ConnectDB dbCon = new ConnectDB();
        private DataFunctions dfun = new DataFunctions();

        public void addSickHours(double hours, string date, object id)
        {

            MySqlCommand cmd = new MySqlCommand("Insert Into SickHours (EmployeeID, SickDate, SickHoursUsed) Values (@id, @date, @hoursUsed)", dbCon.Connection);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@hoursUsed", hours);

            dbCon.runCommand(cmd);
        }

        public void updateSickHours(double hours, object id)
        {
            MySqlCommand updateHours = new MySqlCommand("Update SickHours SET SickHoursUsed=@hours WHERE SickID=@id", dbCon.Connection);

            updateHours.Parameters.AddWithValue("@hours", hours);
            updateHours.Parameters.AddWithValue("@id", id);

            dbCon.runCommand(updateHours);
        }

        public void fillSickDLL(ref ComboBox datesDDL, object id)
        {
            MySqlDataAdapter selectDates = new MySqlDataAdapter("Select * From SickHours WHERE EmployeeID=@id", dbCon.Connection);

            selectDates.SelectCommand.Parameters.AddWithValue("@id", id);


            DataTable dt = new DataTable();

            selectDates.Fill(dt);

            datesDDL.DataSource = dt;
            datesDDL.DisplayMember = "SickDate";
            datesDDL.ValueMember = "SickID";
        }

        public void addAdditionSickHours(double hours, string year, object id)
        {
            MySqlDataAdapter selectRow = new MySqlDataAdapter("Select AddID From AdditionalSickHours WHERE EmployeeID=@id AND Year=@year", dbCon.Connection);
            selectRow.SelectCommand.Parameters.AddWithValue("@id", id);
            selectRow.SelectCommand.Parameters.AddWithValue("@year", year);

            if (dfun.rowExists(ref selectRow))
            {
                MySqlCommand updateAddionalHours = new MySqlCommand("Update AdditionalSickHours SET Hours=@hours WHERE EmployeeID=@id AND Year=@year", dbCon.Connection);
                updateAddionalHours.Parameters.AddWithValue("@id", id);
                updateAddionalHours.Parameters.AddWithValue("@hours", hours);
                updateAddionalHours.Parameters.AddWithValue("@year", year);
                dbCon.runCommand(updateAddionalHours);
            }
            else
            {
                MySqlCommand insertAddionalHours = new MySqlCommand("Insert Into AdditionalSickHours (EmployeeID, Year, Hours) Values (@id, @year, @hours)", dbCon.Connection);
                insertAddionalHours.Parameters.AddWithValue("@id", id);
                insertAddionalHours.Parameters.AddWithValue("@hours", hours);
                insertAddionalHours.Parameters.AddWithValue("@year", year);
                dbCon.runCommand(insertAddionalHours);
            }
        }

        public void fillHoursTextbox(ref TextBox hoursTxt, object employeeID, object sickID)
        {
            //SickHoursUsed
            MySqlDataAdapter selectHours = new MySqlDataAdapter("Select SickHoursUsed From SickHours WHERE EmployeeID=@employeeID AND SickID=@sickID", dbCon.Connection);

            selectHours.SelectCommand.Parameters.AddWithValue("@employeeID", employeeID);
            selectHours.SelectCommand.Parameters.AddWithValue("@sickID", sickID);


            DataTable dt = new DataTable();

            selectHours.Fill(dt);

            if (dt.Rows.Count > 0)//data found
            {
                hoursTxt.Text = dt.Rows[0]["SickHoursUsed"].ToString();
            }
            else//null
            {
                hoursTxt.Text = "";
            }
        }

        public void fillSickHoursLeftGV(ref DataGridView gv, object id)
        {
            DataFunctions dfun = new DataFunctions();

            //Name, Total_Used_Hours, Sick_Hours_Left
            MySqlDataAdapter selectEmployeesWorkedHours = new MySqlDataAdapter("SELECT Name, Total_Used_Hours, Sick_Hours_Left+Hours As Sick_Hours_Left From Employees_Hours_Left_CurrentYear "+
                "Join AdditionalSickHours on Employees_Hours_Left_CurrentYear.EmployeeID = AdditionalSickHours.EmployeeID "+
                "WHERE Employees_Hours_Left_CurrentYear.EmployeeID = @id AND AdditionalSickHours.Year = Year(CURRENT_TIMESTAMP())", dbCon.Connection);

            selectEmployeesWorkedHours.SelectCommand.Parameters.AddWithValue("@id", id);

            dfun.fillGridView(selectEmployeesWorkedHours, ref gv);
        }
    }
}
