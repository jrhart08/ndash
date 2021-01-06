using System.Collections.Generic;
using System.Security.Cryptography;

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
        public static List<T> CryptoShuffle<T>(this IEnumerable<T> collection)
        {
            return collection.Shuffle(RandomNumberGenerator.GetInt32);
        }
    }
}
