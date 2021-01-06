using System;
using System.Collections.Generic;
using System.Linq;

namespace NDash
{
    public static partial class NDashLib
    {
        public record DisjunctionResult<T>(IEnumerable<T> Left, IEnumerable<T> Right);
        public record DisjunctionResult<L, R>(IEnumerable<L> Left, IEnumerable<R> Right);

        public static DisjunctionResult<T> Disjunction<T>(this IEnumerable<T> leftSource, IEnumerable<T> rightSource)
        {
            var uniqueToLeft = leftSource.Except(rightSource);
            var uniqueToRight = rightSource.Except(leftSource);

            return new DisjunctionResult<T>(uniqueToLeft, uniqueToRight);
        }

        public static DisjunctionResult<T> Disjunction<T, TKey>(
            this IEnumerable<T> leftSource,
            IEnumerable<T> rightSource,
            Func<T, TKey> selector
        )
        {
            var (left, right) = Disjunction(leftSource, rightSource, selector, selector);

            return new DisjunctionResult<T>(left, right);
        }

        public static DisjunctionResult<L, R> Disjunction<L, R, TKey>(
            this IEnumerable<L> leftSource,
            IEnumerable<R> rightSource,
            Func<L, TKey> leftSelector,
            Func<R, TKey> rightSelector
        )
        {
            var leftKeyed = leftSource.ToLookup(leftSelector);
            var rightKeyed = rightSource.ToLookup(rightSelector);

            var uniqueToLeft = leftKeyed
                .Where(group => !rightKeyed[group.Key].Any())
                .Flatten();

            var uniqueToRight = rightKeyed
                .Where(group => !leftKeyed[group.Key].Any())
                .Flatten();

            return new DisjunctionResult<L, R>(uniqueToLeft, uniqueToRight);
        }

        public static DisjunctionResult<L, R> Disjunction<L, R>(
            this IEnumerable<L> leftSource,
            IEnumerable<R> rightSource,
            Func<L, R> leftSelector
        )
        {
            return Disjunction(leftSource, rightSource, leftSelector, Identity);
        }

        public static DisjunctionResult<L, R> Disjunction<L, R>(
            this IEnumerable<L> leftSource,
            IEnumerable<R> rightSource,
            Func<R, L> rightSelector
        )
        {
            return Disjunction(leftSource, rightSource, Identity, rightSelector);
        }
    }
}
