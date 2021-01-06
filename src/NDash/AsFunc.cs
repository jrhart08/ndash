using System;
using System.Collections.Generic;
using System.Text;

namespace NDash
{
    public static partial class NDashLib
    {
        public static Func<TResult> AsFunc<TResult>(Func<TResult> method) => method;

        public static Func<T1, TResult> AsFunc<T1, TResult>(Func<T1, TResult> method) => method;
    }
}
