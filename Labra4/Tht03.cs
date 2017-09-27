using System;

namespace Labra4
{
    class Vahvistin
    {
        private int aani;
        public int Aani
        {
            get
            {
                return aani;
            }
            set
            {
                if (value > 100)
                    aani = 100;
                else if (value < 0)
                    aani = 0;
                else
                    aani = value;
            }
        }
    }
    class Tht03
    {
        static void Main()
        {
            Vahvistin vahvistin = new Vahvistin();
            do
            {
                Console.Write("Syötä äänenvoimakkuus (0-100): ");
                string syote = Console.ReadLine();
                int luku;
                bool valinta = int.TryParse(syote, out luku);
                if (valinta) { vahvistin.Aani = luku; }
                else
                {
                    break;
                }
                Console.WriteLine("Äänenvoimakkuus: {0}", vahvistin.Aani);
            } while (true);
        }
    }
}
