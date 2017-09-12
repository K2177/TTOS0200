using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1_2
{
    class Tht05
    {
        public static void Tehtava5()
        {
            // Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.

            Console.WriteLine("Sekunnit: ");
            int sek = int.Parse(Console.ReadLine());
            int h = sek / 3600;
            int m = (sek % 3600) / 60;
            int s = (sek % 3600) % 60;
            Console.WriteLine("Tunnit: " + h + " Minuutit: " + m + " Sekunnit: " + s);
        }
    }
}