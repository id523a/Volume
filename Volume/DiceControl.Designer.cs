namespace Volume {
    partial class DiceControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.RollUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.DiceImgBox = new System.Windows.Forms.PictureBox();
            this.HoldCheckBox = new System.Windows.Forms.CheckBox();
            this.RollFinish = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DiceImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RollUpdateTimer
            // 
            this.RollUpdateTimer.Interval = 50;
            this.RollUpdateTimer.Tick += new System.EventHandler(this.RollUpdateTimer_Tick);
            // 
            // DiceImgBox
            // 
            this.DiceImgBox.Location = new System.Drawing.Point(3, 3);
            this.DiceImgBox.Name = "DiceImgBox";
            this.DiceImgBox.Size = new System.Drawing.Size(50, 50);
            this.DiceImgBox.TabIndex = 0;
            this.DiceImgBox.TabStop = false;
            // 
            // HoldCheckBox
            // 
            this.HoldCheckBox.AutoSize = true;
            this.HoldCheckBox.Location = new System.Drawing.Point(5, 59);
            this.HoldCheckBox.Name = "HoldCheckBox";
            this.HoldCheckBox.Size = new System.Drawing.Size(48, 17);
            this.HoldCheckBox.TabIndex = 1;
            this.HoldCheckBox.Text = "Hold";
            this.HoldCheckBox.UseVisualStyleBackColor = true;
            // 
            // RollFinish
            // 
            this.RollFinish.Interval = 600;
            this.RollFinish.Tick += new System.EventHandler(this.RollFinish_Tick);
            // 
            // DiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HoldCheckBox);
            this.Controls.Add(this.DiceImgBox);
            this.MaximumSize = new System.Drawing.Size(56, 80);
            this.MinimumSize = new System.Drawing.Size(56, 80);
            this.Name = "DiceControl";
            this.Size = new System.Drawing.Size(56, 80);
            this.Load += new System.EventHandler(this.DiceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiceImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer RollUpdateTimer;
        private System.Windows.Forms.PictureBox DiceImgBox;
        private System.Windows.Forms.CheckBox HoldCheckBox;
        private System.Windows.Forms.Timer RollFinish;
    }
}
