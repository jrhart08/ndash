using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NDash.FP
{
    public static partial class NDashFP
    {
        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop() { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1>(T1 i1) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2>(T1 p1, T2 p2) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3>(T1 p1, T2 p2, T3 p3) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7, T8>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15) { }

        /// <summary>
        /// Noop function. Does nothing.
        /// </summary>
        public static void Noop<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16) { }

        public static Task NoopAsync() => Task.CompletedTask;
        public static Task NoopAsync<T1>(T1 i1) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2>(T1 p1, T2 p2) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3>(T1 p1, T2 p2, T3 p3) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7, T8>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15) => Task.CompletedTask;
        public static Task NoopAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16) => Task.CompletedTask;
    }
}
