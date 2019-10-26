using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            double hipotenusa, a ,b;

            Console.Write("informe um cateto: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("informe outro cateto: ");
            b = double.Parse(Console.ReadLine());
         
            hipotenusa = Math.Sqrt(a*a+b*b);

            Console.Write("O resultado da hipotenusa: " + hipotenusa);
            Console.ReadKey();
        }
    }
}
