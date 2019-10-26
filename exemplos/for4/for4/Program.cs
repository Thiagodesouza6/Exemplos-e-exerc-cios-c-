using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double nota = 0, somadasnotas = 0, mediadasnotas = 0;
            //laço de repetição para ler as 5 notas
            for(i=1; i<=5; i++)
            {
                Console.Write("\ninforme o [{0}º]número: ", i);
                nota = double.Parse(Console.ReadLine());
                //soma todas as notas
                somadasnotas = somadasnotas + nota;
            }
            //calcula a media das notas
            mediadasnotas = somadasnotas / 5;
            Console.Write("a soma das notas é: "+somadasnotas);
            Console.Write("\na média das notas é: " + mediadasnotas);
            Console.ReadKey();
        }
    }
}
