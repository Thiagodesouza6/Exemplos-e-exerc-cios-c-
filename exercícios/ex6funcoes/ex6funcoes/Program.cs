using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariomensal;
            Console.Write("informe salario mensal: ");
            salariomensal = double.Parse(Console.ReadLine());
            
            

            if (salariomensal >=9900)
            {
                Console.Write("grande função");
            }
            else
            {
                if(salariomensal > 5000 && salariomensal<9899)
                  Console.Write("media função");
                else
                {
                if (salariomensal <= 5000)
                    Console.Write("pequena função");
                }
            }

            Console.ReadKey();
        }
    }
}
