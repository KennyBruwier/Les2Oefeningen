using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6_1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int prijsVol = 35;
            int prijsTien = 25;
            int prijsKind = 20;
            double prijsTot, prijsTotMetKorting, prijsTotTemp;
                        
            Console.WriteLine("Welkom in kenland! Het tofste pretpark van de Benelux!");

            Console.Write("Aantal volwassene: ");
            int aantalVolwassenen = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aantal tieners: ");
            int aantalTieners = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aantal kinderen: ");
            int aantalKind = Convert.ToInt32(Console.ReadLine());

            Console.Write("Procent korting (default: 10): ");
            int procentKorting = Convert.ToInt32(Console.ReadLine());
 
            prijsTot = prijsVol * aantalVolwassenen + prijsTien * aantalTieners + prijsKind * aantalKind;
            prijsTotTemp = prijsMetKorting(prijsVol, aantalVolwassenen, procentKorting);
            prijsTotMetKorting =    prijsMetKorting(prijsVol, aantalVolwassenen, procentKorting) + 
                                    prijsMetKorting(prijsTien, aantalTieners, procentKorting) + 
                                    prijsMetKorting(prijsKind, aantalKind, procentKorting);
            Console.WriteLine(  $"\nPrijs per volwassene: {prijsVol} euro" +
                                $"\nPrijs per tiener: {prijsTien} euro" +
                                $"\nPrijs per kind: {prijsKind} euro\n");
            Console.WriteLine($"Totaal zonder korting: {prijsTot}\nTotaal met {procentKorting}% korting: {prijsTotMetKorting}");
            Console.ReadLine();
        }
        static double prijsMetKorting(double prijs, int aantal, int procentKorting = 10)
        {

            double totaal = 0, huidigePrijs=0;

            for (int i = 0; i < aantal; i++)
            {
                huidigePrijs = (i==0)?prijs:(huidigePrijs * (1-(double)procentKorting/100));
                totaal += huidigePrijs;
            }

            return totaal;

        }

    }
}
