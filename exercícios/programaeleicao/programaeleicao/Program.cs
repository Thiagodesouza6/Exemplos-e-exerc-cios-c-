using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaeleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            double vb, vn, vv, ne, pb, pv, pn;

            Console.Write("informe votos em branco: ");
            vb = double.Parse(Console.ReadLine());
            Console.Write("informe votos validos: ");
            vv= double.Parse(Console.ReadLine());
            Console.Write("informe votos nulos: ");
            vn = double.Parse(Console.ReadLine());

            ne = vb + vn + vv;
            Console.Write("O número de eleitores é: " + ne);


            pb = (vb / ne) *100;
            Console.Write("\n A porcentagem que corresponde ao número de eleitores que votaram em branco é (%): " + pb);


            pn = (vn/ ne) * 100;
            Console.Write("\n A porcentagem que corresponde ao número de eleitores que votaram nulo é (%): " + pn);


            pv = (vv/ ne) * 100;
            Console.Write("\n A porcentagem que corresponde ao número de eleitores que votaram válido é (%): " + pv);


            Console.ReadKey();
        }
    }
}
