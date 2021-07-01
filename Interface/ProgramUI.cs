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
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                int PlayerA = 0;
                int PlayerB = 0;
                Console.WriteLine(
                    "1. Play an entire Game of War and see the winner.\n" +
                    "2. See current winner standings for multiple games. \n" +
                    "3. Exit.");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Queue<int> playingDeck = deck.ShuffleDeck(deck.CreateDeck());
                        Queue<int>[] game = deck.Deal(playingDeck);
                        deck.Game(game[0], game[1]);
                        break;

                    case "2":
                        Console.WriteLine(PlayerA.ToString());
                        Console.WriteLine(PlayerB.ToString());
                        Console.ReadLine();

                        break;
                    case "3":
                        isRunning = false;
                        break;


                }

            }

        }
    }
}
