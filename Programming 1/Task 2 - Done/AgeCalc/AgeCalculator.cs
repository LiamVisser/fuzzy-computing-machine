namespace AgeCalc
{
    internal class AgeCalculator
    {
        static void Main()
        {
            string ageInput;
            int age, ageDays, ageHours;
            Console.Write("Please enter in your age.    ");
            ageInput = Console.ReadLine();
            age = Convert.ToInt32(ageInput);
            ageDays = age * 365;
            ageHours = ageDays * 24;
            Console.Write("You have been alive for at least " + ageDays + " days, and " + ageHours  + " hours");
            Console.ReadLine();
        }
    }
}
