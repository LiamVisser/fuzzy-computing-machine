using System.Drawing;

namespace Lab13Test
{
    internal class ForEach
    {
        static void Main()
        {
            string text, textUpper = "ABCDEFGHIJKLMNOPQRSTUVWXWZ", textLower = textUpper.ToLower();
            int upperCount = 0, lowerCount = 0, otherCount = 0, textCount = 0;
            Console.WriteLine("Please enter in some text.");
            text = Console.ReadLine();

           


            foreach (char i in text)
            {

                
                if (i >= 'A' && i <= 'Z')// is upper
                {
                    upperCount++;
                }
                else if (i >= 'a' && i <= 'z') // is lower
                {
                    lowerCount++;

                }
                else
                {
                    otherCount++;
                }

                
            }

            for (int i = 0; i < text.Length; i++) //Use .indexOf() to add to the textCount and get the total count
            {
              
                {
                    textCount++;
                    Console.WriteLine($"{textUpper}");
                }
            }
            Console.WriteLine($"Uppercase letters: {upperCount}");
            Console.WriteLine($"Lowercase letters: {lowerCount}");
            Console.WriteLine($"Non-char letters:  {otherCount}");
            Console.ReadLine();

            
        }
    }
}
