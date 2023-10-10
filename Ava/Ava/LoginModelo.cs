using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LoginModelo
    {



        //atributos Cadastro
        public string apelido;
        public string usuario;
        public string senha;
        public string codigo;
        

        public LoginModelo()
        {
            //inicia os atributos nulo, sem valor
            apelido = null;
            usuario = null;
            senha = null;
            codigo = null;
            
       

        }
    }
}
