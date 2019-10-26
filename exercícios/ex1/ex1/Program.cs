using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            //laço de repetição para ler as 5 notas
            for (i = 50; i <= 70; i = i + 2 )
            {
                n = i +i ;
                Console.Write("\n{0}: média", n);

            }
            
            Console.ReadKey();
        }
    }
}
