using System;
using System.Collections.Generic;

namespace Labra9
{
    class Product
    {
        public string Cart { get; set; }
        public double Price { get; set; }
        public Product(string cart, double price)
        {
            Cart = cart;
            Price = price;
        }
        public override string ToString()
        {
            return "- " + Cart + " " + Price + "e";
        }
    }
    class Tht02
    {
        static void Tehtava2()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Milk", 1.4));
            list.Add(new Product("Coca-Cola", 2.2));
            list.Add(new Product("Butter", 3.2));
            list.Add(new Product("Cheese", 4.2));
            Console.WriteLine("All products:");
            foreach (var l in list)
            {
                Console.WriteLine(l.ToString());
            }
        }
    }
}