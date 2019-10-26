using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadradodonumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int q,x;//declaração de variáveis "q" seria uma variável p/quadrado de acordo com o Thi

            //entrada
            Console.Write("informe x : ");
            x =  int.Parse(Console.ReadLine());


            //processamento
            q = x * x;

            //saída
            Console.Write("O resultado de q: " + q);
            Console.ReadKey();
        }
    }
}
