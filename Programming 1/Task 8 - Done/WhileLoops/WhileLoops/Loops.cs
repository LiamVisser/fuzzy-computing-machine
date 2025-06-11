namespace WhileLoops
{
    internal class Loops
    {
        static void Main()
        {
            int count;
            double temp, tempInc;
            Random rand = new Random();

            count = 0;
            Console.WriteLine("Hello. This program will track when you must leave a sauna.");
            Console.ReadLine();

            Console.Write("What is the temperature you are entering at?  ");
            temp = Convert.ToDouble(Console.ReadLine());

            while (temp < 39)
            {
                count++;
                tempInc = rand.NextDouble();
                temp += tempInc;
                Console.WriteLine($"You have been in the sauna for {count} minutes. Your current temp is {temp}");
            }
            Console.WriteLine("You must now exit the sauna. You are getting too hot.");
            Console.ReadLine();
        }
    }
}
