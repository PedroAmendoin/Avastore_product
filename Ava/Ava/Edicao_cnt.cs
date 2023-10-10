using Controller;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Ava
{
    public partial class Edicao_cnt : Form
    {
        public Edicao_cnt()
        {
            InitializeComponent();
        }

        private void Edicao_cnt_Load(object sender, EventArgs e)
        {

        }

        private void Procedimento_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexao conexao = new conexao();

            if (Procedimento_cb.Text == "Excluir")
            {
                if (Usuario.Text != null && Senha.Text != null)
                {

                    string logar = "SELECT * FROM cadastrar WHERE usuario=@usuario AND senha=@senha";
                    MySqlConnection cnx = conexao.getconexao();

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

                        MySqlConnection cn = conexao.getconexao();
                        string sql = "DELETE FROM cadastrar WHERE usuario=@usuario AND senha=@senha";
                        cn.Open();
                        MySqlCommand cmd1 = new MySqlCommand(sql, cn);
                        cmd1.Parameters.AddWithValue("@usuario", us.usuario);
                        cmd1.Parameters.AddWithValue("@senha", us.senha);
                        cmd1.ExecuteNonQuery();

                        this.Visible = false;
                        Login go_login = new Login();
                        go_login.ShowDialog();
                        Usuario.Text = null;//esvaziando textbox do usuario
                        Senha.Text = null;//esvaziando textbox da senha
                        this.Visible = true;

                    }
                }
            }

            if (Procedimento_cb.Text == "Alterar senha")
            {
                label3.Visible = true;
                Senha_nova.Visible = true;
                concluir.Visible = true;

            }
            else
            {
                label3.Visible = false;
                Senha_nova.Visible = false;
                concluir.Visible = false;
            }

            if (Procedimento_cb.Text == "Recuperar senha")
            {
                label2.Visible = false;
                Senha.Visible = false;
                Codigo.Visible = true;
                Enviar.Visible = true;

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

        private void label4_Click(object sender, EventArgs e)
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

        private void Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void concluir_Click(object sender, EventArgs e)
        {

           

            if (Senha_nova.Text != null)
            { 
                conexao conexao2 = new conexao();
                string editar = "SELECT * FROM cadastrar WHERE usuario=@usuario AND senha=@senha";
                MySqlConnection cnx = conexao2.getconexao();

                MySqlCommand cmd = new MySqlCommand(editar, cnx);
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

                    MySqlConnection cn = conexao2.getconexao();

                    us.senha = Senha_nova.Text; //alterando o valor da senha para a da caixa de texto da nova senha
                    string sql = "SELECT * FROM `cadastrar` WHERE usuario = '"+us.usuario+"'; UPDATE `cadastrar` SET senha = '"+us.senha+"' WHERE usuario = '"+us.usuario+"';";
                    cn.Open();
                    MySqlCommand cmd2 = new MySqlCommand(sql, cn);
                    cmd2.ExecuteNonQuery();

                    this.Close();
                }

            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            conexao conexao3 = new conexao();
            string logar = "SELECT * FROM cadastrar WHERE usuario=@usuario AND codigo=@codigo";
            MySqlConnection cnx = conexao3.getconexao();

            MySqlCommand cmd = new MySqlCommand(logar, cnx);
            cnx.Open();

            //comparando os dados do banco e do visual
            cmd.Parameters.AddWithValue("@usuario", Usuario.Text);
            cmd.Parameters.AddWithValue("@codigo", Codigo.Text);


            MySqlDataReader registro = cmd.ExecuteReader(); //executa a consulta.
            LoginModelo us = new LoginModelo(); //chamo a classe usuario modelo

            if (registro.HasRows)
            {
                registro.Read();
                us.usuario = Convert.ToString(registro["usuario"]);
                us.codigo = Convert.ToString(registro["codigo"]);

                MySqlConnection cn = conexao3.getconexao();
                string sql = "SELECT senha FROM cadastrar WHERE codigo='321'";
                cn.Open();
                MySqlCommand cmd1 = new MySqlCommand(sql, cn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show(" "+ (registro["senha"]) +" ");
                this.Visible = false;
                Login go_login = new Login();
                go_login.ShowDialog();
                Usuario.Text = null;//esvaziando textbox do usuario
                Senha.Text = null;//esvaziando textbox da senha
                this.Visible = true;

            }
        }
    }
    }

