using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Vehicles
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public Vehicles(string name, string model, int year, string color)
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Year: " + Year + ", Color: " + Color;
        }
    }
    class Bikes : Vehicles
    {
        public string GearWheels { get; set; }
        public string GearName { get; set; }
        public Bikes(string name, string model, int year, string color, string gearWheels, string gearName) : base(name, model, year, color)
        {
            GearWheels = gearWheels;
            GearName = gearName;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Year: " + Year + ", Color: " + Color + ", GearWheels: " + GearWheels + ", Gear Name: " + GearName;
        }
    }
    class Boats : Vehicles
    {
        public string Type { get; set; }
        public int Seats { get; set; }
        public Boats(string name, string model, int year, string color, string type, int seats) : base(name, model, year, color)
        {
            Type = type;
            Seats = seats;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Year: " + Year + ", Color: " + Color + ", Type: " + Type + ", Seats: " + Seats;
        }
    }
    class Tht05
    {
        static void Tehtava5()
        {
            Vehicles bike1 = new Bikes("Jopo", "Street", 2016, "Blue", "False", "");
            Console.WriteLine("Bike info\n" + bike1);
            Vehicles bike2 = new Bikes("Tunturi", "StreetPower", 2010, "Black", "True", "Shimano");
            Console.WriteLine("Bike2 info\n" + bike2);
            Vehicles boat1 = new Boats("Suvi", "S900", 1990, "White", "Rowboat", 3);
            Console.WriteLine("Boat info\n" + boat1);
            Vehicles boat2 = new Boats("Yamaha", "1000", 2010, "Yellow", "Motorboat", 5);
            Console.WriteLine("Boat2 info\n" + boat2);
        }
    }
}