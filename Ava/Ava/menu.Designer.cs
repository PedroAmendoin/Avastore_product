namespace Ava
{
    partial class menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mic = new System.Windows.Forms.Button();
            this.apelido = new System.Windows.Forms.Label();
            this.perfil = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mic
            // 
            this.mic.Location = new System.Drawing.Point(296, 440);
            this.mic.Name = "mic";
            this.mic.Size = new System.Drawing.Size(201, 34);
            this.mic.TabIndex = 3;
            this.mic.Text = "mic";
            this.mic.UseVisualStyleBackColor = true;
            this.mic.Click += new System.EventHandler(this.mic_Click);
            // 
            // apelido
            // 
            this.apelido.AutoSize = true;
            this.apelido.BackColor = System.Drawing.Color.White;
            this.apelido.ForeColor = System.Drawing.Color.Black;
            this.apelido.Location = new System.Drawing.Point(595, 449);
            this.apelido.Name = "apelido";
            this.apelido.Size = new System.Drawing.Size(0, 13);
            this.apelido.TabIndex = 4;
            this.apelido.Visible = false;
            this.apelido.Click += new System.EventHandler(this.apelido_Click);
            // 
            // perfil
            // 
            this.perfil.BackColor = System.Drawing.Color.Black;
            this.perfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("perfil.BackgroundImage")));
            this.perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perfil.Location = new System.Drawing.Point(557, 440);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(32, 30);
            this.perfil.TabIndex = 5;
            this.perfil.UseVisualStyleBackColor = false;
            this.perfil.Click += new System.EventHandler(this.perfil_Click);
            this.perfil.MouseLeave += new System.EventHandler(this.perfil_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(114, 446);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(61, 23);
            this.btConectar.TabIndex = 6;
            this.btConectar.Text = "conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            this.btConectar.MouseHover += new System.EventHandler(this.btConectar_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 446);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.apelido);
            this.Controls.Add(this.mic);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mic;
        private System.Windows.Forms.Label apelido;
        private System.Windows.Forms.Button perfil;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort;
    }
}

