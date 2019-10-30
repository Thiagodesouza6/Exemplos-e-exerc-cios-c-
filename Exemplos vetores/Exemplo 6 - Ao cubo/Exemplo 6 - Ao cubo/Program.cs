using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_6___Ao_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[6];
            double[] cubo = new double[6];
            int i;
           

            for (i = 1; i < vetor.Length; i++)
            {
                Console.Write("Digite o {0}º número: ",i);
                vetor[i] = int.Parse(Console.ReadLine());

            }


            Console.WriteLine("impressão do vetor: ");
            for (i = 1; i < vetor.Length; i++)
            {
                cubo[i] = Math.Pow(vetor[i],  3) ;

                Console.WriteLine("{0}º: {1} ", i, cubo[i]);


            }

            Console.ReadKey();
        }
    }
}
