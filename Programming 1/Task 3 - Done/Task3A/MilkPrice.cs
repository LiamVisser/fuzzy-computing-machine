namespace Task3A
{
    internal class MilkPrice
    {
        static void Main()
        {
            string temp;
            int count=3;
            double milkPrice1, milkPrice2, milkPrice3, milkAverage;

            Console.Write("Can you please enter in the price of a milk bottle?   ");
            temp = Console.ReadLine();
            milkPrice1 = Convert.ToDouble(temp);
            Console.Write("Can you please enter in the price of another milk bottle?   ");
            temp = Console.ReadLine();
            milkPrice2 = Convert.ToDouble(temp);
            Console.Write("Can you please enter in the price of a final bottle of milk?   ");
            temp = Console.ReadLine();
            milkPrice3 = Convert.ToDouble(temp);

            milkAverage = (milkPrice1 + milkPrice2 + milkPrice3) / (double) count;
            Console.WriteLine($"The average price of milk is {milkAverage:C2}.");
            Console.ReadLine();
        }
    }
}
