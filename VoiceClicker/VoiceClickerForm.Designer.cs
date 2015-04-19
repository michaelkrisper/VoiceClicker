namespace VoiceClicker
{
	partial class VoiceClickerForm
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
			this.lblInputTime = new System.Windows.Forms.Label();
			this.btControl = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Last input time:";
			// 
			// lblInputTime
			// 
			this.lblInputTime.AutoSize = true;
			this.lblInputTime.Location = new System.Drawing.Point(135, 9);
			this.lblInputTime.Name = "lblInputTime";
			this.lblInputTime.Size = new System.Drawing.Size(0, 20);
			this.lblInputTime.TabIndex = 1;
			// 
			// btControl
			// 
			this.btControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btControl.Location = new System.Drawing.Point(16, 45);
			this.btControl.Name = "btControl";
			this.btControl.Size = new System.Drawing.Size(299, 100);
			this.btControl.TabIndex = 2;
			this.btControl.Text = "Stop";
			this.btControl.UseVisualStyleBackColor = false;
			this.btControl.Click += new System.EventHandler(this.btControl_Click);
			// 
			// VoiceClickerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 157);
			this.Controls.Add(this.btControl);
			this.Controls.Add(this.lblInputTime);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "VoiceClickerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Voice Clicker";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblInputTime;
		private System.Windows.Forms.Button btControl;

	}
}

