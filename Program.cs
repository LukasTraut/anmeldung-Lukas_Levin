using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace anmeldung_Lukas_Levin
{
    internal class Program
    {
        const string dataPath = @"C:\Users\levin\OneDrive - sluz\Basislehrjahr\Datenmodelieren\Anmeldungen\Anmeldung_readeble.csv";
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(dataPath); 
            Console.WriteLine("Test");
            Console.Write(lines);

            Console.WriteLine("*** Anmeldung verwalten ***");
            Console.WriteLine("Menu: a = Anmeldungen anzeigen, n = Neue Anmeldung, g = Gebrauchte Vorlesungen");
            string menu = Console.ReadLine();
            
            
            
            if (menu == "a" || menu == "A") {
                for (int i = 0; i < lines.Length; i++)
                {
                    
                }
            }
            else if (menu == "n" || menu == "N")
            {
                string addCsv = newUser();
                File.AppendAllText(dataPath, "\n" + addCsv);
                

            }
        }
        static string newUser () {
            string n = Console.ReadLine();
            
            Console.WriteLine("Neue Anmeldung:");
            Console.Write("Vorname: ");
            string name = Console.ReadLine();
            Console.Write("Nachname: ");
            string sirname = Console.ReadLine();
            Console.Write("Geschlecht (M/W): ");
            string gender = Console.ReadLine();
            Console.Write("Telefon: ");
            string phonenumber = Console.ReadLine();
            Console.Write("Geburtsdatum: ");
            string birthday = Console.ReadLine();
            Console.Write("Vorlesung: ");
            string vorlesung=Console.ReadLine();
            string addCsv = name + ";" + sirname +";"+gender+ ";" + phonenumber + ";" + vorlesung + ";" + birthday;
            return addCsv;
            

        }
    }
}
