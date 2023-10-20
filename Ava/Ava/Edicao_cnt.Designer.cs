namespace Ava
{
    partial class Edicao_cnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edicao_cnt));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Procedimento_cb = new System.Windows.Forms.ComboBox();
            this.Senha_nova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.concluir = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Enviar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(192, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha nova:";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(275, 256);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(250, 20);
            this.Senha.TabIndex = 8;
            this.Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(275, 215);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(250, 20);
            this.Usuario.TabIndex = 7;
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // Procedimento_cb
            // 
            this.Procedimento_cb.FormattingEnabled = true;
            this.Procedimento_cb.Items.AddRange(new object[] {
            "Excluir",
            "Alterar senha",
            "Recuperar senha"});
            this.Procedimento_cb.Location = new System.Drawing.Point(337, 360);
            this.Procedimento_cb.Name = "Procedimento_cb";
            this.Procedimento_cb.Size = new System.Drawing.Size(121, 21);
            this.Procedimento_cb.TabIndex = 12;
            this.Procedimento_cb.SelectedIndexChanged += new System.EventHandler(this.Procedimento_cb_SelectedIndexChanged);
            // 
            // Senha_nova
            // 
            this.Senha_nova.Location = new System.Drawing.Point(275, 295);
            this.Senha_nova.Name = "Senha_nova";
            this.Senha_nova.Size = new System.Drawing.Size(250, 20);
            this.Senha_nova.TabIndex = 19;
            this.Senha_nova.Visible = false;
            this.Senha_nova.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuário:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // concluir
            // 
            this.concluir.Location = new System.Drawing.Point(541, 295);
            this.concluir.Name = "concluir";
            this.concluir.Size = new System.Drawing.Size(54, 20);
            this.concluir.TabIndex = 22;
            this.concluir.Text = "concluir";
            this.concluir.UseVisualStyleBackColor = true;
            this.concluir.Visible = false;
            this.concluir.Click += new System.EventHandler(this.concluir_Click);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(275, 329);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(250, 20);
            this.Codigo.TabIndex = 23;
            this.Codigo.Visible = false;
            this.Codigo.TextChanged += new System.EventHandler(this.Codigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Código:";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(541, 329);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(54, 23);
            this.Enviar.TabIndex = 25;
            this.Enviar.Text = "enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Visible = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.Location = new System.Drawing.Point(45, 105);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(17, 169);
            this.login.TabIndex = 31;
            this.login.TabStop = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.MouseHover += new System.EventHandler(this.login_MouseHover);
            // 
            // Edicao_cnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.concluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Senha_nova);
            this.Controls.Add(this.Procedimento_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edicao_cnt";
            this.Text = "Edicao_cnt";
            this.Load += new System.EventHandler(this.Edicao_cnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.ComboBox Procedimento_cb;
        private System.Windows.Forms.TextBox Senha_nova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button concluir;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox login;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}