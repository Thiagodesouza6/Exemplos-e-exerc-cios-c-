using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5___média
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[11];
            int i;
            double    soma=0,media;


            for (i = 1; i < vetor.Length; i++)
            {
                Console.Write("Digite a {0}º idade: ", i);
                vetor[i] = int.Parse(Console.ReadLine());
                soma = vetor[i] + soma;
                
                
            }

            media = soma / i+1;



            Console.WriteLine("\n média: {0}  ", media);

            Console.ReadKey();
        }
    }
}
