using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hora_trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            double htrabalho, nhoras, sfinal;
            Console.Write("Informe o valor da hora de trabalho: ");
            htrabalho = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor das horas trabalhadas: ");
            nhoras = double.Parse(Console.ReadLine());

            sfinal = htrabalho * nhoras + (htrabalho * nhoras * 0.1);
            Console.Write("Informe o valor das horas trabalhadas: " + sfinal);
            Console.ReadKey();
        }
    }
}
