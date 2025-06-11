namespace TestPrac
{
    internal class CardGame
    {
        static void Main()
        {
            int age, money = 0, card;
            Random rand = new Random();
            Console.WriteLine("Hello. Before we play this card game we must ask you what your age is.");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 17)
            {
                Console.WriteLine("Sorry, but you are too young to play this game.\nPlease come back when you are 18.\nPress [Enter] to leave.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Great! You are old enough to play");
                Console.WriteLine("These are the rules:\nThere will be 5 rounds\nEach round you will be dealt one of thirteen cards.\nIf the card is 11, 12, or 13 you win $10\nIf the card is between 2 and 10 you will lose the value of that card\nIf the card is 1 then you win $20\n\nPress [Enter] to start.");
                Console.ReadLine();
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    card = rand.Next(1, 14);
                    Console.WriteLine($"Round {i + 1}");
                    Console.WriteLine($"You drew {card}");

                    switch (card)
                    {
                        default:
                            money = money - card;
                            Console.WriteLine($"You lose ${card}");
                            break;
                        case 1:
                            money = money + 20;
                            Console.WriteLine($"You win $20");
                            break;
                        case 11:
                        case 12:
                        case 13:
                            money = money + 10;
                            Console.WriteLine($"You win $10.");
                            break;

                    }
                    Console.WriteLine($"You currently have ${money}.\nPress [Enter] to continue.");
                    Console.ReadLine();
                }
                if (money > 0)
                {
                    Console.WriteLine($"The game has ended! In total you gained ${money}");
                }
                else
                {
                    Console.WriteLine($"The game has ended! In total you lost ${money * -1}");
                }
                Console.ReadLine();
            }

        }
    }
}
