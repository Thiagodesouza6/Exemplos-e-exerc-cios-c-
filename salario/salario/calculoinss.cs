using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario
{
    class calculoinss
    {
        //atributos
        public string funcionario;
        public double salario;
        public double horasextras;
        public double salariobruto;
        public double salarioliquido;
        public double dsctoinss;

        public void calcularresultado()
        {
            
            this.salariobruto = this.salario + this.horasextras;
            if (this.salariobruto <= 1000)
            {
                this.dsctoinss = salariobruto * 0.08;
            }
            if (this.salariobruto >1000&& this.salariobruto<=1500)
            {
                this.dsctoinss = salariobruto * 0.09;
            }
            if (this.salariobruto > 1500)
            {
                this.dsctoinss = salariobruto * 0.11;
            }
            this.salarioliquido = this.salariobruto - this.dsctoinss;
        }
    }
}
