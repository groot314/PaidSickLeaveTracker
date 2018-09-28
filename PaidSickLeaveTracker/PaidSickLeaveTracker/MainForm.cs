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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)//employee add
		{
			EmployeeAddForm eaf = new EmployeeAddForm();
			eaf.Show();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)//employee edit
		{
			EmployeeEditForm eef = new EmployeeEditForm();
			eef.Show();
		}

		private void addToolStripMenuItem1_Click(object sender, EventArgs e)//worked hours add
		{
			WorkedHoursAdd wha = new WorkedHoursAdd();
			wha.Show();
		}

		private void editToolStripMenuItem1_Click(object sender, EventArgs e)//worked hours edit
		{
			WorkedHoursEdit whe = new WorkedHoursEdit();
			whe.Show();
		}

		private void addToolStripMenuItem2_Click(object sender, EventArgs e)//sick hours add
		{
			SickHoursAdd sha = new SickHoursAdd();
			sha.Show();
		}

		private void editToolStripMenuItem2_Click(object sender, EventArgs e)//sick hours edit
		{
			SickHoursEdit she = new SickHoursEdit();
			she.Show();
		}
	}
}
