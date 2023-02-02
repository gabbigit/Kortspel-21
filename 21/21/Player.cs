using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21
{
    class Player
    {
        public string name;
        public int chips;
        public int hand;

        public Player(string name, int chips, int hand)
        {
            this.name = name;
            this.chips = chips;
            this.hand = hand;
        }

        public void Bet()
        {
            Console.Write("How much would you bet?:> ");
            int input = Convert.ToInt32(Console.ReadLine());
            chips -= input;
        }

        public void HitMeOrHold()
        {
            throw new System.NotImplementedException();
        }

    }
}