using NDash.common;
using System.Collections.Generic;
using System.Dynamic;

namespace NDash
{
    public static partial class NDashLib
    {
        public static Dictionary<string, object> Omit(object sourceObject, params string[] properties)
            => OmitBy(sourceObject, PickOmitHelper.ToPropLookup(properties));

        public static ExpandoObject OmitExpando(object sourceObject, params string[] properties)
            => OmitByExpando(sourceObject, PickOmitHelper.ToPropLookup(properties));

        public static T Omit<T>(object sourceObject, params string[] properties) where T : new()
            => OmitBy<T>(sourceObject, PickOmitHelper.ToPropLookup(properties));
    }
}
