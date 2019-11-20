using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1___salarioprestação
{
    class Program
    {
        static void Main(string[] args)
        {
            double prestacao, salario,percentual;
            Console.WriteLine("informe o salario: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a prestação: ");
            prestacao = double.Parse(Console.ReadLine());
            percentual=salario*0.2;
            if (prestacao >percentual)
            {
                Console.Write("emprestimo nao pode ser realizado");
            }
            else
            {
                Console.Write("emprestimo sucesso");
            }
            

            Console.ReadKey();
        }
    }
}
