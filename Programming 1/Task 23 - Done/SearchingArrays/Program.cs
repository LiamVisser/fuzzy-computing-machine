namespace SearchingArrays
{
    public struct IceCream
    {
        public string flavor;
        public string manufacturer;
        public int decade;
    }
    internal class Program
    {
        static void structEntry(IceCream[] iceCream)
        {
            int count = 0;
            string aLine;
            StreamReader sr = new StreamReader(@"H:\Programming 1\icecream.txt");
            while (!sr.EndOfStream)
            {
                aLine = sr.ReadLine();
                iceCream[count].flavor = aLine;
                aLine = sr.ReadLine();
                iceCream[count].manufacturer = aLine;
                aLine = sr.ReadLine();
                iceCream[count].decade = Convert.ToInt32(aLine);
                count++;
            }
            sr.Close();
        }
        static void structAdd(ref IceCream[] iceCream)
        {
            Array.Resize(ref iceCream, iceCream.Length + 2);
            iceCream[22].flavor = "Flavor";
            iceCream[22].manufacturer = "Manufacturing";
            iceCream[22].decade = 2020;
            iceCream[23].flavor = "Other Flavor";
            iceCream[23].manufacturer= "Manufacturing";
            iceCream[23].decade = 2020;
        }

        static void structEdit(ref IceCream[] iceCream)
        {
            string input = "";
            bool found = false;
            Console.WriteLine("Which ice cream would you like to edit?");
            input = Console.ReadLine();
            for (int i = 0; i < iceCream.Length; i++)
            {
                if (input == iceCream[i].flavor)
                {
                    found = true;
                    Console.WriteLine("Please type the new ice cream flavor name");
                    iceCream[i].flavor = Console.ReadLine();
                    Console.WriteLine("Please type the new manufacturer name");
                    iceCream[i].manufacturer = Console.ReadLine();
                    Console.WriteLine("Please type the new decade");
                    iceCream[i].decade = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (found == false)
            {
                Console.WriteLine("Not found");
            }
        }
        static void structOutput(IceCream[] iceCream)
        {
            Console.Write("Flavor".PadRight(25));
            Console.Write("Manufacturer".PadRight(25));
            Console.WriteLine("Decade");
            Console.WriteLine("--");

            for (int i = 0; i < iceCream.Length; i++)
            {
                //if (iceCream[i].manufacturer == "Streets")
                //{
                //    Console.Write(iceCream[i].flavor.PadRight(25));
                //    Console.Write(iceCream[i].manufacturer.PadRight(25));
                //    Console.WriteLine(iceCream[i].decade.ToString().PadRight(25));
                //}

                //if (iceCream[i].decade == 1950)
                //{
                //    Console.Write(iceCream[i].flavor.PadRight(25));
                //    Console.Write(iceCream[i].manufacturer.PadRight(25));
                //    Console.WriteLine(iceCream[i].decade.ToString().PadRight(25));
                //}

                Console.Write(iceCream[i].flavor.PadRight(25));
                Console.Write(iceCream[i].manufacturer.PadRight(25));
                Console.WriteLine(iceCream[i].decade.ToString().PadRight(25));
            }
            Console.ReadLine();
        }

        static void Main()
        {
            IceCream[] iceCream = new IceCream[22];
            structEntry(iceCream);
            structAdd(ref iceCream);
            structOutput(iceCream);
            Console.Clear();
            structEdit(ref iceCream);
            structOutput(iceCream);

        }
    }
}
