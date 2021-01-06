using System;
using System.Collections.Generic;
using System.Text;

namespace NDash.FP
{
    public static partial class NDashFP
    {
        // public static Func<T, T> Identity<T>() => item => item;
        public static T Identity<T>(T item) => item;
    }
}
