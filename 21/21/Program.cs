namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Victor", 50, 0);
            Dealer dealer = new Dealer();

            Console.WriteLine("BLACKJACK ISH");
            while(player1.chips >= 0)
            {
                dealer.ShuffleCards();
                player1.hand = dealer.Deal();
                Console.WriteLine($"Player card = {player1.hand}");
                Console.WriteLine($"Player chiptotal = {player1.chips}");
                player1.Bet();
            }

        }
    }
}