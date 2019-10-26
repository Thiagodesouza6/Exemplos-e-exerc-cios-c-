using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIA
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media; //declaração de variáveis

            //entrada
            Console.Write("informe a nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("informe a nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("informe o nota 3: ");
            n3 = double.Parse(Console.ReadLine());
            //processamento
            media = (n1*2+n2*3+n3*5 )/10;

            //saída
            Console.Write("O resultado media: " + media);
            Console.ReadKey();
        }
    }
}
