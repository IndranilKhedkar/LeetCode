using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/excel-sheet-column-title/
    /// Given a positive integer, return its corresponding column title as appear in an Excel sheet.
    /// For example:
    ///     1 -> A
    ///     2 -> B
    ///     3 -> C
    ///     ...
    ///     26 -> Z
    ///     27 -> AA
    ///     28 -> AB
    /// </summary>
    [RelatedTopic(Topic.Math)]
    public class ExcelSheetColumnTitle : Question
    {
        public string ConvertToTitle(int n)
        {
            string result = string.Empty;

            do
            {
                n -= 1;
                int mod = n % 26;
                result = (char)('A' + mod) + result;
                n /= 26;
            } while (n != 0);

            return result;
        }

        public override void Run()
        {
            // Example 1
            int n = 1;
            var result = ConvertToTitle(n);

            // Example 2
            n = 26;
            result = ConvertToTitle(n);

            // Example 3
            n = 28;
            result = ConvertToTitle(n);

            // Example 4
            n = 701;
            result = ConvertToTitle(n);

            // Example 5
            n = 1000;
            result = ConvertToTitle(n);
        }
    }
}
