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
    class EmployeeFunctions
    {
        private ConnectDB dbcon = new ConnectDB();

        public void updateEmployeeName(string name, object id)
        {
            MySqlCommand updateEmployee = new MySqlCommand("Update Employees SET Name=@name WHERE EmployeeID=@id", dbcon.Connection);

            updateEmployee.Parameters.AddWithValue("@name", name);
            updateEmployee.Parameters.AddWithValue("@id", id);

            dbcon.runCommand(updateEmployee);
        }

        public void removeEmployee(object id)
        {
            MySqlCommand updateEmployee = new MySqlCommand("Delete From Employees WHERE EmployeeID=@id", dbcon.Connection);

            updateEmployee.Parameters.AddWithValue("@id", id);

            dbcon.runCommand(updateEmployee);
        }

        public void addEmployee(string name)
        {
            MySqlCommand cmd = new MySqlCommand("Insert Into Employees (Name) Values (@name)", dbcon.Connection);

            cmd.Parameters.AddWithValue("@name", name);

            dbcon.runCommand(cmd);
        }

        public void fillEmployeeDDL(ref ComboBox employeeDDL)
        {
            MySqlDataAdapter selectEmployees = new MySqlDataAdapter("Select * From Employees Order By Name", dbcon.Connection);

            DataTable dt = new DataTable();

            selectEmployees.Fill(dt);

            employeeDDL.DataSource = dt;
            employeeDDL.DisplayMember = "Name";
            employeeDDL.ValueMember = "EmployeeID";
        }
    }
}
