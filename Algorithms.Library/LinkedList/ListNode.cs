namespace Algorithms.Library.LinkedList
{
    public class ListNode<T>
    {
        #region Private Variables

        private ListNode<T> _next;
        private T _item;

        #endregion Private Variables

        #region Constructors

        public ListNode(T item) : this(item, null)
        { }

        public ListNode(T item, ListNode<T> next)
        {
            this._item = item;
            this._next = next;
        }

        #endregion Constructors

        #region Public Properties

        public ListNode<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }

        public T Item
        {
            get { return _item; }
            private set { _item = value; }
        }

        public override string ToString()
        {
            if (_item == null)
                return string.Empty;
            return _item.ToString();
        }

        #endregion Public Properties
    }
}
