using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_4___invertido
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]vetor = new int[5];
            int[] invertido = new int[5];
            int i;


            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
                
            }

            
            Console.WriteLine("impressão do vetor: ");
            for (i = 0; i <vetor.Length; i++)
            {
                invertido[i] = vetor[vetor.Length - 1 - i];
                
                    Console.WriteLine("[{0}º]: {1} ", i, invertido[i]);
                
                
            }

            Console.ReadKey();
        }
    }
}
