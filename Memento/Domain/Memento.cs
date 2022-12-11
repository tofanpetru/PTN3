namespace Memento.Domain
{
    public class Memento
    {
        private readonly string _user;
        private readonly string _gameNameInCart;

        public Memento(GameProductContext context)
        {
            _user = context.User;
            _gameNameInCart = context.Cart;
        }

        public GameProductContext Context => new(_user, _gameNameInCart);
    }
}
