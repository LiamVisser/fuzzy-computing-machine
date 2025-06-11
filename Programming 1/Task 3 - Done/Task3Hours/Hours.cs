namespace Task3Hours
{
    internal class Hours
    {
        static void Main()
        {
            string temp;
            int hours, days, hourDisplay, seconds, secondsDisplay, minutes;

            //Console.Write("Please can you enter in an amount of hours?  ");
            //temp = Console.ReadLine();
            //hours = Convert.ToInt32(temp);

            //days = hours / 24;
            //hourDisplay = hours % 24;
            //Console.Write($"The time you have inputted is a total of {days} days and {hourDisplay} hours.");
            //Console.ReadLine();
            //Console.WriteLine("I've made like 4 projects now so I am not doing another one. Press [Enter] to enter the next task...");
            //Console.ReadLine();
            //Console.Clear();


            Console.Write("Please can you enter in an amount of seconds?  ");
            temp = Console.ReadLine();
            seconds = Convert.ToInt32(temp);
            hours = seconds / 3600;
            minutes = (seconds - (hours * 3600)) / 60;
            secondsDisplay = seconds % 60;
            Console.WriteLine($"The total time you have entered in is {hours} hours, {minutes} minutes, and {secondsDisplay} seconds");
            Console.ReadLine() ;
        }
    }
}
