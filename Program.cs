﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace anmeldung_Lukas_Levin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText(@"C:\Users\levin\OneDrive - sluz\Basislehrjahr\Datenmodelieren\Anmeldungen\Anmeldung_readeble.csv");
            Console.WriteLine("Test");
            Console.Write(content);







            Console.WriteLine("*** Anmeldung verwalten ***");
            Console.WriteLine("Menu: a = Anmeldungen anzeigen, n = Neue Anmeldung, g = Gebrauchte Vorlesungen");
            string n = Console.ReadLine();
            if (content == "n" || content == "N")
            {



            }
        }
        static string newUser (string content) {
            string n = Console.ReadLine();
            
                Console.WriteLine("Neue Anmeldung:");
                Console.Write("Vorname: ");
                string name = Console.ReadLine();
                Console.Write("Nachname: ");
                string sirname = Console.ReadLine();
                Console.Write("Telefon: ");
                string phonenumber = Console.ReadLine();
                Console.Write("Geburtsdatum: ");
            string birthday = Console.ReadLine();
            Console.Write("Vorlesung: ");
            
        }
    }
}
