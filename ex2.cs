using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4,n5,soma;


            Console.Write("\ninforme o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("\ninforme o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("\ninforme o terceiro numero: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("\ninforme o quarto numero: ");
            n4 = int.Parse(Console.ReadLine());
            Console.Write("\ninforme o quinto numero: ");
            n5 = int.Parse(Console.ReadLine());
            soma = n1 + n2+n3+n4+n5;
            Console.Write("\n a soma é: " + soma);

        
            
           
            Console.ReadKey();
        }
    }
}
