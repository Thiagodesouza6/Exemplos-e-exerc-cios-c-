using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaeproduto
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,d,s,p;//declaração de variáveis

            //entrada
            Console.Write("informe a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("informe b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("informe c: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("informe d: ");
            d = double.Parse(Console.ReadLine());
            //processamento
            p = a * c;
            s = b + d;
            

            //saída
            Console.Write("O resultado de p: " + p);
            Console.Write("\nO resultado de s: " + s);
            Console.ReadKey();
        }
    }
}
