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
    public partial class Form2 : Form
    {
        public int[] levels = new int[3];
        public int level;
        PictureBox pendingImage1;
        PictureBox pendingImage2;
        List<Point> points = new List<Point>();
        Random r = new Random();
        

        public Form2()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Start();
            timer1.Enabled = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 120;
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
        

        private void Form2_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = Properties.Resources.angularjs;
            pictureBox2.Image = Properties.Resources.angularjs;
            pictureBox3.Image = Properties.Resources.cobol;
            pictureBox4.Image = Properties.Resources.cobol;
            pictureBox5.Image = Properties.Resources.c_;
            pictureBox6.Image = Properties.Resources.c_;
            pictureBox7.Image = Properties.Resources.c__;
            pictureBox8.Image = Properties.Resources.c__;
            pictureBox9.Image = Properties.Resources.html;
            pictureBox10.Image = Properties.Resources.html;
            pictureBox11.Image = Properties.Resources.java;
            pictureBox12.Image = Properties.Resources.java;

            

            foreach (PictureBox pb in CardsHolder.Controls)
            {
                pb.Image = Properties.Resources.cover;
            }

        }

        public void check()
        {
            Console.WriteLine("hello");
            if (levels[level] <= 0)
            {
                Form5 form5 = new Form5();
                form5.Show();
                this.Close();
                Console.WriteLine("hi");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.angularjs;
            if(pendingImage1 == null)
            {
                pendingImage1 = pictureBox1;
            }
            else if(pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox1;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.c_;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox6;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox6;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox6.Enabled = false;
                    pictureBox5.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.html;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox9;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox9;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.java;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox12;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox12;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox12.Enabled = false;
                    pictureBox11.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.cobol;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox3;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox3;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.cobol;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox4;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox4;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox4.Enabled = false;
                    pictureBox3.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.c__;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox7;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox7;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.html;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox10;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox10;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox10.Enabled = false;
                    pictureBox9.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.angularjs;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox2;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox2;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox2.Enabled = false;
                    pictureBox1.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.c_;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox5;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox5;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.c__;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox8;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox8;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox8.Enabled = false;
                    pictureBox7.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.java;

            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox11;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox11;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    levels[level]--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+1);
        }

        private void cardsCheck_Tick(object sender, EventArgs e)
        {
            cardsCheck.Stop();
            pendingImage1.Image = Properties.Resources.cover;
            pendingImage2.Image = Properties.Resources.cover;
            pendingImage1 = null;
            pendingImage2 = null;
        }
    }
}