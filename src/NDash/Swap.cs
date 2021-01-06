using System.Collections.Generic;

namespace NDash
{
    public static partial class NDashLib
    {
        /// <summary>
        /// Swaps 2 elements in-place (READ: mutates the list)
        /// </summary>
        public static IList<T> Swap<T>(this IList<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;

            return list;
        }
    }
}
