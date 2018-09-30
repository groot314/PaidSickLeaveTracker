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
    class DataFunctions
    {
        public DataFunctions()
        {

        }

        public void fillGridView(MySqlDataAdapter selectCmd, ref DataGridView gv)
        {
            DataTable dt = new DataTable();
            selectCmd.Fill(dt);

            gv.DataSource = dt;
        }
    }
}
