using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double  idade ;
            Console.Write("informe a idade: ");
            idade= double.Parse(Console.ReadLine());

            if (idade < 5) 
            {
                Console.Write("BÈBÈ");
                
            }
            
            if (idade>=5 && idade<=7)
            {
                Console.Write("infantil");

            }
            if (idade >= 8 && idade <=10 )
            {
                Console.Write("juvenil");

            }
            if (idade >= 11 && idade <= 15)
            {
                Console.Write("adolescente");

            }
            if (idade >= 16)
            {
                Console.Write("adulto");

            }
            Console.ReadKey();
        }
    }
}
