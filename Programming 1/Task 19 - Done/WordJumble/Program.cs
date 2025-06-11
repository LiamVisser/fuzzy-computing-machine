namespace WordJumble
{
    internal class Program
    {
        static Random rand = new Random();

        static void Main()
        {
            int score = 0;
            string word, answer;

           
            Console.WriteLine("Hello. You are going to play a word jumble game. Press enter to start playing");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 8; i++)
            {
                word = RandomPick();
                Console.WriteLine($"The word is {WordJumbler(word)}");
                answer = Console.ReadLine();
                if (answer == word)

                {
                    score++;
                    Console.WriteLine($"You won! Your score is: {score}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"YOU ARE WRONG! Your score is {score}");
                    Console.ForegroundColor= ConsoleColor.White;

                    

                }
                Console.ReadLine() ;
                Console.Clear() ;
            }
            Console.WriteLine($"The game has ended! Your final score is {score} out of 8 words");

            Console.ReadLine();
            Console.Clear();
        }

        static string RandomPick()
        {
            string[] words = { "detonate", "interpolate", "immutable", "graphics", "afterlife", "midnight", "messenger", "stranger" };
            string shuffle = words[rand.Next(words.Length)];
            return shuffle;
        }

        public static string WordJumbler(string word)
        {
            int r1, r2;
            string jumbled;

            char temp;

            char[] letters = word.ToCharArray();

            for (int i = 0; i < 10; i++)
            {
                r1 = rand.Next(word.Length);
                r2 = rand.Next(word.Length);
                temp = letters[r1];
                letters[r1] = letters[r2];
                letters[r2] = temp;
            }

            jumbled = new string(letters);
            return jumbled;

        }
    }
}
