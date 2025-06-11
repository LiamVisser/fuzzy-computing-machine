namespace Lab2Advanced
{
    internal class Program
    {
        static void Main()
        {
            int time, nonTravelTime, avgSpeed, distance, input;
            Console.WriteLine("This program will work out the distance of a car trip.");
            Console.WriteLine("Please enter in how fast you were going in km/h");
            avgSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in how long the trip took in hours");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in how long you spent not traveling throughout that time (also in hours)");
            nonTravelTime = Convert.ToInt32(Console.ReadLine());
            while (nonTravelTime > time)
            {
                Console.WriteLine("That number is physically impossible. Please enter in the actual time.");
                nonTravelTime = Convert.ToInt32(Console.ReadLine());
            }
            distance = avgSpeed * (time - nonTravelTime);
            Console.WriteLine($"You travelled a total of {distance}km");
            Console.WriteLine("Would you like to enter in another set of data? [1 = Yes / Any other number = No]");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                default:
                    Console.WriteLine("Goodbye.");
                    Console.ReadLine();
                    break;
                case 1:
                    Main();
                    break;
            }
        }
    }
}
