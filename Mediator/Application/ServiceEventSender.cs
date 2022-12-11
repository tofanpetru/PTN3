using Mediator.Domain;

namespace Mediator.Application
{
    internal class ServiceEventSender
    {
        private event MessageEvent _messageEvent;
        public event MessageEvent MessageEvent
        {
            add
            {
                _messageEvent += value;
            }

            remove
            {
                if (_messageEvent != null)
                {
                    _messageEvent -= value;
                }
            }
        }

        public void RaiseEvent(string message) => _messageEvent?.Invoke(message);
    }
}
