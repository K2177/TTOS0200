﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Tht01
    {
        static void Tehtava1()
        {
            //KÄYTTÄKÄÄ AINA TRY-CATCHIA
            try
            {
                string nimi;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\testi.txt";
                //Kirjoitetaan käyttäjän antamat rivit tiedostoon
                //Luodaan Streamwriter tyyppinen olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa): ");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                        sw.WriteLine(nimi);
                } while (nimi.Length != 0);
                sw.Close();
                //Avataan tiedosto uudestaan, luetaan sisältö ja näytetään konsolissa
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine(teksti);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}