using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit: ");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Celsius: {Math.Round((fahrenheit - 32)/(5/9),4)}");

            // wachten

            Console.ReadLine();
        }
    }
}
