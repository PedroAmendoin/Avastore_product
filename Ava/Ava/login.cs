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

       

        private void Entrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao(); //chamando a minha conexão.
            string logar = "SELECT * FROM cadastrar WHERE usuario=@usuario AND senha=@senha AND apelido=@apelido";
            MySqlConnection cnx = con.getconexao();
            MySqlCommand cmd = new MySqlCommand(logar, cnx);
            cnx.Open();

            //comparando os dados do banco e do visual
            cmd.Parameters.AddWithValue("@apelido", Apelido.Text);
            cmd.Parameters.AddWithValue("@usuario", Usuario.Text);
            cmd.Parameters.AddWithValue("@senha", Senha.Text);


            MySqlDataReader registro = cmd.ExecuteReader(); //executa a consulta.
            LoginModelo us = new LoginModelo(); //chamo a classe usuario modelo

            if (registro.HasRows)
            {
                registro.Read();
                us.apelido = Convert.ToString(registro["apelido"]);
                us.usuario = Convert.ToString(registro["usuario"]);
                us.senha = Convert.ToString(registro["senha"]);
               
                
                
                this.Visible = false;
                menu go_menu = new menu(us);
                go_menu.ShowDialog();
                Apelido.Text = null;
                Usuario.Text = null;//esvaziando textbox do usuario
                Senha.Text = null;//esvaziando textbox da senha
                this.Visible = true;

            }


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

        private void Apelido_MouseHover(object sender, EventArgs e)
        {
            Apelido.Size = new System.Drawing.Size(255, 20);
        }

        private void Apelido_MouseLeave(object sender, EventArgs e)
        {
            Apelido.Size = new System.Drawing.Size(250, 20);
        }

        private void Apelido_Click(object sender, EventArgs e)
        {
            Apelido.Size = new System.Drawing.Size(255, 20);
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
            Edicao_cnt goedicao = new Edicao_cnt();
            goedicao.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Apelido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tecla enter
            if (e.KeyChar == 13)
            {
                Senha.Focus();
            }
        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tecla enter
            if (e.KeyChar == 13)
            {
                Senha.Focus();
            }

        }

        private void Senha_KeyPress(object sender, KeyPressEventArgs e)
        { 

                //tecla enter
                if (e.KeyChar == 13)
                {
                    //sua rotina aqui
                    Entrar.Focus();

                    e.Handled = true;

                }
            }


        private void Apelido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Usuario.Focus();
            }
        }

        //receber seta para cima
        private void Usuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Apelido.Focus();
            }
        }

        //receber seta para baixo
        private void Usuario_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Down)
            {
               Senha.Focus(); 
            }
            
        }

        //receber seta para cima
        private void Senha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Usuario.Focus();
            }
           
        }

        private void Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                Entrar.Focus();
            }
        }

        private void Entrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Senha.Focus();
            }
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

        private void fundologo_Click(object sender, EventArgs e)
        {

        }
    }

}