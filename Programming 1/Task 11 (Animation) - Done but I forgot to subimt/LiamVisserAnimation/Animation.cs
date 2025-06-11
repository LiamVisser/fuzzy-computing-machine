namespace LiamVisserAnimation
{
    internal class Animation
    {
        static void Main()
        {
            string name;
            Console.WriteLine("What is your name?   ");
            name = Console.ReadLine();
            Console.Clear();

            while (true)
            {
                Console.WriteLine($"{name}");
                Thread.Sleep(50);
                Console.WriteLine($" {name}");
                Thread.Sleep(50);
                Console.WriteLine($"  {name}");
                Thread.Sleep(50);
                Console.WriteLine($"   {name}");
                Thread.Sleep(50);
                Console.WriteLine($"    {name}");
                Thread.Sleep(50);
                Console.WriteLine($"   {name}");
                Thread.Sleep(50);
                Console.WriteLine($"  {name}");
                Thread.Sleep(50);
                Console.WriteLine($" {name}");
                Thread.Sleep(50);
                Console.WriteLine($"{name}");
                Thread.Sleep(50);
            }
        }
    }
}
