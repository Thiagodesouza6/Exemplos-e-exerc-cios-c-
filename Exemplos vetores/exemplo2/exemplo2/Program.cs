using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[5];
            int[] soma = new int[5];
            int i;//contador do for.
            
            Console.Write("Inserindo valores no vetor A***\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Inserindo valores no vetor B***\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                B[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("impressão do vetor: ");
            for (i = 0; i < 5; i++)
            {
                soma[i] = B[i] + A[i];
                Console.WriteLine("A[{0}] + B[{1}] = Soma[{2}]", A[i], B[i], soma[i]);
            }
           
            Console.ReadKey();
        }
    }
}
