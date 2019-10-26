using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media; //declaração de variáveis

            //entrada
            Console.Write("informe a nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("informe a nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            
            //processamento
            media = (n1 + n2  ) / 2;
            if (media >= 7) //se a média for maior que 7
            {
                Console.Write("Aprovado com média: " + media);
            }
            else
            {
                Console.Write("Reprovado com média: " + media);
            }
            //saída
           
            Console.ReadKey();
        }
    }
}
