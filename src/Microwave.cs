﻿using System;
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
        bool finished = true;
        int timesBeeped = 0;
        
        SoundPlayer humSoundPlayer = new SoundPlayer(Properties.Resources.Microwave_Hum_1_Second);
        SoundPlayer beepSoundPlayer = new SoundPlayer(Properties.Resources.Microwave_Beep);
        SoundPlayer finishedBeepSoundPlayer = new SoundPlayer(Properties.Resources.Microwave_Finish_Beep_1_Second);

        public Microwave()
        {
            InitializeComponent();
        }

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

        #region Start & Stop button click voids
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartOrStopPress("Start");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StartOrStopPress("Stop");
        }
        #endregion

        void StartOrStopPress(string startOrStop)
        {
            if(startOrStop == "Start")
            {
                if (cooking == true)
                {
                    // add something to add a minute to the cook timer
                    return;
                }
                else
                {
                    CookTimer.Enabled = true;
                }
            }else if (startOrStop == "Stop")
            {
                if (cooking == false)
                {
                    return;
                }
                else
                {
                    humSoundPlayer.Stop();
                    CookTimer.Enabled = false;
                    cooking = false;
                }
            }
        }

        private void CookTimer_Tick(object sender, EventArgs e)
        {
            if(secondsToCook <= 0)
            {
                CookTimer.Enabled = false;
                return;
            }

            secondsToCook--;
            SecondsToCookBox.Text = secondsToCook.ToString();
        }
    }
}