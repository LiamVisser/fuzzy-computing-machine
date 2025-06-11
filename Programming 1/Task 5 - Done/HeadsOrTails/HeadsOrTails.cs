namespace HeadsOrTails
{
    internal class HeadsOrTails
    {
        static void Main()
        {
            int coinFlip, scoreUser, scoreProgram;
            char coin, input;
            string winner;
            Random rand = new Random();

            scoreUser = 0;
            scoreProgram = 0;
            Console.WriteLine("This is a game of Heads or tails");

            /*Round 1*/
            Console.Write("To play simply enter in an input of 'h' or 't'.      ");
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
                scoreUser = scoreUser + 1;
                Console.WriteLine($"Your score: {scoreUser}\nComputers score: {scoreProgram}");
            }
            else
            {
                Console.WriteLine($"The coin landed on {coin}. You lose!");
                scoreProgram = scoreProgram + 1;
                Console.WriteLine($"Your score: {scoreUser}\nComputers score: {scoreProgram}");
            }

            /*Round 2*/

            Console.Write("Round 2! Please enter in an input of 'h' or 't'.     ");
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
                scoreUser = scoreUser + 1;
                Console.WriteLine($"Your score: {scoreUser}\nComputers score: {scoreProgram}");
            }
            else
            {
                Console.WriteLine($"The coin landed on {coin}. You lose!");
                scoreProgram = scoreProgram + 1;
                Console.Write($"Your score: {scoreUser}\nComputers score: {scoreProgram}");
            }

            /*Round 3*/

            Console.Write("Final Round! Please enter in an input of 'h' or 't'.     ");
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
                scoreUser = scoreUser + 1;
                Console.WriteLine($"Your score: {scoreUser}\nComputers score: {scoreProgram}");
            }
            else
            {
                Console.WriteLine($"The coin landed on {coin}. You lose!");
                scoreProgram = scoreProgram + 1;
                Console.WriteLine($"Your score: {scoreUser}\nComputers score: {scoreProgram}");
            }

            if (scoreUser > scoreProgram) 
            {
                Console.WriteLine("You win! Congratulations.");
            }
            else if (scoreUser < scoreProgram)
            {
                Console.WriteLine("You lose. Trust me, it's not rigged");
            }


            Console.WriteLine("The game has ended. Please press [Enter] to close the program...");
            Console.ReadLine();
        }
    }
}
