using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public enum SuitType
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
    public enum CardValueType
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public class Card
    {

        public SuitType Suit { get; set; }
        public CardValueType CardValue {  get; set; }

        public Card(SuitType suit, CardValueType cardvalue)
        {
            Suit = suit;
            CardValue = cardvalue;
        }
        public override string ToString()
        {
            return $"{CardValue} of {Suit}";
        }
    }
}
