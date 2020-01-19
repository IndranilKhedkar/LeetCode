using System;
using System.Linq;

namespace Algorithms.Library.Extensions
{
    public static class AttributeExtensions
    {
        /// <summary>
        /// Sample Usage: typeof(SearchInsertPosition).GetAttributeValue((RelatedTopic relatedTopic) => relatedTopic.RelatedTopics);
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="type"></param>
        /// <param name="valueSelector"></param>
        /// <returns></returns>
        public static TValue GetAttributeValue<TAttribute, TValue>(this Type type, Func<TAttribute, TValue> valueSelector)
            where TAttribute : Attribute
        {
            if (type.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() is TAttribute attr)
            {
                return valueSelector(attr);
            }

            return default;
        }
    }
}
