using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal 1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 3: ");
            int getal3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{getal1} - {getal2} - {getal3}\n{getal1} - {getal3} - {getal2}");
            Console.WriteLine($"{getal2} - {getal3} - {getal1}\n{getal2} - {getal1} - {getal3}");
            Console.WriteLine($"{getal3} - {getal1} - {getal2}\n{getal3} - {getal2} - {getal1}");

            Console.ReadLine();
        }
    }
}
