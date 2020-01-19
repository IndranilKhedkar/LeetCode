using Algorithms.Helpers.Enums;
using System;
using System.Collections.Generic;

namespace Algorithms.Helpers.Attibutes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class RelatedTopic : Attribute
    {
        private static readonly HashSet<Topic> _relatedTopics = new HashSet<Topic>();

        public RelatedTopic(Topic topic)
        {
            _relatedTopics.Add(topic);
        }

        public HashSet<Topic> RelatedTopics
        {
            get { return _relatedTopics; }
        }
    }
}
