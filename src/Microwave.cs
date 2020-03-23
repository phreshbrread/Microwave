using System;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Microwave
{
    public partial class Microwave: Form
    {
        // declare variables
        int secondsToCook = 0;
        bool cooking = false;
        int timesBeeped = 0;
        
        SoundPlayer humSoundPlayer = new SoundPlayer(Properties.Resources.Microwave_Hum_1_Second);
        SoundPlayer beepSoundPlayer = new SoundPlayer(Properties.Resources.Microwave_Beep);
        SoundPlayer finishedBeepSoundPlayer = new SoundPlayer(Properties.Resources.Microwave_Finish_Beep_1_Second);

        public Microwave()
        {
            InitializeComponent();
        }

        // when any number button is pressed
        #region Button Clicks Code
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
        #endregion

        void NumberButtonPress(string number)
        {
            beepSoundPlayer.Play();
            secondsToCook += Convert.ToInt32(number);
            SecondsToCookBox.Text = Convert.ToString(secondsToCook);
        }

        // when the start or stop buttons are pressed
        #region Start & Stop button click voids
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (secondsToCook < 0)
            {
                SecondsToCookBox.Text = 0.ToString();
                secondsToCook = 0;
            }
            
            if (secondsToCook > 0)
            {
                StopResetButton.Text = "Stop";
            }

            
            if (cooking == true)
            {
                // add something to add a minute to the cook timer
                return;
            }
            else
            {
                CookTimer.Enabled = true;
                cooking = true;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopResetButton.Text = "Reset";
            if (cooking == false)
            {
                secondsToCook = 0;
                SecondsToCookBox.Text = 0.ToString();
                return;
            }
            else
            {
                humSoundPlayer.Stop();
                CookTimer.Enabled = false;
                cooking = false;
            }
        }
        #endregion

        private void CookTimer_Tick(object sender, EventArgs e)
        {
            if(secondsToCook <= 0)
            {
                CookTimer.Enabled = false;
                StopResetButton.Text = "Reset";
                return;
            }

            secondsToCook--;
            SecondsToCookBox.Text = secondsToCook.ToString();
        }

        private void SecondsToCookBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                secondsToCook = Convert.ToInt32(SecondsToCookBox.Text);
            }
            catch (FormatException)
            {
                return;
            }
            catch (OverflowException)
            {
                return;
            }
        }
    }
}