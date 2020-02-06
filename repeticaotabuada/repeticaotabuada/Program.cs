using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeticaotabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,resultado,x=1,resultado2,y=1,resultado3;

            Console.Write("\n for");

            for (i = 1; i <= 10; i++)
            {     
                resultado = i * 5;
                Console.Write("\n{0}X5={1}", i,resultado);
            }

            Console.Write("\n");
            Console.Write("\n do while");
            do
            {
                resultado2 = x * 5;
                Console.Write("\n{0}X5={1}", x, resultado2);
                x++;
            } while (x<= 10);

            Console.Write("\n");
            Console.Write("\n  while");

            while (y <= 10)
            {
                resultado3 = y * 5;
                Console.Write("\n{0}X5={1}", y, resultado3);
                y++;
            }
            Console.ReadKey();
        }
    }
}
