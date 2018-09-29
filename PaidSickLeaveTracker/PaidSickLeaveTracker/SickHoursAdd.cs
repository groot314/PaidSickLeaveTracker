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
	public partial class SickHoursAdd : Form
	{
		public SickHoursAdd()
		{
			InitializeComponent();
		}

		private void SickHoursAdd_Load(object sender, EventArgs e)
		{
			ConnectDB dbcon = new ConnectDB();
			MySqlDataAdapter selectEmployees = new MySqlDataAdapter("Select * From Employees", dbcon.Connection);


			DataTable dt = new DataTable();

			selectEmployees.Fill(dt);

			employeeDDL.DataSource = dt;
			employeeDDL.DisplayMember = "Name";
			employeeDDL.ValueMember = "EmployeeID";
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			ConnectDB db = new ConnectDB();

			MySqlCommand cmd = new MySqlCommand("Insert Into SickHours (EmployeeID, SickDate, SickHoursUsed) Values (@id, @date, @hoursUsed)", db.Connection);

			cmd.Parameters.AddWithValue("@id", employeeDDL.SelectedValue);
			cmd.Parameters.AddWithValue("@date", datePicker.Value.Date.ToString("yyyy-MM-dd"));
			cmd.Parameters.AddWithValue("@hoursUsed", Int32.Parse(hoursTxt.Text));

			db.runCommand(cmd);
		}
	}
}
