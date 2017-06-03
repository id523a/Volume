using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume {
    public partial class DiceControl : UserControl {
        private static Bitmap[] DiceImages;
        static DiceControl() {
            DiceImages = new Bitmap[7] { null, ImageRes.D1, ImageRes.D2, ImageRes.D3, ImageRes.D4, ImageRes.D5, ImageRes.D6 };
        }
        public DiceControl() {
            InitializeComponent();
            Value = 1;
            DiceImgBox.Image = ImageRes.D1;
            Rand = new Random(Guid.NewGuid().GetHashCode());
        }
        private Random Rand;
        public int Value { get; private set; }
        private void DiceControl_Load(object sender, EventArgs e) {

        }
        public void Roll() {
            if (!HoldCheckBox.Checked) {
                RollFinish.Start();
                RollUpdateTimer.Start();
            }
        }

        private void RollFinish_Tick(object sender, EventArgs e) {
            RollUpdateTimer.Stop();
            RollFinish.Stop();
        }

        private void RollUpdateTimer_Tick(object sender, EventArgs e) {
            Value = Rand.Next(1, 7);
            DiceImgBox.Image = DiceImages[Value];
        }
    }
}
