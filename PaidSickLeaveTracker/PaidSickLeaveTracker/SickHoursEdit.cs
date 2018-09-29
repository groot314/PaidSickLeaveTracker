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
	public partial class SickHoursEdit : Form
	{
		public SickHoursEdit()
		{
			InitializeComponent();
		}

        private void SickHoursEdit_Load(object sender, EventArgs e)
        {
            Functions fun = new Functions();
            fun.fillEmployeeDDL(ref employeeDDL);


            refreshDates();
            refreshHours();
        }

        private void employeeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDates();
            refreshHours();
        }

        private void datesDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshHours();
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            ConnectDB dbcon = new ConnectDB();

            MySqlCommand updateHours = new MySqlCommand("Update SickHours SET SickHoursUsed=@hours WHERE SickID=@id", dbcon.Connection);

            updateHours.Parameters.AddWithValue("@hours", Int32.Parse(hoursTxt.Text));
            updateHours.Parameters.AddWithValue("@id", datesDDL.SelectedValue);

            dbcon.runCommand(updateHours);

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshDates()
        {
            ConnectDB dbcon = new ConnectDB();
            MySqlDataAdapter selectDates = new MySqlDataAdapter("Select * From SickHours WHERE EmployeeID=@id", dbcon.Connection);

            selectDates.SelectCommand.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);


            DataTable dt = new DataTable();

            selectDates.Fill(dt);

            datesDDL.DataSource = dt;
            datesDDL.DisplayMember = "SickDate";
            datesDDL.ValueMember = "SickID";
        }

        private void refreshHours()
        {
            ConnectDB dbcon = new ConnectDB();
            MySqlDataAdapter selectHours = new MySqlDataAdapter("Select SickHoursUsed From SickHours WHERE EmployeeID=@employeeID AND SickID=@sickID", dbcon.Connection);

            selectHours.SelectCommand.Parameters.AddWithValue("@employeeID", employeeDDL.SelectedValue);
            selectHours.SelectCommand.Parameters.AddWithValue("@sickID", datesDDL.SelectedValue);


            DataTable dt = new DataTable();

            selectHours.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                hoursTxt.Text = dt.Rows[0]["SickHoursUsed"].ToString();
            }
            else
            {
                hoursTxt.Text = "";
            }
        }
    }
}
