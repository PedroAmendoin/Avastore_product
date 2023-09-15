namespace Ava
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
            this.mic = new System.Windows.Forms.Button();
            this.quarto = new System.Windows.Forms.Button();
            this.cozinha = new System.Windows.Forms.Button();
            this.sala = new System.Windows.Forms.Button();
            this.banheiro = new System.Windows.Forms.Button();
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
            this.quarto.Location = new System.Drawing.Point(181, 87);
            this.quarto.Name = "quarto";
            this.quarto.Size = new System.Drawing.Size(135, 57);
            this.quarto.TabIndex = 1;
            this.quarto.Text = "quarto";
            this.quarto.UseVisualStyleBackColor = true;
            this.quarto.Click += new System.EventHandler(this.quarto_Click);
            // 
            // cozinha
            // 
            this.cozinha.Location = new System.Drawing.Point(473, 87);
            this.cozinha.Name = "cozinha";
            this.cozinha.Size = new System.Drawing.Size(132, 57);
            this.cozinha.TabIndex = 2;
            this.cozinha.Text = "cozinha";
            this.cozinha.UseVisualStyleBackColor = true;
            this.cozinha.Click += new System.EventHandler(this.cozinha_Click);
            // 
            // sala
            // 
            this.sala.Location = new System.Drawing.Point(473, 244);
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(132, 55);
            this.sala.TabIndex = 3;
            this.sala.Text = "sala de estar";
            this.sala.UseVisualStyleBackColor = true;
            this.sala.Click += new System.EventHandler(this.sala_Click);
            // 
            // banheiro
            // 
            this.banheiro.Location = new System.Drawing.Point(181, 244);
            this.banheiro.Name = "banheiro";
            this.banheiro.Size = new System.Drawing.Size(135, 55);
            this.banheiro.TabIndex = 4;
            this.banheiro.Text = "banheiro";
            this.banheiro.UseVisualStyleBackColor = true;
            this.banheiro.Click += new System.EventHandler(this.banheiro_Click);
            // 
            // cômodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.banheiro);
            this.Controls.Add(this.sala);
            this.Controls.Add(this.cozinha);
            this.Controls.Add(this.quarto);
            this.Controls.Add(this.mic);
            this.Name = "cômodo";
            this.Text = "cômodo";
            this.Load += new System.EventHandler(this.cômodo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mic;
        private System.Windows.Forms.Button quarto;
        private System.Windows.Forms.Button cozinha;
        private System.Windows.Forms.Button sala;
        private System.Windows.Forms.Button banheiro;
    }
}