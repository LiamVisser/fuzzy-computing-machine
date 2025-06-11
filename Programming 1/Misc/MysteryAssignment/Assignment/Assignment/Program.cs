using static System.Formats.Asn1.AsnWriter;

namespace Assignment
{
    internal class Program
    {
        private static int input;
        static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("What task would you like to access?"); //TODO: Use padding instead. Also make it so you must press 0 to go back to the menu, not anything but 0
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
                        Console.WriteLine("That option doesn't exist. Please press [Enter] to try again");
                        Console.ReadLine();
                        break;
                    case 0:
                        break;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                }
            } while (input != 0);
        }

        public static void Task1() //First task
        {
            int temp = 0;
            int[] lotto = new int[6];
            Random rand = new Random();

            for (int i = 0; i < lotto.Length; i++)
            {
                temp = rand.Next(1, 7);
                do { 
                    temp = rand.Next(1, 7); 
                } while (lotto[i] == temp);

                lotto[i] = temp;
            }
            for (int i = 0;i < lotto.Length; i++)
            {
                Console.Write($"{lotto[i]} ");
            }

            Console.WriteLine("\nPlease press anything but 0 to go back to the menu");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    break;
            }


        }
     
        public static void Task2() //Second task
        {
            Console.WriteLine("Please press 0 to go back to the menu");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    break;
            }
        }
        
        public static void Task3() //Third task
        { 
            Console.WriteLine("Please press 0 to go back to the menu");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    break;
            }
        }
       
        public static void Task4()
        {
            Console.WriteLine("Please press 0 to go back to the menu");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    break;
            }
        }
    }
}
