using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4___vetor_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.Write("informe o valor do vetor: ");
            n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];
            Console.Write("\n");
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());

            }
            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("vetor:" + vetor[i]);
            }

            Console.ReadKey();
        }
    }
}
