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

namespace Microwave
{
    public partial class Microwave: Form
    {
        bool microwaveOn = false;

        public Microwave()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Microwave_Hum_1_Second);
            if (microwaveOn == true)
            {
                return;
            }
            else
            {
                soundPlayer.PlayLooping();
                microwaveOn = true;
            }
        }

        private void ButtonN1_Click(object sender, EventArgs e)
        {
            NumberButtonPress(ButtonN1.Text);
        }
        private void ButtonN2_Click(object sender, EventArgs e)
        {
            NumberButtonPress(ButtonN2.Text);
        }
        private void ButtonN3_Click(object sender, EventArgs e)
        {
            NumberButtonPress(ButtonN3.Text);
        }
        private void ButtonN4_Click(object sender, EventArgs e)
        {
            NumberButtonPress(ButtonN4.Text);
        }
        private void ButtonN5_Click(object sender, EventArgs e)
        {
            NumberButtonPress(ButtonN5.Text);
        }

        private void ButtonN6_Click(object sender, EventArgs e)
        {
            NumberButtonPress(ButtonN6.Text);
        }
        private void ButtonN7_Click(object sender, EventArgs e)
        {
            NumberButtonPress(ButtonN7.Text);
        }
        private void ButtonN8_Click(object sender, EventArgs e)
        {
            NumberButtonPress(ButtonN8.Text);
        }
        private void ButtonN9_Click(object sender, EventArgs e)
        {
            NumberButtonPress(ButtonN9.Text);
        }

        void NumberButtonPress(string number)
        {
            LabelNumber.Text = number;
        }
    }
}
