namespace rng
{
    internal class random
    {
        static void Main()
        {
            int balance, posNeg, coinFlip;
            char coin, input;
            Random rand = new Random(); /*How random is random?*/
            Console.WriteLine("Generating bank balance...");
            Console.ReadLine();
            balance = rand.Next(1001);
            posNeg = rand.Next(2);

            if (posNeg == 0)
            {
                Console.WriteLine($"Your card has declined. You owe us {balance:C}.");
                balance = balance * -1;
            }
            else
            {
                Console.WriteLine("You have a positive balance.");
            }
            Console.Write($"Your balance is {balance:C}");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("This is a game of Heads or tails");
            Console.WriteLine("To play simply enter in an input of 'h' or 't'.");
            input = Convert.ToChar(Console.ReadLine());
            coinFlip = rand.Next(2);
            if (coinFlip == 0)
            {
                coin = 'h';
            }
            else
            {
                coin = 't';
            }


            Console.WriteLine("The coin has been cast...");
            if (coin == input)
            {
                Console.WriteLine($"The coin landed on {coin}. You win!");
            }
            else 
            { 
                Console.WriteLine($"The coin landed on {coin}. You lose!");
            }
            Console.WriteLine("The game has ended. Please press [Enter] to close the program...");
            Console.ReadLine();
        }
    }
}
