using System.Xml.Linq;

namespace BubbleSort
{
    public struct Students
    {
        public string lastName;
        public string firstName;
        public string interests;
    }

    internal class Program
    {
        static void structEntry(Students[] students)
        {
            Students temp;
            int count = 0;
            string aLine;
            StreamReader sr = new StreamReader(@"C:\Users\gmzw6\Downloads\millionaire.txt");
            while (!sr.EndOfStream)
            {
                aLine = sr.ReadLine();
                students[count].firstName = aLine;
                aLine = sr.ReadLine();
                students[count].lastName = aLine;
                aLine = sr.ReadLine();
                students[count].interests = aLine;
                count++;
            }
            sr.Close();

            for (int i = 0; i < students.Length - 1; i++) 
            {
                for (int pos = 0; pos < students.Length - 1; pos++)
                {
                    if (students[pos].lastName.CompareTo(students[pos + 1].lastName) > 0)
                    {
                        temp = students[pos + 1];
                        students[pos + 1] = students[pos];
                        students[pos] = temp;
                    }
                }
            }
        }

        static void structOutput(Students[] students)
        {
            Console.Write("First Name".PadRight(25));
            Console.Write("Last Name".PadRight(25));
            Console.WriteLine("Interests".PadRight(25));
            Console.WriteLine("--------------------------------------------------------------------\n");

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].firstName.PadRight(25));
                Console.Write(students[i].lastName.PadRight(25));
                Console.WriteLine(students[i].interests.PadRight(25));
            }
            Console.ReadLine();
        }
        

        static void Main()
        {
            Students[] students = new Students[31];
            structEntry(students);
            structOutput(students);
        }
    }
}
