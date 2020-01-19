using Algorithms.Contracts;
using System.Collections;
using System.Collections.Generic;

namespace HashTable
{
    public class SubdomainVisitCount : Question
    {
        private readonly Hashtable domainVisitsHashTable = new Hashtable();

        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            domainVisitsHashTable.Clear();

            int len = cpdomains.Length;
            List<string> result = new List<string>();

            for (int i = 0; i < len; i++)
            {
                string[] domainAndVisitCount = cpdomains[i].Split(' ');
                int visitCount = int.Parse(domainAndVisitCount[0]);
                string domain = domainAndVisitCount[1];
                int domainLength = domain.Length;

                AddOrUpdateDomainVisitsHashTable(domain, visitCount);

                for (int j = 0; j < domainLength; j++)
                {
                    if (domain[j] == '.')
                    {
                        AddOrUpdateDomainVisitsHashTable(domain.Substring(j + 1), visitCount);
                    }
                }
            }

            foreach (DictionaryEntry entry in domainVisitsHashTable)
            {
                result.Add($"{entry.Value} {entry.Key}");
            }

            return result;
        }

        private void AddOrUpdateDomainVisitsHashTable(string domain, int visitCount)
        {
            if (domainVisitsHashTable.ContainsKey(domain))
            {
                domainVisitsHashTable[domain] = visitCount + (int)domainVisitsHashTable[domain];
            }
            else
            {
                domainVisitsHashTable.Add(domain, visitCount);
            }
        }

        public override void Run()
        {
            // Example 1
            string[] input = new string[] { "9001 discuss.leetcode.com" };
            SubdomainVisits(input);

            // Example 2
            input = new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
            SubdomainVisits(input);
        }
    }
}
