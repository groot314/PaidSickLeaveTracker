using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaidSickLeaveTracker
{
	public partial class EmployeesView : Form
	{
		public EmployeesView()
		{
			InitializeComponent();
		}

		ViewFunctions vfun = new ViewFunctions();

		private void EmployeesView_Load(object sender, EventArgs e)
		{
			vfun.viewEmployeesSearch(ref employeesGV, searchTxt.Text);
		}

		private void searchTxt_TextChanged(object sender, EventArgs e)
		{
			vfun.viewEmployeesSearch(ref employeesGV, searchTxt.Text);
		}
	}
}
