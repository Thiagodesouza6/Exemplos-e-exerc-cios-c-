using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];//declaração do vetor de 5 posições
            int i;//contador do for.
            //inserindo valores no vetor
            for(i=0; i<5; i++)
            {
                Console.Write("Digite o[{0}º] número: ",i);
                vetor[i] = int.Parse(Console.ReadLine());
            }
            //mostrando os valores do vetor
            Console.WriteLine("impressão do vetor: ");
            for(i=0; i<5;i++)
            {
                //os valores são referenciados na memoria ram
                //como sendo {0} a valor de i e {1} p vaçpr de vetor[i]
                Console.WriteLine("[{0}º]= {1}", i, vetor[i]);
            }
            //finaliza
            Console.ReadKey();
        }
    }
}
