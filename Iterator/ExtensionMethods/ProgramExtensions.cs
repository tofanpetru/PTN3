using Iterator.Implementation;

namespace Iterator.ExtensionMethods
{
    public static class ProgramExtensions
    {
        public static void PrintGames()
        {
            foreach (var game in new GameProductsQueueContainer<string>(3)
            {
                "Game 3",
                "Game 2",
                "Game 1"
            })
            {
                Console.WriteLine("Get Game: " + game);
            }
        }

        public static void PrintGames2()
        {
            try
            {
                foreach (var game in new GameProductsQueueContainer<string>(3)
                {
                    "Game 3",
                    "Game 2",
                    "Game 1",
                    "Game 5",
                })
                {
                    Console.WriteLine("Get Game: " + game);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
