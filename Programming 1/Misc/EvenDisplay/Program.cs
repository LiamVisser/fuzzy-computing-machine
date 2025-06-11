namespace EvenDisplay
{
    internal class Program
    {
        static void Main()
        {
            int userInput, intCount, oddCount = 0; //declaring variables, initializing oddCount
            Console.WriteLine("This program will ask you to enter in a number, and depending on if the number is odd or even it will do something different.");
            Console.WriteLine("Please enter in a positive number.");
            userInput = Convert.ToInt32(Console.ReadLine()); //taking user input
            while (userInput < 0)
            {
                Console.WriteLine("You entered in a negative number. Please enter in a positive number.");
                userInput = Convert.ToInt32(Console.ReadLine());
            } //Forcing userInput to be positive

            Console.Clear(); //Removes the input section from the console. Makes everything look cleaner

            if (userInput % 2 == 0) //if userInput is an even number
            {
                Console.WriteLine("Printing every even number up to and including your input");
                intCount = 2; //setting up intCount to print the first number 
                for (int i = 0; i < userInput/2; i++) //divide it by two because I only want every even number
                {
                    Console.WriteLine(intCount); //prints every number each time the loop runs
                    intCount = intCount + 2; //makes intCount the next even number
                }
                Console.ReadLine();
            }
            else //If userInput is an odd number
            {
                Console.WriteLine("Adding every odd number up to and including your input...");
                intCount = 1; //setting up intCount to add the first number, and make it odd
                for (int i = 0; i < userInput/2+1; i++) //+1 because the remainder of an odd number is thrown out
                {
                    oddCount = oddCount + intCount;
                    intCount = intCount + 2;
                }
                Console.WriteLine(oddCount); //print the number after the loop has run so we don't see all the working
                Console.ReadLine();
            }
        }
    }
}
