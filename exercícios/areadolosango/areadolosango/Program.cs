using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areadolosango
{
    class Program
    {
        static void Main(string[] args)
        {
            double dmaior, dmenor, a;//declaração de variáveis

            //entrada
            Console.Write("informe diagonal maior: ");
            dmaior = double.Parse(Console.ReadLine());
            Console.Write("informe dmenor: ");
            dmenor = double.Parse(Console.ReadLine());

            //processamento
            a= (dmaior * dmenor)/2;

            //saída
            Console.Write("O resultado da a: " + a);
            Console.ReadKey();
        }
    }
}
