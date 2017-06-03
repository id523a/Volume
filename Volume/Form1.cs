using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume {
    public partial class Form1 : Form {
        private static Bitmap[] SpeakerImages;
        static Form1() {
            SpeakerImages = new Bitmap[3] { ImageRes.Spk1, ImageRes.Spk2, ImageRes.Spk3 };
        }
        private DiceControl[] DiceControls;
        public Form1() {
            InitializeComponent();
            DiceControls = new DiceControl[16] {
                diceControl1, diceControl2, diceControl3, diceControl4,
                diceControl5, diceControl6, diceControl7, diceControl8,
                diceControl9, diceControl10, diceControl11, diceControl12,
                diceControl13, diceControl14, diceControl15, diceControl16
            };
            SpeakerDisplay.Image = SpeakerImages[0];
        }
        private void RollButton_Click(object sender, EventArgs e) {
            RollButton.Enabled = false;
            RollTimer.Start();
            foreach (DiceControl d in DiceControls) {
                d.Roll();
            }
        }

        private void RollTimer_Tick(object sender, EventArgs e) {
            RollButton.Enabled = true;
            RollTimer.Stop();
            int volume = 0;
            foreach (DiceControl d in DiceControls) {
                volume += d.Value;
            }
            VolumeDisplay.Text = string.Format("Volume: {0}", volume);
            SpeakerDisplay.Image = SpeakerImages[volume / 33];
        }
    }
}
