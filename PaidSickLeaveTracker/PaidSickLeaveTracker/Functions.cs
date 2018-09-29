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
    class Functions
    {
        public Functions()
        {

        }

        public void fillEmployeeDDL(ref ComboBox employeeDDL)
        {
            ConnectDB dbcon = new ConnectDB();
            MySqlDataAdapter selectEmployees = new MySqlDataAdapter("Select * From Employees", dbcon.Connection);


            DataTable dt = new DataTable();

            selectEmployees.Fill(dt);

            employeeDDL.DataSource = dt;
            employeeDDL.DisplayMember = "Name";
            employeeDDL.ValueMember = "EmployeeID";
        }

        public void fillGridView(MySqlDataAdapter selectCmd, ref DataGridView gv)
        {
            DataTable dt = new DataTable();
            selectCmd.Fill(dt);

            gv.DataSource = dt;
        }
    }
}
