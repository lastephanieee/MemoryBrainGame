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
    public partial class Form3 : Form
    {
        public int level;

        public Form3()
        {
            InitializeComponent();
            DoubleBuffered = true;
            level = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level = 0;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level = 1;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            level = 3;
            this.Close();
        }
    }
}
