using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            for(i=1; i<=8; i++)
            {
                Console.Write("\ninforme o [{0}º]número: ",i);
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)//se o resto da divisao for zero
                {
                    Console.Write("Número par: " + num);

                }
                else//senao
                {
                    Console.Write("Número ímpar: " + num);

                }
            }
            Console.ReadKey();
        }
    }
}
