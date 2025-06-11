using Microsoft.VisualBasic.FileIO;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //string text;

           //Console.WriteLine("Hello, Please enter in a sentence.");
           //text = Console.ReadLine();
           //string[] split = text.Split(' ');

           //foreach (string word in split)
           //{
           //    Console.WriteLine(word);
           //}
           //Console.ReadLine();

           //string replace = text.Replace("dog", "chicken");

           //Console.WriteLine(replace.Insert(text.IndexOf("brown"),"Hairy "));
           //Console.ReadLine();

           //Console.WriteLine(replace.ToLower());S
           //Console.WriteLine(replace.ToUpper());
           //Console.ReadLine();


           //Console.WriteLine(replace.Replace('e', 'y'));
           //Console.ReadLine();

           string[] names = { "Krissi", "Dale", "Bo", "Christopher" };
           double[] wealth = { 150000, 100000, 5.66, 10 };

          for (int i = 0; i < names.Length; i++)
          {
              Console.Write(names[i].PadRight(11));
              Console.WriteLine(wealth[i].ToString().PadLeft(6));
          }
          Console.ReadLine();

           //int day, month, year, indexCapture1, indexCapture2, calc;
           //string temp;

           //Console.WriteLine("Please enter your birthday DD/MM/YYYY");
           //temp = Console.ReadLine();
           //indexCapture1 = temp.IndexOf("/");
           //indexCapture2 = temp.LastIndexOf("/");
           //day = Convert.ToInt32(temp.Substring(0,indexCapture1));
           //calc = indexCapture2 - indexCapture1;
           //month = Convert.ToInt32(temp.Substring(indexCapture1+1, calc-1));
           //year = Convert.ToInt32(temp.Substring(indexCapture2+1));
           //Console.WriteLine($"{day}, {month}, {year}");
           //Console.ReadLine();

           //    string text, temp = "";

           //    Console.WriteLine("Hello, Please enter in a sentence.");
           //    text = Console.ReadLine();
           

           //    string replace = text.Replace("dog", "chicken");

           //    Console.WriteLine(replace.Insert(text.IndexOf("brown"), "Hairy "));

           //string[] split = text.Split(' ');
           //foreach (string word in split)
           //{
           //    temp += word[0].ToString().ToUpper() + word.Substring(1) + " ";             
           //}
           //Console.WriteLine(temp);

           //Console.ReadLine();
       }
    }
}
