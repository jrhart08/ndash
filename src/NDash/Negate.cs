using System;
using System.Collections.Generic;
using System.Text;

namespace NDash
{
    public static partial class NDashLib
    {
        public static Func<bool> Negate(this Func<bool> predicate) =>
            () => !predicate();

        public static Func<T1, bool> Negate<T1>(this Func<T1, bool> predicate) =>
            (T1 t1) => !predicate(t1);

        public static Func<T1, T2, bool> Negate<T1, T2>(this Func<T1, T2, bool> predicate) =>
            (T1 t1, T2 t2) => !predicate(t1, t2);

        public static Func<T1, T2, T3, bool> Negate<T1, T2, T3>(this Func<T1, T2, T3, bool> predicate) =>
            (T1 t1, T2 t2, T3 t3) => !predicate(t1, t2, t3);

        public static Func<T1, T2, T3, T4, bool> Negate<T1, T2, T3, T4>(this Func<T1, T2, T3, T4, bool> predicate) =>
            (T1 t1, T2 t2, T3 t3, T4 t4) => !predicate(t1, t2, t3, t4);
    }
}
