using Algorithms.Contracts;
using System;

namespace Arrays_and_Strings
{
    public class DefangingIPAddress : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/defanging-an-ip-address/
        /// Given a valid (IPv4) IP address, return a defanged version of that IP address.
        /// A defanged IP address replaces every period "." with "[.]".
        /// Example 1:
        ///     Input: address = "1.1.1.1"
        ///     Output: "1[.]1[.]1[.]1"
        /// Example 2: 
        ///     Input: address = "255.100.50.0"
        ///     Output: "255[.]100[.]50[.]0"
        /// </summary>
        public string DefangIPaddr(string address)
        {
            char[] result = new char[address.Length + 6];
            int j = 0;

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                {
                    result[j++] = '[';
                    result[j++] = address[i];
                    result[j++] = ']';
                }
                else
                {
                    result[j++] = address[i];
                }
            }
            return new string(result);
        }

        public override void Run()
        {
            // Example 1
            string address = "1.1.1.1";
            Console.WriteLine($"Input: ${address}\nExpected Output: {"1[.]1[.]1[.]1"}\nActual Output: {DefangIPaddr(address)}");

            // Example 2
            address = "255.100.50.0";
            Console.WriteLine($"Input: ${address}\nExpected Output: {"255[.]100[.]50[.]0"}\nActual Output: {DefangIPaddr(address)}");
        }
    }
}
