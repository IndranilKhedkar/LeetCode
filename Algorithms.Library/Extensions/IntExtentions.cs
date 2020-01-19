namespace Algorithms.Library.Extensions
{
    public static class IntExtentions
    {
        /// <summary>
        /// Checks whether number is self-dividing or not.
        /// A self-dividing number is a number that is divisible by every digit it contains.
        /// </summary>
        /// <param name="no"></param>
        /// <returns>true/false</returns>
        public static bool IsSelfDivisible(this int no)
        {
            if (no % 10 == 0)
            {
                return false;
            }

            int n = no;
            while (n != 0)
            {
                int digit = n % 10;
                if (digit == 0 || no % digit != 0)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

        /// <summary>
        /// Returns the floor square root of a non-negative integer.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>int</returns>
        public static int FloorSqrt(this int n)
        {
            int start = 0;
            int end = n;

            while (start < end)
            {
                int mid = (start + end) / 2;
                ulong squareOfMid = ((ulong)mid * (ulong)mid);

                if (squareOfMid == (ulong)n)
                    return mid;
                else if ((ulong)n > squareOfMid)
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            int result = (start * start) > n ? start - 1 : start;

            return result;
        }
    }
}
