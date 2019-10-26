using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programalatadeoleo
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, R, altura;//declaração de variáveis
            
            //entrada
            Console.Write("informe o raio: ");
            R = double.Parse(Console.ReadLine());
            Console.Write("informe a altura: ");
            altura = double.Parse(Console.ReadLine());
            //processamento
            volume = 3,1415 * R * altura;
            Console.Write("O resultado da volume: " + volume);
            Console.ReadKey();

        }
    }
}
