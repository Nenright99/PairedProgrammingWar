using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class War
    {
        //Create deck
        public List<int> CreateDeck()
        {
            List<int> _deck = new List<int>();
            for (int i = 1; i <= 52; i++)
            {
                _deck.Add(i);;
            }
            return _deck;
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
        public Queue<int>[] Deal(Queue<int> _deck)
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
            Queue<int>[] game = { DeckA, DeckB };
            return game;

        }

        public Queue<int>[] Hand(Queue<int> playerA, Queue<int> playerB)
        {
            Queue<int> hand = new Queue<int>();
            int handA = playerA.Dequeue();
            int handB = playerB.Dequeue();
            hand.Enqueue(handA);
            hand.Enqueue(handB);
            Compare(handA, handB, hand, playerA, playerB);
            Queue<int>[] game = { playerA, playerB };
            return game;
        }

        public Queue<int>[] Compare(int handA, int handB, Queue<int> hand, Queue<int> playerA, Queue<int> playerB)
        {
            if (handA > handB)
            {
                bool isRunning = true;
                while (isRunning)
                {
                    int card = hand.Dequeue();
                    playerA.Enqueue(card);
                    if (hand.Count() == 0)
                    {
                        isRunning = false;
                    }
                }
                Queue<int>[] game = { playerA, playerB };
                return game;
            }
            else if (handB > handA)
            {
                bool isRunning = true;
                while (isRunning)
                {
                    int card = hand.Dequeue();
                    playerB.Enqueue(card);
                    if (hand.Count() == 0)
                    {
                        isRunning = false;
                    }
                }
                Queue<int>[] game = { playerA, playerB };
                return game;
            }
            else if (handA == handB)
            {
                int d1 = playerA.Dequeue();
                int d2 = playerB.Dequeue();
                int d3 = playerA.Dequeue();
                int d4 = playerB.Dequeue();
                int warA = playerA.Dequeue();
                int warB = playerB.Dequeue();
                hand.Enqueue(d1);
                hand.Enqueue(d2);
                hand.Enqueue(d3);
                hand.Enqueue(d4);
                hand.Enqueue(warA);
                hand.Enqueue(warB);
                Queue<int>[] game = Compare(warA, warB, hand, playerA, playerB);
                return game;

            }
            else
            {
                Queue<int>[] game = { playerA, playerB };
                return game;
            }
        }


        public void Game(Queue<int> playerA, Queue<int> playerB)
        {
            Hand(playerA, playerB);
        }

    }

}