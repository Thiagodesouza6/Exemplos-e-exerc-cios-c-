using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.Write("informe um numero: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
               
                Console.Write("\n"+i);

            }
            Console.ReadKey();
        }
    }
}
