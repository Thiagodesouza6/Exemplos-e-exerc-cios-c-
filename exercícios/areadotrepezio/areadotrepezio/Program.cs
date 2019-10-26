using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areadotrepezio
{
    class Program
    {
        static void Main(string[] args)
        {
            double basemaior, basemenor, altura, area;
            //entrada
            Console.Write("informe a base maior: ");
            basemaior = double.Parse(Console.ReadLine());
            Console.Write("informe a base menor: ");
            basemenor = double.Parse(Console.ReadLine());
            Console.Write("informe a altura: ");
            altura = double.Parse(Console.ReadLine());

            //processamento
            area = ((basemenor + basemaior) * altura) / 2;

            //saida
            Console.Write("informe a area: " + area);
            Console.ReadKey();
        }
    }
}
