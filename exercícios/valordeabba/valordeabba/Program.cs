using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valordeabba
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("informe o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("informe o valor de b: ");
            b = double.Parse(Console.ReadLine());
           
            Console.Write("Informe a:   " + b);
            Console.Write("\nInforme b:   "+ a);
            Console.ReadKey();


        }
    }
}
