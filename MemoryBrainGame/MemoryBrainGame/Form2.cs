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
        public Image firstClicked;
        public Image secondClicked;
        public Image firstOld;
        public Image secondOld;
        private Memory memory;
        public PictureBox pbFirst;
        public PictureBox pbSecond;
        public int[] levels = new int[3];
        public int level;
        public Dictionary<int, Image> images;

        public Form2()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Start();
            timer1.Enabled = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 120;
            level = Form1.level;
            levels[0] = 12;
            levels[1] = 20;
            levels[2] = 30;

            memory = new Memory(level);
            memory.fill();
            images = new Dictionary<int, Image>();

            initialize();
        }

        public void initialize()
        {
            images.Add(1, new Bitmap(MemoryBrainGame.Properties.Resources.angularjs));
            images.Add(2, new Bitmap(MemoryBrainGame.Properties.Resources.cobol));
            images.Add(3, new Bitmap(MemoryBrainGame.Properties.Resources.c_));
            images.Add(4, new Bitmap(MemoryBrainGame.Properties.Resources.c__));
            images.Add(5, new Bitmap(MemoryBrainGame.Properties.Resources.html));
            images.Add(6, new Bitmap(MemoryBrainGame.Properties.Resources.java));
            images.Add(7, new Bitmap(MemoryBrainGame.Properties.Resources.javascript));
            images.Add(8, new Bitmap(MemoryBrainGame.Properties.Resources.php));
            images.Add(9, new Bitmap(MemoryBrainGame.Properties.Resources.prolog));
            images.Add(10, new Bitmap(MemoryBrainGame.Properties.Resources.python));
            images.Add(11, new Bitmap(MemoryBrainGame.Properties.Resources.ruby));
            images.Add(12, new Bitmap(MemoryBrainGame.Properties.Resources.sql));
        }

        private bool clicking(Image oldImage, Image newImage)
        {
            if (firstClicked == null)
            {
                firstClicked = newImage;
                firstOld = oldImage;
                return true;
            }
            else
            {
                secondClicked = newImage;
                secondOld = newImage;
                if (firstClicked == secondClicked)
                {
                    levels[level]--;
                    if (levels[level] == 0)
                    {
                        this.Close();
                        Form5 form5 = new Form5();
                        form5.Show();
                    }
                    return true;
                }
                else
                    return false;
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(1, 3);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox10.Image;
            this.pictureBox10.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(0, 2);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox9.Image;
            this.pictureBox9.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(0, 0);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox1.Image;
            this.pictureBox1.Image = bmp;

            if (!clicking(oldie, bmp))
            {
            }

            Invalidate();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(0, 1);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox6.Image;
            this.pictureBox6.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }
            Invalidate();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(1, 0);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox3.Image;
            this.pictureBox3.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(1, 1);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox4.Image;
            this.pictureBox4.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(1, 2);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox7.Image;
            this.pictureBox7.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(0, 3);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox12.Image;
            this.pictureBox12.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(2, 3);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox11.Image;
            this.pictureBox11.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(2, 2);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox8.Image;
            this.pictureBox8.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(2, 1);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox5.Image;
            this.pictureBox5.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(2, 0);

            Image bmp;
            images.TryGetValue(temp, out bmp);
            Image oldie = this.pictureBox2.Image;
            this.pictureBox2.Image = bmp;

            if (!clicking(oldie, bmp))
            {

            }

            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+1);
        }
    }
}