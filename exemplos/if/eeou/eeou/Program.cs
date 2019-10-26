using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eeou
{
    class Program
    {
        static void Main(string[] args)
        {
            double x; 

          
            Console.Write("digite um valor real (ex.: 34,45): ");
            x = double.Parse(Console.ReadLine());
 
            if ((x >10)&&(x<50)) 
            {
                Console.Write(x + " está entre 10 e 50");
            }
            else
            {
                Console.Write(x+" não está entre 10 e 50");
            }
            

            Console.ReadKey();
        }
    }
}
