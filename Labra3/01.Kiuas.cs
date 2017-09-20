using System;

namespace Labra3
{
    public class Kiuas
    {
        public bool Virta;
        public int Lampotila;
        //Kosteus 0-100%
        float kosteus;
        public float Kosteus
        {
            get { return kosteus; }
            set
            {
                kosteus = value;
                if (kosteus < 0 || kosteus > 100)
                {
                    kosteus = 0;
                }
            }
        }
    }
    public class Tht1
    {
        static void Tehtava1()
        {
            Kiuas kiuas = new Kiuas();
            Console.Write("Onko kiuas päällä? (0/1): ");
            int virtaa = int.Parse(Console.ReadLine());
            if (virtaa == 0)
            {
                kiuas.Virta = false;
            }
            else
            {
                kiuas.Virta = true;
            }
            Console.Write("Haluttu lämpötila: ");
            kiuas.Lampotila = int.Parse(Console.ReadLine());
            Console.Write("Haluttu kosteus: ");
            kiuas.Kosteus = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Kiuas on päällä: {0}", kiuas.Virta);
            Console.WriteLine("Lämpötila-asetus: {0}", kiuas.Lampotila);
            Console.WriteLine("Kosteusasetus: {0}", kiuas.Kosteus);
        }
    }
}