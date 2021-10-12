using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on su eesnimi");
            string NIMI = Console.ReadLine();
            
            if (NIMI.Length >= 5)
            {
                for (int i = NIMI.Length - 1; i >= 1; i--)
                {
                    Console.WriteLine(NIMI[i]);
                }

            }
            else
            {
                Console.WriteLine(NIMI);
            }


        }
    }
}
