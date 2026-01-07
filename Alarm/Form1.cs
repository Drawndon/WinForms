using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Alarm
{
	public partial class Form1 : Form
	{
		string selectedTime;
		string selectedSnooze;
		string selectedRingtone;
		string selectedMessage;

		bool alarmSet = false;

		string snoozeTime;
		bool snoozeSet = false;

		string wavPath = @"C:\Users\admin\Ringtone\";
		SoundPlayer soundPlayer;

		ringingForm ringForm;


		public Form1()
		{
			InitializeComponent();
			soundPlayer = new SoundPlayer();
			ringForm = new ringingForm(this);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			selectedTime = cmbHour.Text + ":" + cmbMinute.Text + " " + cmbAMPM.Text;
			selectedSnooze = cmbSnooze.Text;
			selectedRingtone = listRingtone.Text;
			selectedMessage = richtxtMessage.Text;

			soundPlayer.SoundLocation = wavPath + selectedRingtone + ".wav";

			ringForm.Message(selectedMessage);

			groupBox1.Enabled = false;
			alarmSet = true;

		}

		public void Snooze()
		{
			try
			{
				soundPlayer.Stop();
			}
			catch { }

			DateTime dateTime = DateTime.Now;
			TimeSpan timeSpan = new TimeSpan(0, Convert.ToInt32(selectedSnooze), 0);
			snoozeTime = dateTime.Add(timeSpan).ToString("h:mm tt");

			snoozeSet = true;
		}

		public void Resume()
		{
			try
			{
				soundPlayer.Stop();
			}
			catch { }

			groupBox1.Enabled = true;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
			txtTime.Text = DateTime.Now.ToString("h:mm tt");

			UpdateData();

		}
		private void UpdateData()
		{
			for (int i = 1; i <= 12; i++)
			{
				cmbHour.Items.Add(i.ToString());
			}
			for (int i = 0; i <= 59; i++)
			{
				if (i < 10)
				{
					cmbMinute.Items.Add("0" + i.ToString());
				}
				else
				{
					cmbMinute.Items.Add(i.ToString());
				}
			}
			cmbAMPM.Items.Add("AM");
			cmbAMPM.Items.Add("PM");

			cmbSnooze.Items.Add("1");
			cmbSnooze.Items.Add("5");
			cmbSnooze.Items.Add("10");
			cmbSnooze.Items.Add("15");

			string[] wavFiles = Directory.GetFiles(wavPath, "*.wav");

			foreach (string wavFile in wavFiles)
			{
				string wavName = wavFile.Replace(wavPath, string.Empty);
				wavName = wavName.Replace(".wav", string.Empty);
				listRingtone.Items.Add(wavName);
			}

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
			txtTime.Text = DateTime.Now.ToString("h:mm tt");

			if (alarmSet)
			{
				if (txtTime.Text == selectedTime)
				{
					alarmSet = false;

					soundPlayer.Play();
					ringForm.ShowDialog();
				}
				else if (snoozeSet)
				{
					if (txtTime.Text == snoozeTime)
					{
						snoozeSet = false;
						soundPlayer.Play();
						ringForm.ShowDialog();
					}
				}
			}
		}
	}
}
