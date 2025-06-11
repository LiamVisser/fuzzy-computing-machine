namespace ReadingFromFiles
{
    public struct Students
    {
        public string lastName;
        public string firstName;
        public string address;
        public int team;
    }

    internal class Program
    {
        static void structEntry(Students[] students)
        {

            Random rand = new Random();
            int count = 0;
            string aLine;
            StreamReader sr = new StreamReader(@"H:\Programming 1\names2.txt");
            while (!sr.EndOfStream)
            {
                aLine = sr.ReadLine();
                students[count].lastName = aLine;
                aLine = sr.ReadLine();
                students[count].firstName = aLine;
                students[count].address = "Dunedin";
                students[count].team = rand.Next(1,5);
                count++;
            }
            sr.Close();
        }
        static void structOutput(Students[] students)
        {
            Console.Write("First Name".PadRight(15));
            Console.Write("Last Name".PadRight(15));
            Console.Write("Address".PadRight(15));
            Console.WriteLine("Team".PadRight(15));
            Console.WriteLine("----------------------------------------------------\n");

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].firstName.PadRight(25));
                Console.Write("|" + students[i].lastName.PadRight(25));
                Console.Write("|" + students[i].address.PadRight(25));
                Console.WriteLine("|" + students[i].team.ToString().PadRight(25));
            }
            Console.ReadLine();
        }
        static void ourClass(Students[] students)
        {
            StreamWriter sw = new StreamWriter(@"H:\Programming 1\namesOutput.txt");
            for (int i = 0; i < students.Length; i++)
            {
                sw.WriteLine($"{students[i].lastName} {students[i].firstName} {students[i].address} {students[i].team}");
            }
            sw.Close();
        }
        static void Main()
        {
            Students[] students = new Students[31];
            structEntry(students);
            structOutput(students);
            ourClass(students);
        }
    }
}
