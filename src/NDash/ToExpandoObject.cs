using NDash.common;
using System.Collections.Generic;
using System.Dynamic;

namespace NDash
{
    public static partial class NDashLib
    {
        /// <summary>
        /// Copies an <c>IDictionary&lt;string, object&gt;</c> into an ExpandoObject. Useful if you want to quickly make it serializable.
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static ExpandoObject ToExpandoObject(this IDictionary<string, object> dict)
        {
            IDictionary<string, object> expando = new ExpandoObject();

            foreach (var kvp in dict)
            {
                expando.Add(kvp);
            }

            return (ExpandoObject)expando;
        }

        /// <summary>
        /// Copies the object into an ExpandoObject. Useful if you're too lazy for class(es).
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static ExpandoObject ToExpandoObject(object source)
        {
            var props = Reflector.GetPublicInstanceProperties(source);

            IDictionary<string, object> expando = new ExpandoObject();
            foreach(var prop in props)
            {
                expando.Add(prop.Name, prop.GetValue(source));
            }

            return (ExpandoObject)expando;
        }
    }
}
