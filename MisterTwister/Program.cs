namespace MisterTwister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Mister Twister");
            Thread.Sleep(1000);
            Console.WriteLine("If want to play Twister with me press s");
            Thread.Sleep(1000);
            Console.WriteLine("... or press h to get help");
            Thread.Sleep(1000);
            Console.WriteLine("... or press q to quit");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.S:
                    // start game
                    break;
                case ConsoleKey.H:
                    // display help
                    break;
                case ConsoleKey.Q:
                    // quit app
                    break;
                default:
                    // wait for valid input
                    break;
            }
        }
    }
}