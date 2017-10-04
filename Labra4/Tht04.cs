using System;

namespace Labra4
{
    class Staff
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public Staff(string name)
        {
            Name = Name;
        }
        public Staff(string name, string profession, int salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }
        public override string ToString()
        {
            return Name + ", " + Profession + ", Salary: " + Salary;
        }
    }
    class Boss : Staff
    {
        public string Car { get; set; }
        public int Bonus { get; set; }
        public Boss(string name, string profession, int salary, string car, int bonus) : base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }
        public override string ToString()
        {
            return Name + ", " + Profession + ", Salary: " + Salary + ", Car: " + Car + ", Bonus: " + Bonus;
        }
    }
    class Tht04
    {
        static void Tehtava4()
        {
            Staff person = new Staff("Kalle Kalamies", "Duunari", 1200);
            Console.WriteLine("Employee:\n" + person);
            Staff boss = new Boss("Matti Majava", "Pomo", 4400, "Ferrari", 2500);
            Console.WriteLine("Boss:\n" + boss);
            Staff person2 = new Staff("Timo Tilli", "Työmies", 1400);
            Console.WriteLine("Employee:\n" + person2);
        }
    }
}