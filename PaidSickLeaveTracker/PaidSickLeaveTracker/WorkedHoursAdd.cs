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
	public partial class WorkedHoursAdd : Form
	{
		public WorkedHoursAdd()
		{
			InitializeComponent();
            yearSelect.CustomFormat = "yyyy";
            yearSelect.ShowUpDown = true;
		}

        private WorkedHoursFunctions wfun = new WorkedHoursFunctions();
        private EmployeeFunctions efun = new EmployeeFunctions();

		private void WorkedHoursAdd_Load(object sender, EventArgs e)
		{
            efun.fillEmployeeDDL(ref employeeDDL);

            refreshViewHours();
		}

        private void employeeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshViewHours();
        }

        private void yearSelect_ValueChanged(object sender, EventArgs e)
        {
            refreshViewHours();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            WorkedHoursFunctions.updateWorkedHours.add(Convert.ToDouble(hoursTxt.Text), yearSelect.Value.ToString("yyyy"), employeeDDL.SelectedValue);

			hoursTxt.Text = "";

            refreshViewHours();
		}


        private void refreshViewHours()
        {
            wfun.fillWorkedHoursGV(ref workedHoursGV, yearSelect.Value.ToString("yyyy"), employeeDDL.SelectedValue);
        }
    }
}
