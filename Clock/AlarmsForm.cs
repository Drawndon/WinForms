using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmsForm : Form
	{
	AlarmDialog alarm;
		public AlarmsForm()
		{
			InitializeComponent();
			alarm = new AlarmDialog();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (alarm.ShowDialog() == DialogResult.OK)
			{
				listBoxAlarms.Items.Add(alarm.Alarm);
			}
			
		}

		private void listBoxAlarms_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listBoxAlarms.Items.Count > 0)
			{
				if (listBoxAlarms.SelectedItem != null)
				{
					if (alarm.ShowDialog() == DialogResult.OK)
					{
						listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = alarm.Alarm;
					}
				}
				else
					MessageBox.Show(this, "Выберите будильник", "Info",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else buttonAdd_Click(sender, e);
		}
	}
}
