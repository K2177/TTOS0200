using System;

namespace Labra3
{
    public class TV
    {
        public bool Virta;
        public bool Aani;
        //Kanavat 1-999
        int kanava;
        public int Kanava
        {
            get { return kanava; }
            set
            {
                kanava = value;
                if (kanava < 1 || kanava > 999)
                {
                    kanava = 1;
                }
            }
        }
    }
    public class Tht3
    {
        static void Tehtava3()
        {
            TV tv = new TV();
            Console.Write("Onko TV päällä? (0/1): ");
            int virtaa = int.Parse(Console.ReadLine());
            if (virtaa == 0)
            {
                tv.Virta = false;
            }
            else
            {
                tv.Virta = true;
            }
            Console.Write("Ovatko äänet päällä? (0/1): ");
            int aani = int.Parse(Console.ReadLine());
            if (aani == 0)
            {
                tv.Aani = false;
            }
            else
            {
                tv.Aani = true;
            }
            Console.Write("Kanava: ");
            tv.Kanava = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("TV on päällä: {0}", tv.Virta);
            Console.WriteLine("Äänet: {0}", tv.Aani);
            Console.WriteLine("Valittu kanava: {0}", tv.Kanava);
        }
    }
}