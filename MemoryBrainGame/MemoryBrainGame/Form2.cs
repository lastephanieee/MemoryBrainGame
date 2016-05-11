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
        public PictureBox first;
        public PictureBox second;
        public int clicked;
        public bool finish;
        private Memory memory;
        public int level;
        public Dictionary<int, Image> images;

        public Form2()
        {
            InitializeComponent();
            DoubleBuffered = true;

            first = new PictureBox();
            second = new PictureBox();
            clicked = 0;
            finish = false;

            level = Form1.level;

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

        private void clicking(PictureBox pb)
        {


        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(1, 3);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox10.Image = bmp;
            clicking(this.pictureBox10);
            Invalidate();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(0, 2);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox9.Image = bmp;
            clicking(this.pictureBox9);
            Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(0, 0);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox1.Image = bmp;
            clicking(this.pictureBox1);
            Invalidate();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(0, 1);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox6.Image = bmp;
            clicking(this.pictureBox6);
            Invalidate();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(1, 0);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox3.Image = bmp;
            clicking(this.pictureBox3);
            Invalidate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(1, 1);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox4.Image = bmp;
            clicking(this.pictureBox4);
            Invalidate();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(1, 2);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox7.Image = bmp;
            clicking(this.pictureBox7);
            Invalidate();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(0, 3);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox12.Image = bmp;
            clicking(this.pictureBox12);
            Invalidate();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(2, 3);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox11.Image = bmp;
            clicking(this.pictureBox11);
            Invalidate();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(2, 2);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox8.Image = bmp;
            clicking(this.pictureBox8);
            Invalidate();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(2, 1);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox5.Image = bmp;
            clicking(this.pictureBox5);
            Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int temp = memory.getValue(2, 0);
            Image bmp;
            images.TryGetValue(temp, out bmp);
            this.pictureBox2.Image = bmp;
            clicking(this.pictureBox2);
            Invalidate();
        }
    }
}
