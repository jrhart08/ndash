using System;
using System.Linq;

namespace NDash.common
{
    class PickOmitHelper
    {
        public static Func<object, string, bool> ToPropLookup(string[] properties)
        {
            var propHash = properties.ToHashSet();

            return (val, key) => propHash.Contains(key);
        }
    }
}
