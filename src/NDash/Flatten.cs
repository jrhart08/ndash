using System.Collections.Generic;
using System.Linq;

namespace NDash
{
    public static partial class NDashLib
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> nestedCollection)
        {
            return nestedCollection.SelectMany(Identity);
        }
    }
}
