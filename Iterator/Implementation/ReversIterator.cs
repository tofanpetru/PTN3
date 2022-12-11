using System.Collections;

namespace Iterator.Implementation
{
    public class ReversIterator<T> : IEnumerator<T>
    {
        private int _currentIndex;
        private readonly GameProductsQueueContainer<T> _reversContainer;

        public ReversIterator(GameProductsQueueContainer<T> reversContainer)
        {
            _reversContainer = reversContainer;
            _currentIndex = _reversContainer.Count;
        }

        public T Current
        {
            get
            {
                return _currentIndex.Equals(-1)
                    || _currentIndex.Equals(_reversContainer.Count)
                    ? throw new InvalidOperationException()
                    : _reversContainer[_currentIndex];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_currentIndex != -1) _currentIndex--;
            return _currentIndex >= 0;
        }

        public void Reset()
        {
            _currentIndex = _reversContainer.Count;
        }

        public void Dispose() { }
    }
}
