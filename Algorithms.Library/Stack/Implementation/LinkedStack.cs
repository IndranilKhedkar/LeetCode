using Algorithms.Library.LinkedList;
using Algorithms.Library.Stack.Exceptions;
using Algorithms.Library.Stack.Interface;
using System.Text;

namespace Algorithms.Library.Stack.Implementation
{
    public class LinkedStack<T> : IStack<T>
    {
        #region Private Variables

        private int _count;
        private ListNode<T> _top;

        #endregion Private Variables

        #region Constructors

        public LinkedStack()
        {
            _count = 0;
            _top = null;
        }

        #endregion Constructors

        #region Public Properties

        public int Count
        {
            get { return _count; }
        }

        #endregion Public Properties

        #region Public Methods

        public bool IsEmpty()
        {
            return Count < 0;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new StackUnderflowException();
            }

            return _top.Item;
        }

        public T Pop()
        {
            lock (this)
            {
                if (IsEmpty())
                {
                    throw new StackUnderflowException();
                }

                T topItem = _top.Item;
                _top = _top.Next;
                _count--;
                return topItem;
            }
        }

        public void Push(T item)
        {
            lock (this)
            {
                ListNode<T> listNode = new ListNode<T>(item) { Next = _top };
                _top = listNode;
                _count++;
            }
        }

        public override string ToString()
        {
            if (IsEmpty())
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new StringBuilder("[");
            var current = _top;
            while (current != null)
            {
                stringBuilder.Append($"{current.Item}, ");
                current = current.Next;
            }
            return stringBuilder.Append("]").ToString();
        }

        #endregion Public Methods
    }
}
