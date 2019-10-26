using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_e_Else__exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //programa que lê um número e imprime o antecessor e o sucessor
            //do nro se o nro for par.
            //declaração de variáveis
            int num, a, s;
            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            //estrutura de decisão
            if (num % 2 == 0)// se o resto da divisão por dois for igual a zero é par
            {
                Console.WriteLine("Número par: " + num);
                a = num - 1;
                s = num + 1;
                Console.WriteLine("Antecessor: " + a);
                Console.WriteLine("Sucessor: " + s);
            }

            else//senão é impar
            {
                Console.Write("Número ímpar: " + num);

            }
            Console.ReadKey();


            



          }
        }
    }

