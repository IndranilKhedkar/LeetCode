using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTable
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/lru-cache/
    /// Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.
    ///     get(key) - Get the value(will always be positive) of the key if the key exists in the cache, otherwise return -1.
    ///     put(key, value) - Set or insert the value if the key is not already present.When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.
    ///     The cache is initialized with a positive capacity.
    ///    
    /// Follow up:
    ///    Could you do both operations in O(1) time complexity?
    ///    
    /// Example:
    ///     LRUCache cache = new LRUCache(2 /* capacity */ );
    ///     cache.put(1, 1);
    ///     cache.put(2, 2);
    ///     cache.get(1);       // returns 1
    ///     cache.put(3, 3);    // evicts key 2
    ///     cache.get(2);       // returns -1 (not found)
    ///     cache.put(4, 4);    // evicts key 1
    ///     cache.get(1);       // returns -1 (not found)
    ///     cache.get(3);       // returns 3
    ///     cache.get(4);       // returns 4
    /// </summary>
    [RelatedTopic(Topic.HashTable)]
    [RelatedTopic(Topic.DoublyLinkedList)]
    public class LruCache : Question
    {
        private readonly Dictionary<int, Node> _nodeByKey;
        private readonly int _capacity;
        private readonly Node _head = new Node();
        private readonly Node _tail = new Node();

        public LruCache(int capacity)
        {
            _nodeByKey = new Dictionary<int, Node>();
            _capacity = capacity;
            _head.NextNode = _tail;
            _tail.PrevNode = _head;
        }

        public int Get(int key)
        {
            int result = -1;
            if (_nodeByKey.ContainsKey(key))
            {
                var node = _nodeByKey[key];
                result = node.Value;
                RemoveNode(node);
                AddAfterHeadNode(node);
            }

            return result;
        }

        public void Put(int key, int value)
        {
            if (_nodeByKey.ContainsKey(key))
            {
                var node = _nodeByKey[key];
                node.Value = value;
                RemoveNode(node);
                AddAfterHeadNode(node);
            }
            else
            {
                if (_nodeByKey.Count == _capacity)
                {
                    _nodeByKey.Remove(_tail.PrevNode.Key);
                    RemoveNode(_tail.PrevNode);
                }

                Node node = new Node
                {
                    Key = key,
                    Value = value
                };

                _nodeByKey[key] = node;
                AddAfterHeadNode(node);
            }
        }

        public void AddAfterHeadNode(Node node)
        {
            Node headNextNode = _head.NextNode;
            headNextNode.PrevNode = node;
            node.NextNode = headNextNode;
            node.PrevNode = _head;
            _head.NextNode = node;
        }

        public void RemoveNode(Node node)
        {
            Node prevNode = node.PrevNode;
            Node nextNode = node.NextNode;

            prevNode.NextNode = nextNode;
            nextNode.PrevNode = prevNode;
        }

        public override void Run()
        {
            // Example 1
        }

        public class Node
        {
            public int Key { get; set; }
            public int Value { get; set; }
            public Node PrevNode { get; set; }
            public Node NextNode { get; set; }
        }
    }

}
