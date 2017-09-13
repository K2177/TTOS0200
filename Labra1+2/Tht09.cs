using System;
using System.Collections.Generic;
using System.Linq;

namespace Labra1_2
{
    class Tht09
    {
        public static void Main()
        {
            // Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.

            List<int> luvut = new List<int>();
            for (int i = 1; ; i++)
            {
                Console.Write("Luku: ");
                int luku = int.Parse(Console.ReadLine());
                if (luku == 0)
                {
                    break;
                }
                else
                {
                    luvut.Add(luku);
                }
            }
            Console.WriteLine("Lukujen summa: " + luvut.Sum());
        }
    }
}