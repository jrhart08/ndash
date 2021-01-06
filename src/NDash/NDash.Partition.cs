using System;
using System.Collections;
using System.Collections.Generic;

namespace NDash
{
    public static partial class NDashLib
    {
        public class PartitionResult<T>
        {
            public List<T> Yes { get; private set; }
            public List<T> No { get; private set; }

            public PartitionResult(List<T> yes, List<T> no)
            {
                Yes = yes;
                No = no;
            }

            public void Deconstruct(out List<T> yes, out List<T> no)
            {
                yes = Yes;
                no = No;
            }

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
