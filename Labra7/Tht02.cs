using System;
using System.Collections.Generic;

namespace Labra7
{
    class CD
    {
        #region PROPERTIES
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Songs { get; set; }
        #endregion
        #region CONSTRUCTORS
        public CD(string name, string artist, string songs)
        {
            Name = name;
            Artist = artist;
            Songs = songs;
        }
        #endregion
        #region METHODS
        public override string ToString()
        {
            return string.Format("Levy: {0}\nArtisti: {1}\nKappaleet: {2}\n", Name, Artist, Songs);
        }
        #endregion
    }
    class Tht02
    {
        static void Tehtava2()
        {
            List<CD> levy = new List<CD>();
            levy.Add(new CD("Sounds of a Playground Fading", "In Flames", "Kappale1, 4:00 kappale2 4:00, kappale3 4:00"));
            levy.Add(new CD("Indestructible", "Disturbed", "Kappale1, 2:00 kappale2 2:00, kappale3 2:00"));
            levy.Add(new CD("Reload", "Metallica", "Kappale1, 3:00 kappale2 3:00, kappale3 3:00"));
            Console.WriteLine("Jukeboksi");
            foreach (var o in levy)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}