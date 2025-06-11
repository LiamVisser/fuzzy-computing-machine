namespace RockaPaperScissors
{
    internal class RPSGame
    {
        static void Main()
        {
            int randCons;
            char playerInput, consoleInput, playAgain;
            Random random = new Random();
            Console.WriteLine("This is a paper scissors rock game");
            Console.Write("Please enter in R, P, or S.  ");
            playerInput = Convert.ToChar(Console.ReadLine());
            consoleInput = 'X';

            randCons = random.Next(0,3);
            switch (randCons)
            {
                case 0:
                    consoleInput = 'R';
                    break;

                case 1:
                    consoleInput = 'P';
                    break;

                case 2:
                    consoleInput = 'S';
                    break;
            }
            Console.WriteLine($"You have chosen {playerInput}, and the console has chosen {consoleInput}");

            if (playerInput == consoleInput)
            {
                Console.WriteLine($"You draw!\nYou both picked {playerInput}.");
            }
            else if (playerInput == 'R' && consoleInput == 'S' || playerInput == 'P' && consoleInput == 'R' || playerInput == 'S' && consoleInput == 'P')
            {
                Console.WriteLine($"You won!\nYou picked {playerInput} and the console picked {consoleInput}.");
            }

            else
            {
               Console.WriteLine($"You lost!\nYou picked {playerInput} and the console picked {consoleInput}.");
            }
            Console.WriteLine("Do you want to play again? (Y/N or anything else)");
            playAgain = Convert.ToChar(Console.ReadLine());

            if (playAgain == 'Y')
            {
                Main();
            }
            else
            {
                Console.WriteLine("Okay. Please press [Enter] to close the program");
            }



            Console.ReadLine();
            }
    }
}
