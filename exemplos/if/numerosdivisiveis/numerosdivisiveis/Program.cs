using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosdivisiveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y, num;


            Console.Write("informe um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num%2==0)
            {
                x = num - 1;
                y = num + 1;
                Console.Write("antecessor:" + x );
                Console.Write("\nsucessor:" + y);
            }
            else
            {
                Console.Write("não divisível");
            }

            Console.ReadKey();
        }
    }
}
