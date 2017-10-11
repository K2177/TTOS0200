using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniASIO
{
    class Opiskelija
    {
        #region PROPERTIES
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string AsioID { get; set; }
        public string Ryhmä { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Opiskelija()
        { }
        public Opiskelija(string etunimi, string sukunimi)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
        }
        public Opiskelija(string etunimi, string sukunimi, string asioid): this(etunimi, sukunimi)
        {
            AsioID = asioid;
        }
        public Opiskelija(string etunimi, string sukunimi, string asioid, string ryhmä) : this(etunimi, sukunimi, asioid)
        {
            Ryhmä = ryhmä;
        }
        #endregion
        #region METHODS
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Etunimi, Sukunimi, AsioID, Ryhmä);
        }
        #endregion
    }
    class TestaaMiniASIO
    {
        static void Testaa()
        {
            //Luodaan List-tyyppinen lista opiskelijoista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            //Testin vuoksi erilaisia tapoja lisätä oliota Listaan
            Opiskelija masa = new Opiskelija("Masa", "Niemi");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1234"));
            //Myös näin
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H5678" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testaaja", AsioID = "T9876", Ryhmä="TTV17S1" });
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle"; kalle.Sukunimi = "Ankka"; kalle.AsioID = "N6543";
            opiskelijat.Add(kalle);
            //Yhden opiskelijan tietojen näyttäminen
            Console.WriteLine("Anna numero väliltä 1-{0}", opiskelijat.Count);
            int i = int.Parse(Console.ReadLine());
            if (i-1 < opiskelijat.Count)
                Console.WriteLine("MiniASIOn {0} opiskelija on {1}", i, opiskelijat[i - 1].ToString());
            else
                Console.WriteLine("MiniASIOssa on vain {0} opiskelijaa", opiskelijat.Count);
            //Kaikkien opiskelijoiden tiedot
            Console.WriteLine("MiniASIOn kaikki opiskelijat:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //Kaikkien opiskelijoiden tiedot aakkosjärjestyksessä sukunimen mukaan
            //sortataan oliot Sukunimi -ominaisuuden mukaiseen järjestykseen
            opiskelijat.Sort((x,y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("MiniASIOn kaikki opiskelijat aakkosjärjestyksessä:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //Uuden opiskelijan lisääminen, huom tehdään tarkistus ettei AsioID ole jo olemassa
            Console.WriteLine("Anna uuden opiskelijan AsioID");
            string asioid = Console.ReadLine();
            //Tutkitaan onko listassa
            bool lippu = false;
            foreach (Opiskelija o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);
            }
            else
            {
                Console.WriteLine("Anna uuden opiskelijan etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna ryhmä");
                string ryhmä = Console.ReadLine();
                //Luodaan uusi Opiskelija olio
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhmä);
                opiskelijat.Add(uusi);
                Console.WriteLine("MiniASIOn kaikki {0} opiskelijat:", opiskelijat.Count);
                foreach (var o in opiskelijat)
                {
                    Console.WriteLine(o.ToString());
                }
            }
        }
        static void Main()
        {
            Testaa();
        }
    }
}
