using Algorithms.Library.Queue.Exceptions;
using Algorithms.Library.Queue.Interface;
using System.Text;

namespace Algorithms.Library.Queue.Implementation
{
    public class FixedSizeArrayQueue<T> : IQueue<T>
    {
        #region Private Variables

        private static readonly int DEFAULT_CAPACITY = 10;
        private readonly int _capacity;
        private readonly T[] _queue;

        private int _front;
        private int _rear;

        #endregion Private Variables

        #region Constructors

        public FixedSizeArrayQueue() : this(DEFAULT_CAPACITY)
        { }

        public FixedSizeArrayQueue(int capacity)
        {
            _capacity = capacity;
            _front = 0;
            _rear = 0;
            Count = 0;
            _queue = new T[capacity];
        }

        #endregion Constructors

        #region Public Properties

        public int Count { get; private set; }

        #endregion Public Properties

        #region Public Methods

        public T Dequeue()
        {
            lock (this)
            {
                if (IsEmpty())
                {
                    throw new QueueUnderflowException();
                }

                T result = _queue[_front];
                _queue[_front++] = default;
                _front %= _capacity;
                Count--;
                return result;
            }
        }

        public void Enqueue(T item)
        {
            lock (this)
            {
                if (IsFull())
                {
                    throw new QueueOverflowException();
                }

                _queue[_rear++] = item;
                _rear %= _capacity;
                Count++;
            }
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException();
            }

            return _queue[_front];
        }

        public override string ToString()
        {
            if (IsEmpty())
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new StringBuilder("[");
            for (int i = 0; i < Count; i++)
            {
                stringBuilder.Append($"{_queue[(_front + i) % _capacity]}");
                if (i < Count - 1)
                {
                    stringBuilder.Append(", ");
                }
            }
            return stringBuilder.Append("]").ToString();
        }

        #endregion Public Methods

        #region Private Methods

        private bool IsFull()
        {
            return Count == _capacity;
        }

        #endregion Private Methods
    }
}
