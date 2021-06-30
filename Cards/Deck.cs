using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Deck
    {
        //Create deck

        
        public List<int> CreateDeck()
        {
            List<int> _deck = new List<int>();
            for(int i = 1; i <= 52; i++)
            {
                _deck.Add(i);
            }
            return _deck;
        }
        //Shuffle

        public Queue<int> ShuffleDeck(List<int> deck)
        {
            Random rnd = new Random();
            int card = rnd.Next(51);
            Queue<int> playingDeck = new Queue<int>();
            int x = card + 1;
            playingDeck.Enqueue(x);
            return playingDeck;
        }
        //Deal

    }
}
