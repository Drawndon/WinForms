namespace Alarm
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbSnooze = new System.Windows.Forms.ComboBox();
			this.cmbAMPM = new System.Windows.Forms.ComboBox();
			this.cmbMinute = new System.Windows.Forms.ComboBox();
			this.cmbHour = new System.Windows.Forms.ComboBox();
			this.richtxtMessage = new System.Windows.Forms.RichTextBox();
			this.btnSetAlarm = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDate = new System.Windows.Forms.RichTextBox();
			this.txtTime = new System.Windows.Forms.RichTextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.listRingtone = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(49, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Дата:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(49, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "Время:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listRingtone);
			this.groupBox1.Controls.Add(this.cmbSnooze);
			this.groupBox1.Controls.Add(this.cmbAMPM);
			this.groupBox1.Controls.Add(this.cmbMinute);
			this.groupBox1.Controls.Add(this.cmbHour);
			this.groupBox1.Controls.Add(this.richtxtMessage);
			this.groupBox1.Controls.Add(this.btnSetAlarm);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(40, 238);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1356, 622);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Set Alarm";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// cmbSnooze
			// 
			this.cmbSnooze.FormattingEnabled = true;
			this.cmbSnooze.Location = new System.Drawing.Point(177, 207);
			this.cmbSnooze.Name = "cmbSnooze";
			this.cmbSnooze.Size = new System.Drawing.Size(100, 48);
			this.cmbSnooze.TabIndex = 10;
			// 
			// cmbAMPM
			// 
			this.cmbAMPM.FormattingEnabled = true;
			this.cmbAMPM.Location = new System.Drawing.Point(480, 102);
			this.cmbAMPM.Name = "cmbAMPM";
			this.cmbAMPM.Size = new System.Drawing.Size(103, 48);
			this.cmbAMPM.TabIndex = 9;
			// 
			// cmbMinute
			// 
			this.cmbMinute.FormattingEnabled = true;
			this.cmbMinute.Location = new System.Drawing.Point(329, 102);
			this.cmbMinute.Name = "cmbMinute";
			this.cmbMinute.Size = new System.Drawing.Size(101, 48);
			this.cmbMinute.TabIndex = 8;
			// 
			// cmbHour
			// 
			this.cmbHour.FormattingEnabled = true;
			this.cmbHour.Location = new System.Drawing.Point(171, 102);
			this.cmbHour.Name = "cmbHour";
			this.cmbHour.Size = new System.Drawing.Size(107, 48);
			this.cmbHour.TabIndex = 7;
			// 
			// richtxtMessage
			// 
			this.richtxtMessage.Location = new System.Drawing.Point(731, 131);
			this.richtxtMessage.Name = "richtxtMessage";
			this.richtxtMessage.Size = new System.Drawing.Size(602, 357);
			this.richtxtMessage.TabIndex = 6;
			this.richtxtMessage.Text = "";
			// 
			// btnSetAlarm
			// 
			this.btnSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSetAlarm.Location = new System.Drawing.Point(533, 523);
			this.btnSetAlarm.Name = "btnSetAlarm";
			this.btnSetAlarm.Size = new System.Drawing.Size(228, 60);
			this.btnSetAlarm.TabIndex = 5;
			this.btnSetAlarm.Text = "Set Alarm";
			this.btnSetAlarm.UseVisualStyleBackColor = true;
			this.btnSetAlarm.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(717, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(173, 40);
			this.label7.TabIndex = 4;
			this.label7.Text = "Message:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(9, 301);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(171, 40);
			this.label6.TabIndex = 3;
			this.label6.Text = "Ringtone:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(322, 207);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(167, 40);
			this.label5.TabIndex = 2;
			this.label5.Text = "minute(s)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(9, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 40);
			this.label4.TabIndex = 1;
			this.label4.Text = "Snooze:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(9, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 40);
			this.label3.TabIndex = 0;
			this.label3.Text = "Time:";
			// 
			// txtDate
			// 
			this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtDate.Location = new System.Drawing.Point(230, 64);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(377, 63);
			this.txtDate.TabIndex = 3;
			this.txtDate.Text = "";
			this.txtDate.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// txtTime
			// 
			this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTime.Location = new System.Drawing.Point(234, 162);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(372, 65);
			this.txtTime.TabIndex = 4;
			this.txtTime.Text = "";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// listRingtone
			// 
			this.listRingtone.FormattingEnabled = true;
			this.listRingtone.ItemHeight = 40;
			this.listRingtone.Location = new System.Drawing.Point(171, 301);
			this.listRingtone.Name = "listRingtone";
			this.listRingtone.Size = new System.Drawing.Size(428, 164);
			this.listRingtone.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1424, 872);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.txtDate);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSetAlarm;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox txtDate;
		private System.Windows.Forms.ComboBox cmbSnooze;
		private System.Windows.Forms.ComboBox cmbAMPM;
		private System.Windows.Forms.ComboBox cmbMinute;
		private System.Windows.Forms.ComboBox cmbHour;
		private System.Windows.Forms.RichTextBox richtxtMessage;
		private System.Windows.Forms.RichTextBox txtTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ListBox listRingtone;
	}
}

