using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PaidSickLeaveTracker
{
    class ViewFunctions
    {

        ConnectDB dbCon = new ConnectDB();

        public void mainView(ref DataGridView gv, string name)
        {
            DataFunctions dfun = new DataFunctions();

            //Name, Total_Used_Hours, Sick_Hours_Left
            MySqlDataAdapter selectEmployeesWorkedHours = new MySqlDataAdapter("SELECT Name, Total_Used_Hours, Sick_Hours_Left+Hours As Sick_Hours_Left From Employees_Hours_Left_CurrentYear " +
                "Join AdditionalSickHours on Employees_Hours_Left_CurrentYear.EmployeeID = AdditionalSickHours.EmployeeID " +
                "WHERE Employees_Hours_Left_CurrentYear.Name LIKE @name AND AdditionalSickHours.Year = Year(CURRENT_TIMESTAMP()) Order By Name", dbCon.Connection);

            selectEmployeesWorkedHours.SelectCommand.Parameters.AddWithValue("@name", "%" + name + "%" );

            dfun.fillGridView(selectEmployeesWorkedHours, ref gv);
        }

		public void viewEmployeesSearch(ref DataGridView gv, string name)
		{
			DataFunctions dfun = new DataFunctions();

			MySqlDataAdapter selectEmployeesWorkedHours = new MySqlDataAdapter("SELECT Name From Employees Where Name LIKE @name Order By Name", dbCon.Connection);

			selectEmployeesWorkedHours.SelectCommand.Parameters.AddWithValue("@name", "%" + name + "%");

			dfun.fillGridView(selectEmployeesWorkedHours, ref gv);
		}

		public void viewWorkedHoursSearch(ref DataGridView gv, string name)
		{
			DataFunctions dfun = new DataFunctions();

			MySqlDataAdapter selectEmployeesWorkedHours = new MySqlDataAdapter("SELECT Name, Hours From Employees Join WorkedHours on Employees.EmployeeID = WorkedHours.EmployeeID Where Name Like @name Order By Name", dbCon.Connection);

			selectEmployeesWorkedHours.SelectCommand.Parameters.AddWithValue("@name", "%" + name + "%");

			dfun.fillGridView(selectEmployeesWorkedHours, ref gv);
		}
    }
}
