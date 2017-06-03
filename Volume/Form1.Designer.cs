namespace Volume {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.RollButton = new System.Windows.Forms.Button();
            this.RollTimer = new System.Windows.Forms.Timer(this.components);
            this.VolumeDisplay = new System.Windows.Forms.Label();
            this.SpeakerDisplay = new System.Windows.Forms.PictureBox();
            this.diceControl16 = new Volume.DiceControl();
            this.diceControl15 = new Volume.DiceControl();
            this.diceControl14 = new Volume.DiceControl();
            this.diceControl13 = new Volume.DiceControl();
            this.diceControl12 = new Volume.DiceControl();
            this.diceControl11 = new Volume.DiceControl();
            this.diceControl10 = new Volume.DiceControl();
            this.diceControl9 = new Volume.DiceControl();
            this.diceControl8 = new Volume.DiceControl();
            this.diceControl7 = new Volume.DiceControl();
            this.diceControl6 = new Volume.DiceControl();
            this.diceControl5 = new Volume.DiceControl();
            this.diceControl4 = new Volume.DiceControl();
            this.diceControl3 = new Volume.DiceControl();
            this.diceControl2 = new Volume.DiceControl();
            this.diceControl1 = new Volume.DiceControl();
            ((System.ComponentModel.ISupportInitialize)(this.SpeakerDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // RollButton
            // 
            this.RollButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(12, 184);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(242, 70);
            this.RollButton.TabIndex = 1;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // RollTimer
            // 
            this.RollTimer.Interval = 700;
            this.RollTimer.Tick += new System.EventHandler(this.RollTimer_Tick);
            // 
            // VolumeDisplay
            // 
            this.VolumeDisplay.AutoSize = true;
            this.VolumeDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeDisplay.Location = new System.Drawing.Point(260, 204);
            this.VolumeDisplay.Name = "VolumeDisplay";
            this.VolumeDisplay.Size = new System.Drawing.Size(116, 30);
            this.VolumeDisplay.TabIndex = 17;
            this.VolumeDisplay.Text = "Volume: 16";
            // 
            // SpeakerDisplay
            // 
            this.SpeakerDisplay.Location = new System.Drawing.Point(432, 184);
            this.SpeakerDisplay.Name = "SpeakerDisplay";
            this.SpeakerDisplay.Size = new System.Drawing.Size(70, 70);
            this.SpeakerDisplay.TabIndex = 18;
            this.SpeakerDisplay.TabStop = false;
            // 
            // diceControl16
            // 
            this.diceControl16.Location = new System.Drawing.Point(446, 98);
            this.diceControl16.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl16.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl16.Name = "diceControl16";
            this.diceControl16.Size = new System.Drawing.Size(56, 80);
            this.diceControl16.TabIndex = 16;
            // 
            // diceControl15
            // 
            this.diceControl15.Location = new System.Drawing.Point(384, 98);
            this.diceControl15.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl15.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl15.Name = "diceControl15";
            this.diceControl15.Size = new System.Drawing.Size(56, 80);
            this.diceControl15.TabIndex = 15;
            // 
            // diceControl14
            // 
            this.diceControl14.Location = new System.Drawing.Point(322, 98);
            this.diceControl14.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl14.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl14.Name = "diceControl14";
            this.diceControl14.Size = new System.Drawing.Size(56, 80);
            this.diceControl14.TabIndex = 14;
            // 
            // diceControl13
            // 
            this.diceControl13.Location = new System.Drawing.Point(260, 98);
            this.diceControl13.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl13.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl13.Name = "diceControl13";
            this.diceControl13.Size = new System.Drawing.Size(56, 80);
            this.diceControl13.TabIndex = 13;
            // 
            // diceControl12
            // 
            this.diceControl12.Location = new System.Drawing.Point(198, 98);
            this.diceControl12.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl12.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl12.Name = "diceControl12";
            this.diceControl12.Size = new System.Drawing.Size(56, 80);
            this.diceControl12.TabIndex = 12;
            // 
            // diceControl11
            // 
            this.diceControl11.Location = new System.Drawing.Point(136, 98);
            this.diceControl11.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl11.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl11.Name = "diceControl11";
            this.diceControl11.Size = new System.Drawing.Size(56, 80);
            this.diceControl11.TabIndex = 11;
            // 
            // diceControl10
            // 
            this.diceControl10.Location = new System.Drawing.Point(74, 98);
            this.diceControl10.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl10.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl10.Name = "diceControl10";
            this.diceControl10.Size = new System.Drawing.Size(56, 80);
            this.diceControl10.TabIndex = 10;
            // 
            // diceControl9
            // 
            this.diceControl9.Location = new System.Drawing.Point(12, 98);
            this.diceControl9.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl9.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl9.Name = "diceControl9";
            this.diceControl9.Size = new System.Drawing.Size(56, 80);
            this.diceControl9.TabIndex = 9;
            // 
            // diceControl8
            // 
            this.diceControl8.Location = new System.Drawing.Point(446, 12);
            this.diceControl8.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl8.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl8.Name = "diceControl8";
            this.diceControl8.Size = new System.Drawing.Size(56, 80);
            this.diceControl8.TabIndex = 8;
            // 
            // diceControl7
            // 
            this.diceControl7.Location = new System.Drawing.Point(384, 12);
            this.diceControl7.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl7.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl7.Name = "diceControl7";
            this.diceControl7.Size = new System.Drawing.Size(56, 80);
            this.diceControl7.TabIndex = 7;
            // 
            // diceControl6
            // 
            this.diceControl6.Location = new System.Drawing.Point(322, 12);
            this.diceControl6.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl6.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl6.Name = "diceControl6";
            this.diceControl6.Size = new System.Drawing.Size(56, 80);
            this.diceControl6.TabIndex = 6;
            // 
            // diceControl5
            // 
            this.diceControl5.Location = new System.Drawing.Point(260, 12);
            this.diceControl5.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl5.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl5.Name = "diceControl5";
            this.diceControl5.Size = new System.Drawing.Size(56, 80);
            this.diceControl5.TabIndex = 5;
            // 
            // diceControl4
            // 
            this.diceControl4.Location = new System.Drawing.Point(198, 12);
            this.diceControl4.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl4.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl4.Name = "diceControl4";
            this.diceControl4.Size = new System.Drawing.Size(56, 80);
            this.diceControl4.TabIndex = 4;
            // 
            // diceControl3
            // 
            this.diceControl3.Location = new System.Drawing.Point(136, 12);
            this.diceControl3.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl3.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl3.Name = "diceControl3";
            this.diceControl3.Size = new System.Drawing.Size(56, 80);
            this.diceControl3.TabIndex = 3;
            // 
            // diceControl2
            // 
            this.diceControl2.Location = new System.Drawing.Point(74, 12);
            this.diceControl2.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl2.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl2.Name = "diceControl2";
            this.diceControl2.Size = new System.Drawing.Size(56, 80);
            this.diceControl2.TabIndex = 2;
            // 
            // diceControl1
            // 
            this.diceControl1.Location = new System.Drawing.Point(12, 12);
            this.diceControl1.MaximumSize = new System.Drawing.Size(56, 80);
            this.diceControl1.MinimumSize = new System.Drawing.Size(56, 80);
            this.diceControl1.Name = "diceControl1";
            this.diceControl1.Size = new System.Drawing.Size(56, 80);
            this.diceControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 384);
            this.Controls.Add(this.SpeakerDisplay);
            this.Controls.Add(this.VolumeDisplay);
            this.Controls.Add(this.diceControl16);
            this.Controls.Add(this.diceControl15);
            this.Controls.Add(this.diceControl14);
            this.Controls.Add(this.diceControl13);
            this.Controls.Add(this.diceControl12);
            this.Controls.Add(this.diceControl11);
            this.Controls.Add(this.diceControl10);
            this.Controls.Add(this.diceControl9);
            this.Controls.Add(this.diceControl8);
            this.Controls.Add(this.diceControl7);
            this.Controls.Add(this.diceControl6);
            this.Controls.Add(this.diceControl5);
            this.Controls.Add(this.diceControl4);
            this.Controls.Add(this.diceControl3);
            this.Controls.Add(this.diceControl2);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.diceControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SpeakerDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiceControl diceControl1;
        private System.Windows.Forms.Button RollButton;
        private DiceControl diceControl2;
        private DiceControl diceControl3;
        private DiceControl diceControl4;
        private DiceControl diceControl5;
        private DiceControl diceControl6;
        private DiceControl diceControl7;
        private DiceControl diceControl8;
        private DiceControl diceControl9;
        private DiceControl diceControl10;
        private DiceControl diceControl11;
        private DiceControl diceControl12;
        private DiceControl diceControl13;
        private DiceControl diceControl14;
        private DiceControl diceControl15;
        private DiceControl diceControl16;
        private System.Windows.Forms.Timer RollTimer;
        private System.Windows.Forms.Label VolumeDisplay;
        private System.Windows.Forms.PictureBox SpeakerDisplay;
    }
}

