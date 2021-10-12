using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestage oma eesnimi");
            string NIMI1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Palun sisestage oma perekonna nimi");
            string NIMI2 = Console.ReadLine().ToUpper();

            Console.WriteLine($"Tere, {NIMI1[0]}. {NIMI2[0]}.!");
        }
    }
}
