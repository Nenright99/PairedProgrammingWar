using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Decks
    {
        public Decks() { }
        public Decks(Queue<int> deck)
        {
            Cards = deck;
        }
        Queue<int> Cards { get; set; }

        public void Add()
    }
}
