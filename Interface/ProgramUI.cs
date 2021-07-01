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
            Queue<int> playingDeck = deck.ShuffleDeck(deck.CreateDeck());
            Queue<int>[] game = deck.Deal(playingDeck);
            deck.Game(game[0], game[1]);

        }
    }
}

