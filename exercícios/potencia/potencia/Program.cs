using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y , p;//declaração de variáveis

            //entrada
            Console.Write("informe x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("informe y: ");
            y = double.Parse(Console.ReadLine());

            //processamento
            p = Math.Pow(x, y);

            //saída
            Console.Write("O resultado de p: " + p);
            Console.ReadKey();
        }
    }
}
