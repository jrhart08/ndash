using System;
using System.Collections.Generic;
using System.Dynamic;

namespace NDash
{
    public static partial class NDashLib
    {
        // there's gotta be a way to trick roslyn into compiling this
        //public static Func<TResult, TFunc> InverseOf<T, TFunc, TResult>(Func<Func<T, bool>, TFunc> predicateOperator)
        //{
        //    return predicate => predicateOperator(Negate(predicate));
        //}

        #region Dictionary variants
        public static Dictionary<string, object> OmitBy(object sourceObject, Func<object, string, bool> predicate)
            => PickBy(sourceObject, Negate(predicate));

        public static Dictionary<string, object> OmitBy(object sourceObject, Func<object, bool> predicate)
            => PickBy(sourceObject, Negate(predicate));
        #endregion

        #region ExpandoObject variants
        /// <summary>
        /// (Inverse of PickBy): Returns a new ExpandoObject consisting of the source object's properties which DO NOT match the given predicate.
        /// </summary>
        /// <param name="sourceObject">The object to pick properties from.</param>
        /// <param name="predicate">A predicate to apply to each property on the given object. The second parameter is the name of the property.</param>
        /// <returns></returns>
        public static ExpandoObject OmitByExpando(object sourceObject, Func<object, string, bool> predicate)
            => PickByExpando(sourceObject, Negate(predicate));

        /// <summary>
        /// (Inverse of PickBy): Returns a new ExpandoObject consisting of the source object's properties which DO NOT match the given predicate.
        /// </summary>
        /// <param name="sourceObject">The object to pick properties from.</param>
        /// <param name="predicate">A predicate to apply to each property on the given object.</param>
        /// <returns></returns>
        public static ExpandoObject OmitByExpando(object sourceObject, Func<object, bool> predicate)
            => PickByExpando(sourceObject, Negate(predicate));
        #endregion

        #region Generic variants
        public static T OmitBy<T>(object sourceObject, Func<object, string, bool> predicate) where T : new()
            => PickBy<T>(sourceObject, Negate(predicate));

        public static T OmitBy<T>(object sourceObject, Func<object, bool> predicate) where T : new()
            => PickBy<T>(sourceObject, Negate(predicate));
        #endregion
    }
}
