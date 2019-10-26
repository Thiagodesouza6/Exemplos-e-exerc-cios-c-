using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, comprimento, altura, largura;//declaração de variáveis

            //entrada
            Console.Write("informe a largura: ");
            largura = double.Parse(Console.ReadLine());
            Console.Write("informe a altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("informe o comprimento: ");
            comprimento = double.Parse(Console.ReadLine());
            //processamento
            volume = comprimento * altura* altura;
            Console.Write("O resultado da volume: " + volume);
            Console.ReadKey();

        }
    }
}
