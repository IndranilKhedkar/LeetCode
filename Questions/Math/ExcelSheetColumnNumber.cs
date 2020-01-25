using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;

namespace Math
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/excel-sheet-column-number/
    /// Given a column title as appear in an Excel sheet, return its corresponding column number.
    /// For example:
    ///     A -> 1
    ///     B -> 2
    ///     C -> 3
    ///     ...
    ///     Z -> 26
    ///     AA -> 27
    ///     AB -> 28
    /// </summary>
    [RelatedTopic(Topic.Math)]
    public class ExcelSheetColumnNumber : Question
    {
        public int TitleToNumber(string s)
        {
            int result = 0;
            int pow = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                //result += (int)System.Math.Pow(26, pow++) * (s[i] - 'A' + 1);
                result += (int)System.Math.Pow(26, pow++) * (s[i] - 64);
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            // Output: 1
            string s = "A";
            var result = TitleToNumber(s);

            // Example 2
            // Output: 28
            s = "AB";
            result = TitleToNumber(s);

            // Example 3
            // Output: 701
            s = "ZY";
            result = TitleToNumber(s);

            // Example 4
            // Output: 703
            s = "AAA";
            result = TitleToNumber(s);

            // Example 5
            // Output: 18277
            s = "ZZY";
            result = TitleToNumber(s);
        }
    }
}
