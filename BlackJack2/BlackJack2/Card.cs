using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack2
{
    public enum Suit { Hearts, Diamons, Clubs, Spades };
    public enum Rank { LowAce = 1, Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }

    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }
        
        public Card (Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
            
        }
    }
}
