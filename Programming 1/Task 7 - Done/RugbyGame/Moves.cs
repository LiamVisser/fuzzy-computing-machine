namespace RugbyGame
{
    internal class Moves
    {
        static void Main()
        {
            int teamOne, teamTwo;
            Random rand = new Random();

            Console.WriteLine("This is the first two moves of a rugby game");
            Console.WriteLine("Press enter to start the game");
            Console.ReadLine();

            teamOne = rand.Next(0, 8);
            switch (teamOne)
            {
                case 0:
                    Console.WriteLine("Team One was tackled and lost the ball");
                    break;
                case 1:
                    Console.WriteLine("Team One was tackled and lost the ball");
                    teamOne = 0;
                    break;
                case 2:
                    Console.WriteLine("Team One was tackled and lost the ball");
                    teamOne = 0;
                    break;
                case 3:
                    Console.WriteLine("Team One scored a goal and earned 3 points");
                    break;
                case 4:
                    Console.WriteLine("Team One was tackled and lost the ball");
                    teamOne = 0;
                    break;
                case 5:
                    Console.WriteLine("Team One scored a try and earned 5 points");
                    break;
                case 6:
                    Console.WriteLine("Team One was tackled and lost the ball");
                    teamOne = 0;
                    break;
                case 7:
                    Console.WriteLine("Team One scored a try and converted, earning 7 points");
                    break;
            }

            teamTwo = rand.Next(0, 8);
            switch (teamTwo)
            {
                case 0:
                    Console.WriteLine("Team Two was tackled and lost the ball");
                    break;
                case 1:
                    Console.WriteLine("Team Two was tackled and lost the ball");
                    teamTwo = 0;
                    break;
                case 2:
                    Console.WriteLine("Team Two was tackled and lost the ball");
                    teamTwo = 0;
                    break;
                case 3:
                    Console.WriteLine("Team Two scored a goal and earned 3 points");
                    break;
                case 4:
                    Console.WriteLine("Team Two was tackled and lost the ball");
                    teamTwo = 0;
                    break;
                case 5:
                    Console.WriteLine("Team Two scored a try and earned 5 points");
                    break;
                case 6:
                    Console.WriteLine("Team Two was tackled and lost the ball");
                    teamTwo = 0;
                    break;
                case 7:
                    Console.WriteLine("Team Two scored a try and converted, earning 7 points");
                    break;
            }

            Console.WriteLine($"The first 2 moves are over.\nTeam One scored {teamOne} points.\nTeam Two scored {teamTwo} points.");
            if (teamOne > teamTwo)
            {
                Console.WriteLine("Team One is taking the lead");
            }
            else if (teamTwo > teamOne)
            {
                Console.WriteLine("Team Two is taking the lead");
            }
            else
            {
                Console.WriteLine("The teams are at a tie");
            }
            Console.ReadLine();
        }
    }
}
