using NDash.common;
using System;

namespace NDash
{
    public static partial class NDashLib
    {
        public static Func<T1, TResult>
            Curry<T1, TResult>(this Func<T1, TResult> fun)
        {
            return fun;
        }

        public static Func<T1, Func<T2, TResult>>
            Curry<T1, T2, TResult>(this Func<T1, T2, TResult> fun)
        {
            return t1 => t2 => fun(t1, t2);
        }

        public static Func<T1, Func<T2, Func<T3, TResult>>>
            Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> fun)
        {
            return t1 => t2 => t3 => fun(t1, t2, t3);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>
            Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> fun)
        {
            return t1 => t2 => t3 => t4 => fun(t1, t2, t3, t4);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>
            Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> fun)
        {
            return t1 => t2 => t3 => t4 => t5 => fun(t1, t2, t3, t4, t5);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> fun)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => fun(t1, t2, t3, t4, t5, t6);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> fun)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => fun(t1, t2, t3, t4, t5, t6, t7);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>
            Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fun)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => fun(t1, t2, t3, t4, t5, t6, t7, t8);
        }
    }
}
