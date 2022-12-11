using System.Collections;

namespace Iterator.Implementation
{
    public class GameProductsQueueContainer<T> : IEnumerable<T>
    {
        private int _count;
        private readonly T[] _internalArray;

        public GameProductsQueueContainer(int arrayLength)
        {
            _internalArray = new T[arrayLength];
        }

        public T this[int index] => _internalArray.Length > index ? _internalArray[index] : throw new IndexOutOfRangeException("Index out of range.");

        public int Count => _count;

        public void Add(T item)
        {
            if (_internalArray.Length <= _count) throw new ArgumentException("The list of requests with games to add is full");
            Console.WriteLine("Add: " + item);
            _internalArray[_count] = item;
            _count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int currentIndex = _count - 1; currentIndex >= 0; currentIndex--)
            {
                yield return _internalArray[currentIndex];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ReversIterator<T>(this);
        }
    }
}
