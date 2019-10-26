using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7idadehomensmulheres
{
    class Program
    {
        static void Main(string[] args)
        {
            double idademulher1, idademulher2, idadehomem1, idadehomem2,soma,produto;
            Console.Write("informe a idade da mulher: ");
            idademulher1 = double.Parse(Console.ReadLine());
            Console.Write("informe a idade da outra mulher: ");
            idademulher2 = double.Parse(Console.ReadLine());
            Console.Write("informe a idade do homem: ");
            idadehomem1 = double.Parse(Console.ReadLine());
            Console.Write("informe a idade do outro homem: ");
            idadehomem2 = double.Parse(Console.ReadLine());

            if (idadehomem1 == idadehomem2 || idademulher1== idademulher2)
            {
                Console.Write("idades incompatíveis");

               
                    if(idadehomem1>idadehomem2 && idademulher1>idademulher2)
                    {
                        soma = idadehomem1 + idadehomem2;
                        produto = idadehomem2 * idademulher1;
                        Console.Write("soma das idades"+soma);
                        Console.Write("produtos das idades" + produto);
                    
                else {
                if (idadehomem2 > idadehomem1 && idademulher2 > idademulher1)
                {
                    soma = idadehomem1 + idadehomem2;
                    produto = idadehomem2 * idademulher1;
                    Console.Write("soma das idades" + soma);
                    Console.Write("produtos das idades" + produto);
                }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
