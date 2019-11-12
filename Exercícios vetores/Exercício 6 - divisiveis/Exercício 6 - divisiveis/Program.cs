using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6___divisiveis
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[6];
            int[] B = new int[6];
            int[] C = new int[21];
            int i,n,b;


            for (i = 1; i < A.Length; i++)
            {
                Console.Write("Digite a {0}º numero: ", i);
                A[i] = int.Parse(Console.ReadLine());
                if(A[i] % 2 ==0&& A[i] % 3 == 0)
                {

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("\n  ");

            for (i = 1; i < B.Length; i++)
            {
                Console.Write("Digite a {0}º numero: ", i);
                B[i] = int.Parse(Console.ReadLine());
                if (B[i] % 5 == 0)
                {

                }
                else
                {

                    break;
                }
            }
            for (i = 1; i < B.Length; i++)
            {

                C[i] = B[i];
                Console.WriteLine("\n  {0}  ", C[i]);
                
            }
            for (i = 1; i < B.Length; i++)
            {
                C[i] = A[i];
                Console.WriteLine("\n  {0}  ", C[i]);

            }
            Console.ReadKey();
        }
    }
}
