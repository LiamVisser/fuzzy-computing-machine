namespace Chase
{
    internal class WhileChase
    {
        static void Main()
        {
            int runner, chaser, chaserDFromRunner;
            Random rand = new Random();

            Console.WriteLine("Hello, This program will show how fast someone is away from something chasing them as they reach their goal.");

            Console.ReadLine();
            runner = rand.Next(10,20);
            chaser = rand.Next(22, 30);


            while (runner >= 0 && chaser > runner)
            {
                chaserDFromRunner = chaser - runner;
                Console.WriteLine($"The runner is {runner} meters away from the goal");
                Console.WriteLine($"The chaser is {chaserDFromRunner} meters away from the runner");
                Console.ReadLine();

              

                runner = runner - rand.Next(0,5);
                chaser = chaser - rand.Next(0,5);


            }
            if (chaser < runner)
            {
                Console.WriteLine("The chaser has caught up to the runner. The runner did not make it");
            }
            else if (runner < 0)
            {
                Console.WriteLine("The runner has made it to the end ");
            }
            Console.ReadLine() ;
        }
    }
}
