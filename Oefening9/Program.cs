using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening9
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan duurte;

            Console.Write("Af te leggen afstand in km: ");
            int aantalKm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Snelheid in km/h: ");
            int snelheid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"De vrachtwagen zal nog {Math.Round(Convert.ToDouble(aantalKm) / snelheid, 0)} uur moeten rijden.");

            Console.ReadLine();
        }
    }
}
