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

            updateLabels();
        }

        /*
         * double angleRadians = (45 * Math.PI) / 180;
         * double startVelocity = 10;
         * double timeElapsed = 10;
         * double gravAcc = 9.82;
         */

        int gravAcc = 10;
        int sampleTime = 1;
        int projectilePosY = 0;
        int projectilePosX = 0;

        int yVelocity = 0;
        int xVelocity = 0;

        int targetPosX = 100;
        int targetPosY = 0;
        int targetRadius = 5;

        int timeElapsed = 0;

        private void updateScreen(object sender, EventArgs e)
        {
            yVelocity = yVelocity - gravAcc * sampleTime;
            projectilePosY = projectilePosY + yVelocity * sampleTime;

            projectilePosX = projectilePosX + xVelocity * sampleTime;


            timeElapsed++;

            updateLabels();

            collisionDetect();
        }

        private void updateLabels()
        {
            timeLabel.Text = timeElapsed.ToString();

            projPosY.Text = projectilePosY.ToString();
            projPosX.Text = projectilePosX.ToString();

            statusLabel.Text = "Status";

            targetPosXLabel.Text = targetPosX.ToString();
            targetPosYLabel.Text = targetPosY.ToString();
        }

        private void collisionDetect()
        {
            int dX = targetPosX - projectilePosX;
            int dY = targetPosY - projectilePosY;

            double distance = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));
            if (distance < targetRadius)
            {
                gameTimer.Stop();
                statusLabel.Text = "Congratulations! You hit the target!";
            }
            else if(projectilePosY <= 0)
            {
                gameTimer.Stop();
                statusLabel.Text = "You hit the ground!";
            }
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            double angleInput = Convert.ToDouble(angleTextBox.Text);
            angleInput = angleInput * (Math.PI / 180); //Converts angleInput from degrees to radians.
            double velocityInput = Convert.ToDouble(velocityTextBox.Text);
            
            xVelocity = Convert.ToInt32(Math.Cos(angleInput) * velocityInput);
            yVelocity = Convert.ToInt32(Math.Sin(angleInput) * velocityInput);

            fireButton.Enabled = false;
            restartButton.Enabled = true;

            gameTimer.Start();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            projectilePosY = 0;
            projectilePosX = 0;

            timeElapsed = 0;

            fireButton.Enabled = true;
            restartButton.Enabled = false;

            gameTimer.Stop();
            updateLabels();
        }
    }
}