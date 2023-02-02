using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21
{
    public class Game
    {
        Player player1 = new Player("Victor", 50, 0);
        Dealer dealer = new Dealer();
        List<Cards> cards = new List<Cards>();       
        
        public static void Run()
        {
            for(int i = 0; i < 52; i++)
            {
                Cards card = new Cards();
                
            }
        }
    }
}