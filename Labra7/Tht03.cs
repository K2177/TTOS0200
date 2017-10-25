using System;
using System.Collections.Generic;

namespace Labra7
{
    class Deck
    {
        public string Card { get; set; }
        public Deck(string card)
        {
            Card = card;
        }
        public override string ToString()
        {
            return string.Format(Card);
        }
    }
    class Tht03
    {
        static void Main()
        {
            List<Deck> cards = new List<Deck>();
            cards.Add(new Deck("Club#1"));
            cards.Add(new Deck("Club#2"));
            cards.Add(new Deck("Club#3"));
            cards.Add(new Deck("Club#4"));
            cards.Add(new Deck("Club#5"));
            cards.Add(new Deck("Club#6"));
            cards.Add(new Deck("Club#7"));
            cards.Add(new Deck("Club#8"));
            cards.Add(new Deck("Club#9"));
            cards.Add(new Deck("Club#10"));
            cards.Add(new Deck("Club#11"));
            cards.Add(new Deck("Club#12"));
            cards.Add(new Deck("Club#13"));
            cards.Add(new Deck("Heart#1"));
            cards.Add(new Deck("Heart#2"));
            cards.Add(new Deck("Heart#3"));
            cards.Add(new Deck("Heart#4"));
            cards.Add(new Deck("Heart#5"));
            cards.Add(new Deck("Heart#6"));
            cards.Add(new Deck("Heart#7"));
            cards.Add(new Deck("Heart#8"));
            cards.Add(new Deck("Heart#9"));
            cards.Add(new Deck("Heart#10"));
            cards.Add(new Deck("Heart#11"));
            cards.Add(new Deck("Heart#12"));
            cards.Add(new Deck("Heart#13"));
            cards.Add(new Deck("Diamond#1"));
            cards.Add(new Deck("Diamond#2"));
            cards.Add(new Deck("Diamond#3"));
            cards.Add(new Deck("Diamond#4"));
            cards.Add(new Deck("Diamond#5"));
            cards.Add(new Deck("Diamond#6"));
            cards.Add(new Deck("Diamond#7"));
            cards.Add(new Deck("Diamond#8"));
            cards.Add(new Deck("Diamond#9"));
            cards.Add(new Deck("Diamond#10"));
            cards.Add(new Deck("Diamond#11"));
            cards.Add(new Deck("Diamond#12"));
            cards.Add(new Deck("Diamond#13"));
            cards.Add(new Deck("Spade#1"));
            cards.Add(new Deck("Spade#2"));
            cards.Add(new Deck("Spade#3"));
            cards.Add(new Deck("Spade#4"));
            cards.Add(new Deck("Spade#5"));
            cards.Add(new Deck("Spade#6"));
            cards.Add(new Deck("Spade#7"));
            cards.Add(new Deck("Spade#8"));
            cards.Add(new Deck("Spade#9"));
            cards.Add(new Deck("Spade#10"));
            cards.Add(new Deck("Spade#11"));
            cards.Add(new Deck("Spade#12"));
            cards.Add(new Deck("Spade#13"));
            foreach (var o in cards)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}