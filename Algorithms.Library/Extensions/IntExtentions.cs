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

        /// <summary>
        /// Returns true if num is a perfect square, otherwise false.
        /// </summary>
        /// <param name="num">Number</param>
        /// <returns>bool</returns>
        public static bool IsPerfectSquare(this int num)
        {
            int start = 0;
            int end = num;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                ulong square = ((ulong)mid * (ulong)mid);

                if (square == (ulong)num)
                    return true;
                else if (square < (ulong)num)
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return false;
        }

        /// <summary>
        /// Returns true if num is a prime, otherwise false.
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>bool</returns>
        public static bool IsPrime(this int n)
        {
            int sqrt = (int)System.Math.Sqrt(n);
            if (n <= 1)
                return false;

            int i = 2;
            while (i <= sqrt)
            {
                if (n % i == 0)
                {
                    return false;
                }
                i++;
            }

            return true;
        }
    }
}
