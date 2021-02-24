using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int Getal1 = 7;
            int Getal2 = 5;


            Console.WriteLine($"{Getal1} + {Getal2} = " + System.Convert.ToInt32(Getal1 + Getal2));
            Console.WriteLine($"{Getal1} - {Getal2} = " + System.Convert.ToInt32(Getal1 - Getal2));
            Console.WriteLine($"{Getal1} * {Getal2} = " + System.Convert.ToInt32(Getal1 * Getal2));
            Console.WriteLine($"{Getal1} / {Getal2} = " + System.Convert.ToDouble(Getal1) / System.Convert.ToDouble(Getal2));
            Console.ReadLine();
        }
    }
}
