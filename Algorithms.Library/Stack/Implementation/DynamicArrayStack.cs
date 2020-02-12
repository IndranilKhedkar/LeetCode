using Algorithms.Library.Stack.Exceptions;
using Algorithms.Library.Stack.Interface;
using System.Text;

namespace Algorithms.Library.Stack.Implementation
{
    public class DynamicArrayStack<T> : IStack<T>
    {
        #region Private Variables

        private static readonly int DEFAULT_CAPACITY = 16;
        private static readonly int MIN_CAPACITY = 16;
        private int _capacity;
        private int _top = -1;
        private T[] _stack;

        #endregion Private Variables

        #region Constructors

        public DynamicArrayStack() : this(DEFAULT_CAPACITY)
        { }

        public DynamicArrayStack(int capacity)
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
                Shrink();
                return item;
            }
        }

        public void Push(T item)
        {
            lock (this)
            {
                if (IsFull())
                {
                    Expand();
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

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new StackUnderflowException();
            }

            return _stack[_top];
        }

        #endregion Public Methods

        #region Private Methods

        private void Expand()
        {
            T[] tempArray = new T[_capacity << 1];
            _stack.CopyTo(tempArray, 0);
            _stack = tempArray;
            _capacity <<= 1;
        }

        private void Shrink()
        {
            if (Count <= MIN_CAPACITY)
                return;

            T[] tempArray = new T[_capacity >> 1];
            _stack.CopyTo(tempArray, 0);
            _stack = tempArray;
            _capacity >>= 1;
        }

        private bool IsFull()
        {
            return Count == _capacity;
        }

        #endregion Private Methods
    }
}
