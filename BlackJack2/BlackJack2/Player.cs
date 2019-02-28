using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack2
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Money { get; set; }
        public List<Card> Hand { get; set; }
        public bool IsDealer { get; set; }
        public bool Active { get; set; }

        //public static List<Player> Players = new List<Player>();

        public Player(string name)
        {
            Name = name;
            Money = 10;
            Hand = new List<Card>();
            IsDealer = false;
            Active = false;
        }
    }
}
