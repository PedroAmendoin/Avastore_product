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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                
                
                this.Visible = false;
                menu go_menu = new menu();
                go_menu.ShowDialog();
                this.Visible = true;

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
           this.Visible = false;
            Cadastrar gocadastrar = new Cadastrar();
            gocadastrar.ShowDialog();
            this.Visible = true;
            
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

        private void ed_conta_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ed_conta, "recuperar/alterar senha/excluir conta");
        }

        private void ed_conta_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ed_conta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }

}