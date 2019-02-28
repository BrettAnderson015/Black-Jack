using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack2
{
    public partial class Form1 : Form
    {
        public List<Player> Players = new List<Player>();
        public List<Card> Deck = new List<Card>();
        public List<ListBox> PlayersHandsListBoxesList = new List<ListBox>();
        public List<TextBox> PlayerScoreTextBoxesList = new List<TextBox>();
        public List<TextBox> MoneyBoxesList = new List<TextBox>();
        int hitIndex = 0;
        

        public Form1()
        {
            InitializeComponent();
            Deck = CreateDeck();
            PlayerScoreTextBoxesList.Add(PlayerOneScoreBox);
            PlayerScoreTextBoxesList.Add(PlayerTwoScoreBox);
            PlayerScoreTextBoxesList.Add(PlayerThreeScoreBox);
            PlayerScoreTextBoxesList.Add(PlayerFourScoreBox);
            PlayerScoreTextBoxesList.Add(DealerScoreBox);

            PlayersHandsListBoxesList.Add(PlayerOneListBox);
            PlayersHandsListBoxesList.Add(PlayerTwoListBox);
            PlayersHandsListBoxesList.Add(PlayerThreeListBox);
            PlayersHandsListBoxesList.Add(PlayerFourListBox);
            PlayersHandsListBoxesList.Add(DealerListBox);

            MoneyBoxesList.Add(P1MoneyBox);
            MoneyBoxesList.Add(P2MoneyBox);
            MoneyBoxesList.Add(P3MoneyBox);
            MoneyBoxesList.Add(P4MoneyBox);
        }

        public void DetermineWinners()
        {
            int dealerIndex = Players.Count - 1;
            for(int i = 0; i < Players.Count - 1; i++)
            {
                if(Players[i].Score > Players[dealerIndex].Score)
                {
                    MessageBox.Show($"{Players[i].Name} wins!");
                    Players[i].Money += 2;
                    MoneyBoxesList[i].Text = Players[i].Money.ToString();
                }
                else if(Players[i].Score == Players[dealerIndex].Score && Players[dealerIndex].Score > 0)
                {
                    MessageBox.Show($"{Players[i].Name} ties.");
                    Players[i].Money += 1;
                    MoneyBoxesList[i].Text = Players[i].Money.ToString();
                }
                    
                else
                    MessageBox.Show($"{Players[i].Name} loses.");
            }
            MessageBox.Show("Winnings have been distributed.");
        }

        public void PlaceBets()
        {
            for(int i = 0; i < Players.Count - 1; i++)
            {
                Players[i].Money -= 1;
            }
        }

        public void DisplayMoney()
        {
            for(int i = 0; i < Players.Count - 1; i++)
            {
                MoneyBoxesList[i].Text = Players[i].Money.ToString();
            }
        }

        public void Hit()
        {
            for(int i = 0; i < Players.Count - 1; i++)
            {
                if (Players[i].Active == true)
                {
                    Players[i].Hand.Add(Deck[hitIndex]);
                    PlayersHandsListBoxesList[i].Items.Add(Players[i].Hand.Last().Rank);
                }
            }
            hitIndex++;
            ScorePlayer();
        }

        public void DisplayDealerHand()
        {
            foreach (Card c in Players[Players.Count - 1].Hand)
            {
                PlayersHandsListBoxesList[4].Items.Add(c.Rank);
            }
        }

        public void HitDealer()
        {
            if (Players[Players.Count - 1].Active == true)
            {
                Players[Players.Count - 1].Hand.Add(Deck[hitIndex]);
                PlayersHandsListBoxesList[4].Items.Add(Players[Players.Count - 1].Hand.Last().Rank);
            }
            hitIndex++;
            ScoreDealer();
        }

        public void ScorePlayer()
        {
            for(int i = 0; i < Players.Count - 1; i++)
            {
                Players[i].Score = 0;
                foreach (Card c in Players[i].Hand)
                {
                    switch (c.Rank)
                    {
                        case Rank.Jack:
                            Players[i].Score += 10;
                            break;
                        case Rank.Queen:
                            Players[i].Score += 10;
                            break;
                        case Rank.King:
                            Players[i].Score += 10;
                            break;
                        case Rank.Ace:
                            Players[i].Score += 11;
                            break;
                        default:
                            Players[i].Score += (int)c.Rank;
                            break;
                    }
                }
                if (Players[i].Score > 21)
                {

                    bool contains = Players[i].Hand.Any(p => p.Rank == Rank.Ace);
                    if (contains)
                    {
                        int aceIndex = Players[i].Hand.FindIndex(q => q.Rank == Rank.Ace);
                        Players[i].Hand[aceIndex].Rank = Rank.LowAce;
                        Players[i].Score = 0;
                        foreach (Card c in Players[i].Hand)
                        {
                            switch (c.Rank)
                            {
                                case Rank.Jack:
                                    Players[i].Score += 10;
                                    break;
                                case Rank.Queen:
                                    Players[i].Score += 10;
                                    break;
                                case Rank.King:
                                    Players[i].Score += 10;
                                    break;
                                case Rank.Ace:
                                    Players[i].Score += 11;
                                    break;
                                default:
                                    Players[i].Score += (int)c.Rank;
                                    break;
                            }
                        }
                        PlayerScoreTextBoxesList[i].Text = Players[i].Score.ToString();
                    }
                    else
                    {
                        Players[i].Score = 0;
                        PlayerScoreTextBoxesList[i].Text = ("Busted");
                    } 
                }
                else
                    PlayerScoreTextBoxesList[i].Text = Players[i].Score.ToString();
            }
        }

        public void ScoreDealer()
        {
            int dealerIndex = Players.Count - 1;
            Players[dealerIndex].Score = 0;
            foreach (Card c in Players[dealerIndex].Hand)
            {
                switch (c.Rank)
                {
                    case Rank.Jack:
                        Players[dealerIndex].Score += 10;
                        break;
                    case Rank.Queen:
                        Players[dealerIndex].Score += 10;
                        break;
                    case Rank.King:
                        Players[dealerIndex].Score += 10;
                        break;
                    case Rank.Ace:
                        Players[dealerIndex].Score += 11;
                        break;
                    default:
                        Players[dealerIndex].Score += (int)c.Rank;
                        break;
                }
            }
            if (Players[dealerIndex].Score > 21)
            {

                bool contains = Players[dealerIndex].Hand.Any(p => p.Rank == Rank.Ace);
                if (contains)
                {
                    int aceIndex = Players[dealerIndex].Hand.FindIndex(q => q.Rank == Rank.Ace);
                    Players[dealerIndex].Hand[aceIndex].Rank = Rank.LowAce;
                    Players[dealerIndex].Score = 0;
                    foreach (Card c in Players[dealerIndex].Hand)
                    {
                        switch (c.Rank)
                        {
                            case Rank.Jack:
                                Players[dealerIndex].Score += 10;
                                break;
                            case Rank.Queen:
                                Players[dealerIndex].Score += 10;
                                break;
                            case Rank.King:
                                Players[dealerIndex].Score += 10;
                                break;
                            case Rank.Ace:
                                Players[dealerIndex].Score += 11;
                                break;
                            default:
                                Players[dealerIndex].Score += (int)c.Rank;
                                break;
                        }
                    }
                    PlayerScoreTextBoxesList[dealerIndex].Text = Players[dealerIndex].Score.ToString();
                }
                else
                {
                    Players[dealerIndex].Score = 0;
                    PlayerScoreTextBoxesList[4].Text = ("Busted");
                }
            }
            else
                PlayerScoreTextBoxesList[4].Text = Players[dealerIndex].Score.ToString();
        }

        public void Deal()              
        {
            Shuffle();
            int j = 0;
            for (int i = 0; i < 2; i++)
            {
                foreach (Player p in Players)
                {
                    p.Hand.Add(Deck[j]);
                    j++;
                }
            }
            
            for (int playerIndex = 0; playerIndex < Players.Count - 1; playerIndex++)
            {
                for (int cardIndex = 0; cardIndex < Players[playerIndex].Hand.Count; cardIndex++)
                {
                    PlayersHandsListBoxesList[playerIndex].Items.Add(Players[playerIndex].Hand[cardIndex].Rank);
                }
            }
            ScorePlayer();
            PlaceBets();
            DisplayMoney();
            hitIndex = Players.Count * 2;
        }

        public List<Player> AddPlayer()
        {
            Player p = new Player(AddPlayerTextBox.Text);
            Players.Add(p);

            int numberOfPlayers = Players.Count();
            switch (numberOfPlayers)
            {
                case 1:
                    PlayerOneNameTextBox.Text = AddPlayerTextBox.Text;
                    break;
                case 2:
                    PlayerTwoNameTextBox.Text = AddPlayerTextBox.Text;
                    break;
                case 3:
                    PlayerThreeNameTextBox.Text = AddPlayerTextBox.Text;
                    break;
                case 4:
                    PlayerFourNameTextBox.Text = AddPlayerTextBox.Text;
                    break;
            }
            AddPlayerTextBox.Clear();
            
            if (Players.Count == 4)
            {
                AddDealer();
                AddPlayerButton.Enabled = false;
                FinishedAddingPlayersButton.Enabled = false;
                DealButton.Enabled = true;
            }
            return Players;
        }

        public void AddDealer()
        {
            Player p = new Player("Dealer");
            Players.Add(p);
        }

        public List<Card> CreateDeck()
        {
            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                if(r != Rank.LowAce)
                {
                    foreach (Suit s in Enum.GetValues(typeof(Suit)))
                    {
                        var card = new Card(r, s);
                        Deck.Add(card);
                    }
                }
                
            }
            return Deck;
        }

        public void Shuffle()
        {
            Random r = new Random();
            for(int i = 0; i < Deck.Count; i++)
            {
                int randomIndex = r.Next(0, Deck.Count);
                Card temp1 = Deck[i];
                Card temp2 = Deck[randomIndex];
                Deck[i] = temp2;
                Deck[randomIndex] = temp1;
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGameButton.Enabled = false;
            NewRoundButton.Enabled = false;
            AddPlayerButton.Enabled = true;
            Players.Clear();
            for(int i = 0; i < 5; i++)
            {
                PlayersHandsListBoxesList[i].Items.Clear();
                PlayerScoreTextBoxesList[i].Clear();
            }
            for(int i = 0; i < 4; i++)
            {
                MoneyBoxesList[i].Clear();
            }
        }

        private void AddPlayerButton_MouseClick(object sender, MouseEventArgs e)
        {
            AddPlayer();
            if(Players.Count < 4)
                FinishedAddingPlayersButton.Enabled = true;
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            Deal();
            DealButton.Enabled = false;
            P1HitButton.Enabled = true;
            P1StandButton.Enabled = true;
        }

        private void FinishedAddingPlayersButton_Click(object sender, EventArgs e)
        {
            AddDealer();
            AddPlayerButton.Enabled = false;
            FinishedAddingPlayersButton.Enabled = false;
            DealButton.Enabled = true;
        }

        private void P1HitButton_Click(object sender, EventArgs e)
        {
            Players[0].Active = true;
            Hit();
            if(Players[0].Score == 0)
            {
                Players[0].Active = false;
                P1HitButton.Enabled = false;
                P1StandButton.Enabled = false;
                if (Players.Count > 2)
                {
                    P2HitButton.Enabled = true;
                    P2StandButton.Enabled = true;
                }
                else
                    DealerStartButton.Enabled = true;
            }
                
        }

        private void P2HitButton_Click(object sender, EventArgs e)
        {
            Players[1].Active = true;
            Hit();
            if (Players[1].Score == 0)
            {
                Players[1].Active = false;
                P2HitButton.Enabled = false;
                P2StandButton.Enabled = false;
                if (Players.Count > 3)
                {
                    P3HitButton.Enabled = true;
                    P3StandButton.Enabled = true;
                }
                else
                    DealerStartButton.Enabled = true;
            }
        }

        private void P3HitButton_Click(object sender, EventArgs e)
        {
            Players[2].Active = true;
            Hit();
            if(Players[2].Score == 0)
            {
                Players[2].Active = false;
                P3HitButton.Enabled = false;
                P3StandButton.Enabled = false;
                if (Players.Count > 4)
                {
                    P4HitButton.Enabled = true;
                    P4StandButton.Enabled = true;
                }
                else
                    DealerStartButton.Enabled = true;
            }
        }

        private void P4HitButton_Click(object sender, EventArgs e)
        {
            Players[3].Active = true;
            Hit();
            if(Players[3].Score == 0)
            {
                Players[3].Active = false;
                P4HitButton.Enabled = false;
                P4StandButton.Enabled = false;
                DealerStartButton.Enabled = true;
            }
        }

        private void P1StandButton_Click(object sender, EventArgs e)
        {
            Players[0].Active = false;
            P1HitButton.Enabled = false;
            P1StandButton.Enabled = false;
            if (Players.Count > 2)
            {
                P2HitButton.Enabled = true;
                P2StandButton.Enabled = true;
            }
            else
                DealerStartButton.Enabled = true;
        }

        private void P2StandButton_Click(object sender, EventArgs e)
        {
            Players[1].Active = false;
            P2HitButton.Enabled = false;
            P2StandButton.Enabled = false;
            if(Players.Count > 3)
            {
                P3HitButton.Enabled = true;
                P3StandButton.Enabled = true;
            }
            else
                DealerStartButton.Enabled = true;
        }

        private void P3StandButton_Click(object sender, EventArgs e)
        {
            Players[2].Active = false;
            P3HitButton.Enabled = false;
            P3StandButton.Enabled = false;
            if(Players.Count > 4)
            {
                P4HitButton.Enabled = true;
                P4StandButton.Enabled = true;
            }
            else
                DealerStartButton.Enabled = true;
        }

        private void P4StandButton_Click(object sender, EventArgs e)
        {
            Players[3].Active = false;
            P4HitButton.Enabled = false;
            P4StandButton.Enabled = false;
            DealerStartButton.Enabled = true;
        }

        private void DealerStartButton_Click(object sender, EventArgs e)
        {
            Players[Players.Count - 1].Active = true;
            DisplayDealerHand();
            ScoreDealer();
            DealerStartButton.Enabled = false;
            DealerContinueButton.Enabled = true;
        }

        private void DealerContinueButton_Click(object sender, EventArgs e)
        {
            ScoreDealer();
            
            if (Players[Players.Count - 1].Score > 0 && Players[Players.Count - 1].Score < 17)
            {
                HitDealer();
            }
            else if (Players[Players.Count - 1].Score >= 17)
            {
                MessageBox.Show("Dealer Stands");
                DealerContinueButton.Enabled = false;
                NewRoundButton.Enabled = true;
                NewGameButton.Enabled = true;
                DetermineWinners();
            }
            else
            {
                MessageBox.Show("Dealer Busts.");
                DealerContinueButton.Enabled = false;
                NewRoundButton.Enabled = true;
                NewGameButton.Enabled = true;
                DetermineWinners();
            }
        }

        private void NewRoundButton_Click(object sender, EventArgs e)
        {
            NewGameButton.Enabled = false;
            NewRoundButton.Enabled = false;
            for(int i = 0; i < Players.Count - 1; i++)
            {
                Players[i].Hand.Clear();
                PlayersHandsListBoxesList[i].Items.Clear();
                PlayerScoreTextBoxesList[i].Clear();
            }
            Players[Players.Count - 1].Hand.Clear();
            PlayersHandsListBoxesList[4].Items.Clear();
            PlayerScoreTextBoxesList[4].Clear();
            DealButton.Enabled = true;
        }
    }
}
