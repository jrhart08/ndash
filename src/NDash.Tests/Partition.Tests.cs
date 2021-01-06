﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NDash.Tests
{
    public class NDash_Partition_Tests
    {
        static bool IsEven(int i) => i % 2 == 0;

        public class given_empty_collection
        {
            [Fact]
            public void should_return_empty_lists()
            {
                IEnumerable<int> empty = new List<int>();

                var (evens, odds) = empty.Partition(IsEven);

                Assert.Empty(evens);
                Assert.Empty(odds);
            }
        }

        public class given_nonempty_collection
        {
            readonly int[] numbers = new[] { 1, 2, 3, 4 };
            readonly int[] expectedEvens = new[] { 2, 4 };
            readonly int[] expectedOdds = new[] { 1, 3 };
            
            [Fact]
            public void should_partition_by_predicate()
            {
                var (evens, odds) = NDashLib.Partition(numbers, IsEven);
                Assert.Equal(expectedEvens, evens);
                Assert.Equal(expectedOdds, odds);
            }

            [Fact]
            public void should_provide_extension_method()
            {
                var (evens, odds) = numbers.Partition(IsEven);
                Assert.Equal(expectedEvens, evens);
                Assert.Equal(expectedOdds, odds);
            }
        }
    }
}
