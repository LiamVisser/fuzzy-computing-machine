using System;

namespace DoWhile
{
    internal class NumGuess
    {
        static void Main()
        {
            /*
            int randNum, input, count = 0;
            Random random = new Random();
            randNum = random.Next(1, 101);
            do
            {
                Console.WriteLine($"What do you think the number is? (You have had {count} attempts)");
                input = Convert.ToInt32(Console.ReadLine());
                if (input > 100)
                {
                    Console.WriteLine("Your number is out of the range");
                }
                else if (input < randNum)
                {
                    Console.WriteLine("Your number is too low");
                }
                else if (input > randNum)
                {
                    Console.WriteLine("Your number is too big");
                }
                else
                {
                    Console.WriteLine("You have the right number");
                }
                if (count == 6)
                {
                    Console.WriteLine("You need to have a more systematic approach to your number guessing");
                }
                count++;
            } while (input != randNum);
            Console.ReadLine();
            */

            int high = 101, low = 1, guess, input, count = 0, boundHigh = high, boundLow = low;
            Random random = new Random();

            Console.WriteLine($"Please enter in any number between {low} and {high}");
            input = Convert.ToInt32(Console.ReadLine());

            while (input < low || input > high)
            {
                
                if (input > high)
                {
                    Console.WriteLine("Your number is too high! Please enter in a different number.");
                    input = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Your number is too low! Please enter in a different number.");
                    input = Convert.ToInt32(Console.ReadLine());

                }
            }

            do
            {
                guess = random.Next(boundLow, boundHigh);
                Console.WriteLine(guess);
                count++;

                if (guess > input)
                {
                    boundHigh = guess;
                }
                else
                {
                    boundLow = guess;
                }


                if (guess == input){
                    Console.WriteLine($"The computer guessed it in {count} attempts");
                }
            } while (guess != input);
            Console.ReadLine();
        }
    }
}