using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, vp;

            Console.Write("Informe o valor do produto: ");
            vp = double.Parse(Console.ReadLine());

            d = vp - (vp * 0.12);
            Console.Write("O valor do desconto é de: " + d);
            Console.ReadKey();



        }
    }
}
