using System;
using System.Collections.Generic;

namespace Labra7
{
    class Deck
    {
        public string Kortti { get; set; }
        public Deck(string kortti)
        {
            Kortti = kortti;
        }
        public override string ToString()
        {
            return string.Format(Kortti);
        }
    }
    class Tht03
    {
        static void Main()
        {
            List<Deck> kortit = new List<Deck>();
            kortit.Add(new Deck("Club#1"));
            kortit.Add(new Deck("Club#2"));
            kortit.Add(new Deck("Club#3"));
            kortit.Add(new Deck("Club#4"));
            kortit.Add(new Deck("Club#5"));
            kortit.Add(new Deck("Club#6"));
            kortit.Add(new Deck("Club#7"));
            kortit.Add(new Deck("Club#8"));
            kortit.Add(new Deck("Club#9"));
            kortit.Add(new Deck("Club#10"));
            kortit.Add(new Deck("Club#11"));
            kortit.Add(new Deck("Club#12"));
            kortit.Add(new Deck("Club#13"));
            kortit.Add(new Deck("Heart#1"));
            kortit.Add(new Deck("Heart#2"));
            kortit.Add(new Deck("Heart#3"));
            kortit.Add(new Deck("Heart#4"));
            kortit.Add(new Deck("Heart#5"));
            kortit.Add(new Deck("Heart#6"));
            kortit.Add(new Deck("Heart#7"));
            kortit.Add(new Deck("Heart#8"));
            kortit.Add(new Deck("Heart#9"));
            kortit.Add(new Deck("Heart#10"));
            kortit.Add(new Deck("Heart#11"));
            kortit.Add(new Deck("Heart#12"));
            kortit.Add(new Deck("Heart#13"));
            kortit.Add(new Deck("Diamond#1"));
            kortit.Add(new Deck("Diamond#2"));
            kortit.Add(new Deck("Diamond#3"));
            kortit.Add(new Deck("Diamond#4"));
            kortit.Add(new Deck("Diamond#5"));
            kortit.Add(new Deck("Diamond#6"));
            kortit.Add(new Deck("Diamond#7"));
            kortit.Add(new Deck("Diamond#8"));
            kortit.Add(new Deck("Diamond#9"));
            kortit.Add(new Deck("Diamond#10"));
            kortit.Add(new Deck("Diamond#11"));
            kortit.Add(new Deck("Diamond#12"));
            kortit.Add(new Deck("Diamond#13"));
            kortit.Add(new Deck("Spade#1"));
            kortit.Add(new Deck("Spade#2"));
            kortit.Add(new Deck("Spade#3"));
            kortit.Add(new Deck("Spade#4"));
            kortit.Add(new Deck("Spade#5"));
            kortit.Add(new Deck("Spade#6"));
            kortit.Add(new Deck("Spade#7"));
            kortit.Add(new Deck("Spade#8"));
            kortit.Add(new Deck("Spade#9"));
            kortit.Add(new Deck("Spade#10"));
            kortit.Add(new Deck("Spade#11"));
            kortit.Add(new Deck("Spade#12"));
            kortit.Add(new Deck("Spade#13"));
            foreach (var o in kortit)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}