using System;

namespace Labra6
{
    class Jaakaappi
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string Elintarvikkeet { get; set; }
        public Jaakaappi(string valmistaja, string malli, string elintarvikkeet)
        {
            Valmistaja = valmistaja;
            Malli = malli;
            Elintarvikkeet = elintarvikkeet;
        }
        public override string ToString()
        {
            return "\nValmistaja: " + Valmistaja + "\nMalli: " + Malli + "\nSisällä: " + Elintarvikkeet;
        }
    }
    class Tht02
    {
        static void Main()
        {
            Jaakaappi jaakaappi = new Jaakaappi("Samsung", "BRB6000", "Juustoa, kinkkuleikettä, margariinia, ruisleipää, maitoa, tuoremehua");
            Console.WriteLine("Jääkaappini {0}", jaakaappi);
        }
    }
}