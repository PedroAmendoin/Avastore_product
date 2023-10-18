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
            this.twitch = new System.Windows.Forms.Button();
            this.youtube = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.spotfy = new System.Windows.Forms.Button();
            this.netflix = new System.Windows.Forms.Button();
            this.instagram = new System.Windows.Forms.Button();
            this.facebook = new System.Windows.Forms.Button();
            this.crunchyroll = new System.Windows.Forms.Button();
            this.whatsapp = new System.Windows.Forms.Button();
            this.google = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // twitch
            // 
            this.twitch.BackColor = System.Drawing.Color.Transparent;
            this.twitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("twitch.BackgroundImage")));
            this.twitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.twitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twitch.Location = new System.Drawing.Point(364, 104);
            this.twitch.Name = "twitch";
            this.twitch.Size = new System.Drawing.Size(61, 54);
            this.twitch.TabIndex = 1;
            this.twitch.UseVisualStyleBackColor = false;
            this.twitch.Visible = false;
            this.twitch.Click += new System.EventHandler(this.twitch_Click);
            // 
            // youtube
            // 
            this.youtube.BackColor = System.Drawing.Color.Transparent;
            this.youtube.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("youtube.BackgroundImage")));
            this.youtube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youtube.Location = new System.Drawing.Point(289, 259);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(58, 54);
            this.youtube.TabIndex = 0;
            this.youtube.UseVisualStyleBackColor = false;
            this.youtube.Visible = false;
            this.youtube.Click += new System.EventHandler(this.youtube_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.BackColor = System.Drawing.Color.White;
            this.pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pesquisar.BackgroundImage")));
            this.pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisar.Location = new System.Drawing.Point(364, 190);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(58, 54);
            this.pesquisar.TabIndex = 12;
            this.pesquisar.UseVisualStyleBackColor = false;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            this.pesquisar.MouseHover += new System.EventHandler(this.pesquisar_MouseHover);
            // 
            // spotfy
            // 
            this.spotfy.BackColor = System.Drawing.Color.Transparent;
            this.spotfy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spotfy.BackgroundImage")));
            this.spotfy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spotfy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spotfy.Location = new System.Drawing.Point(436, 259);
            this.spotfy.Name = "spotfy";
            this.spotfy.Size = new System.Drawing.Size(61, 55);
            this.spotfy.TabIndex = 0;
            this.spotfy.UseVisualStyleBackColor = false;
            this.spotfy.Visible = false;
            this.spotfy.Click += new System.EventHandler(this.spotfy_Click);
            // 
            // netflix
            // 
            this.netflix.BackColor = System.Drawing.Color.Transparent;
            this.netflix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("netflix.BackgroundImage")));
            this.netflix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.netflix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.netflix.Location = new System.Drawing.Point(257, 190);
            this.netflix.Name = "netflix";
            this.netflix.Size = new System.Drawing.Size(58, 54);
            this.netflix.TabIndex = 2;
            this.netflix.UseVisualStyleBackColor = false;
            this.netflix.Visible = false;
            this.netflix.Click += new System.EventHandler(this.netflix_Click);
            // 
            // instagram
            // 
            this.instagram.BackColor = System.Drawing.Color.Transparent;
            this.instagram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("instagram.BackgroundImage")));
            this.instagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.instagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instagram.Location = new System.Drawing.Point(296, 130);
            this.instagram.Name = "instagram";
            this.instagram.Size = new System.Drawing.Size(61, 54);
            this.instagram.TabIndex = 13;
            this.instagram.UseVisualStyleBackColor = false;
            this.instagram.Visible = false;
            this.instagram.Click += new System.EventHandler(this.instagram_Click);
            // 
            // facebook
            // 
            this.facebook.BackColor = System.Drawing.Color.Transparent;
            this.facebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("facebook.BackgroundImage")));
            this.facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facebook.Location = new System.Drawing.Point(436, 130);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(61, 54);
            this.facebook.TabIndex = 14;
            this.facebook.UseVisualStyleBackColor = false;
            this.facebook.Visible = false;
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // crunchyroll
            // 
            this.crunchyroll.BackColor = System.Drawing.Color.Transparent;
            this.crunchyroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crunchyroll.BackgroundImage")));
            this.crunchyroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crunchyroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crunchyroll.Location = new System.Drawing.Point(364, 292);
            this.crunchyroll.Name = "crunchyroll";
            this.crunchyroll.Size = new System.Drawing.Size(61, 54);
            this.crunchyroll.TabIndex = 15;
            this.crunchyroll.UseVisualStyleBackColor = false;
            this.crunchyroll.Visible = false;
            this.crunchyroll.Click += new System.EventHandler(this.crunchyroll_Click);
            // 
            // whatsapp
            // 
            this.whatsapp.BackColor = System.Drawing.Color.Transparent;
            this.whatsapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("whatsapp.BackgroundImage")));
            this.whatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whatsapp.Location = new System.Drawing.Point(480, 199);
            this.whatsapp.Name = "whatsapp";
            this.whatsapp.Size = new System.Drawing.Size(58, 54);
            this.whatsapp.TabIndex = 16;
            this.whatsapp.UseVisualStyleBackColor = false;
            this.whatsapp.Visible = false;
            this.whatsapp.Click += new System.EventHandler(this.whatsapp_Click);
            // 
            // google
            // 
            this.google.BackColor = System.Drawing.Color.Transparent;
            this.google.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("google.BackgroundImage")));
            this.google.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.google.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.google.Location = new System.Drawing.Point(364, 232);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(58, 54);
            this.google.TabIndex = 17;
            this.google.UseVisualStyleBackColor = false;
            this.google.Visible = false;
            this.google.Click += new System.EventHandler(this.google_Click);
            this.google.MouseLeave += new System.EventHandler(this.google_MouseLeave);
            this.google.MouseHover += new System.EventHandler(this.google_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(162, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(471, 389);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.google);
            this.Controls.Add(this.whatsapp);
            this.Controls.Add(this.crunchyroll);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.instagram);
            this.Controls.Add(this.netflix);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.spotfy);
            this.Controls.Add(this.youtube);
            this.Controls.Add(this.twitch);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.apelido);
            this.Controls.Add(this.mic);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load_1);
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
        private System.Windows.Forms.Button twitch;
        private System.Windows.Forms.Button youtube;
        private System.Windows.Forms.Button spotfy;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button netflix;
        private System.Windows.Forms.Button instagram;
        private System.Windows.Forms.Button facebook;
        private System.Windows.Forms.Button crunchyroll;
        private System.Windows.Forms.Button whatsapp;
        private System.Windows.Forms.Button google;
        private System.Windows.Forms.Button button1;
    }
}

