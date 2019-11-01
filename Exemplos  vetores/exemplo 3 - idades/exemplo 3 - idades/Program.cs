using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_3___idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[5];
            int i;

           
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite a idade: ");
                idade[i] = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine("impressão do vetor: ");
            for (i = 0; i < 5; i++)
            {
                
                Console.WriteLine("Idade: {0} ", idade[i]);
            }

            Console.ReadKey();
        }
    }
}
