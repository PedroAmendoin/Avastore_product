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
            this.mic = new System.Windows.Forms.Button();
            this.apelido = new System.Windows.Forms.Label();
            this.perfil = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yt = new System.Windows.Forms.Button();
            this.tw = new System.Windows.Forms.Button();
            this.ntf = new System.Windows.Forms.Button();
            this.spot = new System.Windows.Forms.Button();
            this.ytb = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(114, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 101);
            this.button1.TabIndex = 8;
            this.button1.Text = "Assistir algo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(460, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 101);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ouvir um som";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ntf);
            this.panel1.Controls.Add(this.tw);
            this.panel1.Controls.Add(this.yt);
            this.panel1.Location = new System.Drawing.Point(114, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 60);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pesquisar);
            this.panel2.Controls.Add(this.ytb);
            this.panel2.Controls.Add(this.spot);
            this.panel2.Location = new System.Drawing.Point(460, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 61);
            this.panel2.TabIndex = 11;
            // 
            // yt
            // 
            this.yt.BackColor = System.Drawing.Color.White;
            this.yt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yt.BackgroundImage")));
            this.yt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yt.Location = new System.Drawing.Point(3, 3);
            this.yt.Name = "yt";
            this.yt.Size = new System.Drawing.Size(58, 54);
            this.yt.TabIndex = 0;
            this.yt.UseVisualStyleBackColor = false;
            // 
            // tw
            // 
            this.tw.BackColor = System.Drawing.Color.Black;
            this.tw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tw.BackgroundImage")));
            this.tw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tw.Location = new System.Drawing.Point(80, 3);
            this.tw.Name = "tw";
            this.tw.Size = new System.Drawing.Size(61, 54);
            this.tw.TabIndex = 1;
            this.tw.UseVisualStyleBackColor = false;
            // 
            // ntf
            // 
            this.ntf.BackColor = System.Drawing.Color.Transparent;
            this.ntf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ntf.BackgroundImage")));
            this.ntf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ntf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ntf.Location = new System.Drawing.Point(161, 3);
            this.ntf.Name = "ntf";
            this.ntf.Size = new System.Drawing.Size(58, 54);
            this.ntf.TabIndex = 2;
            this.ntf.UseVisualStyleBackColor = false;
            // 
            // spot
            // 
            this.spot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spot.BackgroundImage")));
            this.spot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spot.Location = new System.Drawing.Point(151, 2);
            this.spot.Name = "spot";
            this.spot.Size = new System.Drawing.Size(66, 54);
            this.spot.TabIndex = 0;
            this.spot.UseVisualStyleBackColor = true;
            // 
            // ytb
            // 
            this.ytb.BackColor = System.Drawing.Color.White;
            this.ytb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ytb.BackgroundImage")));
            this.ytb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ytb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ytb.Location = new System.Drawing.Point(3, 4);
            this.ytb.Name = "ytb";
            this.ytb.Size = new System.Drawing.Size(58, 54);
            this.ytb.TabIndex = 3;
            this.ytb.UseVisualStyleBackColor = false;
            // 
            // pesquisar
            // 
            this.pesquisar.BackColor = System.Drawing.Color.White;
            this.pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pesquisar.BackgroundImage")));
            this.pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisar.Location = new System.Drawing.Point(77, 4);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(58, 54);
            this.pesquisar.TabIndex = 12;
            this.pesquisar.UseVisualStyleBackColor = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(286, 52);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(226, 23);
            this.titulo.TabIndex = 12;
            this.titulo.Text = "Menu";
            this.titulo.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.apelido);
            this.Controls.Add(this.mic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mic;
        private System.Windows.Forms.Label apelido;
        private System.Windows.Forms.Button perfil;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ntf;
        private System.Windows.Forms.Button tw;
        private System.Windows.Forms.Button yt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button spot;
        private System.Windows.Forms.Button ytb;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button titulo;
    }
}

