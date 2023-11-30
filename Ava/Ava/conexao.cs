using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controller
{
    public class conexao
    {
        //atributos de conexão
        static private string servidor = "localhost";
        static private string bd = "ava";
        static private string usuario = "root";
        static private string senhabd = "";
        public MySqlConnection conn = null;

        static private string caminho_cnx = "server= " + servidor + ";database= " + bd + ";user id =" + usuario + ";password= " + senhabd;

        public MySqlConnection getconexao()
        {
            //atribui conexão a uma nova conexão mysql com o caminho acima
            MySqlConnection conexao = new MySqlConnection(caminho_cnx);
            return conexao; //retorna o valor da conexão
        }

    }
}
