using System;

namespace LokaleNr
{
    class Program
    {
        static void Main(string[] args)
        {
            // start op
            Console.WriteLine("Din Lokale-nummer-vejleder");

            // indlæsning
            Console.Write("Indtast venligst bygning: ");
            string bygning = Console.ReadLine();

            Console.Write("Indtast venligst etage: ");
            string etage = Console.ReadLine();

            Console.Write("Indtast venligst nummer: ");
            string nummer = Console.ReadLine();

            // validering
            // gemmer jeg til senere, når vi har kigget på if/else

            //udskrivning
            Console.WriteLine("Lokalet du søger er {0}.{1}{2}", bygning, etage, nummer);
        }
    }
}
