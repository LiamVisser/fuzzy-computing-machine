namespace Animation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rowOne = new string[15], rowTwo = new string[15], rowThree = new string[15], rowFour = new string[15], rowFive = new string[15], rowSix = new string[15],
            rowSeven = new string[15], rowEight = new string[15], rowNine = new string[15], rowTen = new string[15], rowEleven = new string[15], rowTwelve = new string[15],
            rowThirteen = new string[15], rowFourteen = new string[15], rowFifteen = new string[15];

            int length, index = 0, starCount = 0;
            Random rand = new Random();


            Console.WriteLine("How many seconds do you wish to look at the stars?");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int x = 0; x < length; x++)
            {
                starCount = rand.Next(0, 7);

                for (int j = 0; j < starCount; j++)
                {
                    
                    index = rand.Next(0, rowOne.Length);
                    rowOne[index] = "*";
                    rowTwo[index] = "*";
                    rowThree[index] = "*";
                    rowFour[index] = "*";
                    rowFive[index] = "*";
                    rowSix[index] = "*";
                    rowSeven[index] = "*";
                    rowEight[index] = "*";
                    rowNine[index] = "*";
                    rowTen[index] = "*";
                    rowEleven[index] = "*";
                    rowTwelve[index] = "*";
                    rowThirteen[index] = "*";
                    rowFourteen[index] = "*";
                    rowFifteen[index] = "*";
                    

                }

                for (int i = 0; i < rowOne.Length; i++)
                {
                        Console.WriteLine(rowOne[i]);
                        Console.WriteLine("\n"+ rowTwo[i]);
                        Console.WriteLine("\n"+ rowThree[i]);
                        Console.WriteLine("\n"+ rowFour[i]);
                        Console.WriteLine("\n"+ rowFive[i]);
                        Console.WriteLine("\n"+ rowSix[i]);
                        Console.WriteLine("\n"+ rowSeven[i]);
                        Console.WriteLine("\n"+ rowEight[i]);
                        Console.WriteLine("\n"+ rowNine[i]);
                        Console.WriteLine("\n"+ rowTen[i]);
                        Console.WriteLine("\n"+ rowEleven[i]);
                        Console.WriteLine("\n"+ rowTwelve[i]);
                        Console.WriteLine("\n"+ rowThirteen[i]);
                        Console.WriteLine("\n"+ rowFourteen[i]);
                        Console.WriteLine("\n"+ rowFifteen[i]);
                        
                    }
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
