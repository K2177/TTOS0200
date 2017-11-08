using System;

namespace Labra9
{
    class Dice
    {
        public int Throws { get; set; }
        public int Value { get; set; }
        private float Average;
        private int[] Count = new int[6];
        Random rnd = new Random();
        public void Throw()
        {
            Console.Write("Amount of throws: ");
            Throws = int.Parse(Console.ReadLine());
        }
        public void Randomize()
        {
            for (int i = 0; i < Throws; i++)
            {
                Value = rnd.Next(1, 7);
                Average += Value;
                switch (Value)
                {
                    case 1: Count[0]++; break;
                    case 2: Count[1]++; break;
                    case 3: Count[2]++; break;
                    case 4: Count[3]++; break;
                    case 5: Count[4]++; break;
                    case 6: Count[5]++; break;
                    default:
                        break;
                }
            }
            Average = Average / Throws;
        }
        public override string ToString()
        {
            return "Average: " + Average + "\nThrows: " + Throws + "\n1 count: " + Count[0] + "\n2 count: " + Count[1] + "\n3 count: " + Count[2] + "\n4 count: " + Count[3] + "\n5 count: " + Count[4] + "\n6 count: " + Count[5];
        }
    }
    class Tht01
    {
        static void Tehtava1()
        {
            Dice dice = new Dice();
            dice.Throw();
            dice.Randomize();
            Console.WriteLine(dice.ToString());
        }
    }
}