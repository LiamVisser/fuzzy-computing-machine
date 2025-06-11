namespace Task3Advanced
{
    internal class Program
    {
        static void Main()
        {
            double fahr, cels;
            int hours, seconds, minutes, leftOverSeconds;
            Console.WriteLine("This program will convert Celsius to Fahrenheit");
            Console.WriteLine("Please enter in a temperature in Celsius");
            cels = Convert.ToDouble(Console.ReadLine());
            fahr = (cels * 9) / 5 + 32;
            Console.WriteLine($" temp is {fahr} in Fahrenheit. Press [Enter] to do Fahrenheit to Celsius");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("This program will convert Fahrenheit to Celsius.");
            Console.WriteLine("Please enter in a temperature in Fahrenheit");
            fahr = Convert.ToDouble(Console.ReadLine());
            cels = (fahr - 32) * 5 / 9;
            Console.WriteLine($"The temp is {cels} in Celsius. Press [Enter] to convert seconds to hours, minutes, and seconds");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("This program will convert seconds to hours, minutes, and seconds.");
            Console.WriteLine("Please enter in a time in seconds");
            seconds = Convert.ToInt32(Console.ReadLine());

            hours = seconds / 3600;
            minutes = (seconds - (hours * 3600)) / 60;
            leftOverSeconds = (seconds - (hours * 3600) - (minutes * 60));
            Console.WriteLine($"In total you have entered a time of {hours} hours, {minutes} minutes, and {leftOverSeconds} seconds");
            Console.ReadLine();
        }
    }
}
