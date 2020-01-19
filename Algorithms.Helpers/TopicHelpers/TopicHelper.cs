using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Algorithms.Library.Extensions;
using System.Collections.Generic;

namespace Algorithms.Helpers.TopicHelpers
{
    public static class TopicHelper
    {
        public static List<Topic> GetRelatedTopics<T>()
        {
            var realtedTopics = typeof(T).GetAttributeValue((RelatedTopic relatedTopic) => relatedTopic.RelatedTopics);
            return realtedTopics != null ? new List<Topic>(realtedTopics) : new List<Topic>();
        }
    }
}
