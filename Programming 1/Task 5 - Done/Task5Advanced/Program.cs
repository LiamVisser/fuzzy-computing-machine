namespace Task5Advanced
{
    internal class Program
    {
        static void Main()
        {
            string humanInput, programInput;
            int programSelect, scoreHuman, scoreProgram;
            Random rand = new Random();
            Console.WriteLine("This is a game of ehads and tails. You will play 3 rounds against the computer. Try to win.");

            for (int i = 0; i < 3; i++)
            {
                programSelect = rand.Next(0,2);
                if (programSelect == 0)
                {
                    programInput = "heads";
                }
                else
                {
                    programInput = "tails";
                }
                Console.WriteLine("Please enter heads or tails");
                humanInput = Console.ReadLine();

                if (humanInput.ToLower = programInput)
                {

                }
            }
        }
    }
}
