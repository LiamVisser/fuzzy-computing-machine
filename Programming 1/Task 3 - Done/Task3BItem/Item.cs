namespace Task3BItem
{
    internal class Item
    {
        static void Main()
        {
            string temp;
            double price1, price2, percentageIncrease;

            Console.Write("Can you please enter the price of the item BEFORE the increase?  ");
            temp = Console.ReadLine();
            price1 = Convert.ToDouble(temp);

            Console.Write("Can you please enter the price of the item AFTER the increase? ");
            temp = Console.ReadLine() ;
            price2 = Convert.ToDouble(temp);

            percentageIncrease = (price2 - price1) / price1;
            Console.WriteLine($"The price increased by {percentageIncrease:p}.");
            Console.ReadLine();
        }
    }
}
