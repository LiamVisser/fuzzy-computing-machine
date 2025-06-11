using System.Formats.Asn1;

namespace Methods
{
    internal class Menu
    {
        private static string answer; //Variables that will go across methods
        private static int score, input;
        private static double length, width, height, area, m2OfPaint, paintLitres;

        static void Main()
        {
            Console.Clear();
            Console.WriteLine("What task would you like to access?"); //TODO: Use padding instead. It feels more sensible
            Console.WriteLine("Your task options are:");
            Console.WriteLine("1    Task 1");
            Console.WriteLine("2    Task 2");
            Console.WriteLine("3    Task 3");
            Console.WriteLine("4    Task 4");
            Console.WriteLine("0    Exit menu system");
            input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (input)
            {
                default:
                    Console.WriteLine("That option doesn't exist. Please press [Enter] to restart program and try again");
                    Console.ReadLine();
                    Main();
                    break;
                case 0:
                    break;
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2 (); 
                    break;
                case 3:
                    Task3 (); 
                    break;
                case 4:
                    Task4 ();
                    break;
            }
        }

        public static void Task1() //First task
        {
            Console.WriteLine("This is main");
            Two();
            Console.WriteLine("Please press 0 to go back to the menu");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    Main();
                    break;
            }

           
        }
        public static void Two()
        {
            One();
            Console.WriteLine("This is the second method");
        }
        public static void One()
        {
            Console.WriteLine("This is the first method");
        }
        public static void Task2() //Second task
        {
            QuestionOne();
            QuestionTwo();
            QuestionThree();
            Console.WriteLine("Please press 0 to go back to the menu");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    Main();
                    break;
            }
        }
        public static void QuestionOne()
        {
            Console.WriteLine("Question One: What is this method called?");
            answer = Console.ReadLine();
            if (answer == "QuestionOne" || answer == "QuestionOne()")
            {
                score++;
                Console.WriteLine($"Answer was correct! Your score is {score}");
            }
            else
            {
                Console.WriteLine($"Your answer was incorrect. Your score is {score}");
            }
            Console.ReadLine();
        }
        public static void QuestionTwo()
        {
            Console.WriteLine("Question Two: How many questions have you done so far?");
            answer = Console.ReadLine().ToLower();
            if (answer == "2" || answer == "two")
            {
                score++;
                Console.WriteLine($"Your answer was correct! Your score is {score}");
            }
            else
            {
                Console.WriteLine($"Your answer was incorrect. Your score is {score}");
            }
            Console.ReadLine();
        }
        public static void QuestionThree()
        {
            Console.WriteLine("Which twin am I?");
            answer = Console.ReadLine().ToLower();
            if (answer == "liam")
            {
                score++;
                Console.WriteLine($"Your answer was correct! Your score is {score}");
            }
            else
            {
                Console.WriteLine($"Your answer was incorrect. Your score is {score}");
            }
            Console.ReadLine();
        }
        public static void Task3() //Third task
        {
            Input();
            PaintCalc();
            Output();
            Console.WriteLine("Please press 0 to go back to the menu");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    Main();
                    break;
            }
        }
        public static void Input()
        {
            Console.WriteLine("Please input the length of your room in meters");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the width of your room in meters");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the height of your room in meters");
            height = Convert.ToDouble(Console.ReadLine());
        }
        public static void PaintCalc()
        {
            area = (2 * width * height) + (2 * length * height) + (length * width);
            m2OfPaint = 2*area;
            paintLitres = m2OfPaint / 20;
        }
        public static void Output()
        {
            Console.WriteLine($"You will need {paintLitres:F0} litres of paint");
            Console.ReadLine();
        }
        public static void Task4()
        {
            Console.WriteLine("There is nothing in here right now. Please press 0 to go back to the menu");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    Main();
                    break;
            }
        }
    }
}
