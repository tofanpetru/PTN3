namespace Mediator.Application
{
    internal class EventsMediator
    {
        private bool _disposed;
        private ServiceEventSender _serviceSender;
        private readonly SteamEventReciver _steamService;

        public EventsMediator(SteamEventReciver steamReciver,
                              ServiceEventSender serviceSender)
        {
            _steamService = steamReciver;
            _serviceSender = serviceSender;
            _serviceSender.MessageEvent += OnMessageReceived;
        }

        private void OnMessageReceived(string message)
        {
            _steamService.Message = message;
        }

        ~EventsMediator()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _serviceSender.MessageEvent -= OnMessageReceived;
                    _serviceSender = null;
                }
            }

            _disposed = true;
        }
    }
}
