using System;
using System.Collections;
using System.Collections.Generic;

namespace NDash
{
    public static partial class NDashLib
    {
        public record PartitionResult<T>(List<T> Yes, List<T> No)
        {
            public IEnumerable<List<T>> AsEnumerable() => new[] { Yes, No };
        }

        public static PartitionResult<T> Partition<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var yes = new List<T>();
            var no = new List<T>();

            foreach(T item in collection)
            {
                var list = predicate(item) ? yes : no;

                list.Add(item);
            }

            return new PartitionResult<T>(yes, no);
        }
    }
}
