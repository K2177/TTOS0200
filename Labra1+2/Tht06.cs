using System;

namespace Labra1_2
{
    class Tht06
    {
        public static void Tehtava6()
        {
            // Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.

            Console.Write("Kilometrit: ");
            int km = int.Parse(Console.ReadLine());
            double kulutus = km * 7.02 / 100;
            double hinta = kulutus * 1.595;
            Console.WriteLine("Bensaa kuluu {0} litraa. Kustannus {1} euroa.", kulutus, hinta);
        }
    }
}