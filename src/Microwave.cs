using System;
using System.Windows.Forms;
using System.Media;

namespace Microwave
{
    public partial class Microwave: Form
    {
        int secondsToCook = 0;
        bool cooking = false;
        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Microwave_Hum_1_Second);

        public Microwave()
        {
            InitializeComponent();
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
            secondsToCook += Convert.ToInt32(number);
            SecondsToCookBox.Text = Convert.ToString(secondsToCook);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartOrStopPress("Start");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StartOrStopPress("Stop");
        }

        void StartOrStopPress(string startOrStop)
        {
            if(startOrStop == "Start")
            {
                if (cooking == true)
                {
                    return;
                }
                else
                {
                    soundPlayer.PlayLooping();
                    cooking = true;
                }
            }else if (startOrStop == "Stop")
            {
                if (cooking == false)
                {
                    return;
                }
                else
                {
                    soundPlayer.Stop();
                    cooking = false;
                }
            }
        }

        void Cook()
        {

        }
    }
}