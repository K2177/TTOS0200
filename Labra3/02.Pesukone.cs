using System;

namespace Labra3
{
    public class Pesukone
    {
        public bool Virta { get; set; }
        public bool Luukku { get; set; }
        public bool Vesi { get; set; }
    }
    public class Tht2
    {
        static void Tehtava2()
        {
            Pesukone pesukone = new Pesukone();
            Console.Write("Onko pesukone päällä? (0/1): ");
            int virtaa = int.Parse(Console.ReadLine());
            if (virtaa == 0)
            {
                pesukone.Virta = false;
            }
            else
            {
                pesukone.Virta = true;
            }
            Console.Write("Onko luukku kiinni? (0/1): ");
            int kiinni = int.Parse(Console.ReadLine());
            if (kiinni == 0)
            {
                pesukone.Luukku = false;
            }
            else
            {
                pesukone.Luukku = true;
            }
            Console.Write("Onko vesi päällä? (0/1): ");
            int vetta = int.Parse(Console.ReadLine());
            if (vetta == 0)
            {
                pesukone.Vesi = false;
            }
            else
            {
                pesukone.Vesi = true;
            }
            Console.Clear();
            Console.WriteLine("Pesukone on päällä: {0}", pesukone.Virta);
            Console.WriteLine("Luukku on kiinni: {0}", pesukone.Luukku);
            Console.WriteLine("Vesi on päällä: {0}", pesukone.Vesi);
        }
    }
}