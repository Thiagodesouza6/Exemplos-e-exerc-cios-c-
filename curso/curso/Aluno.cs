using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    class Aluno
    {
        //Atributos da classe Aluno
        public String nome;
        public String email;
        public String login;
        public String senha;
        //método
        public String ValidarLogineSenha()
        {
            String resposta = "";
            if(this.login.Equals("aluno")&& this.senha.Equals("123"))
            {
                return resposta = "Acesso permitido!";
            }
            else
            {
                return resposta = "Acesso negado!";
            }
        }

    }
}
