namespace Tasb3CFahrToCels
{
    internal class Program
    {
        static void Main()
        {
            string temp;
            double Farenheit, Celsius;

            Console.Write("Please can you enter in a temp in Celsius?   ");
            temp = Console.ReadLine();
            Celsius = Convert.ToDouble(temp);

            Farenheit = (Celsius * 9) / 5 + 32;
            Console.Write($"Your temperature of {Celsius} is actually {Farenheit} in Farenheit.\nPlease press [Enter] to move on...");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Please can you enter in a temp in Farenheit?     ");
            temp = Console.ReadLine() ;
            Farenheit = Convert.ToDouble(temp);
            Celsius = (Farenheit - 32) * 5 / 9;
            Console.Write($"Your temp in Farenheit is actually {Celsius} in Celsius.\nPlease press [Enter] to move on...");
            Console.ReadLine() ;
            Console.Clear();
        }
    }
}
