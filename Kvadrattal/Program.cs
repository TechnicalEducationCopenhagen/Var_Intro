using System;

namespace Kvadrattal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kvadrattalsberegner!");

            Console.Write("Indtast venligst et tal vi kan kvadrere: ");
            string talStr = Console.ReadLine();
            double tal = Convert.ToDouble(talStr);

            double kvadrat;
            kvadrat = Math.Pow(tal, 2);
            // kunne også være:
            // double kvadrat = tal * tal;

            Console.WriteLine("Kvadratet på {0} er: {1}", tal, kvadrat);
        }
    }
}
