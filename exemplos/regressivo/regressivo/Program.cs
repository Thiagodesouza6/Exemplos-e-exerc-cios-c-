using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regressivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for(x=50; x>=1; x--)
            {
                Console.WriteLine("contagem regrassiva: " + x);

            }
            Console.ReadKey();
        }
    }
}
