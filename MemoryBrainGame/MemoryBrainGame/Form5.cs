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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Enabled = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 360;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+1);
        }
    }
}
