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
        public int Score
        {
            get
            {
                if (CardValue == CardValueType.Ace)
                {
                    return 11;
                }
                if (CardValue == CardValueType.King || CardValue == CardValueType.Queen || CardValue == CardValueType.Jack)
                {
                    return 10;
                }
                if (CardValue == CardValueType.Ten)
                {
                    return 10;
                }
                if (CardValue == CardValueType.Nine)
                {
                    return 9;
                }
                if (CardValue == CardValueType.Eight)
                {
                    return 8;
                }
                if (CardValue == CardValueType.Seven)
                {
                    return 7;
                }
                if (CardValue == CardValueType.Six)
                {
                    return 6;
                }
                if (CardValue == CardValueType.Five)
                {
                    return 5;
                }
                if (CardValue == CardValueType.Four)
                {
                    return 4;
                }
                if (CardValue == CardValueType.Three)
                {
                    return 3;
                }
                if (CardValue == CardValueType.Two)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

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
