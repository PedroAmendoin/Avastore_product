﻿namespace Ava
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
            this.AVA = new System.Windows.Forms.Button();
            this.AVA_interact = new System.Windows.Forms.PictureBox();
            this.AVA_interactsd = new System.Windows.Forms.PictureBox();
            this.fechar_itns = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.acessar_casa = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.PictureBox();
            this.foco_olhar = new System.Windows.Forms.PictureBox();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AVA_interact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVA_interactsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessar_casa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foco_olhar)).BeginInit();
            this.SuspendLayout();
            // 
            // mic
            // 
            this.mic.Location = new System.Drawing.Point(296, 429);
            this.mic.Name = "mic";
            this.mic.Size = new System.Drawing.Size(201, 34);
            this.mic.TabIndex = 3;
            this.mic.Text = "mic";
            this.mic.UseVisualStyleBackColor = true;
            this.mic.Click += new System.EventHandler(this.mic_Click);
            // 
            // apelido
            // 
            this.apelido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.apelido.AutoSize = true;
            this.apelido.BackColor = System.Drawing.Color.White;
            this.apelido.ForeColor = System.Drawing.Color.Black;
            this.apelido.Location = new System.Drawing.Point(105, 395);
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
            this.perfil.Location = new System.Drawing.Point(91, 362);
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
            this.btConectar.Location = new System.Drawing.Point(296, 471);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(103, 23);
            this.btConectar.TabIndex = 6;
            this.btConectar.Text = "conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            this.btConectar.MouseHover += new System.EventHandler(this.btConectar_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(405, 473);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
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
            this.netflix.Location = new System.Drawing.Point(261, 190);
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
            // AVA
            // 
            this.AVA.Location = new System.Drawing.Point(69, 323);
            this.AVA.Name = "AVA";
            this.AVA.Size = new System.Drawing.Size(75, 23);
            this.AVA.TabIndex = 19;
            this.AVA.Text = "Ava";
            this.AVA.UseVisualStyleBackColor = true;
            this.AVA.Click += new System.EventHandler(this.AVA_Click);
            // 
            // AVA_interact
            // 
            this.AVA_interact.BackColor = System.Drawing.Color.Transparent;
            this.AVA_interact.Image = ((System.Drawing.Image)(resources.GetObject("AVA_interact.Image")));
            this.AVA_interact.Location = new System.Drawing.Point(23, 144);
            this.AVA_interact.Name = "AVA_interact";
            this.AVA_interact.Size = new System.Drawing.Size(163, 154);
            this.AVA_interact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AVA_interact.TabIndex = 21;
            this.AVA_interact.TabStop = false;
            this.AVA_interact.Click += new System.EventHandler(this.AVA_interact_Click);
            this.AVA_interact.MouseHover += new System.EventHandler(this.AVA_interact_MouseHover);
            // 
            // AVA_interactsd
            // 
            this.AVA_interactsd.BackColor = System.Drawing.Color.Transparent;
            this.AVA_interactsd.Image = ((System.Drawing.Image)(resources.GetObject("AVA_interactsd.Image")));
            this.AVA_interactsd.Location = new System.Drawing.Point(23, 144);
            this.AVA_interactsd.Name = "AVA_interactsd";
            this.AVA_interactsd.Size = new System.Drawing.Size(163, 154);
            this.AVA_interactsd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AVA_interactsd.TabIndex = 22;
            this.AVA_interactsd.TabStop = false;
            this.AVA_interactsd.Visible = false;
            this.AVA_interactsd.Click += new System.EventHandler(this.AVA_interactsd_Click);
            // 
            // fechar_itns
            // 
            this.fechar_itns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar_itns.ForeColor = System.Drawing.Color.White;
            this.fechar_itns.Location = new System.Drawing.Point(364, 389);
            this.fechar_itns.Name = "fechar_itns";
            this.fechar_itns.Size = new System.Drawing.Size(58, 23);
            this.fechar_itns.TabIndex = 23;
            this.fechar_itns.Text = "^";
            this.fechar_itns.UseVisualStyleBackColor = true;
            this.fechar_itns.Visible = false;
            this.fechar_itns.Click += new System.EventHandler(this.fechar_itns_Click);
            this.fechar_itns.MouseHover += new System.EventHandler(this.fechar_itns_MouseHover);
            // 
            // toolTip2
            // 
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // toolTip3
            // 
            this.toolTip3.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip3_Popup);
            // 
            // acessar_casa
            // 
            this.acessar_casa.BackColor = System.Drawing.Color.Transparent;
            this.acessar_casa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acessar_casa.BackgroundImage")));
            this.acessar_casa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acessar_casa.Location = new System.Drawing.Point(588, 133);
            this.acessar_casa.Name = "acessar_casa";
            this.acessar_casa.Size = new System.Drawing.Size(17, 169);
            this.acessar_casa.TabIndex = 28;
            this.acessar_casa.TabStop = false;
            this.acessar_casa.Click += new System.EventHandler(this.acessar_casa_Click);
            this.acessar_casa.MouseHover += new System.EventHandler(this.acessar_casa_MouseHover);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.Location = new System.Drawing.Point(192, 133);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(17, 169);
            this.login.TabIndex = 29;
            this.login.TabStop = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.MouseHover += new System.EventHandler(this.login_MouseHover);
            // 
            // foco_olhar
            // 
            this.foco_olhar.BackColor = System.Drawing.Color.Transparent;
            this.foco_olhar.Location = new System.Drawing.Point(261, 104);
            this.foco_olhar.Name = "foco_olhar";
            this.foco_olhar.Size = new System.Drawing.Size(277, 242);
            this.foco_olhar.TabIndex = 31;
            this.foco_olhar.TabStop = false;
            this.foco_olhar.Click += new System.EventHandler(this.foco_olhar_Click);
            this.foco_olhar.MouseLeave += new System.EventHandler(this.foco_olhar_MouseLeave);
            this.foco_olhar.MouseHover += new System.EventHandler(this.foco_olhar_MouseHover);
            // 
            // toolTip4
            // 
            this.toolTip4.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip4_Popup);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.login);
            this.Controls.Add(this.acessar_casa);
            this.Controls.Add(this.fechar_itns);
            this.Controls.Add(this.AVA_interactsd);
            this.Controls.Add(this.AVA_interact);
            this.Controls.Add(this.AVA);
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
            this.Controls.Add(this.foco_olhar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.AVA_interact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVA_interactsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessar_casa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foco_olhar)).EndInit();
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
        private System.Windows.Forms.Button AVA;
        private System.Windows.Forms.PictureBox AVA_interact;
        private System.Windows.Forms.PictureBox AVA_interactsd;
        private System.Windows.Forms.Button fechar_itns;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.PictureBox acessar_casa;
        private System.Windows.Forms.PictureBox login;
        private System.Windows.Forms.PictureBox foco_olhar;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

