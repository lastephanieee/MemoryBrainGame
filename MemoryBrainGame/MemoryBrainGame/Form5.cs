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
        public int[] levels = new int[3];
        public int level;
        PictureBox pendingImage1;
        PictureBox pendingImage2;
        List<Point> points = new List<Point>();
        Random r = new Random();

        public Form5()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Enabled = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 360;
            level = Form1.level;
            levels[0] = 6;
            levels[1] = 10;
            levels[2] = 15;

            foreach (PictureBox pb in CardsHolder.Controls)
            {
                points.Add(pb.Location);
                //Console.WriteLine("adding locations");
            }

            foreach (PictureBox pb in CardsHolder.Controls)
            {
                int next = r.Next(points.Count);
                //Console.WriteLine(next);
                Point p = points[next];
                pb.Location = p;
                points.Remove(p);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.earth;
            pictureBox2.Image = Properties.Resources.earth;
            pictureBox3.Image = Properties.Resources.venus;
            pictureBox4.Image = Properties.Resources.venus;
            pictureBox5.Image = Properties.Resources.uranus;
            pictureBox6.Image = Properties.Resources.uranus;
            pictureBox7.Image = Properties.Resources.jupiter;
            pictureBox8.Image = Properties.Resources.jupiter;
            pictureBox9.Image = Properties.Resources.mars;
            pictureBox10.Image = Properties.Resources.mars;
            pictureBox11.Image = Properties.Resources.mercury;
            pictureBox12.Image = Properties.Resources.mercury;
            pictureBox13.Image = Properties.Resources.moon;
            pictureBox14.Image = Properties.Resources.moon;
            pictureBox15.Image = Properties.Resources.nepturn;
            pictureBox16.Image = Properties.Resources.nepturn;
            pictureBox17.Image = Properties.Resources.saturn;
            pictureBox18.Image = Properties.Resources.saturn;
            pictureBox19.Image = Properties.Resources.sun;
            pictureBox20.Image = Properties.Resources.sun;

            foreach (PictureBox pb in CardsHolder.Controls)
            {
                pb.Image = Properties.Resources.cover;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        
    }
}
