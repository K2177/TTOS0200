using System;
using System.Globalization;

namespace Labrat
{
    public class Tarkastus
    {
        public static bool OnkoPvm(string syote)
        {
            DateTime temp;
            var dateFormats = new[]{"dd.MM.yyyy", "dd.MM.yy", "d.M.yy", "d.M.yyyy", "dd.M.yy", "dd.M.yyyy", "d.MM.yy", "d.MM.yyyy"};
            if (DateTime.TryParseExact(syote, dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out temp))
            {
                Console.WriteLine("{0} on päivämäärä", syote);
                return true;
            }
            else
            {
                Console.WriteLine("{0} ei ole päivämäärä", syote);
                return false;
            }
        }
        public static bool OnkoLuku(string syote)
        {
            double luku;
            if (syote.Contains(" "))
            {
                return false;
            }
            if (syote[syote.Length - 1] == ',')
            {
                Console.WriteLine("Syöte {0} ei ole luku", syote);
                return false;
            }
            if (syote[0] == ',')
            {
                Console.WriteLine("Syöte {0} ei ole luku", syote);
                return false;
            }
            if (double.TryParse(syote, out luku))
            {
                Console.WriteLine("Syöte {0} on luku", luku);
                return true;
            }
            else
            {
                Console.WriteLine("Syöte {0} ei ole luku", syote);
                return false;
            }
        }
    }
    public class TestiPeti
    {
        static void Tehtava1()
        {
            Console.Write("Anna luku: ");
            string syote = Console.ReadLine();
            Tarkastus.OnkoLuku(syote);
            Tarkastus.OnkoPvm(syote);
        }
    }
}