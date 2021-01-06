using System.Collections.Generic;
using System.Linq;

namespace NDash
{
    public static partial class NDashLib
    {
        /// <summary>
        /// Flattens nested collections. Syntactic sugar for <c>nestedCollection.SelectMany(a => a)</c>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nestedCollection"></param>
        /// <returns></returns>
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> nestedCollection)
        {
            return nestedCollection.SelectMany(Identity);
        }
    }
}
