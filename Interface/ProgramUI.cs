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
        Deck deck = new Deck();
public void run() { deck.Deal(deck.ShuffleDeck(deck.CreateDeck())); }
    }
}
