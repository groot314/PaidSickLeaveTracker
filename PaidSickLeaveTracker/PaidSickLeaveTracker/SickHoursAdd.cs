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

        private EmployeeFunctions efun = new EmployeeFunctions();
        private SickHoursFunctions sfun = new SickHoursFunctions();

		private void SickHoursAdd_Load(object sender, EventArgs e)
		{
            efun.fillEmployeeDDL(ref employeeDDL);

            refreshSickHoursView();
		}

        private void employeeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshSickHoursView();
        }

        private void AddButton_Click(object sender, EventArgs e)
		{
			double num;
			if (double.TryParse(hoursTxt.Text, out num))
			{
				sfun.addSickHours(Convert.ToDouble(hoursTxt.Text), datePicker.Value.Date.ToString("yyyy-MM-dd"), employeeDDL.SelectedValue);

				hoursTxt.Text = "";

				refreshSickHoursView();

			}
			else
			{
				MessageBox.Show("Enter in a numeric number");
			}
		}


        private void refreshSickHoursView()
        {
            sfun.fillSickHoursLeftGV(ref sickHourGV, employeeDDL.SelectedValue);
        }
    }
}
