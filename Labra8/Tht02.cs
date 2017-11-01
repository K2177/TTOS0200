using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Tht02
    {
        static void Main()
        {
            try
            {
                var nameCount = new Dictionary<string, int>();
                var lineCount = File.ReadLines(@"D:\Temp\nimet.txt").Count();
                foreach (String s in File.ReadAllLines(@"D:\Temp\nimet.txt"))
                {
                    if (nameCount.ContainsKey(s))
                    {
                        nameCount[s] = nameCount[s] + 1;
                    }
                    else
                    {
                        nameCount.Add(s, 1);
                    }
                }
                Console.WriteLine("{0} riviä, {1} nimeä", lineCount, nameCount.Count);
                foreach (var pair in nameCount)
                {
                    Console.WriteLine("Nimi {0} esiintyy {1} kertaa", pair.Key, pair.Value);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File (nimet.txt) not found!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}