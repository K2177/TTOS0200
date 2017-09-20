using System;

namespace Labra3
{
    public class Vehicle
    {
        //Ominaisuudet
        public string Name;
        public int Speed;
        public int Tyres;
        //Toiminnot
        public void PrintData()
        {
            Console.WriteLine("Nimi: {0}", Name);
            Console.WriteLine("Nopeus: {0}", Speed);
            Console.WriteLine("Renkaat: {0}", Tyres);
        }
        public override string ToString()
        {
            string tiedot = Name + ", " + Speed + " km/h, " + Tyres + " rengasta";
            Console.WriteLine(tiedot);
            return tiedot;
        }
    }
    public class Tht4
    {
        static void Tehtava4()
        {
            Vehicle veh = new Vehicle();
            Console.Write("Nimi: ");
            veh.Name = Console.ReadLine();
            Console.Write("Nopeus: ");
            veh.Speed = int.Parse(Console.ReadLine());
            Console.Write("Renkaiden määrä: ");
            veh.Tyres = int.Parse(Console.ReadLine());
            Console.Clear();
            veh.PrintData();
            veh.ToString();
        }
    }
}