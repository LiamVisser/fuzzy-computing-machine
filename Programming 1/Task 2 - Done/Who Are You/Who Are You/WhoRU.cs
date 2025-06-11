namespace Who_Are_You
{
    internal class WhoRU
    {
        static void Main()
        {
            string name, ageInput, dunedinTime, numInput1, numInput2, avgInput, speedInput, nonTravelTimeInput, totalTimeInput;
            int age, time, num1, num2, numAnswer, avgNum, speed, totalTime, nonTravelTime, distance, movingTime;
            Console.Write("Hello! What is your name?    ");
            name = Console.ReadLine();
            Console.Write("Hello, " + name + "! Can you tell me your age?   ");
            ageInput = Console.ReadLine();
            age = Convert.ToInt32(ageInput);
            Console.Write("How many years have you lived in Dunedin for?    ");
            dunedinTime = Console.ReadLine();
            time = Convert.ToInt32(dunedinTime);
            Console.Write(time + " years is long enough to get a feel for this place, " + name + ". I hope you like it.\nPlease press [Enter] key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Please can you enter in a number.    ");
            numInput1 = Console.ReadLine();
            num1 = Convert.ToInt32(numInput1);
            Console.Write("Again, please can you enter in a number.     ");
            numInput2 = Console.ReadLine();
            num2 = Convert.ToInt32(numInput2);
            Console.WriteLine("Thank you.");
            numAnswer = num1 + num2;
            Console.Write(num1 + " + " + num2 + " = " + numAnswer + ".\nPlease press [Enter] to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.Write("On average, how many hours do you spend watching TV per night?   ");
            avgInput = Console.ReadLine();
            avgNum = Convert.ToInt32(avgInput);
            Console.Write("On average you watch TV " + avgNum * 7 + " hours per week, " + avgNum * 30 + " hours per month, and " + avgNum * 365 + " hours per year.\nPlease press [Enter] to continue..."); 
            Console.ReadLine();
            Console.Clear();
            Console.Write("Please can you enter in the average speed of your car.   ");
            speedInput = Console.ReadLine();
            speed = Convert.ToInt32(speedInput);
            Console.Write("Please can you enter in the duration of your car ride.   ");
            totalTimeInput = Console.ReadLine();
            totalTime = Convert.ToInt32(totalTimeInput);
            Console.Write("Please can you enter in the total tie you will NOT be moving.     ");
            nonTravelTimeInput = Console.ReadLine();
            nonTravelTime = Convert.ToInt32(nonTravelTimeInput);
            movingTime = totalTime - nonTravelTime;
            distance = speed * movingTime;
            Console.WriteLine("You will travel a total of " + distance + "km. Please press [Enter] to close the program");
            Console.ReadLine();
        }
    }
}
