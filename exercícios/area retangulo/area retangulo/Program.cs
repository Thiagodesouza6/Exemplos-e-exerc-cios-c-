using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas, altura, area;//declaração de variáveis

            //entrada
            Console.Write("informe a base: ");
            bas = double.Parse(Console.ReadLine());
            Console.Write("informe a altura: ");
            altura = double.Parse(Console.ReadLine());

            //processamento
            area = altura * bas;

            //saída
            Console.Write("O resultado da area: " + area);
            Console.ReadKey();

        }
    }
}
