using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro
{
    class Carro
    {
        //Atributos
        public String modelo;
        public String fabricante;
        public String cor;
        public String nroportas;

        public String ligar()//método ligar()
        {
            String mensagem = "O carro está ligado!";
            return mensagem;
        }
        public String buzinar()//método buzinar()
        {
            String mensagem2 = "Buzinando!";
            return mensagem2;
        }
        public String desligar()//método desligar()
        {
            String mensagem3 = "desligando!";
            return mensagem3;
        }
       
    }
}
