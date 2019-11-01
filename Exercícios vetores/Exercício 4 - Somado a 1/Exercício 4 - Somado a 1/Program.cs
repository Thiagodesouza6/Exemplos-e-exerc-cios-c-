using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4___Somado_a_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[11];
            double[] soma = new double[11];
            int i;


            for (i = 1; i < vetor.Length; i++)
            {
                Console.Write("Digite o {0}º número: ", i);
                vetor[i] = int.Parse(Console.ReadLine());

            }


            Console.WriteLine("impressão do vetor: ");
            for (i = 1; i < vetor.Length; i++)
            {
                soma[i] = vetor[i]+1;

                Console.WriteLine("{0}º: {1} ", i, soma[i]);


            }

            Console.ReadKey();
        }
    }
}
