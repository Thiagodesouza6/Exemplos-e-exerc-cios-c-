using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESTAÇÃO
{
    class Program
    {
        static void Main(string[] args)
        {
            double prestacao, valor, taxa, tempo; //declaração de variáveis

            //entrada
            Console.Write("informe o valor: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("informe a taxa: ");
            taxa = double.Parse(Console.ReadLine());
            Console.Write("informe o tempo: ");
            tempo = double.Parse(Console.ReadLine());
            //processamento
            prestacao = valor + (valor * (taxa / 100) * tempo);

            //saída
            Console.Write("O resultado prestacao: " + prestacao);
            Console.ReadKey();
        }
    }
}
