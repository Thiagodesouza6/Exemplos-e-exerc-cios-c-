using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5___transposta
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriznormal = new int[3, 4];
            int[,] matriztransposta = new int[4, 3];
            int i, j;

            for (i = 0; i < 3; i++)//leitura da matriz normal
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write("[{0},{1}]: ", i + 1, j + 1);
                    matriznormal[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n*****Matriz normal 3 X 4******");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write("[{0},{1}]: {2} \t", i + 1, j + 1, matriznormal[i, j]);
                }
                Console.Write("\n");
            }
            for (i = 0; i < 4; i++) //leitura da matriz transposta
            {
                for (j = 0; j < 3; j++)
                {
                    matriztransposta[i, j] = matriznormal[j, i];
                }

            }
            Console.WriteLine("\n*****Matriz transposta 4 X 3******");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("[{0},{1}]: {2} \t", i + 1, j + 1, matriztransposta[i, j]);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
