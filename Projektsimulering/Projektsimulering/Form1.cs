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
         * double angleRadians = (45 * Math.PI) / 180;
         * double startVelocity = 10;
         * double timeElapsed = 10;
         * double gravAcc = 9.82;
         */

        private void updateScreen(object sender, EventArgs e)
        {
            /* double xPos = Math.Cos(angleRadians)*startVelocity*timeElapsed;
             * double yPos = Math.Sin(angleRadians) * startVelocity * timeElapsed
             *             - (gravAcc * Math.Pow(timeElapsed, 2) / 2);
             */

        }
    }
}
