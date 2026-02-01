namespace Autorunner
{
	partial class Autorunner
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
			this.label1 = new System.Windows.Forms.Label();
			this.checkBoxLaunch = new System.Windows.Forms.CheckBox();
			this.buttonComplete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(40, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(691, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Поздравляем, Вы установили ClockPM_521!";
			// 
			// checkBoxLaunch
			// 
			this.checkBoxLaunch.AutoSize = true;
			this.checkBoxLaunch.Checked = true;
			this.checkBoxLaunch.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLaunch.Location = new System.Drawing.Point(59, 192);
			this.checkBoxLaunch.Name = "checkBoxLaunch";
			this.checkBoxLaunch.Size = new System.Drawing.Size(320, 24);
			this.checkBoxLaunch.TabIndex = 1;
			this.checkBoxLaunch.Text = "Запустить установленную программу";
			this.checkBoxLaunch.UseVisualStyleBackColor = true;
			// 
			// buttonComplete
			// 
			this.buttonComplete.Location = new System.Drawing.Point(558, 351);
			this.buttonComplete.Name = "buttonComplete";
			this.buttonComplete.Size = new System.Drawing.Size(193, 54);
			this.buttonComplete.TabIndex = 2;
			this.buttonComplete.Text = "Завершить";
			this.buttonComplete.UseVisualStyleBackColor = true;
			this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
			// 
			// Autorunner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonComplete);
			this.Controls.Add(this.checkBoxLaunch);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Autorunner";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Завершение установки";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxLaunch;
		private System.Windows.Forms.Button buttonComplete;
	}
}

