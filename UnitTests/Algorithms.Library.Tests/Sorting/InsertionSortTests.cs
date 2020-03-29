using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Library.Sorting.Tests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void Sort_For_IntArrayInDescendingOrder_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            int[] A = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            /* Act */
            var result = new InsertionSort<int>().Sort(A);

            /* Assert */
            Assert.IsNotNull(A);
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(i, A[i]);
            }
        }

        [TestMethod]
        public void Sort_For_IntArrayInAscendingOrder_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            int[] A = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            /* Act */
            var result = new InsertionSort<int>().Sort(A);

            /* Assert */
            Assert.IsNotNull(A);
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(i, A[i]);
            }
        }

        [TestMethod]
        public void Sort_For_IntArray_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            int[] A = new int[] { 3, 5, 1, 3, 9, 0, 5612, 123, 57, 9, 123 };
            int[] expectedResult = new int[] { 0, 1, 3, 3, 5, 9, 9, 57, 123, 123, 5612 };

            /* Act */
            var result = new InsertionSort<int>().Sort(A);

            /* Assert */
            Assert.IsNotNull(A);
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], A[i]);
            }
        }
    }
}
