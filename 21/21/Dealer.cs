using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21
{
    class Dealer: Cards
    {
        
        List<Cards> cards = new List<Cards>();

        public int hand;
        Random rand = new Random();

        public Dealer(int hand = 0):base()
        {
            this.hand = hand;
        }
        public void ShuffleCards()
        {
            for (int i = 0; i < 52; i++)
            {
                Cards card = new Cards();
                cards.Add(card);

            }
            int b = 2;
            foreach (Cards a in cards)
            {
                if (b <= 14)
                {
                    a.value += b;
                }
                else if (b >= 14)
                {
                    b = 2;
                    a.value += b;
                }
                b++;
            }
            var shuffleList = cards.OrderBy(a => rand.Next(0, 53)).ToList();
            cards = shuffleList;
        }

        public int Deal()
        {
            int a = rand.Next(0, 52);
            return cards[a].value;
        }
    }
}