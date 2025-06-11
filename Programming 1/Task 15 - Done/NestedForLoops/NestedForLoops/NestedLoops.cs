namespace NestedForLoops
{
    internal class NestedLoops
    {
        static void Main()
        {
            int loopCount = 1, roundNum = 1;
            string col = "ABCDEFGHIJK";
            char startChar, endChar, charPrint;

            //for (int i = 0; i < 10; i++)
            //{

            //    for (int j = 0; j < 50; j++)
            //    {
            //        Console.Write("*");
            //    }
            //Console.WriteLine("\n");
            //}

            //Task 2

            //foreach (char c in col)
            //{
            //    Console.WriteLine("\n");
            //    for (int i = 0; i < 20; i++)
            //    {
            //        Console.Write($"{c}{loopCount} ");
            //        loopCount++;
            //        if (loopCount > 20)
            //        {
            //            loopCount = 1;
            //        }
            //    }
            //}

            //Task 3

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"\nRound {loopCount}");
            //    loopCount++;
            //    roundNum = 1;
            //    for (int j = -1; j < i; j++)
            //    {
            //        Console.Write($"{roundNum}  ");
            //        roundNum++;
            //    }
            //}

            //Task 4

            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine("\n");
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //}

            Console.WriteLine("What would you like the starting character to be?");
            startChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("What would you like the finishing character to be?");
            endChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            for (char i = startChar; i <= endChar; i++)
            {
                for (char j = startChar; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
