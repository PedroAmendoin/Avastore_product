﻿namespace Ava
{
    partial class casa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(casa));
            this.mic = new System.Windows.Forms.Button();
            this.quarto = new System.Windows.Forms.Button();
            this.cozinha = new System.Windows.Forms.Button();
            this.sala = new System.Windows.Forms.Button();
            this.banheiro = new System.Windows.Forms.Button();
            this.temp_quarto = new System.Windows.Forms.Button();
            this.temp_cozinha = new System.Windows.Forms.Button();
            this.temp_sala = new System.Windows.Forms.Button();
            this.temp_banheiro = new System.Windows.Forms.Button();
            this.cam_se = new System.Windows.Forms.Button();
            this.ajuda = new System.Windows.Forms.PictureBox();
            this.comandos = new System.Windows.Forms.ComboBox();
            this.descricao = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.fechar_itns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ajuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.SuspendLayout();
            // 
            // mic
            // 
            this.mic.Location = new System.Drawing.Point(362, 167);
            this.mic.Name = "mic";
            this.mic.Size = new System.Drawing.Size(75, 23);
            this.mic.TabIndex = 0;
            this.mic.Text = "mic";
            this.mic.UseVisualStyleBackColor = true;
            this.mic.Click += new System.EventHandler(this.mic_Click);
            // 
            // quarto
            // 
            this.quarto.BackColor = System.Drawing.Color.Gainsboro;
            this.quarto.Location = new System.Drawing.Point(181, 87);
            this.quarto.Name = "quarto";
            this.quarto.Size = new System.Drawing.Size(135, 57);
            this.quarto.TabIndex = 1;
            this.quarto.Text = "quarto";
            this.quarto.UseVisualStyleBackColor = false;
            this.quarto.Click += new System.EventHandler(this.quarto_Click);
            // 
            // cozinha
            // 
            this.cozinha.BackColor = System.Drawing.Color.Gainsboro;
            this.cozinha.Location = new System.Drawing.Point(473, 87);
            this.cozinha.Name = "cozinha";
            this.cozinha.Size = new System.Drawing.Size(132, 57);
            this.cozinha.TabIndex = 2;
            this.cozinha.Text = "cozinha";
            this.cozinha.UseVisualStyleBackColor = false;
            this.cozinha.Click += new System.EventHandler(this.cozinha_Click);
            // 
            // sala
            // 
            this.sala.BackColor = System.Drawing.Color.Gainsboro;
            this.sala.Location = new System.Drawing.Point(473, 244);
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(132, 55);
            this.sala.TabIndex = 3;
            this.sala.Text = "sala de estar";
            this.sala.UseVisualStyleBackColor = false;
            this.sala.Click += new System.EventHandler(this.sala_Click);
            // 
            // banheiro
            // 
            this.banheiro.BackColor = System.Drawing.Color.Gainsboro;
            this.banheiro.Location = new System.Drawing.Point(181, 244);
            this.banheiro.Name = "banheiro";
            this.banheiro.Size = new System.Drawing.Size(135, 55);
            this.banheiro.TabIndex = 4;
            this.banheiro.Text = "banheiro";
            this.banheiro.UseVisualStyleBackColor = false;
            this.banheiro.Click += new System.EventHandler(this.banheiro_Click);
            // 
            // temp_quarto
            // 
            this.temp_quarto.BackColor = System.Drawing.Color.White;
            this.temp_quarto.ForeColor = System.Drawing.Color.Black;
            this.temp_quarto.Location = new System.Drawing.Point(100, 87);
            this.temp_quarto.Name = "temp_quarto";
            this.temp_quarto.Size = new System.Drawing.Size(75, 23);
            this.temp_quarto.TabIndex = 5;
            this.temp_quarto.UseVisualStyleBackColor = false;
            this.temp_quarto.Visible = false;
            this.temp_quarto.Click += new System.EventHandler(this.temp_quarto_Click);
            // 
            // temp_cozinha
            // 
            this.temp_cozinha.BackColor = System.Drawing.Color.White;
            this.temp_cozinha.Enabled = false;
            this.temp_cozinha.ForeColor = System.Drawing.Color.Black;
            this.temp_cozinha.Location = new System.Drawing.Point(612, 87);
            this.temp_cozinha.Name = "temp_cozinha";
            this.temp_cozinha.Size = new System.Drawing.Size(75, 23);
            this.temp_cozinha.TabIndex = 6;
            this.temp_cozinha.UseVisualStyleBackColor = false;
            this.temp_cozinha.Visible = false;
            this.temp_cozinha.Click += new System.EventHandler(this.temp_cozinha_Click);
            // 
            // temp_sala
            // 
            this.temp_sala.BackColor = System.Drawing.Color.White;
            this.temp_sala.Enabled = false;
            this.temp_sala.ForeColor = System.Drawing.Color.Black;
            this.temp_sala.Location = new System.Drawing.Point(612, 275);
            this.temp_sala.Name = "temp_sala";
            this.temp_sala.Size = new System.Drawing.Size(75, 23);
            this.temp_sala.TabIndex = 7;
            this.temp_sala.UseVisualStyleBackColor = false;
            this.temp_sala.Visible = false;
            this.temp_sala.Click += new System.EventHandler(this.temp_sala_Click);
            // 
            // temp_banheiro
            // 
            this.temp_banheiro.BackColor = System.Drawing.Color.White;
            this.temp_banheiro.ForeColor = System.Drawing.Color.Black;
            this.temp_banheiro.Location = new System.Drawing.Point(100, 275);
            this.temp_banheiro.Name = "temp_banheiro";
            this.temp_banheiro.Size = new System.Drawing.Size(75, 23);
            this.temp_banheiro.TabIndex = 8;
            this.temp_banheiro.UseVisualStyleBackColor = false;
            this.temp_banheiro.Visible = false;
            this.temp_banheiro.Click += new System.EventHandler(this.temp_banheiro_Click);
            // 
            // cam_se
            // 
            this.cam_se.BackColor = System.Drawing.Color.White;
            this.cam_se.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam_se.BackgroundImage")));
            this.cam_se.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam_se.Location = new System.Drawing.Point(636, 244);
            this.cam_se.Name = "cam_se";
            this.cam_se.Size = new System.Drawing.Size(28, 28);
            this.cam_se.TabIndex = 9;
            this.cam_se.UseVisualStyleBackColor = false;
            this.cam_se.Click += new System.EventHandler(this.cam_se_Click);
            // 
            // ajuda
            // 
            this.ajuda.BackColor = System.Drawing.Color.Transparent;
            this.ajuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajuda.BackgroundImage")));
            this.ajuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajuda.Location = new System.Drawing.Point(362, 207);
            this.ajuda.Name = "ajuda";
            this.ajuda.Size = new System.Drawing.Size(75, 65);
            this.ajuda.TabIndex = 10;
            this.ajuda.TabStop = false;
            this.ajuda.Click += new System.EventHandler(this.ajuda_Click);
            // 
            // comandos
            // 
            this.comandos.FormattingEnabled = true;
            this.comandos.Items.AddRange(new object[] {
            "\"acender luz do quarto/banheiro\"",
            "\"apagar luz do quarto/banheiro\"",
            "\"temperatura do quarto/banheiro\"",
            "\"fechar temperatura do quarto/banheiro\"",
            "",
            "\"acender luz da cozinha/sala\"",
            "\"apagar luz da cozinha/sala\"",
            "\"temperatura da cozinha/sala\"",
            "\"fechar temperatura da cozinha/sala\",",
            "",
            "\"mídia\"",
            "\"câmera\""});
            this.comandos.Location = new System.Drawing.Point(294, 330);
            this.comandos.Name = "comandos";
            this.comandos.Size = new System.Drawing.Size(203, 21);
            this.comandos.TabIndex = 11;
            this.comandos.Visible = false;
            this.comandos.SelectedIndexChanged += new System.EventHandler(this.comandos_SelectedIndexChanged);
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(346, 305);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(94, 13);
            this.descricao.TabIndex = 12;
            this.descricao.Text = "comandos de voz:";
            this.descricao.Visible = false;
            this.descricao.Click += new System.EventHandler(this.descricao_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Location = new System.Drawing.Point(45, 103);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(17, 169);
            this.menu.TabIndex = 30;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // fechar_itns
            // 
            this.fechar_itns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar_itns.ForeColor = System.Drawing.Color.Black;
            this.fechar_itns.Location = new System.Drawing.Point(379, 368);
            this.fechar_itns.Name = "fechar_itns";
            this.fechar_itns.Size = new System.Drawing.Size(43, 23);
            this.fechar_itns.TabIndex = 31;
            this.fechar_itns.Text = "^";
            this.fechar_itns.UseVisualStyleBackColor = true;
            this.fechar_itns.Visible = false;
            this.fechar_itns.Click += new System.EventHandler(this.fechar_itns_Click);
            // 
            // casa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fechar_itns);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.comandos);
            this.Controls.Add(this.ajuda);
            this.Controls.Add(this.cam_se);
            this.Controls.Add(this.temp_banheiro);
            this.Controls.Add(this.temp_sala);
            this.Controls.Add(this.temp_cozinha);
            this.Controls.Add(this.temp_quarto);
            this.Controls.Add(this.banheiro);
            this.Controls.Add(this.sala);
            this.Controls.Add(this.cozinha);
            this.Controls.Add(this.quarto);
            this.Controls.Add(this.mic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "casa";
            this.Text = "cômodo";
            this.Load += new System.EventHandler(this.cômodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mic;
        private System.Windows.Forms.Button quarto;
        private System.Windows.Forms.Button cozinha;
        private System.Windows.Forms.Button sala;
        private System.Windows.Forms.Button banheiro;
        private System.Windows.Forms.Button temp_quarto;
        private System.Windows.Forms.Button temp_cozinha;
        private System.Windows.Forms.Button temp_sala;
        private System.Windows.Forms.Button temp_banheiro;
        private System.Windows.Forms.Button cam_se;
        private System.Windows.Forms.PictureBox ajuda;
        private System.Windows.Forms.ComboBox comandos;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Button fechar_itns;
    }
}