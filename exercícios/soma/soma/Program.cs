using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {//início
            //declaração de variáveis
            int num1, num2, soma;

            //entradas
            Console.Write("Informe o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

            //processamento
            soma = num1 + num2;

            //saída
            Console.Write("O resultado da soma é: " + soma);

            Console.ReadKey();
          }/*fim*/
    }
}
