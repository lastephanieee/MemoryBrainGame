using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryBrainGame
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Enabled = true;
            progressBar3.Minimum = 1;
            progressBar3.Maximum = 480;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar3.Increment(+1);
        }
    }
}
