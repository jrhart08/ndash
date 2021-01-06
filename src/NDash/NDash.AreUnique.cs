using System;
using System.Linq;
using System.Collections.Generic;

namespace NDash
{
    public static partial class NDashLib
    {
        /// <summary>
        /// Returns `true` if all items are unique, false otherwise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static bool AreUnique<T>(this IEnumerable<T> collection)
        {
            return AreUniqueBy(collection, Identity);
        }

        /// <summary>
        /// Returns `true` if all items are unique, false otherwise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="collection"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static bool AreUniqueBy<T, TResult>(
            this IEnumerable<T> collection,
            Func<T, TResult> selector
        )
        {
            var diffChecker = new HashSet<TResult>();

            return collection.All(item => diffChecker.Add(selector(item)));
        }
    }
}
