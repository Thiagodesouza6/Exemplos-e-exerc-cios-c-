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
            
            int i,soma=0;
       
            int[] vetor = new int[5];
            Console.Write("\n");
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
                soma = vetor[i] + soma;
            }
            
                Console.WriteLine("vetor:" + soma);
          
            


            Console.ReadKey();
        }
    }
}
