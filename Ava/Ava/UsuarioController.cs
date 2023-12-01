using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{


    public class UsuarioController
    {

        conexao con = new conexao();

        public bool cadastrar(LoginModelo usuario)
        {
            bool resultado = false;
            string sql = "insert into Cadastro(apelido,usuario,senha,codigo)" + "values('" + usuario.apelido + "','" + usuario.usuario + "','" + usuario.senha + "','" + usuario.codigo +"')";
            MySqlConnection sqlCon = con.getconexao();
            sqlCon.Open();
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)
            { //executar o seu sql
                resultado = true;
            }


            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor

        }

    }
}

