namespace MemoryBrainGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.help = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help.BackgroundImage")));
            this.help.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.ForeColor = System.Drawing.Color.Black;
            this.help.Location = new System.Drawing.Point(476, 12);
            this.help.Margin = new System.Windows.Forms.Padding(0);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(82, 30);
            this.help.TabIndex = 3;
            this.help.Text = "? Help";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // options
            // 
            this.options.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("options.BackgroundImage")));
            this.options.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.ForeColor = System.Drawing.Color.Black;
            this.options.Location = new System.Drawing.Point(123, 208);
            this.options.Margin = new System.Windows.Forms.Padding(0);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(253, 67);
            this.options.TabIndex = 4;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = false;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // start
            // 
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(123, 130);
            this.start.Margin = new System.Windows.Forms.Padding(0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(253, 67);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(123, 289);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(253, 67);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryBrainGame.Properties.Resources._13073173_10207811163989525_1338813235_o1;
            this.ClientSize = new System.Drawing.Size(570, 492);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.options);
            this.Controls.Add(this.help);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Memory Brain Game";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button exit;
    }
}

