using Memento.Domain;

namespace Memento.Application
{
    public class MementoManager
    {
        private GameProductContext? _context;

        public void SetContext(GameProductContext context)
        {
            _context = context;
            Console.WriteLine($"[{context.Id}] The context with user name: '{context.User}' and chart product: {context.Cart} was set.");
        }

        public Domain.Memento SaveToMomento()
        {
            Console.WriteLine("Saving to memento...");
            return new Domain.Memento(_context);
        }

        public void RestoreFromMemento(Domain.Memento memento)
        {
            _context = memento.Context;
            Console.WriteLine($"[{_context.Id}] The context with user: '{_context.User}' and chart: {_context.Cart} was restored.");
        }
    }
}
