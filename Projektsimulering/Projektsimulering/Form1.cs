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

        int timeElapsed = 0;

        private void updateScreen(object sender, EventArgs e)
        {
            timeElapsed += 1;
            statusLabel.Text = timeElapsed.ToString();
        }
    }
}
