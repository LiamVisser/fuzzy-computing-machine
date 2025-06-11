namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            int[] rng = new int[7], input = new int[7];
            int score = 0;
            Random rand = new Random();
            Console.WriteLine("You are going to be looking at a random assortment of numbers, and try to memorize them.\nOnce the numbers age gone, try and enter them in sequential order\nPress [Enter] to start");
            Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < rng.Length; i++)
            {
                rng[i] = rand.Next(0, 10);
                Console.Write(rng[i]);
            }
            Thread.Sleep(4000);
            Console.Clear() ;
            Console.WriteLine("Now please put down what you remember. One at a time");
            for (int i = 0;i < input.Length; i++)
            {
                Console.Write("Enter here:  ");
                input[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write($"You had:   ");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
            }
            Console.Write($"\nIt was:    ");
            for (int i = 0; i < rng.Length; i++)
            {
                Console.Write(rng[i]);
            }

            for (int i = 0; i < rng.Length; i++)
            {
                if (rng[i] == input[i])
                {
                    score++;
                }
            }
            Console.WriteLine($"\nYou got {score} out of {rng.Length} right");
            Console.Read();
        }
    }
}
