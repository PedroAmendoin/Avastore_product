﻿namespace Ava
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Entrar = new System.Windows.Forms.Button();
            this.Senha = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ir_cadastro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(391, 264);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 11;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(307, 215);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(250, 20);
            this.Senha.TabIndex = 8;
            this.Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Senha.Click += new System.EventHandler(this.Senha_Click);
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            this.Senha.DragOver += new System.Windows.Forms.DragEventHandler(this.Senha_DragOver);
            this.Senha.MouseLeave += new System.EventHandler(this.Senha_MouseLeave);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(307, 163);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(250, 20);
            this.Usuario.TabIndex = 7;
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            this.Usuario.MouseLeave += new System.EventHandler(this.Usuario_MouseLeave);
            this.Usuario.MouseHover += new System.EventHandler(this.Usuario_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuário:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ir_cadastro
            // 
            this.ir_cadastro.AutoSize = true;
            this.ir_cadastro.BackColor = System.Drawing.Color.Yellow;
            this.ir_cadastro.LinkColor = System.Drawing.Color.Black;
            this.ir_cadastro.Location = new System.Drawing.Point(401, 315);
            this.ir_cadastro.Name = "ir_cadastro";
            this.ir_cadastro.Size = new System.Drawing.Size(52, 13);
            this.ir_cadastro.TabIndex = 14;
            this.ir_cadastro.TabStop = true;
            this.ir_cadastro.Text = "Cadastrar";
            this.ir_cadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ir_cadastro_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ir_cadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ir_cadastro;
    }
}