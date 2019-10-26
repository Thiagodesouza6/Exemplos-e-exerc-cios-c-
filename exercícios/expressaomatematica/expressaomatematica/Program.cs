using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressaomatematica
{
    class Program
    {
        static void Main(string[] args)
        {
            double r,a,b,c;//declaração de variáveis

            //entrada
            Console.Write("informe a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("informe b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("informe c: ");
            c = double.Parse(Console.ReadLine());

            //processamento
            r = (a*a)*5-c / (b-a*4);

            //saída
            Console.Write("O resultado de r: " + r);
            Console.ReadKey();
        }
    }
}
