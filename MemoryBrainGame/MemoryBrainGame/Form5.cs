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
            progressBar1.Maximum = 500;
            level = 10;
            Console.WriteLine(level);


            foreach (PictureBox pb in CardsHolder.Controls)
            {
                points.Add(pb.Location);
            }

            foreach (PictureBox pb in CardsHolder.Controls)
            {
                int next = r.Next(points.Count);
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
        bool flag = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Increment(+1);
                flag = true;
            }
            else 
            {
                if (flag)
                {
                    DialogResult result = MessageBox.Show("Do you want to try again?", "Game Over!",
                   MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Close();
                    }
                    else if (DialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    flag = false;
                }
            
        }
        }

        public void check()
        {
            if (level <= 0)
            {
                Form6 form6 = new Form6();
                form6.Show();
                this.Close();
            }
        }

        #region

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.earth;
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
            pictureBox2.Image = Properties.Resources.earth;
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
            pictureBox3.Image = Properties.Resources.venus;
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
            pictureBox4.Image = Properties.Resources.venus;
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
            pictureBox5.Image = Properties.Resources.uranus;
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
            pictureBox6.Image = Properties.Resources.uranus;
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
            pictureBox7.Image = Properties.Resources.jupiter;
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
            pictureBox8.Image = Properties.Resources.jupiter;
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
            pictureBox9.Image = Properties.Resources.mars;
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
            pictureBox10.Image = Properties.Resources.mars;
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
            pictureBox11.Image = Properties.Resources.mercury;
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
            pictureBox12.Image = Properties.Resources.mercury;
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
            pictureBox13.Image = Properties.Resources.moon;
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
            pictureBox14.Image = Properties.Resources.moon;
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
            pictureBox15.Image = Properties.Resources.nepturn;
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
            pictureBox16.Image = Properties.Resources.nepturn;
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
            pictureBox17.Image = Properties.Resources.saturn;
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
            pictureBox18.Image = Properties.Resources.saturn;
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
            pictureBox19.Image = Properties.Resources.sun;
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
            pictureBox20.Image = Properties.Resources.sun;
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

        #endregion

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
