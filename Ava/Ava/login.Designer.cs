namespace Ava
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Entrar = new System.Windows.Forms.Button();
            this.ir_cadastro = new System.Windows.Forms.LinkLabel();
            this.ed_conta = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Apelido = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(355, 280);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(77, 23);
            this.Entrar.TabIndex = 11;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // ir_cadastro
            // 
            this.ir_cadastro.AutoSize = true;
            this.ir_cadastro.BackColor = System.Drawing.Color.Yellow;
            this.ir_cadastro.LinkColor = System.Drawing.Color.Black;
            this.ir_cadastro.Location = new System.Drawing.Point(371, 320);
            this.ir_cadastro.Name = "ir_cadastro";
            this.ir_cadastro.Size = new System.Drawing.Size(52, 13);
            this.ir_cadastro.TabIndex = 14;
            this.ir_cadastro.TabStop = true;
            this.ir_cadastro.Text = "Cadastrar";
            this.ir_cadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ir_cadastro_LinkClicked);
            // 
            // ed_conta
            // 
            this.ed_conta.AutoSize = true;
            this.ed_conta.BackColor = System.Drawing.Color.Yellow;
            this.ed_conta.ForeColor = System.Drawing.Color.Black;
            this.ed_conta.LinkColor = System.Drawing.Color.Black;
            this.ed_conta.Location = new System.Drawing.Point(380, 354);
            this.ed_conta.Name = "ed_conta";
            this.ed_conta.Size = new System.Drawing.Size(34, 13);
            this.ed_conta.TabIndex = 15;
            this.ed_conta.TabStop = true;
            this.ed_conta.Text = "conta";
            this.ed_conta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ed_conta_LinkClicked);
            this.ed_conta.MouseLeave += new System.EventHandler(this.ed_conta_MouseLeave);
            this.ed_conta.MouseHover += new System.EventHandler(this.ed_conta_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(342, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Apelido:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Senha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Apelido
            // 
            this.Apelido.Location = new System.Drawing.Point(283, 172);
            this.Apelido.Name = "Apelido";
            this.Apelido.Size = new System.Drawing.Size(235, 20);
            this.Apelido.TabIndex = 22;
            this.Apelido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Apelido.TextChanged += new System.EventHandler(this.Apelido_TextChanged);
            this.Apelido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Apelido_KeyDown);
            this.Apelido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apelido_KeyPress);
            this.Apelido.MouseLeave += new System.EventHandler(this.Apelido_MouseLeave);
            this.Apelido.MouseHover += new System.EventHandler(this.Apelido_MouseHover);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(283, 205);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(235, 20);
            this.Usuario.TabIndex = 23;
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            this.Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Usuario_KeyDown);
            this.Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Usuario_KeyPress);
            this.Usuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Usuario_KeyUp);
            this.Usuario.MouseLeave += new System.EventHandler(this.Usuario_MouseLeave);
            this.Usuario.MouseHover += new System.EventHandler(this.Usuario_MouseHover);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(283, 240);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(235, 20);
            this.Senha.TabIndex = 24;
            this.Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            this.Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Senha_KeyDown);
            this.Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Senha_KeyPress);
            this.Senha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Senha_KeyUp);
            this.Senha.MouseLeave += new System.EventHandler(this.Senha_MouseLeave);
            this.Senha.MouseHover += new System.EventHandler(this.Senha_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Apelido);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ed_conta);
            this.Controls.Add(this.ir_cadastro);
            this.Controls.Add(this.Entrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.LinkLabel ir_cadastro;
        private System.Windows.Forms.LinkLabel ed_conta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Apelido;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Senha;
    }
}