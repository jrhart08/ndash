using NDash.common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace NDash
{
    public static partial class NDashLib
    {
        #region dictionary variants
        /// <summary>
        /// Returns a new Dictionary consisting of the source object's properties which match the given predicate.
        /// </summary>
        /// <param name="sourceObject">The object to pick properties from.</param>
        /// <param name="predicate">A predicate to apply to each property on the given object. The second parameter is the name of the property.</param>
        /// <returns></returns>
        public static Dictionary<string, object> PickBy(object sourceObject, Func<object, string, bool> predicate)
        {
            return Reflector
                .GetPublicInstanceProperties(sourceObject)
                .Select(prop => new
                {
                    prop.Name,
                    Value = prop.GetValue(sourceObject),
                })
                .Where(pair => predicate(pair.Value, pair.Name))
                .ToDictionary(
                    pair => pair.Name,
                    pair => pair.Value
                );
        }

        /// <summary>
        /// Returns a new Dictionary consisting of the source object's properties which match the given predicate.
        /// </summary>
        /// <param name="sourceObject">The object to pick properties from.</param>
        /// <param name="predicate">A predicate to apply to each property on the given object.</param>
        /// <returns></returns>
        public static Dictionary<string, object> PickBy(object sourceObject, Func<object, bool> predicate)
        {
            // shape this predicate for extended PickBy function
            Func<object, string, bool> paddedPredicate =
                (propertyValue, propertyName) => predicate(propertyValue);

            return PickBy(sourceObject, paddedPredicate);
        }
        #endregion

        #region ExpandoObject variants
        /// <summary>
        /// Returns a new ExpandoObject consisting of the source object's properties which match the given predicate.
        /// </summary>
        /// <param name="sourceObject">The object to pick properties from.</param>
        /// <param name="predicate">A predicate to apply to each property on the given object. The second parameter is the name of the property.</param>
        /// <returns></returns>
        public static ExpandoObject PickByExpando(object sourceObject, Func<object, string, bool> predicate)
        {
            return PickBy(sourceObject, predicate).ToExpandoObject();
        }

        /// <summary>
        /// Returns a new ExpandoObject consisting of the source object's properties which match the given predicate.
        /// </summary>
        /// <param name="sourceObject">The object to pick properties from.</param>
        /// <param name="predicate">A predicate to apply to each property on the given object.</param>
        /// <returns></returns>
        public static ExpandoObject PickByExpando(object sourceObject, Func<object, bool> predicate)
        {
            return PickBy(sourceObject, predicate).ToExpandoObject();
        }
        #endregion

        #region Generic variants
        public static T PickBy<T>(object sourceObject, Func<object, bool> predicate) where T : new()
        {
            return Reflector.MapCommonProperties<T>(PickBy(sourceObject, predicate));
        }

        public static T PickBy<T>(object sourceObject, Func<object, string, bool> predicate) where T : new()
        {
            return Reflector.MapCommonProperties<T>(PickBy(sourceObject, predicate));
        }
        #endregion
    }
}
