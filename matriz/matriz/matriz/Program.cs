using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LIN = 3, COL = 3;
            int[,] matriz = new int[LIN, COL];
            int l, c;
            for (l = 0; l < LIN; l++)
            {
                for (c = 0; c < COL; c++)
                {
                    Console.Write("Digite um número: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n Matriz Completa: \n");
            for (l = 0; l < LIN; l++)
            {
                for (c = 0; c < COL; c++)
                {
                    Console.Write(" {0} ", matriz[l, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Matriz com Números Pares: \n");
            for (l = 0; l < LIN; l++)
            {
                for (c = 0; c < COL; c++)
                {
                    if (matriz[l, c] % 2 == 0)
                        Console.Write(" {0} ", matriz[l, c]);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
