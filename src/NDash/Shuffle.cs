using System;
using System.Collections.Generic;
using System.Linq;

namespace NDash
{
    public static partial class NDashLib
    {
        public static List<T> Shuffle<T>(this IEnumerable<T> collection)
        {
            return collection.Shuffle(new Random());
        }

        public static List<T> Shuffle<T>(this IEnumerable<T> collection, int seed)
        {
            return collection.Shuffle(new Random(seed));
        }

        public static List<T> Shuffle<T>(this IEnumerable<T> collection, Random rng)
        {
            return collection.Shuffle(rng.Next);
        }

        public static List<T> Shuffle<T>(this IEnumerable<T> collection, Func<int, int> randomNumberGenerator)
        {
            var shuffled = collection.ToList();
            int count = shuffled.Count;

            for (int i = 0; i < count; i++)
            {
                int next = randomNumberGenerator(count);

                shuffled.Swap(i, next);
            }

            return shuffled;
        }
    }
}
