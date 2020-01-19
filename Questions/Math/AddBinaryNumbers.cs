using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/fibonacci-number/
    /// Given two binary strings, return their sum (also a binary string).
    /// The input strings are both non-empty and contains only characters 1 or 0.
    /// Example 1:
    ///     Input: a = "11", b = "1"
    ///     Output: "100"
    /// Example 2:
    ///     Input: a = "1010", b = "1011"
    ///     Output: "10101"
    /// </summary>
    [RelatedTopic(Topic.Math)]
    [RelatedTopic(Topic.String)]
    public class AddBinaryNumbers : Question
    {
        public string AddBinary(string a, string b)
        {
            string result = string.Empty;
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;

            while (i >= 0 || j >= 0 || carry == 1)
            {
                carry += (i >= 0) ? a[i] - '0' : 0;
                carry += (j >= 0) ? b[j] - '0' : 0;

                result = carry % 2 + result;
                carry /= 2;

                i--;
                j--;
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            // Output: "100"
            string a = "11";
            string b = "1";
            string result = AddBinary(a, b);

            // Example 2
            // Output: "10101"
            a = "1010";
            b = "1011";
            result = AddBinary(a, b);
        }
    }
}
