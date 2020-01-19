using Algorithms.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    public class UniqueEmailAddresses : Question
    {
        /// <summary>
        /// Reference Link: https://leetcode.com/problems/unique-email-addresses/
        /// Every email consists of a local name and a domain name, separated by the @ sign.
        /// For example, in alice @leetcode.com, alice is the local name, and leetcode.com is the domain name.
        /// Besides lowercase letters, these emails may contain '.'s or '+'s.
        /// If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)
        /// If you add a plus('+') in the local name, everything after the first plus sign will be ignored.This allows certain emails to be filtered, for example m.y+name @email.com will be forwarded to my@email.com.  (Again, this rule does not apply for domain names.)
        /// It is possible to use both of these rules at the same time.
        /// Given a list of emails, we send one email to each address in the list.How many different addresses actually receive mails? 
        /// </summary>
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> uniqueEmailAddresses = new HashSet<string>();
            int len = emails.Length;

            for (int i = 0; i < len; i++)
            {
                string emailAddress = emails[i];
                int emailLength = emailAddress.Length;
                bool encounteredAtTheRateChar = false;
                bool encounteredPlusChar = false;
                StringBuilder stringBuilder = new StringBuilder();

                for (int j = 0; j < emailLength; j++)
                {
                    if (emailAddress[j] == '@')
                    {
                        encounteredAtTheRateChar = true;
                    }

                    if (emailAddress[j] == '+')
                    {
                        encounteredPlusChar = true;
                    }

                    bool includeCurrentChar = encounteredAtTheRateChar || (!encounteredPlusChar && emailAddress[j] != '.');
                    if (includeCurrentChar)
                    {
                        stringBuilder.Append(emailAddress[j]);
                    }
                }

                uniqueEmailAddresses.Add(stringBuilder.ToString());
            }

            return uniqueEmailAddresses.Count;
        }

        public override void Run()
        {
            // Example 1
            string[] input = new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            NumUniqueEmails(input);
        }
    }
}
