using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_idade10jogadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int i, soma = 0,peso,altura,idade,n=0,media;
            Console.Write("\n");
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("\nDigite a idade: ");
                vetor[i] = int.Parse(Console.ReadLine());
                soma = vetor[i] + soma;
                if(vetor[i]<18)
                {
                    n++;
                }
  
                }
            media = soma / 10;
                Console.WriteLine("idade menor que 18:" + n);
                Console.WriteLine("média de idade:" + media);



            Console.ReadKey();
        }
    }
}
