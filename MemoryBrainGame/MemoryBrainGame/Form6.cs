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
        public int level;
        PictureBox pendingImage1;
        PictureBox pendingImage2;
        List<Point> points = new List<Point>();
        Random r = new Random();

        public Form6()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Start();
            timer1.Enabled = true;
            progressBar3.Minimum = 1;
            progressBar3.Maximum = 800;
            level = 15;

            foreach (PictureBox pb in cardsHolder.Controls)
            {
                points.Add(pb.Location);
            }

            foreach (PictureBox pb in cardsHolder.Controls)
            {
                int next = r.Next(points.Count);
                Point p = points[next];
                pb.Location = p;
                points.Remove(p);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1;
            pictureBox2.Image = Properties.Resources._1;
            pictureBox3.Image = Properties.Resources._2;
            pictureBox4.Image = Properties.Resources._2;
            pictureBox5.Image = Properties.Resources._3;
            pictureBox6.Image = Properties.Resources._3;
            pictureBox7.Image = Properties.Resources._4;
            pictureBox8.Image = Properties.Resources._4;
            pictureBox9.Image = Properties.Resources._5;
            pictureBox10.Image = Properties.Resources._5;
            pictureBox11.Image = Properties.Resources._6;
            pictureBox12.Image = Properties.Resources._6;
            pictureBox13.Image = Properties.Resources._7;
            pictureBox14.Image = Properties.Resources._7;
            pictureBox15.Image = Properties.Resources._8;
            pictureBox16.Image = Properties.Resources._8;
            pictureBox17.Image = Properties.Resources._9;
            pictureBox18.Image = Properties.Resources._9;
            pictureBox19.Image = Properties.Resources._10;
            pictureBox20.Image = Properties.Resources._10;
            pictureBox21.Image = Properties.Resources._11;
            pictureBox22.Image = Properties.Resources._11;
            pictureBox23.Image = Properties.Resources._12;
            pictureBox24.Image = Properties.Resources._12;
            pictureBox25.Image = Properties.Resources._13;
            pictureBox26.Image = Properties.Resources._13;
            pictureBox27.Image = Properties.Resources._14;
            pictureBox28.Image = Properties.Resources._14;
            pictureBox29.Image = Properties.Resources._15;
            pictureBox30.Image = Properties.Resources._15;


            foreach (PictureBox pb in cardsHolder.Controls)
            {
                pb.Image = Properties.Resources.cover;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar3.Increment(+1);
            if (progressBar3.Value.Equals(progressBar3.Maximum))
            {
                // do whatever you want to do
                DialogResult result = MessageBox.Show("Do you want to try again?", "Game Over!",
               MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
            }
            else if(DialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void CardsCheck_Tick(object sender, EventArgs e)
        {
            cardsCheck.Stop();
            pendingImage1.Image = Properties.Resources.cover;
            pendingImage2.Image = Properties.Resources.cover;
            pendingImage1 = null;
            pendingImage2 = null;
        }

        public void check()
        {
            if (level <= 0)
            {
                this.Close();
            }
        }
        #region
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox1;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
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
                    level--;
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
            pictureBox2.Image = Properties.Resources._1;
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
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    level--;
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
            pictureBox3.Image = Properties.Resources._2;
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
                    level--;
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
            pictureBox4.Image = Properties.Resources._2;
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
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    level--;
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
            pictureBox5.Image = Properties.Resources._3;
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
                    level--;
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
            pictureBox6.Image = Properties.Resources._3;
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
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    level--;
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
            pictureBox7.Image = Properties.Resources._4;
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
                    level--;
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
            pictureBox8.Image = Properties.Resources._4;
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
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    level--;
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
            pictureBox9.Image = Properties.Resources._5;
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
                    level--;
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
            pictureBox10.Image = Properties.Resources._5;
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
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    level--;
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
            pictureBox11.Image = Properties.Resources._6;
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
                    level--;
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
            pictureBox12.Image = Properties.Resources._6;
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
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources._7;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox13;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox13;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources._7;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox14;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox14;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources._8;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox15;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox15;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources._8;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox16;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox16;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Properties.Resources._9;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox17;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox17;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox17.Enabled = false;
                    pictureBox18.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = Properties.Resources._9;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox18;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox18;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox17.Enabled = false;
                    pictureBox18.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = Properties.Resources._10;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox19;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox19;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox19.Enabled = false;
                    pictureBox20.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = Properties.Resources._10;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox20;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox20;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox19.Enabled = false;
                    pictureBox20.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Image = Properties.Resources._11;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox21;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox21;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox21.Enabled = false;
                    pictureBox22.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.Image = Properties.Resources._11;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox22;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox22;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox21.Enabled = false;
                    pictureBox22.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.Image = Properties.Resources._12;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox23;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox23;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox23.Enabled = false;
                    pictureBox24.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Image = Properties.Resources._12;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox24;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox24;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox23.Enabled = false;
                    pictureBox24.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.Image = Properties.Resources._13;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox25;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox25;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox25.Enabled = false;
                    pictureBox26.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Image = Properties.Resources._13;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox26;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox26;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox25.Enabled = false;
                    pictureBox26.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.Image = Properties.Resources._14;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox27;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox27;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox27.Enabled = false;
                    pictureBox28.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.Image = Properties.Resources._14;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox28;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox28;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox27.Enabled = false;
                    pictureBox28.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.Image = Properties.Resources._15;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox29;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox29;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox29.Enabled = false;
                    pictureBox30.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.Image = Properties.Resources._15;
            if (pendingImage1 == null)
            {
                pendingImage1 = pictureBox30;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pictureBox30;
            }

            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage1 = null;
                    pendingImage2 = null;
                    pictureBox29.Enabled = false;
                    pictureBox30.Enabled = false;
                    level--;
                    check();
                }
                else
                {
                    cardsCheck.Start();
                }
            }
        }

#endregion
    }
}
