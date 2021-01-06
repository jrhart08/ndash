using System;
using System.Collections.Generic;
using System.Linq;

namespace NDash
{
    public static partial class NDashLib
    {
        public static IEnumerable<T> DisjunctiveUnion<T, TKey>(
            this IEnumerable<T> leftSource,
            IEnumerable<T> rightSource,
            Func<T, TKey> keySelector
        )
        {
            var (left, right) = leftSource.Disjunction(rightSource, keySelector);

            return left.Concat(right);
        }

        public static IEnumerable<T> DisjunctiveUnion<T>(
            this IEnumerable<T> leftSource,
            IEnumerable<T> rightSource
        )
        {
            return leftSource.DisjunctiveUnion(rightSource, Identity);
        }
    }
}
