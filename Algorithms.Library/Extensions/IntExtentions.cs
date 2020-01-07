namespace Algorithms.Library.Extensions
{
    public static class IntExtentions
    {
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
    }
}