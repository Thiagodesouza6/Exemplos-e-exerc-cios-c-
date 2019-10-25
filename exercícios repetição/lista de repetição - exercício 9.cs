using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num1=0,num2=0;
            
           
            do
                {
                

                Console.Write("\ninforme um numero: ");
                    i = int.Parse(Console.ReadLine());
              
                if (i>num1)
                {
                    num1 = i;
                }
               else
                {
                    num2 = i;
                }

            } while (i >= 0);
            Console.Write("\nmaior: " + num1);
            Console.Write("\nmenor: " + num2);


            Console.ReadKey();
                
            
        }
    }
}
