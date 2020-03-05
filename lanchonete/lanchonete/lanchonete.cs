using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanchonete
{
    class lanchonete
    {
        //atributos
        public int lanches;
        public int refrigerantes;
        public double dinheiro;
        public double total;
        public double dinheirorecebido;
        //metodo para calcular o total a pagar
        public void calculatotalapagar()
        {
            this.total = this.lanches * 6 + this.refrigerantes * 2;
        }
        //metodo para calcular o troco
        public void calculatroco()
        {

        }
    }
}
