using System.Text;

namespace MilesToKm
{
    internal class Conversion
    {
        static void Main()
        {
            string temp;
            double miles, kilometres, totalCost, radius, circumference, nzd, aud, usd, pound, yen, eurodollar;
            const double ADULT = 16.5, CHILD = 10.5, FACTOR = 1.60934, AUD = 0.8085, USD = 0.8272, POUND = 0.5457, YEN = 76.23, EURO = 0.6297;
            int adultCount, childCount, numberInput, squared, cubed, p4, p5;

            Console.Write("Hello, please can you enter in a distance in miles?  ");
            temp = Console.ReadLine();
            miles = Convert.ToDouble(temp );
            kilometres = miles * FACTOR;
            Console.WriteLine($"{miles} miles is {kilometres:N2} in kilometres.\nPress [Enter] to move on to the next task.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("How many adult tickets do you want?  ");
            temp = Console.ReadLine();
            adultCount = Convert.ToInt32(temp);
            Console.Write("How many child tickets do you want?  ");
            temp = Console.ReadLine();
            childCount = Convert.ToInt32(temp);
            totalCost = (adultCount * ADULT) + (childCount * CHILD);
            Console.WriteLine($"You are getting {adultCount} adult tickets, and {childCount} child tickets. This will cost you {totalCost:C}\nPlease press [Enter] to move on to the next task.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Please can you enter in the radius of a circle in kilometres?  ");
            temp = Console.ReadLine();
            radius = Convert.ToDouble(temp);
            circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The circumference of that circle is {circumference:N2}km. Please press [Enter] to move on to the next task.");
            Console.ReadLine();
            Console.Clear();
            /*
            Console.Write("Please can you enter in a number?    ");
            temp = Console.ReadLine();
            numberInput = Convert.ToInt32(temp);
            squared = Math.Pow(numberInput, 2);
            cubed = Math.Pow(numberInput, 3);
            p4 = Math.Pow(numberInput, 4);
            p5 = Math.Pow(numberInput, 5);
            Console.WriteLine($"Your number squared is {squared}.\nYour number cubed is {cubed}.\nYour number to the power of 4 is {p4}.\nYour number to the power of 5 is {p5}.\nPlease press [Enter] to move on to the next task");
            Console.ReadLine();
            Console.Clear();
            */
            Console.Write("Please can you enter in some money in New Zealand Dollars?  ");
            temp = Console.ReadLine();
            nzd = Convert.ToDouble(temp);
            aud = nzd * AUD;
            usd = nzd * USD;
            pound = nzd * POUND;
            yen = nzd * YEN;
            eurodollar = nzd * EURO;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"That equates to\nAUD: {aud:C2}\nUSD: {usd:C2}\nPound: £{pound:N2}\nYen: ¥{yen:N2}\nEuro: €{eurodollar:N2}");
            Console.ReadLine();
        }
    }
}
