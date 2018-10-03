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
	public partial class WorkedHoursView : Form
	{
		public WorkedHoursView()
		{
			InitializeComponent();
		}

		ViewFunctions vfun = new ViewFunctions();

		private void WorkedHoursView_Load(object sender, EventArgs e)
		{
			vfun.viewWorkedHoursSearch(ref workedHoursGV, searchTxt.Text);
		}

		private void searchTxt_TextChanged(object sender, EventArgs e)
		{
			vfun.viewWorkedHoursSearch(ref workedHoursGV, searchTxt.Text);
		}
	}
}
