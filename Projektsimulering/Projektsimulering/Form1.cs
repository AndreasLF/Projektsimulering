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
            gameTimer.Start();
        }

        /*
        double angleRadians = (45 * Math.PI) / 180;
        double startVelocity = 10;
        double timeElapsed = 10;
        double gravAcc = 9.82;
        */

        int gravAcc = 10;
        int yVelocity = 100;
        int sampleTime = 1;
        int height = 0;





        private void updateScreen(object sender, EventArgs e)
        {

            yVelocity = yVelocity - gravAcc * sampleTime;
            height = height + yVelocity * sampleTime;

            projPosY.Text = height.ToString();



            /*
            double xPos = Math.Cos(angleRadians)*startVelocity*timeElapsed;
            double yPos = Math.Sin(angleRadians) * startVelocity * timeElapsed
                          - (gravAcc * Math.Pow(timeElapsed, 2) / 2);
            */

        }
    }
}

    }
}
