using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NDash
{
    public static partial class NDashLib
    {
        /// <summary>
        /// Like Shuffle, but more secure, because reasons.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IEnumerable<T> CryptoShuffle<T>(this IEnumerable<T> collection)
        {
            var shuffled = collection.ToList();
            int count = shuffled.Count;

            for(int i = 0; i < count; i++)
            {
                int next = RandomNumberGenerator.GetInt32(count);

                shuffled.Swap(i, next);
            }

            return shuffled;
        }
    }
}
