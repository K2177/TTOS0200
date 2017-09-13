using System;

namespace Labra1_2
{
    class Tht02
    {
        public static void Tehtava2()
        {
            int[] arvosanat = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 5 };
            Console.Write("Pistemäärä: ");
            int pisteet = int.Parse(Console.ReadLine());
            Console.WriteLine("Koulunumero on: " + arvosanat[pisteet]);
        }
    }
}