using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class Deck
    {
        public List<Card> deck { get; set; }
        private int currentCard;
        private const int maxCards = 52;
        private Random ranNum;

        public Deck()
        {
            deck = new List<Card>();
            currentCard = 0;

            int x = 0;
            for (int i = 0; i < Enum.GetValues(typeof(SuitType)).Length; i++)
            {
                for (int j = 0; j < Enum.GetValues(typeof(CardValueType)).Length; j++, x++)
                {
                    var card = new Card((SuitType) i, (CardValueType) j);
                    deck.Add(card);
                }
            }
        }

        public void printDeck()
        {
            foreach (var card in deck)
            {
                Console.WriteLine(card);
            }
        }

        public void Shuffle()
        {
            ranNum = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = ranNum.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }
        public Card DealCard()
        {
            if (currentCard < deck.Count)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
