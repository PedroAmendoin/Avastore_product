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
                        string sql = "DELETE FROM cadastrar WHERE id_usuario =2 ";
                        cn.Open();
                        MySqlCommand cmd1 = new MySqlCommand(sql, cn);
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
    }
}
