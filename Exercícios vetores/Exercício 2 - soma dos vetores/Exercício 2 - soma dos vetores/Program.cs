using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2___soma_dos_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[9];

            int i, soma = 0;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
                soma = vetor[i++]+soma;
            }

            Console.WriteLine("\nA soma é: "+soma);
         
            Console.ReadKey();
        }
    }
}
