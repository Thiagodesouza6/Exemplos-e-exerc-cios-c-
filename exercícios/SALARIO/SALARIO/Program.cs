using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALARIO
{
    class Program
    {
        static void Main(string[] args)
        {
            double SM, PR, NS;
            //entrada
            Console.Write(" informe o valor de PR: ");
            PR = double.Parse(Console.ReadLine());
            Console.Write(" informe o valor de SM: ");
            SM = double.Parse(Console.ReadLine());
            //processamento
            NS = SM + SM * (PR / 100);
            //saida
            Console.Write("Informe on resultado de NS: "+ NS);
            Console.ReadKey();


            
        }
    }
}
