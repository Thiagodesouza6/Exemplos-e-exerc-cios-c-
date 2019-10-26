using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volumedeumcubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double v,a;//declaração de variáveis

            //entrada
            Console.Write("informe a: ");
            a = double.Parse(Console.ReadLine());
     
            //processamento
            v = a*a*a;

            //saída
            Console.Write("O resultado do volume: " + v);
            Console.ReadKey();
        }
    }
}
