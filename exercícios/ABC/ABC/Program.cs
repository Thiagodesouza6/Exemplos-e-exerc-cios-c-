using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            int S, A, B, C;
            //entrada
            Console.Write(" informe A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write(" informe B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write(" informe C: ");
            C = int.Parse(Console.ReadLine());
            //processamento
            S = A * A + B * B + C * C;
            //saida
            Console.Write(" informe S: " + S);
            Console.ReadKey();
        }

    }
}
