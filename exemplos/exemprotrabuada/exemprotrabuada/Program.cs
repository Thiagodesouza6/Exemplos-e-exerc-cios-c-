using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemprotrabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num, r = 0;//i para contador e num para tabuada
            Console.Write("informe qual tabuada deseja criar: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("tabuada do numero{0} ", num);
            for (i = 1; i <= 10; i++) 
            {
                r = num * i;
                Console.Write("\n" + num + "X" + i + "=" + r + "\n");

            }
            Console.ReadKey();
        }
    }
}
