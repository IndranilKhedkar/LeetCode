using Algorithms.Library.Queue.Exceptions;
using Algorithms.Library.Queue.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Library.Queue.Tests
{
    [TestClass]
    public class FizedSizeArrayQueueTests
    {
        [TestMethod]
        public void FizedSizeArrayQueue_EmptyQueue_ValidateQueueStateAndOperations()
        {
            /* Arrange */
            FixedSizeArrayQueue<int> fixedSizeArrayQueue = new FixedSizeArrayQueue<int>();

            /* Act & Assert */
            Assert.AreEqual(0, fixedSizeArrayQueue.Count);
            Assert.AreEqual(true, fixedSizeArrayQueue.IsEmpty());
            Assert.AreEqual(string.Empty, fixedSizeArrayQueue.ToString());
            try
            {
                fixedSizeArrayQueue.Peek();
            }
            catch (QueueUnderflowException ex)
            {
                Assert.IsNotNull(ex);
            }
            try
            {
                fixedSizeArrayQueue.Dequeue();
            }
            catch (QueueUnderflowException ex)
            {
                Assert.IsNotNull(ex);
            }
        }

        [TestMethod]
        public void FizedSizeArrayQueue_EnqueueItemToQueue_ValidateQueueState()
        {
            /* Arrange */
            FixedSizeArrayQueue<int> fixedSizeArrayQueue = new FixedSizeArrayQueue<int>();
            fixedSizeArrayQueue.Enqueue(1);

            /* Act & Assert */
            Assert.AreEqual(1, fixedSizeArrayQueue.Count);
            Assert.AreEqual(false, fixedSizeArrayQueue.IsEmpty());
            Assert.AreEqual("[1]", fixedSizeArrayQueue.ToString());
            Assert.AreEqual(1, fixedSizeArrayQueue.Peek());
        }

        [TestMethod]
        public void FizedSizeArrayQueue_TryToEnqueueItemToFullQueue_Throws_QueueOverflowException()
        {
            /* Arrange */
            const int DefaultCapacity = 10;
            FixedSizeArrayQueue<int> fixedSizeArrayQueue = new FixedSizeArrayQueue<int>();
            for (int i = 0; i < DefaultCapacity; i++)
            {
                fixedSizeArrayQueue.Enqueue(i);
            }

            /* Act & Assert */
            Assert.AreEqual(DefaultCapacity, fixedSizeArrayQueue.Count);
            Assert.AreEqual(false, fixedSizeArrayQueue.IsEmpty());
            Assert.AreEqual("[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]", fixedSizeArrayQueue.ToString());
            Assert.AreEqual(0, fixedSizeArrayQueue.Peek());
            try
            {
                fixedSizeArrayQueue.Enqueue(10);
            }
            catch (QueueOverflowException ex)
            {
                Assert.IsNotNull(ex);
            }
        }

        [TestMethod]
        public void FizedSizeArrayQueue_DequeueItemsFromFullQueue()
        {
            /* Arrange */
            const int DefaultCapacity = 10;
            FixedSizeArrayQueue<int> fixedSizeArrayQueue = new FixedSizeArrayQueue<int>();
            for (int i = 0; i < DefaultCapacity; i++)
            {
                fixedSizeArrayQueue.Enqueue(i);
            }

            /* Act & Assert */
            Assert.AreEqual(DefaultCapacity, fixedSizeArrayQueue.Count);
            Assert.AreEqual(false, fixedSizeArrayQueue.IsEmpty());
            Assert.AreEqual("[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]", fixedSizeArrayQueue.ToString());

            for (int i = 0; i < DefaultCapacity; i++)
            {
                int item = fixedSizeArrayQueue.Dequeue();
                Assert.AreEqual(i, item);
            }

            Assert.AreEqual(0, fixedSizeArrayQueue.Count);
            Assert.AreEqual(true, fixedSizeArrayQueue.IsEmpty());
            Assert.AreEqual(string.Empty, fixedSizeArrayQueue.ToString());
        }
    }
}
