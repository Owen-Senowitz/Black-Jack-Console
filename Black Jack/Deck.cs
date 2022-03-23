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
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            deck = new Card[maxCards];
            currentCard = 0;
            ranNum = new Random();
            for(int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(faces[i % 11], suits[i / 13]);
            }
        }
        public void Shuffle()
        {
            currentCard = 0;
            for(int i = 0; i < deck.Length; i++)
            {
                int second = ranNum.Next(maxCards);
                Card temp = deck[i];
                deck[i] = deck[second];
                deck[second] = temp;
            }
        }
        public Card DealCard()
        {
            if(currentCard < deck.Length)
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
