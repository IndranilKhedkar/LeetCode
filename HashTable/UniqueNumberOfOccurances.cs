using Algorithms.Contracts;
using System.Collections;
using System.Collections.Generic;

namespace HashTable
{
    public class UniqueNumberOfOccurances : Question
    {
        public bool UniqueOccurrences(int[] arr)
        {
            int len = arr.Length;
            Hashtable hashTable = new Hashtable();
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < len; i++)
            {
                if (hashTable.ContainsKey(arr[i]))
                {
                    hashTable[arr[i]] = (int)hashTable[arr[i]] + 1;
                }
                else
                {
                    hashTable.Add(arr[i], 1);
                }
            }

            foreach (DictionaryEntry kvp in hashTable)
            {
                if (hashSet.Contains((int)kvp.Value))
                {
                    return false;
                }
                else
                {
                    hashSet.Add((int)kvp.Value);
                }
            }

            return true;
        }


        public override void Run()
        {
            UniqueOccurrences(new int[] { 1, 2, 2, 1, 1, 3 });
            UniqueOccurrences(new int[] { 1, 2 });
            UniqueOccurrences(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 });
        }
    }
}
