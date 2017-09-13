using System;

namespace Labra1_2
{
    class Tht07
    {
        public static void Tehtava7()
        {
            // Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.

            Console.Write("Syötä vuosi: ");
            int y = int.Parse(Console.ReadLine());
            if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
            {
                Console.WriteLine("Karkausvuosi");
            }
            else
            {
                Console.WriteLine("Ei ole karkausvuosi");
            }
        }
    }
}