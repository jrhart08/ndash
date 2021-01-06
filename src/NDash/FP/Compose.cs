using System;

namespace NDash.FP
{
    public static partial class NDashFP
    {
        /// <summary>
        /// Allows piping of Funcs. Chaining Funcs together will build a `Func<TFirstIn, TLastOut>` delegate.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="g"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Func<T1, T3> Compose<T1, T2, T3>(this Func<T1, T2> g, Func<T2, T3> f)
        {
            return x => f(g(x));
        }

        /// <summary>
        /// Alias for `Compose`.
        /// Allows piping of Funcs. Chaining Funcs together will build a `Func<TFirstIn, TLastOut>` delegate.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="g"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Func<T1, T3> PipeTo<T1, T2, T3>(this Func<T1, T2> g, Func<T2, T3> f)
        {
            return g.Compose(f);
        }
    }
}
