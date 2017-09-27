using System;

namespace Labra4
{
    class Hissi
    {
        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > 5)
                    floor = 5;
                else if (value < 1)
                    floor = 1;
                else
                    floor = value;
            }
        }
    }
    class Tht02
    {
        static void Tehtava2()
        {
            Hissi hissi = new Hissi();
            do
            {
                Console.Write("Syötä kerros (1-5): ");
                string syote = Console.ReadLine();
                int luku;
                bool valinta = int.TryParse(syote, out luku);
                if (valinta) { hissi.Floor = luku; }
                else
                {
                    break;
                }
                Console.WriteLine("Hissi on nyt kerroksessa: {0}", hissi.Floor);
            } while (true);
        }
    }
}