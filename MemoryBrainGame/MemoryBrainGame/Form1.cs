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
    public partial class Form1 : Form
    {
        public static int level;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //this.Close();
            form2.Show();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void options_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            level = form3.level;
            if(form3.Visible)
            {
                this.Hide();
            }
            if(!form3.Visible)
                this.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
