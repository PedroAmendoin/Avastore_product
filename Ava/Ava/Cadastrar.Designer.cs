namespace Ava
{
    partial class Cadastrar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.Apelido = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Entrar = new System.Windows.Forms.Button();
            this.codigo_rec = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            this.SuspendLayout();
            // 
            // Apelido
            // 
            this.Apelido.Location = new System.Drawing.Point(281, 158);
            this.Apelido.Name = "Apelido";
            this.Apelido.Size = new System.Drawing.Size(250, 20);
            this.Apelido.TabIndex = 0;
            this.Apelido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Apelido.TextChanged += new System.EventHandler(this.Apelido_TextChanged);
            this.Apelido.MouseHover += new System.EventHandler(this.Apelido_MouseHover);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(281, 216);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(250, 20);
            this.Usuario.TabIndex = 1;
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            this.Usuario.MouseHover += new System.EventHandler(this.Usuario_MouseHover);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(281, 268);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(250, 20);
            this.Senha.TabIndex = 2;
            this.Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            this.Senha.MouseHover += new System.EventHandler(this.Senha_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apelido:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuário:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(364, 344);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 6;
            this.Entrar.Text = "Cadastrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // codigo_rec
            // 
            this.codigo_rec.AutoSize = true;
            this.codigo_rec.Location = new System.Drawing.Point(222, 308);
            this.codigo_rec.Name = "codigo_rec";
            this.codigo_rec.Size = new System.Drawing.Size(42, 13);
            this.codigo_rec.TabIndex = 8;
            this.codigo_rec.Text = "código:";
            this.codigo_rec.Click += new System.EventHandler(this.codigo_rec_Click);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(281, 308);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 20);
            this.Codigo.TabIndex = 9;
            this.Codigo.TextChanged += new System.EventHandler(this.Codigo_TextChanged);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.Location = new System.Drawing.Point(63, 119);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(17, 169);
            this.login.TabIndex = 32;
            this.login.TabStop = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.MouseHover += new System.EventHandler(this.login_MouseHover);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.codigo_rec);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Apelido);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastrar";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Apelido;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label codigo_rec;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.PictureBox login;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}