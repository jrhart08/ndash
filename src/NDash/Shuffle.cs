using System;
using System.Collections.Generic;
using System.Linq;

namespace NDash
{
    public static partial class NDashLib
    {
        /// <summary>
        /// Shuffles the collection using System.Random
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static List<T> Shuffle<T>(this IEnumerable<T> collection)
        {
            return collection.Shuffle(new Random());
        }

        /// <summary>
        /// Shuffles the collection using the provided Random object's Next() function
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="rng"></param>
        /// <returns></returns>
        public static List<T> Shuffle<T>(this IEnumerable<T> collection, Random rng)
        {
            return collection.Shuffle(rng.Next);
        }

        /// <summary>
        /// Shuffles the collection.
        /// randomNumberGenerator` provides the number of elements in the collection for 
        /// developers providing more fine-grained random number generators.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="randomNumberGenerator"></param>
        /// <returns></returns>
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
