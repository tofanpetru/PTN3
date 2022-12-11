namespace Memento.Domain
{
    public class GameProductContext
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string User { get; set; }
        public string Cart { get; set; } = string.Empty;
        public string Grade { get; set; }
        public List<string> Props { get; set; }

        public GameProductContext()
        {
        }
        public GameProductContext(string user, string gameInCart)
        {
            User = user;
            Cart = gameInCart;
        }
    }
}
