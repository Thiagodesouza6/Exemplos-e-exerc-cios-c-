using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7___Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] homem = new int[6];
            int[] mulher = new int[6];
            int i;
            int alta = 0,vetor=0,media,soma=0, soma2 = 0,baixo=0;


            for (i = 1; i < homem.Length; i++)
            {
                Console.Write("Digite a {0}º idade do homem: ", i);
                homem[i] = int.Parse(Console.ReadLine());
                soma = homem[i] + soma;
                if (homem[i] > baixo)
                {
                    baixo = homem[i];
                }
                else
                {
                    vetor = i;
                }
                
            }
            for (i = 1; i < homem.Length; i++)
            {
                Console.Write("\nDigite a {0}º idade da mulher: ", i);
                mulher[i] = int.Parse(Console.ReadLine());
              
                if (mulher[i]>alta)
                {
                    alta=mulher[i];
                }
                soma2 = mulher[i] + soma2;
            }

            media = (soma + soma2) / 10;

            Console.WriteLine("\n media: {0}  ", media);
            Console.WriteLine("\n vetor do homem mais baixo: {0}  ", vetor);
            Console.WriteLine("\n mulher mais alta: {0}  ", alta);

            Console.ReadKey();
        }
    }
}
