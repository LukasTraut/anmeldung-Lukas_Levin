using System;
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
            string a = Console.ReadLine();
            if (a == "a" || a == "A") ;
        }
    }
}
