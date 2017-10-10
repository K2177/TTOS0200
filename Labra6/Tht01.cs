using System;

namespace Labra6
{
    class Renkaat
    {
        public string Merkki { get; set; }
        public string Tyyppi { get; set; }
        public string Koko { get; set; }
        public Renkaat(string merkki, string tyyppi, string koko)
        {
            Merkki = merkki;
            Tyyppi = tyyppi;
            Koko = koko;
        }
        public override string ToString()
        {
            return "Merkki: " + Merkki + ", Tyyppi: " + Tyyppi + ", Koko: " + Koko;
        }
    }
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public Kulkuneuvo(string nimi, string malli)
        {
            Nimi = nimi;
            Malli = malli;
        }
        public override string ToString()
        {
            return "Nimi: " + Nimi + ", Malli: " + Malli;
        }
    }
    class Tht01
    {
        static void Tehtava1()
        {
            Kulkuneuvo a = new Kulkuneuvo("Porsche", "911");
            Renkaat a1 = new Renkaat("Nokia", "Hakkapeliitta", "205R16");
            Console.WriteLine("Uusi auto luotu:\n{0} ja siihen uudet renkaat {1}", a, a1);
            Kulkuneuvo b = new Kulkuneuvo("Ducati", "Diavel");
            Renkaat b1 = new Renkaat("MIC", "Pilot", "160R17");
            Console.WriteLine("Uusi moottoripyörä luotu\n{0} ja siihen uudet renkaat: {1}", b, b1);
        }
    }
}