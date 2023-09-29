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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edicao_cnt));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Procedimento_cb = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Senha_nova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.concluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(192, 302);
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
            this.label2.Location = new System.Drawing.Point(205, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(275, 263);
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
            this.Procedimento_cb.Location = new System.Drawing.Point(339, 337);
            this.Procedimento_cb.Name = "Procedimento_cb";
            this.Procedimento_cb.Size = new System.Drawing.Size(121, 21);
            this.Procedimento_cb.TabIndex = 12;
            this.Procedimento_cb.SelectedIndexChanged += new System.EventHandler(this.Procedimento_cb_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(364, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 72);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Senha_nova
            // 
            this.Senha_nova.Location = new System.Drawing.Point(275, 302);
            this.Senha_nova.Name = "Senha_nova";
            this.Senha_nova.Size = new System.Drawing.Size(250, 20);
            this.Senha_nova.TabIndex = 19;
            this.Senha_nova.Visible = false;
            this.Senha_nova.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuário:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // concluir
            // 
            this.concluir.Location = new System.Drawing.Point(543, 302);
            this.concluir.Name = "concluir";
            this.concluir.Size = new System.Drawing.Size(54, 20);
            this.concluir.TabIndex = 22;
            this.concluir.Text = "concluir";
            this.concluir.UseVisualStyleBackColor = true;
            this.concluir.Visible = false;
            this.concluir.Click += new System.EventHandler(this.concluir_Click);
            // 
            // Edicao_cnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.concluir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Senha_nova);
            this.Controls.Add(this.pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.ComboBox Procedimento_cb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Senha_nova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button concluir;
    }
}