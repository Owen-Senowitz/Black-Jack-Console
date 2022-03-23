using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int maxCards = 52;
        private Random ranNum;

        public Deck()
        {
            deck = new Card[maxCards];
            currentCard = 0;
            ranNum = new Random();

            int x = 0;
            for (int i = 0; i < Enum.GetValues(typeof(SuitType)).Length; i++)
            {
                for (int j = 0; j < Enum.GetValues(typeof(CardValueType)).Length; j++, x++)
                {
                    deck[x] = new Card((SuitType) i, (CardValueType) j);
                    if (j == 13)
                        break;
                }
            }
        }
        public void Shuffle()
        {
            currentCard = 0;
            for (int i = 0; i < deck.Length; i++)
            {
                int second = ranNum.Next(maxCards);
                Card temp = deck[i];
                deck[i] = deck[second];
                deck[second] = temp;
            }
        }
        public Card DealCard()
        {
            if (currentCard < deck.Length)
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
