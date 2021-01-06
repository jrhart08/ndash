using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace NDash.common
{
    /// <summary>
    /// Internal helper function(s)
    /// </summary>
    class Reflector
    {
        public static IEnumerable<PropertyInfo> GetPublicInstanceProperties(Type type)
            => type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        public static IEnumerable<PropertyInfo> GetPublicInstanceProperties<T>()
            => GetPublicInstanceProperties(typeof(T));

        public static IEnumerable<PropertyInfo> GetPublicInstanceProperties(object obj)
            => GetPublicInstanceProperties(obj.GetType());

        // TODO: Poor man's AutoMapper. Just use AutoMapper.
        public static T MapCommonProperties<T>(IDictionary<string, object> source) where T : new()
        {
            var commonProps = GetPublicInstanceProperties<T>().Where(prop => source.ContainsKey(prop.Name));

            T target = new T();
            foreach (PropertyInfo prop in commonProps)
            {
                object value = source[prop.Name];

                // probably want to do some type-checking here
                prop.SetValue(target, value);
            }

            return target;

            // functional purist way
            //return commonProps.Aggregate(new T(), (result, prop) => {
            //    object value = source[prop.Name];

            //    prop.SetValue(result, value);

            //    return result;
            //});
        }

        public static ExpandoObject ToExpandoObject(IDictionary<string, object> dict)
        {
            IDictionary<string, object> expando = new ExpandoObject();

            foreach(var entry in dict)
            {
                expando.Add(entry.Key, entry.Value);
            }

            return (ExpandoObject)expando;
        }
    }
}
