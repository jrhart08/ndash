using System;
using System.Collections.Generic;
using System.Linq;

namespace NDash
{
    public static partial class NDashLib
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection)
        {
            return collection.Shuffle(new Random());
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection, int seed)
        {
            return collection.Shuffle(new Random(seed));
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection, Random rng)
        {
            int count = collection.Count();

            var shuffled = collection.ToList();

            for (int i = 0; i < count; i++)
            {
                int next = rng.Next(count);

                shuffled.Swap(i, next);
            }

            return shuffled;
        }
    }
}
