using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, soma;
            string continua="S";
            while(continua=="S")
            {
                Console.Write("informe o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("informe o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                soma = num1 + num2;
                Console.Write("\n a soma é: "+soma);
                Console.Write("\ndeseja continuar?(S/N) ");
                //toupper() transforma a string em maiuscula
                continua=Console.ReadLine().ToUpper();
                if(continua=="N")
                {
                    Console.Write("encerrando...");
                }

            }
            Console.ReadKey();
        }
    }
}
