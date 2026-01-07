namespace Alarm
{
	partial class ringingForm
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnSnooze = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(43, 24);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(482, 306);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOK.Location = new System.Drawing.Point(53, 418);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(154, 50);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnSnooze
			// 
			this.btnSnooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSnooze.Location = new System.Drawing.Point(332, 424);
			this.btnSnooze.Name = "btnSnooze";
			this.btnSnooze.Size = new System.Drawing.Size(161, 43);
			this.btnSnooze.TabIndex = 2;
			this.btnSnooze.Text = "Snooze";
			this.btnSnooze.UseVisualStyleBackColor = true;
			this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
			// 
			// ringingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 505);
			this.Controls.Add(this.btnSnooze);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.richTextBox1);
			this.Name = "ringingForm";
			this.Text = "ringingForm";
			this.Shown += new System.EventHandler(this.ringingForm_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnSnooze;
	}
}