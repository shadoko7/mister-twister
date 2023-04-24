namespace MisterTwister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć, jestem Mister Twister");
            Thread.Sleep(1000);
            Console.WriteLine("Jeżeli chcesz zagrać ze mną w Twistera naciśnij \"s\"");
            Thread.Sleep(1000);
            Console.WriteLine("... lub naciśnij \"h\", aby wyświetlić pomoc");
            Thread.Sleep(1000);
            Console.WriteLine("... lub naciśnij \"q\", żeby wyjść");

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