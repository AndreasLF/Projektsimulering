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
            
            //Defines the games Timer-component and method to call.
            gameTimer.Interval = 1000;
            gameTimer.Tick += updateScreen;
            
            updateLabels();
        }

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

        /// <summary>
        /// updateScreen() is the core gameloop, that runs the game.
        /// </summary>
        private void updateScreen(object sender, EventArgs e)
        {
            updateProjPos();

            timeElapsed++;

            updateLabels();

            collisionDetect();
        }

        /// <summary>
        /// Calculates the position of the projectile using the velocity and sampleTime.
        /// </summary>
        private void updateProjPos()
        {
            yVelocity = yVelocity - gravAcc * sampleTime;
            projectilePosY = projectilePosY + yVelocity * sampleTime;

            projectilePosX = projectilePosX + xVelocity * sampleTime;
        }

        /// <summary>
        /// Updates all labels in the GUI.
        /// </summary>
        private void updateLabels()
        {
            timeLabel.Text = timeElapsed.ToString();

            projPosY.Text = projectilePosY.ToString();
            projPosX.Text = projectilePosX.ToString();

            statusLabel.Text = "Status";

            targetPosXLabel.Text = targetPosX.ToString();
            targetPosYLabel.Text = targetPosY.ToString();
        }

        /// <summary>
        /// Detects collision between the projectile and target or the ground. 
        /// </summary>
        private void collisionDetect()
        {
            int dX = targetPosX - projectilePosX;
            int dY = targetPosY - projectilePosY;

            double distance = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));
            if (distance < targetRadius) //Win-state, if the projectile is within the radius of the target.
            {
                gameTimer.Stop();
                statusLabel.Text = "Congratulations! You hit the target!";
            }
            else if(projectilePosY <= 0) //Failure-state, if the projectile collides with the ground.
            {
                gameTimer.Stop();
                statusLabel.Text = "You hit the ground!";
            }
        }

        /// <summary>
        /// Method that runs when the fireButton is clicked.
        /// Interprets input from the player to use in calculations.
        /// Toggles which buttons are enabled.
        /// Starts the gameTimer, and with that, the game.
        /// </summary>
        private void fireButton_Click(object sender, EventArgs e)
        {
            double angleInput = Convert.ToDouble(angleNumUpDown.Value);
            angleInput = angleInput * (Math.PI / 180); //Converts angleInput from degrees to radians.
            double velocityInput = Convert.ToDouble(velocityNumUpDown.Value);
            
            xVelocity = Convert.ToInt32(Math.Cos(angleInput) * velocityInput);
            yVelocity = Convert.ToInt32(Math.Sin(angleInput) * velocityInput);

            fireButton.Enabled = false;
            restartButton.Enabled = true;

            gameTimer.Start();
        }

        /// <summary>
        /// Method that runs when the resetButton is clicked.
        /// Resets position of the projectile, the game time, which buttons are enabled.
        /// Stops the gameTimer.
        /// </summary>
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