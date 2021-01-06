using System;
using System.Collections.Generic;
using System.Text;

namespace NDash
{
    public static partial class NDashLib
    {
        // public static Func<T, T> Identity<T>() => item => item;
        public static T Identity<T>(T item) => item;
    }
}
