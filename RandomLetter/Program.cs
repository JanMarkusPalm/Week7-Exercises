using System;

namespace RandomLetter
{
    class Program
    {
        private static void Main(string[] args)
        {


            Console.WriteLine("Palun sisestage enda eesnimi");
            string NIMI = Console.ReadLine();


            Random rnd = new Random();

            int asi = rnd.Next(0, NIMI.Length - 1);
            Console.WriteLine(NIMI[asi]);
            
            //'a' and 'z' are interpreted as ints for parameters for Next()
            

        }
    }
}
