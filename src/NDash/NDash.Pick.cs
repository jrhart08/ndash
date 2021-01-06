using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using NDash.common;

namespace NDash
{
    public static partial class NDashLib
    {

        public static Dictionary<string, object> Pick(object sourceObject, params string[] properties)
            => PickBy(sourceObject, PickOmitHelper.ToPropLookup(properties));

        public static ExpandoObject PickExpando(object sourceObject, params string[] properties)
            => PickByExpando(sourceObject, PickOmitHelper.ToPropLookup(properties));

        public static T Pick<T>(object sourceObject, params string[] properties) where T : new()
            => PickBy<T>(sourceObject, PickOmitHelper.ToPropLookup(properties));
    }
}
