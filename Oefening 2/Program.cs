using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Prijs drankje: ");
            double prijsDrank = Convert.ToDouble(Console.ReadLine());

            Console.Write("Aantal drankjes: ");
            int aantalDrankjes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prijs zonder btw: " + aantalDrankjes * prijsDrank);
            Console.WriteLine("Prijs met 21% btw: " + Math.Round(aantalDrankjes * prijsDrank * 1.21,2));

            // wachten

            Console.ReadLine();
        }
    }
}
