using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num1,num2,soma=0;
            Console.Write("informe um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("informe outro numero: ");
            num2 = int.Parse(Console.ReadLine());
            for (i =num1; i <= num2; i++)
            {
                
                Console.Write("\n{0}",i);

                soma = soma+i;
                
            }
            Console.Write("\n soma" + soma);
            Console.ReadKey();
        }
    }
}
