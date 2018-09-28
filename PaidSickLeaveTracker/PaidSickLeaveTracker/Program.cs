using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace PaidSickLeaveTracker
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ConnectDB db = new ConnectDB();

			MySqlCommand test = new MySqlCommand("Insert Into test (name) Values ('Geoff')", db.Connection);

			try
			{
				if(db.Connection.State == ConnectionState.Closed)
				{
					db.Connection.Open();
				}
				test.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Debug.Write(ex.Message);
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
