using System;

namespace App
{
    class program
    {
        static void Main(string[] args)
        {
            DrawCards.DrawCardOutLine(0, 0);

            Card card = new Card();
            card.MySuit = Card.SUIT.HEARTS;
            card.MyValue = Card.VALUE.ACE;
            DrawCards.DrawCardSuitValue(card, 0, 0);

            Console.ReadKey();
        }
    }
}