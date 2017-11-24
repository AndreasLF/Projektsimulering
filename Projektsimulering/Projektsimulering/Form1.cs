using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektsimulering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            gameTimer.Interval = 1000;
            gameTimer.Tick += updateScreen;
        }

        /*
         * double angleRadians = (45 * Math.PI) / 180;
         * double startVelocity = 10;
         * double timeElapsed = 10;
         * double gravAcc = 9.82;
         */

        int gravAcc = 10;
        int sampleTime = 1;
        int height = 0;
        int distance = 0;

        int yVelocity = 0;
        int xVelocity = 0;

        int timeElapsed = 0;

        private void updateScreen(object sender, EventArgs e)
        {
            yVelocity = yVelocity - gravAcc * sampleTime;
            height = height + yVelocity * sampleTime;

            distance = distance + xVelocity * sampleTime;


            timeElapsed++;

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            timeLabel.Text = timeElapsed.ToString();

            projPosY.Text = height.ToString();
            projPosX.Text = distance.ToString();
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            double angleInput = Convert.ToDouble(angleTextBox.Text);
            angleInput = angleInput * (Math.PI / 180); //Converts angleInput from degrees to radians.
            double velocityInput = Convert.ToDouble(velocityTextBox.Text);
            
            xVelocity = Convert.ToInt32(Math.Cos(angleInput) * velocityInput);
            yVelocity = Convert.ToInt32(Math.Sin(angleInput) * velocityInput);
            
            gameTimer.Start();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            height = 0;
            distance = 0;

            timeElapsed = 0;

            gameTimer.Stop();
            UpdateLabels();
        }
    }
}
