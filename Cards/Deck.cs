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
        public void CreateDeck()
        {
            Queue<int> _deck = new Queue<int>();
            for(int i = 1; i <= 52; i++)
            {
                _deck.Enqueue(i);
                Console.WriteLine(i.ToString());
            }
        }
        //Shuffle
        //Deal

    }
}
