namespace ForLoops
{
    internal class die
    {
        static void Main()
        {

            int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, dice;
            Random rand = new Random();
            Console.WriteLine("This program is going to roll 6000 die and count how many times each number came up.\nPress [Enter] to roll the die");
            Console.ReadLine();

            for (int i = 0; i < 6000; i++)
            {
                dice = rand.Next(1,7);
                switch (dice)
                {
                    case 1:
                        one++;
                        break;
                    case 2:
                        two++;
                        break;
                    case 3:
                        three++;
                        break;
                    case 4:
                        four++;
                        break;
                    case 5:
                        five++;
                        break;
                    case 6:
                        six++;
                        break;
                }
                
            }
            Console.WriteLine($"The die have been cast! In total we saw:\nOne: {one}\nTwo: {two}\nThree: {three}\nFour: {four}\nFive: {five}\nSix: {six}");
            Console.ReadLine();
        }
    }
}
