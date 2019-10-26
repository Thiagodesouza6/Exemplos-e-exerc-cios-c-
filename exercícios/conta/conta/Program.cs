using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta
{
    class Program
    {
        static void Main(string[] args)
        {
            double R,A,B,C;//declaração de variáveis

            //entrada
            Console.Write("informe A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("informe B: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("informe C: ");
            C = double.Parse(Console.ReadLine());

            //processamento
            R = (7 * C + 5 * B) / (2 * A * 3);

            //saída
            Console.Write("O resultado da R: " + R);
            Console.ReadKey();
        }
    }
}
