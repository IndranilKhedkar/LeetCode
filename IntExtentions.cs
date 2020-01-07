using System;

public static class IntExtentions
{
    public static bool IsSelfDivisible(this int no)
    {
        if (no % 10 == 0)
        {
            return false;
        }

        while (no != 0)
        {
            int digit = no % 10;
            if (no % digit != 0)
            {
                return false;
            }
            no /= 10;
        }
        return true;
    }
}
