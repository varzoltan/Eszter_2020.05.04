﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._05._04
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 feladat: Olvass be két egész számot, majd írd ki összegüket, 
            //különbségüket, szorzatukat és az első és második hányadosát egész osztásnál!
            Console.Write("Legyen szíves megadni egy egész számot: ");
            int x = int.Parse(Console.ReadLine()); //konvertálni kell a megadott számot!!!

            //2. egész szám bekérése a felhasználótól.
            Console.Write("Legyen szíves megadni egy másik egész számot: ");
            int y = Convert.ToInt32(Console.ReadLine());

            //Írjuk ki a két szám összegét!
            Console.Write("A két szám összege: " + (x + y));
            int z = x + y;
            Console.Write("\nA két szám összege: " + z);
            Console.Write("\nA két szám összege: {0}", z);
            Console.ReadKey();
        }
    }
}
