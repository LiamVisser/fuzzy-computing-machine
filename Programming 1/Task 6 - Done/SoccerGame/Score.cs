namespace SoccerGame
{
    internal class Score
    {
        static void Main()
        {
            int numOne, numTwo, numThree, team1, team2;
            Random rand = new Random();

            /*
            Console.WriteLine("You are going to enter in a dequence of numbers and I will tell you whether or not it is entered in sequential order or not");
            Console.WriteLine("Please enter in the first number...");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in the second number...");
            numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in the third and final number");
            numThree = Convert.ToInt32(Console.ReadLine());

            if (numOne >= numTwo && numTwo >= numThree)
            {
                Console.WriteLine("You entered in the numbers in descending order");
            }
            else if (numOne <= numTwo && numTwo <= numThree)
            {
                Console.WriteLine("You entered in the numbers in ascending order");
            }
            else
            {
                Console.WriteLine("You entered in the numbers in a random order");
            }
            Console.WriteLine("Please press [Enter] to move on to the next task...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You are going to be entering in some numbers and we will see if they are odd or not");
            Console.WriteLine("Please enter in the first number...");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now the next one...");
            numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And the final one...");
            numThree = Convert.ToInt32(Console.ReadLine());
            if (numOne % 2 == 1 && numTwo % 2 == 1 && numThree % 2 == 1)
            {
                Console.WriteLine("All of your numbers are odd");
            }
            else
            {
                Console.WriteLine("All of your numbers are NOT odd");
            }
            Console.WriteLine("Please press [Enter] to move on to the next task...");
            Console.ReadLine();
            Console.Clear();
            */
            Console.WriteLine("This is a soccor match. We will see if your team wins, loses, or draws against the enemy team.");
            Console.ReadLine();
            team1 = rand.Next(10);
            team2 = rand.Next(10);

            if (team1 > team2)
            {
                Console.WriteLine($"Your team lost! The enemy team scored {team1} points whereas your team scored {team2}.");
            }
            else if (team1 < team2)
            {
                Console.WriteLine($"Your team wins! The enemy team scored {team1} but you scored {team2}.");
            }
            else
            {
                Console.WriteLine($"Your team drew! You both scored {team1}");
            }
            Console.WriteLine("Please press [Enter] to finish this program");
            Console.ReadLine();
        }
    }
}