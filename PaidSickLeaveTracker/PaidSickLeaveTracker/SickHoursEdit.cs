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

        private EmployeeFunctions efun = new EmployeeFunctions();
        private SickHoursFunctions sfun = new SickHoursFunctions();

        private void SickHoursEdit_Load(object sender, EventArgs e)
        {
            efun.fillEmployeeDDL(ref employeeDDL);


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
			double num;
			if (double.TryParse(hoursTxt.Text, out num))
			{
				sfun.updateSickHours(Convert.ToDouble(hoursTxt.Text), datesDDL.SelectedValue);// hours, and sickHoursID

			}
			else
			{
				MessageBox.Show("Enter in a numeric number");
			}
		}

        private void removeButton_Click(object sender, EventArgs e)
        {
            sfun.deleteSickHours(datesDDL.SelectedValue);
            refreshDates();
            refreshHours();
        }

        private void refreshDates()
        {
            sfun.fillSickDLL(ref datesDDL, employeeDDL.SelectedValue);//combo box(dates), employeeID
        }

        private void refreshHours()
        {
            sfun.fillHoursTextbox(ref hoursTxt, employeeDDL.SelectedValue, datesDDL.SelectedValue);//[txtbox], EmployeeID, SickID
        }
    }
}
