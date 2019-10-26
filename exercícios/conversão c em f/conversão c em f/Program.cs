using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversão_c_em_f
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C; //declaração de variáveis

            //entrada
            Console.Write("informe a °F: ");
             F = double.Parse(Console.ReadLine());
            //processamento
            C = (F-32)*5/9;

            //saída
            Console.Write("O resultado C: " + C);
            Console.ReadKey();
        }
    }
}
