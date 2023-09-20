using Controller;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ava
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao(); //chamando a minha conexão.
            string logar = "SELECT * FROM cadastrar WHERE usuario=@usuario AND senha=@senha";
            MySqlConnection cnx = con.getconexao();
            MySqlCommand cmd = new MySqlCommand(logar, cnx);
            cnx.Open();

            //comparando os dados do banco e do visual
            cmd.Parameters.AddWithValue("@usuario", Usuario.Text);
            cmd.Parameters.AddWithValue("@senha", Senha.Text);


            MySqlDataReader registro = cmd.ExecuteReader(); //executa a consulta.
            LoginModelo us = new LoginModelo(); //chamo a classe usuario modelo

            if (registro.HasRows)
            {
                registro.Read();
                us.usuario = Convert.ToString(registro["usuario"]);
                us.senha = Convert.ToString(registro["senha"]);


                this.Hide();
                menu go_menu = new menu();
                go_menu.ShowDialog();


            }


        }


        private void Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ir_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastrar gocadastrar = new Cadastrar();
            gocadastrar.ShowDialog();
        }

        private void Usuario_MouseHover(object sender, EventArgs e)
        {
            Usuario.Size = new System.Drawing.Size(255, 20);
        }

        private void Usuario_MouseLeave(object sender, EventArgs e)
        {
            Usuario.Size = new System.Drawing.Size(250, 20);
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            Usuario.Size = new System.Drawing.Size(255, 20);
        }

        private void Senha_DragOver(object sender, DragEventArgs e)
        {
            Senha.Size = new System.Drawing.Size(255, 20);
        }

        private void Senha_MouseLeave(object sender, EventArgs e)
        {
            Senha.Size = new System.Drawing.Size(250, 20);
        }

        private void Senha_Click(object sender, EventArgs e)
        {
            Senha.Size = new System.Drawing.Size(255, 20);
        }
    }

}