using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PaidSickLeaveTracker
{
    class WorkedHoursFunctions
    {
        public WorkedHoursFunctions()
        {

        }

        private ConnectDB dbCon = new ConnectDB();

        public class updateWorkedHours
        {
            public static void add(double hours, string year, object id)
            {
                updateLogic(false, hours, year, id);
            }
            public static void set(double hours, string year, object id)
            {
                updateLogic(true, hours, year, id);
            }

            private static void updateLogic(bool set, double hours, string year, object id)
            {
                ConnectDB dbcon = new ConnectDB();

                MySqlDataAdapter selectRow = new MySqlDataAdapter("Select WorkedID From WorkedHours WHERE EmployeeID=@id AND Year=@year", dbcon.Connection);//select to see if row exist
                selectRow.SelectCommand.Parameters.AddWithValue("@id", id);
                selectRow.SelectCommand.Parameters.AddWithValue("@year", year);

                DataTable workedHoursDT = new DataTable();
                selectRow.Fill(workedHoursDT);


                if (workedHoursDT.Rows.Count == 0)//row doesn't exist
                {
                    MySqlCommand addSickHours = new MySqlCommand("Insert Into WorkedHours (EmployeeID, Year, Hours) Values (@id, @year, @hours)", dbcon.Connection);

                    addSickHours.Parameters.AddWithValue("@hours", hours);
                    addSickHours.Parameters.AddWithValue("@id", id);
                    addSickHours.Parameters.AddWithValue("@year", year);

                    dbcon.runCommand(addSickHours);
                }
                else//update row since a row does exist
                {
                    MySqlCommand addSickHours = new MySqlCommand("", dbcon.Connection);

                    if (set) //set hours
                    {
                        addSickHours.CommandText = "Update WorkedHours SET Hours=@hours WHERE EmployeeID=@id AND Year=@year";
                    }
                    else//add hours
                    {
                        addSickHours.CommandText = "Update WorkedHours SET Hours=Hours+@hours WHERE EmployeeID=@id AND Year=@year";
                    }
                  

                    addSickHours.Parameters.AddWithValue("@hours", hours);
                    addSickHours.Parameters.AddWithValue("@id", id);
                    addSickHours.Parameters.AddWithValue("@year", year);

                    dbcon.runCommand(addSickHours);
                }
            }
        }

        public void fillWorkedHoursTextbox(ref TextBox workedHoursTxt, string year, object id)
        {
            //Hours
            MySqlDataAdapter selectHours = new MySqlDataAdapter("Select Hours From WorkedHours WHERE EmployeeID=@employeeID AND Year=@year", dbCon.Connection);

            selectHours.SelectCommand.Parameters.AddWithValue("@employeeID", id);
            selectHours.SelectCommand.Parameters.AddWithValue("@year", year);


            DataTable dt = new DataTable();

            selectHours.Fill(dt);

            if (dt.Rows.Count > 0)//Data was found
            {
                workedHoursTxt.Text = dt.Rows[0]["Hours"].ToString();
            }
            else//null
            {
                workedHoursTxt.Text = "";
            }
        }

        public void fillWorkedHoursGV(ref DataGridView gv, string year, object id)
        {
            DataFunctions dfun = new DataFunctions();

            //Name, Worked Hours
            MySqlDataAdapter selectEmployeesWorkedHours = new MySqlDataAdapter("Select Employees.Name, WorkedHours.Hours From WorkedHours " +
                "Join Employees On WorkedHours.EmployeeID = Employees.EmployeeID WHERE WorkedHours.EmployeeID=@id AND Year=@year", dbCon.Connection);

            selectEmployeesWorkedHours.SelectCommand.Parameters.AddWithValue("@id", id);
            selectEmployeesWorkedHours.SelectCommand.Parameters.AddWithValue("@year", year);

            dfun.fillGridView(selectEmployeesWorkedHours, ref gv);
        }
    }
}
