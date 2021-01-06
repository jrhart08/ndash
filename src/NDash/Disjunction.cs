using System;
using System.Collections.Generic;
using System.Linq;
using static NDash.FP.NDashFP;

namespace NDash
{
    public static partial class NDashLib
    {
        // TODO: upgrade to C# 9 for records
        public class DisjunctionResult<T>
        {
            public IEnumerable<T> Left { get; private set; }
            public IEnumerable<T> Right { get; private set; }

            public DisjunctionResult(IEnumerable<T> left, IEnumerable<T> right)
            {
                Left = left;
                Right = right;
            }

            public void Deconstruct(out IEnumerable<T> left, out IEnumerable<T> right)
            {
                left = Left;
                right = Right;
            }
        }

        public class DisjunctionResult<TLeft, TRight>
        {
            public IEnumerable<TLeft> Left { get; private set; }
            public IEnumerable<TRight> Right { get; private set; }

            public DisjunctionResult(IEnumerable<TLeft> left, IEnumerable<TRight> right)
            {
                Left = left;
                Right = right;
            }

            public void Deconstruct(out IEnumerable<TLeft> left, out IEnumerable<TRight> right)
            {
                left = Left;
                right = Right;
            }
        }

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

        public static DisjunctionResult<TLeft, TRight> Disjunction<TLeft, TRight, TKey>(
            this IEnumerable<TLeft> leftSource,
            IEnumerable<TRight> rightSource,
            Func<TLeft, TKey> leftSelector,
            Func<TRight, TKey> rightSelector
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

            return new DisjunctionResult<TLeft, TRight>(uniqueToLeft, uniqueToRight);
        }

        public static DisjunctionResult<TLeft, TRight> Disjunction<TLeft, TRight>(
            this IEnumerable<TLeft> leftSource,
            IEnumerable<TRight> rightSource,
            Func<TLeft, TRight> leftSelector
        )
        {
            return Disjunction(leftSource, rightSource, leftSelector, Identity);
        }

        public static DisjunctionResult<TLeft, TRight> Disjunction<TLeft, TRight>(
            this IEnumerable<TLeft> leftSource,
            IEnumerable<TRight> rightSource,
            Func<TRight, TLeft> rightSelector
        )
        {
            return Disjunction(leftSource, rightSource, Identity, rightSelector);
        }
    }
}
