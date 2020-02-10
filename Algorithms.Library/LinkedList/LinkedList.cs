using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Library.LinkedList
{
    public class LinkedList<T> : ICollection<T>
    {
        #region Private Variables

        private int _count;
        private ListNode<T> _head;

        #endregion Private Variables

        public LinkedList()
        {
            _count = 0;
            _head = null;
        }

        public int Count => _count;

        public bool IsReadOnly => false;

        public T this[int index]
        {
            get
            {
                if (index < 0)
                    throw new ArgumentOutOfRangeException();
                ListNode<T> currentNode = _head;
                for (int i = 0; i < index; i++)
                {
                    if (currentNode.Next == null)
                        throw new ArgumentOutOfRangeException();
                    currentNode = currentNode.Next;
                }
                return currentNode.Item;
            }
        }

        public bool IsEmpty
        {
            get
            {
                lock (this)
                {
                    return this._head == null;
                }
            }
        }

        public override string ToString()
        {
            lock (this)
            {
                if (IsEmpty)
                {
                    return string.Empty;
                }

                StringBuilder returnString = new StringBuilder();
                foreach (T item in this)
                {
                    if (returnString.Length > 0)
                        returnString.Append("->");
                    returnString.Append(item);
                }
                return returnString.ToString();
            }
        }

        public ListNode<T> GetHeadNode()
        {
            return _head;
        }

        public void InsertAtBegining(ListNode<T> listNode)
        {
            listNode.Next = _head;
            _head = listNode;
            _count++;
        }

        public void InsertAtEnd(ListNode<T> listNode)
        {
            if (_head == null)
            {
                _head = listNode;
            }
            else
            {
                ListNode<T> node = _head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = listNode;
            }
            _count++;
        }

        public void Insert(T item, int position)
        {
            if (position < 0)
            {
                position = 0;
            }
            else if (position > Count)
            {
                position = Count;
            }

            if (_head == null)
            {
                _head = new ListNode<T>(item);
            }
            else if (position == 0)
            {
                ListNode<T> node = new ListNode<T>(item)
                {
                    Next = _head
                };
                _head = node;
            }
            else
            {
                int i = 1;
                ListNode<T> node = _head;
                while (i < position)
                {
                    node = node.Next;
                    i++;
                }
                node.Next = new ListNode<T>(item);
            }

            _count++;
        }

        public ListNode<T> RemoveFromBegining()
        {
            if (_head == null)
                return null;

            ListNode<T> listNode = _head;
            _head = _head.Next;
            listNode.Next = null;
            _count--;
            return listNode;
        }

        public ListNode<T> RemoveFromEnd()
        {
            if (_head == null)
                return null;

            ListNode<T> listNode = _head;
            ListNode<T> prevNode = null;
            while (listNode.Next != null)
            {
                prevNode = listNode;
                listNode = listNode.Next;
            }
            listNode.Next = null;
            prevNode.Next = null;
            _count--;
            return listNode;
        }

        public ListNode<T> RemoveMatched(ListNode<T> node)
        {
            if (_head == null)
                return null;

            ListNode<T> listNode = _head;
            if (node.Equals(listNode))
            {
                _head = listNode.Next;
                listNode.Next = null;
                _count--;
                return listNode;
            }

            ListNode<T> prevNode = null;
            while (listNode.Next != null)
            {
                prevNode = listNode;
                listNode = listNode.Next;

                if (node.Equals(listNode))
                {
                    prevNode.Next = listNode.Next;
                    listNode.Next = null;
                    _count--;
                    return listNode;
                }
            }

            return null;
        }

        public void Remove(int position)
        {
            if (position < 0)
            {
                position = 0;
            }
            else if (position > Count)
            {
                position = Count;
            }

            if (_head == null)
            {
                return;
            }
            else if (position == 0)
            {
                _head = _head.Next;
                _count--;
            }
            else
            {
                int i = 1;
                ListNode<T> node = _head;
                ListNode<T> prevNode = _head;
                while (i < position)
                {
                    prevNode = node;
                    node = node.Next;
                    i++;
                }
                prevNode.Next = node.Next;
                node.Next = null;
                _count--;
            }
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            lock (this)
            {
                ListNode<T> currentNode = _head;
                while (currentNode != null)
                {
                    if (currentNode.Item.Equals(item))
                    {
                        return true;
                    }
                    currentNode = currentNode.Next;
                }
                return false;
            }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListNode<T> listNode = _head;
            while (listNode != null)
            {
                yield return listNode.Item;
                listNode = listNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
    }
}
