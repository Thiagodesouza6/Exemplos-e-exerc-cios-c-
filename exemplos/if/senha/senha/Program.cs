using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            double senha;


            Console.Write("informe a senha: ");
            senha = double.Parse(Console.ReadLine());

            if (senha==123)
            {
                Console.Write( "acesso permitido");
            }
            else
            {
                Console.Write("acesso negado");
            }


            Console.ReadKey();
        }
    }
}
