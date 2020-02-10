using Algorithms.Library.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Library.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedList_InsertAtBeginning()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtBegining(new ListNode<int>(5));
            myLinkedList.InsertAtBegining(new ListNode<int>(4));
            myLinkedList.InsertAtBegining(new ListNode<int>(3));
            myLinkedList.InsertAtBegining(new ListNode<int>(2));
            myLinkedList.InsertAtBegining(new ListNode<int>(1));

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("1->2->3->4->5", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_InsertAtEnd()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("1->2->3->4->5", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_Insert()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            myLinkedList.Insert(6, 6);
            myLinkedList.Insert(0, -1);
            myLinkedList.Insert(7, 10);

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("0->1->2->3->4->5->6->7", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_RemoveFromBeginning()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            myLinkedList.RemoveFromBegining();
            myLinkedList.RemoveFromBegining();
            myLinkedList.RemoveFromBegining();

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("4->5", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_RemoveFromEnd()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            myLinkedList.RemoveFromEnd();
            myLinkedList.RemoveFromEnd();
            myLinkedList.RemoveFromEnd();

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("1->2", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_RemoveMatched_RemoveMiddleNode()
        {
            var nodeToBeRemoved = new ListNode<int>(3);

            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(nodeToBeRemoved);
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            myLinkedList.RemoveMatched(nodeToBeRemoved);

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("1->2->4->5", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_RemoveMatched_RemoveHeadNode()
        {
            var nodeToBeRemoved = new ListNode<int>(1);

            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(nodeToBeRemoved);
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            myLinkedList.RemoveMatched(nodeToBeRemoved);

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("2->3->4->5", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_RemoveMatched_RemoveTailNode()
        {
            var nodeToBeRemoved = new ListNode<int>(5);

            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(nodeToBeRemoved);

            myLinkedList.RemoveMatched(nodeToBeRemoved);

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("1->2->3->4", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_RemoveMatched_NoMatchingNode()
        {
            var nodeToBeRemoved = new ListNode<int>(6);

            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            myLinkedList.RemoveMatched(nodeToBeRemoved);

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("1->2->3->4->", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_Remove_HeadNode()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            myLinkedList.Remove(0);

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("2->3->4->5", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_Remove_TailNode()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            myLinkedList.Remove(5);

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("1->2->3->4", myLinkedList.ToString());
        }

        [TestMethod]
        public void LinkedList_Remove_MiddleNode()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.InsertAtEnd(new ListNode<int>(1));
            myLinkedList.InsertAtEnd(new ListNode<int>(2));
            myLinkedList.InsertAtEnd(new ListNode<int>(3));
            myLinkedList.InsertAtEnd(new ListNode<int>(4));
            myLinkedList.InsertAtEnd(new ListNode<int>(5));

            myLinkedList.Remove(2);

            Assert.IsNotNull(myLinkedList);
            Assert.AreEqual("1->2->4->5", myLinkedList.ToString());
        }
    }
}
