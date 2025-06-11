namespace Yahtzee
{
    internal class Program
    {
        static void Main()
        {
            //Check EvenDisplay in the Misc folder for the first task.
            int dice, scoreOne = 0, scoreTwo = 0, count = 0, userInput = 0; //Declaring and initializing variables
            Random rand = new Random();
            Console.WriteLine("You will be playing a round of Yahtzee. Press [Enter] to throw your die.");
            Console.ReadLine(); //Starts the game
            for (int i = 0; i < 5; i++) //Your 5 Yahtzee rolls
            {
                dice = rand.Next(1, 7); //rolls 1-6
                Console.WriteLine(dice);
                if (dice == 4)
                {
                    count++; //Takes the amount of 4's seen
                }
                scoreOne = 4 * count; //and multiplies it by 4
            }
            Console.ReadLine();
            Console.WriteLine($"Your total score is {scoreOne}. Lets see if you win or lose. Press [Enter] to roll for the second player");
            Console.ReadLine(); //Starts the second round
            count = 0;

            for (int i = 0; i < 5; i++) //Their 5 rolls. Does the same as above
            {
                dice = rand.Next(1, 7);
                Console.WriteLine(dice);
                if (dice == 4)
                {
                    count++;
                }
                scoreTwo = 4 * count;
            }
        Console.WriteLine($"The final scores are done. In total you got {scoreOne} points, and the second player got {scoreTwo} points."); //Reads out points
            if (scoreOne > scoreTwo) //If you win
            {
                Console.WriteLine("You win.");
            }
            else if (scoreOne == scoreTwo) //If you draw
            {
                Console.WriteLine("You draw");
            }
            else //If you lose
            {
                Console.WriteLine("You lose.");
            }
            Console.WriteLine("Would you like to play again? [1 = Yes / Any other number = No]");
            userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                default: 
                    break;
                case 1:
                    Console.Clear();
                    Main();
                    break;
            }
            Console.ReadLine();
        }
    }
}
