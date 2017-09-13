using System;

namespace Labra1_2
{
    class Tht08
    {
        public static void Tehtava8()
        {
            // Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.

            int n1, n2, n3;
            Console.Write("Luku 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Luku 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Luku 3: ");
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2)
                if (n1 > n3)
                {
                    Console.WriteLine("Suurin: " + n1);
                }
                else
                {
                    Console.WriteLine("Suurin: " + n3);
                }
            else
                if (n2 > n3)
            {
                Console.WriteLine("Suurin: " + n2);
            }
            else
            {
                Console.WriteLine("Suurin: " + n3);
            }
        }
    }
}