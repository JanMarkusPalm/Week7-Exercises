using System;

namespace ducksong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"{i} little ducks went swimming one day, Over the hill and far away, mother duck said, quack quack quack, quack but only {i - 1} ducks came back!");
                Console.WriteLine("");
                if (i == 1)
                {
                    Console.WriteLine("1 little duck went swimming one day, Over the hill and far away, mother duck said, quack quack quack, quack but no little ducks came back!");
                    Console.WriteLine("");
                    Console.WriteLine("Sade mother duck went out one day over the hill and far away, the sad mother duck said, quack quack quack quack and all of the 5 little ducks came back!");
                }
            }
        }
    }
}
