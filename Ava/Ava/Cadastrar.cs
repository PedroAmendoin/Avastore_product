using Controller;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ava
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Apelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (!Apelido.Text.Equals(null) && !Usuario.Text.Equals(null) && !Senha.Text.Equals(null))
            {

                LoginModelo gravadado = new LoginModelo();
                gravadado.apelido = Apelido.Text;
                gravadado.usuario = Usuario.Text;
                gravadado.senha = Senha.Text;
                



                UsuarioController uscontrole = new UsuarioController();

                if (gravadado.apelido != "" && gravadado.usuario != "" && gravadado.senha != "")
                {
                    if (uscontrole.cadastrar(gravadado) == true)
                    {
                        MessageBox.Show("Usuário" + Usuario.Text + "cadastrado com sucesso");

                        //para a próxima tela
                        this.Hide();
                        menu gomenu = new menu();
                        DialogResult = gomenu.ShowDialog();
                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("Campos estão vazios");
                    }
                }

            }
            else
            {
                MessageBox.Show("escolha um usuário válido");
            }
           
        }

        private void Apelido_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Usuario_MouseHover(object sender, EventArgs e)
        {

        }

        private void Senha_MouseHover(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {

            this.Close();
            
           
        }
    }
}
