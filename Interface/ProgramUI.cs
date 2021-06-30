using Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class ProgramUI
    {
        War deck = new War();
        public void run()
        {
            Decks playingDeck = new Decks(deck.ShuffleDeck(deck.CreateDeck()));
        }
    }
}

