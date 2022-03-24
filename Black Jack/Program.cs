using System;
using System.Threading;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.Shuffle();
            deck1.printDeck();
            Console.WriteLine("Dealing Card");
            Thread.Sleep(500);
            Console.WriteLine(deck1.DealCard().Score);
            
            Console.ReadLine();
        }
    }
}
