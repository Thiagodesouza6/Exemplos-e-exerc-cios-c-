using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            //laço de repetição para ler as 5 notas
            for (i = 0; i <= 100; i=i+10)
            {
                
                Console.Write("\n{0}", i);

            }

            Console.ReadKey();
        }
    }
}
