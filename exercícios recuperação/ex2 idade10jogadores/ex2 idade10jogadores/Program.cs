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
            int[] altura = new int[10];
            int[] idade = new int[10];
            int[] peso = new int[10];
            int i, soma = 0,n=0,media;
            Console.Write("\nInforme as idades\n");
            for (i = 0; i < idade.Length; i++)
            {
                Console.Write("Digite a {0}º idade: ",i + 1);
                idade[i] = int.Parse(Console.ReadLine());
                soma = idade[i] + soma;
                if(idade[i]<18)
                {
                    n++;
                }
               

                }
            Console.Write("\nInforme os pesos\n");
            for (i = 0; i < idade.Length; i++)
            {
                Console.Write("Digite o {0}º peso: ", i+1);
                peso[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nInforme as alturas\n");
            for (i = 0; i < altura.Length; i++)
            {
                Console.Write("Digite a {0}º altura: ", i + 1);
                altura[i] = int.Parse(Console.ReadLine());
            }
            media = soma / 10;
                Console.WriteLine("\nidade menor que 18 :" + n);
                Console.WriteLine("\nmédia de idade:" + media);



            Console.ReadKey();
        }
    }
}
