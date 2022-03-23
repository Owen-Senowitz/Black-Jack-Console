using System;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(deck1.DealCard());
            }
            Console.ReadLine();
        }
    }
}
