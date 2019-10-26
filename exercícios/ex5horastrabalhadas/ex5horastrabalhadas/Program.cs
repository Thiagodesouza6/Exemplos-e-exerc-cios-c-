using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5horastrabalhadas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nfilhos, horastrabalhadas, valor, salariomensal, salfinal;
            Console.Write("informe as horas de trabalho mensais: ");
            horastrabalhadas = double.Parse(Console.ReadLine());
            Console.Write("informe valor p/ hora: ");
            valor= double.Parse(Console.ReadLine());
            Console.Write("informe o numero de filhos com menos de 14 anos: ");
            nfilhos = double.Parse(Console.ReadLine());
            salariomensal = horastrabalhadas * valor;

            if (nfilhos== 0)
            {
                Console.Write("salario final: "+ salariomensal );
            }
             else
            {
                salfinal = salariomensal + (salariomensal*10*nfilhos/100);
                Console.Write("salario final: "+salfinal);
            }
            
            Console.ReadKey();
        }
    }
}
