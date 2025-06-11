namespace Structs
{
    public struct Classroom 
    {
        public string firstName;
        public string lastName;
        public string interest;
    }
    internal class Program
    {
        static void Main()
        {
            int count = 0;
            Classroom[] classroom = new Classroom[2];
            Console.WriteLine("You will enter 2 data entries for this struct");
            Console.WriteLine("Please enter in a first name");
            string tempName = Console.ReadLine();
            while (tempName != "")
            {
                classroom[count].firstName = tempName;
                Console.WriteLine("Please enter in a last name");
                classroom[count].lastName = Console.ReadLine();
                Console.WriteLine("Please enter in an interest");
                classroom[count].interest = Console.ReadLine();
                count++;
                Console.WriteLine("Please enter in the next first name");
                tempName = Console.ReadLine();
            }
            Console.Write("First Name".PadRight(15));
            Console.Write("Last Name".PadRight(15));
            Console.WriteLine("Interests".PadRight(15));
            Console.WriteLine("------------------------------------------");
            for (int i = 0; i < classroom.Length; i++)
            {
                Console.Write(classroom[i].firstName.PadRight(15));
                Console.Write(classroom[i].lastName.PadRight(15));
                Console.WriteLine(classroom[i].interest.PadRight(15));
            }
            Console.ReadLine();
        }
    }
}
