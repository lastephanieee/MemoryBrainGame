namespace MemoryBrainGame
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.hard = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(93, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your level";
            // 
            // hard
            // 
            this.hard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hard.BackgroundImage")));
            this.hard.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.ForeColor = System.Drawing.Color.Black;
            this.hard.Location = new System.Drawing.Point(139, 299);
            this.hard.Margin = new System.Windows.Forms.Padding(0);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(253, 67);
            this.hard.TabIndex = 9;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.button3_Click);
            // 
            // easy
            // 
            this.easy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("easy.BackgroundImage")));
            this.easy.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.ForeColor = System.Drawing.Color.Black;
            this.easy.Location = new System.Drawing.Point(139, 140);
            this.easy.Margin = new System.Windows.Forms.Padding(0);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(253, 67);
            this.easy.TabIndex = 8;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.button1_Click);
            // 
            // medium
            // 
            this.medium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("medium.BackgroundImage")));
            this.medium.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium.ForeColor = System.Drawing.Color.Black;
            this.medium.Location = new System.Drawing.Point(139, 218);
            this.medium.Margin = new System.Windows.Forms.Padding(0);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(253, 67);
            this.medium.TabIndex = 7;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryBrainGame.Properties.Resources.layer;
            this.ClientSize = new System.Drawing.Size(570, 492);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Memory Brain Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button medium;
    }
}