namespace Rugby
{
    internal class score
    {
        static void Main()
        {
            int teamOne, teamOneTotal = 0, teamTwo, teamTwoTotal = 0;
            Random rand = new Random();

            Console.WriteLine("This is the first two moves of a rugby game");
            Console.WriteLine("Press enter to start the game");
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                teamOne = rand.Next(0, 8);
                switch (teamOne)
                {
                    default:
                        Console.WriteLine("Team One was tackled and lost the ball");
                        break;
                    case 3:
                        Console.WriteLine("Team One scored a goal and earned 3 points");
                        break;
                    case 5:
                        Console.WriteLine("Team One scored a try and earned 5 points");
                        break;
                    case 7:
                        Console.WriteLine("Team One scored a try and converted, earning 7 points");
                        break;
                }
                teamOneTotal = teamOneTotal + teamOne;


                teamTwo = rand.Next(0, 8);
                switch (teamTwo)
                {
                    default:
                        Console.WriteLine("Team Two was tackled and lost the ball");
                        break;
                    case 3:
                        Console.WriteLine("Team Two scored a goal and earned 3 points");
                        break;
                    case 5:
                        Console.WriteLine("Team Two scored a try and earned 5 points");
                        break;
                    case 7:
                        Console.WriteLine("Team Two scored a try and converted, earning 7 points");
                        break;
                }
                teamTwoTotal = teamTwoTotal + teamTwo;
            }

            Console.WriteLine($"The first 10 moves are over.\nTeam One scored {teamOneTotal} points.\nTeam Two scored {teamTwoTotal} points.");
            if (teamOneTotal > teamTwoTotal)
            {
                Console.WriteLine("Team One is taking the lead");
            }
            else if (teamTwoTotal > teamOneTotal)
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
