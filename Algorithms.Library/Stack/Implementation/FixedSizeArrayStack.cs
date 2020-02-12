using Algorithms.Library.Stack.Exceptions;
using Algorithms.Library.Stack.Interface;
using System.Text;
using StackOverflowException = Algorithms.Library.Stack.Exceptions.StackOverflowException;

namespace Algorithms.Library.Stack.Implementation
{
    public class FixedSizeArrayStack<T> : IStack<T>
    {
        #region Private Variables

        private static readonly int DEFAULT_CAPACITY = 10;
        private int _capacity;
        private int _top = -1;
        private T[] _stack;

        #endregion Private Variables

        #region Constructors

        public FixedSizeArrayStack() : this(DEFAULT_CAPACITY)
        { }

        public FixedSizeArrayStack(int capacity)
        {
            _capacity = capacity;
            _stack = new T[capacity];
        }

        #endregion Constructors

        #region Public Properties

        public int Count
        {
            get { return _top + 1; }
        }

        #endregion Public Properties

        #region Public Methods

        public bool IsEmpty()
        {
            return (_top < 0);
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new StackUnderflowException();
            }

            return _stack[_top];
        }

        public T Pop()
        {
            lock (this)
            {
                if (IsEmpty())
                {
                    throw new StackUnderflowException();
                }

                T item = _stack[_top];
                _stack[_top] = default;
                _top -= 1;
                return item;
            }
        }

        public void Push(T item)
        {
            lock (this)
            {
                if (IsFull())
                {
                    throw new StackOverflowException();
                }

                _stack[++_top] = item;
            }
        }

        public override string ToString()
        {
            if (IsEmpty())
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new StringBuilder("[");

            if (Count > 0)
            {
                stringBuilder.Append(_stack[0]);
            }

            if (Count > 1)
            {
                for (int i = 1; i < _top; i++)
                {
                    stringBuilder.Append($", {_stack[i]}");
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
