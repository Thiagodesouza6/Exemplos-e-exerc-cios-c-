using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parouimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            Console.Write("informe um numero: ");
            numero = double.Parse(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.Write("Par");

            }
            else
            {
                Console.Write("Ímpar");

            }
            Console.ReadKey();
        }
    }
}
