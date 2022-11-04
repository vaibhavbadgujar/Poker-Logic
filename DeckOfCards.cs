using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class DeckOfCards : Card
    {
        const int NUM_OF_CARDS = 52; // number of all cards
        private Card[] deck; // array of all playing cards

        public DeckOfCards()
        {
            deck = new Card[NUM_OF_CARDS];
        }

        public Card[] getDeck { get { return deck; } } //get current deck

        //create deck of 52 cards: 13 values each, with 4 suit
        public void setUpDeck()
        {
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;
                }
            }
            ShuffleCards();
        }
        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;

            //run the shuffle 1000 times
            for (int shuffleTime = 0; shuffleTime < 1000; shuffleTime++)
            {
                for(int i = 0; i < NUM_OF_CARDS; i++)
                {
                    // swap the cards
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }

        }

    }
}
