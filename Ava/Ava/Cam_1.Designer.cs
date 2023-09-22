namespace Ava
{
    partial class Cam_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cam_1));
            this.tim3 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Button();
            this.cam_img = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tim3
            // 
            this.tim3.AutoSize = true;
            this.tim3.Location = new System.Drawing.Point(309, 172);
            this.tim3.Name = "tim3";
            this.tim3.Size = new System.Drawing.Size(0, 13);
            this.tim3.TabIndex = 2;
            // 
            // clock
            // 
            this.clock.BackColor = System.Drawing.Color.White;
            this.clock.Enabled = false;
            this.clock.ForeColor = System.Drawing.Color.Black;
            this.clock.Location = new System.Drawing.Point(329, 383);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(141, 23);
            this.clock.TabIndex = 3;
            this.clock.UseVisualStyleBackColor = false;
            this.clock.Click += new System.EventHandler(this.clock_Click);
            // 
            // cam_img
            // 
            this.cam_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam_img.BackgroundImage")));
            this.cam_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam_img.Image = ((System.Drawing.Image)(resources.GetObject("cam_img.Image")));
            this.cam_img.Location = new System.Drawing.Point(0, 0);
            this.cam_img.Name = "cam_img";
            this.cam_img.Size = new System.Drawing.Size(803, 451);
            this.cam_img.TabIndex = 4;
            this.cam_img.UseVisualStyleBackColor = true;
            this.cam_img.Click += new System.EventHandler(this.cam_img_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(344, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "voltar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cam_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.tim3);
            this.Controls.Add(this.cam_img);
            this.DoubleBuffered = true;
            this.Name = "Cam_1";
            this.Text = "Cam_1";
            this.Load += new System.EventHandler(this.Cam_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tim3;
        private System.Windows.Forms.Button clock;
        private System.Windows.Forms.Button cam_img;
        private System.Windows.Forms.Button button1;
    }
}