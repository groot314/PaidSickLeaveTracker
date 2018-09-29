using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace PaidSickLeaveTracker
{
	class ConnectDB
	{
		public ConnectDB()
		{

		}

		MySqlConnection con = new MySqlConnection("Data Source=;Initial Catalog=SickHours;Persist Security Info=True; User ID=; Password=");

		public MySqlConnection Connection
		{
			get { return con; }
		}

		public void runCommand(MySqlCommand cmd)
		{
			try
			{
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Debug.Write(ex.Message);
			}
		}
	}
}
