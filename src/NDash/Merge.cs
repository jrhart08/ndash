using System.Collections.Generic;
using System.Linq;

namespace NDash
{
    public static partial class NDashLib
    {
        /// <summary>
        /// Merges the 2 dictionaries, with the first dictionary winning key conflicts.
        /// </summary>
        public static IDictionary<K, V> Merge<K, V>(
            this IDictionary<K, V> winner,
            IDictionary<K, V> loser
        )
        {
            return _Merge(winner, loser);
        }

        /// <summary>
        /// Merges the 2 dictionaries, with the second dictionary winning key conflicts.
        /// </summary>
        public static IDictionary<K, V> MergeRight<K, V>(
            this IDictionary<K, V> loser,
            IDictionary<K, V> winner
        )
        {
            return _Merge(winner, loser);
        }

        static IDictionary<K, V> _Merge<K, V>(
            IDictionary<K, V> dict1,
            IDictionary<K, V> dict2
        )
        {
            var entriesToCopy = dict2.Where(entry => !dict1.ContainsKey(entry.Key));

            return dict1
                .Concat(entriesToCopy)
                .ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value
                );
        }
    }
}
