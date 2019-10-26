using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @do
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.Write("\nLAÇO DE REPETIÇAO DO...WHILE");
            do//faca
            {
                Console.Write("\n" + i);
                i++;
            } while (i <= 10);//enquanto...
            Console.ReadKey();
        }
    }
}
