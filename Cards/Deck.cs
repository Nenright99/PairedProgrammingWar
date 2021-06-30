using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cards
{
    public class Deck
    {
       
          public List<int> CreateDeck()
        {

            {
                List<int> _deck = new List<int>();
                for (int i = 1; i <= 52; i++)
                {
                    _deck.Add(i);
                    Console.WriteLine(i.ToString());
                    _deck.Add(i);
                }
                return _deck;
            }
        }


        //Shuffle

        public Queue<int> ShuffleDeck(List<int> _deck)
        {
            bool isrunning = true;
            Queue<int> playingDeck = new Queue<int>();

            while (isrunning)
            {
                Random rnd = new Random();
                int card = rnd.Next(_deck.Count() - 1);
                int x = _deck[card];
                _deck.RemoveAt(card);
                playingDeck.Enqueue(x);
                if (_deck.Count == 0)
                {
                    isrunning = false;
                }
                else
                {

                }
            }
            return playingDeck;

        }

        //Deal
        public void Deal(Queue<int> _deck)
        {
            Queue<int> DeckA = new Queue<int>();
            Queue<int> DeckB = new Queue<int>();
            bool isrunning = true;
            while (isrunning)
            {
                int A = _deck.Dequeue();
                DeckA.Enqueue(A);
                int B = _deck.Dequeue();
                DeckB.Enqueue(B);
                if (_deck.Count == 0)
                {
                    isrunning = false;
                }
                else
                {

                }

            }
            Console.WriteLine($"PlayerA:{DeckA.Count()} PlayerB:{DeckB.Count()}");
            Console.ReadLine();

        }

    }

}
