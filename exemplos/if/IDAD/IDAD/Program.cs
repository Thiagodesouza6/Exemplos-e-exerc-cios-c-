using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAD
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade;


            Console.Write("informe a idade: ");
            idade = double.Parse(Console.ReadLine());

            if (idade>=21)
            {
                Console.Write("Maior de idade");
            }
            else
            {
                Console.Write("Menor de idade");
            }


            Console.ReadKey();
        }
    }
}
