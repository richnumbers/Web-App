using System.Diagnostics.Contracts;

namespace DeckShuffle.Components.Modles
{
    public class Shuffle
    {
        

        Cards attack = new Cards(1, 5, 0, "Attack");
        Cards block = new Cards(1, 0, 5, "Block");
        Cards ShieldBash = new Cards(2, 3, 3, "Shield Bash");

        Cards swordSmash = new Cards(2, 12, 0, "SwordSmash");
        Cards HeltHit = new Cards(1, 6, 0, "heltHit");


        public List<Cards> Deck = new List<Cards>();
        public List<Cards> Graveyard = new List<Cards>();
        public List<Cards> Hand = new List<Cards>();

        

        private int deckSize => Deck.Count;
        private int GraveyardSize => Graveyard.Count;

        public int getDeckSize() { return deckSize; }
        public int getGraveyardSize() { return GraveyardSize; }

        public List<Cards> AddCards()
        {
            for (int i = 0; i < 5; i++)
            {
                Deck.Add(attack);
                Deck.Add(block);
            }
            Deck.Add(ShieldBash);
            return Deck;
        }

        public List<Cards> AddMonsterCards()
        {
            for (int i = 0; i < 5; i++)
            {
                Deck.Add(attack);

            }
            Deck.Add(swordSmash);
            Deck.Add(HeltHit);
            return Deck;
        }


        public List<Cards> shuffleDeck()
        {
            Random random = new Random();
            int n = Deck.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Cards value = Deck[k];
                Deck[k] = Deck[n];
                Deck[n] = value;
            }
            return Deck;
        }

        public void DrawCards()
        {
            while (Hand.Count < 5)
            {
                if (Deck.Count > 0)
                {
                    Hand.Add(Deck[0]);
                    Deck.RemoveAt(0);
                }
                else if (Graveyard.Count > 0)
                {
                    Deck = new List<Cards>(Graveyard);
                    Graveyard.Clear();
                    Deck = shuffleDeck();
                }
                else
                {
                    break; // no cards left anywhere
                }
            }
        }

        public void PlayCard(Cards card)
        {
            if (Hand.Count == 0) return;
            Graveyard.Add(card);
            Hand.Remove(card);
        }

        public List<Cards> GetHand()
        {
            return Hand;
        }

        public void EndTurn()
        {
            foreach (var card in Hand)
            {
                Graveyard.Add(card);
            }
            Hand.Clear();
            DrawCards();
        }
       
    }


}

