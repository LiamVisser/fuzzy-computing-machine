namespace References
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("Please enter in the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in the third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            NumberSort(ref num1, ref num2, ref num3);

            Console.Clear();
            Console.WriteLine($"Your numbers ordered are: {num1}, {num2}, {num3}");
            Console.ReadLine();
        }
        static void Swap(ref int number1, ref int number2)
        {
            int temp;
            temp = number1; 
            number1 = number2; 
            number2 = temp;
                
        }
        /*
        2, 5, 10
        10, 2, 5
        5, 2, 10
        10, 5, 2
        2, 10, 5
        5, 10, 2
        */
        static void NumberSort(ref int n1, ref int n2, ref int n3)
        {
            do
            {
                if (n1 > n2)
                {
                    Swap(ref n1, ref n2);
                }
                if (n2 > n3)
                {
                    Swap(ref n2, ref n3);
                }
                
            } while (n1 > n2);
        } 
    }
}

