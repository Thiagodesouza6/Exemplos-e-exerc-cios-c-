using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.Write("\n Laço de repetição while/enquanto");
            while (i<=10)//enquanto
            {
                Console.Write("\n" + i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
