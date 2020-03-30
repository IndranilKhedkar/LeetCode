using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Library.Sorting.Tests
{
    [TestClass]
    public class CountingSortTests
    {
        #region Sort Tests

        [TestMethod]
        public void Sort_For_IntArrayInDescendingOrder_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            int[] A = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            /* Act */
            var result = new CountingSort().Sort(A, 10);

            /* Assert */
            Assert.IsNotNull(result);
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(i + 1, result[i]);
            }
        }

        [TestMethod]
        public void Sort_For_IntArrayInAscendingOrder_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            /* Act */
            var result = new CountingSort().Sort(A, 10);

            /* Assert */
            Assert.IsNotNull(result);
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(i + 1, result[i]);
            }
        }

        [TestMethod]
        public void Sort_For_IntArray_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            int[] A = new int[] { 3, 5, 1, 3, 9, 56, 12, 57, 9, 97 };
            int[] expectedResult = new int[] { 1, 3, 3, 5, 9, 9, 12, 56, 57, 97 };

            /* Act */
            var result = new CountingSort().Sort(A, 100);

            /* Assert */
            Assert.IsNotNull(result);
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }

        #endregion Sort Tests

        #region Sort_1 Tests

        [TestMethod]
        public void Sort_1_For_IntArrayInDescendingOrder_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            int[] A = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            /* Act */
            var result = new CountingSort().Sort_1(A, 10);

            /* Assert */
            Assert.IsNotNull(result);
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(i + 1, result[i]);
            }
        }

        [TestMethod]
        public void Sort_1_For_IntArrayInAscendingOrder_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            /* Act */
            var result = new CountingSort().Sort_1(A, 10);

            /* Assert */
            Assert.IsNotNull(result);
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(i + 1, result[i]);
            }
        }

        [TestMethod]
        public void Sort_1_For_IntArray_Returns_SortedArrayInAscendingOrder()
        {
            /* Arrange */
            int[] A = new int[] { 3, 5, 1, 3, 9, 56, 12, 57, 9, 97 };
            int[] expectedResult = new int[] { 1, 3, 3, 5, 9, 9, 12, 56, 57, 97 };

            /* Act */
            var result = new CountingSort().Sort_1(A, 100);

            /* Assert */
            Assert.IsNotNull(result);
            for (int i = 0; i < A.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }

        #endregion Sort_1 Tests
    }
}
