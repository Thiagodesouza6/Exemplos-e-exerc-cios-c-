using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_5___posição
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[11];
           
            int i;


            for (i = 1; i < vetor.Length; i++)
            {
                Console.Write("Digite a {0}º idade: ",i);
                vetor[i] = int.Parse(Console.ReadLine());

            }


           
           
            Console.WriteLine("\n6º idade: {0}  ", vetor[6]);

            Console.ReadKey();
        }
    }
}
