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
	public partial class WorkedHoursEdit : Form
	{
		public WorkedHoursEdit()
		{
			InitializeComponent();
            yearSelect.CustomFormat = "yyyy";
            yearSelect.ShowUpDown = true;
        }

        private EmployeeFunctions efun = new EmployeeFunctions();
        private WorkedHoursFunctions wfun = new WorkedHoursFunctions();

        private void WorkedHoursEdit_Load(object sender, EventArgs e)
        {
            efun.fillEmployeeDDL(ref employeeDDL);

            refreshWorkedHours();
        }

        private void employeeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshWorkedHours();
        }

        private void yearSelect_ValueChanged(object sender, EventArgs e)
        {
            refreshWorkedHours();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
			double num;
			if (double.TryParse(workedHoursTxt.Text, out num))
			{
				WorkedHoursFunctions.updateWorkedHours.set(Convert.ToDouble(workedHoursTxt.Text), yearSelect.Value.ToString("yyyy"), employeeDDL.SelectedValue);
			}
			else
			{
				MessageBox.Show("Enter in a numeric number");
			}
		}


        private void refreshWorkedHours()
        {
            wfun.fillWorkedHoursTextbox(ref workedHoursTxt, yearSelect.Value.ToString("yyyy"), employeeDDL.SelectedValue);
        }

    }
}
