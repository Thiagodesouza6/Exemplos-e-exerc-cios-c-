using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            double media=0,media2=0, soma=0,soma1=0,pares=0,impares=0;
            string continua = "S";
            while (continua == "S")
            {
                for (i = 1; i <= 10; i++)
                {
                    Console.Write("\ninforme o [{0}º]número: ", i);
                    num = int.Parse(Console.ReadLine());


                    if (num % 2 == 0)
                    {
                        pares++;
                        Console.Write("\nNúmero par");
                        soma = num + soma;

                    }

                    else
                    {
                        impares++;
                        Console.Write("\nNúmero ímpar ");
                        soma1 = num + soma1;

                    }
                }
                        media2 = soma1 / impares;
                        Console.Write("\n\nmédia dos ímpares:" + soma1 + "/" + impares + "=" + media2);
                        media = soma / pares;
                        Console.Write("\nmédia dos pares:" + soma + "/" + pares + "=" + media);
                        Console.Write("\n\nsoma dos pares:" + soma);
                   
                Console.Write("\ndeseja continuar?(S/N) ");
                
                continua = Console.ReadLine().ToUpper();

                if (continua=="N")
                {
                    Console.Write("\nfim ");
                }
            }


                Console.ReadKey();
        }
    }

    }

