using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal 1: ");
            int Getal1 = System.Convert.ToInt32(Console.ReadLine());

            Console.Write("Getal 2: ");
            int Getal2 = System.Convert.ToInt32(Console.ReadLine());

            double resultaat1, resultaat2, resultaat3, resultaat4;
            resultaat1 = Getal1 + Getal2;
            resultaat2 = Getal1 - Getal2;
            resultaat3 = Getal1 * Getal2;
            resultaat4 = Convert.ToDouble(Getal1) / Convert.ToDouble(Getal2);
            
            Console.WriteLine($"{Getal1} + {Getal2} = " + resultaat1);
            Console.WriteLine($"{Getal1} - {Getal2} = " + resultaat2);
            Console.WriteLine($"{Getal1} * {Getal2} = " + resultaat3);
            Console.WriteLine($"{Getal1} / {Getal2} = " + resultaat4 + "\n");

            Console.WriteLine($"{resultaat1} + {resultaat2} + {resultaat3} + {Convert.ToDecimal(resultaat4)} = {resultaat1 + resultaat2 + resultaat3 + resultaat4}");
            Console.WriteLine($"{resultaat1} + {resultaat2} + {resultaat3} + {Convert.ToDecimal(resultaat4)} = {resultaat1 * resultaat2 * resultaat3 * resultaat4}");
            Console.ReadLine();
        }
    }
}
