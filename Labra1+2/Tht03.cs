using System;

namespace Labra1_2
{
    class Tht03
    {
        public static void Tehtava3()
        {
            // Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.

            Console.WriteLine("Syötä kolme lukua yksi kerrallaan: ");
            int luku1 = int.Parse(Console.ReadLine());
            int luku2 = int.Parse(Console.ReadLine());
            int luku3 = int.Parse(Console.ReadLine());
            int summa = luku1 + luku2 + luku3;
            int keskiarvo = summa / 3;
            Console.WriteLine("Summa: " + summa + "\r\nKeskiarvo: " + keskiarvo);
        }
    }
}