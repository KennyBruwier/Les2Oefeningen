using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voornaam: ");
            string voorNaam = Console.ReadLine();

            Console.Write("Achternaam: ");
            string achterNaam = Console.ReadLine();

            Console.Write("Adres: ");
            string adres = Console.ReadLine();

            Console.Write("Postcode: ");
            string postCode = Console.ReadLine();

            Console.Write("Hobby's: ");
            string hobbies = Console.ReadLine();

            Console.WriteLine($"Dag {voorNaam} {achterNaam}! Jij woont op {adres}, {postCode}.\nJouw Hobby's zijn {hobbies}");

            Console.ReadLine();
        }
    }
}
