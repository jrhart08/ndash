using System.Collections.Generic;
using Xunit;

namespace NDash.Tests
{
    public class PartitionTests
    {
        static bool IsEven(int i) => i % 2 == 0;

        public class given_empty_collection
        {
            [Fact]
            public void should_return_empty_lists()
            {
                IEnumerable<int> empty = new List<int>();

                var (evens, odds) = empty.SeparateBy(IsEven);

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
                var (evens, odds) = NDashLib.SeparateBy(numbers, IsEven);
                Assert.Equal(expectedEvens, evens);
                Assert.Equal(expectedOdds, odds);
            }

            [Fact]
            public void should_provide_extension_method()
            {
                var (evens, odds) = numbers.SeparateBy(IsEven);
                Assert.Equal(expectedEvens, evens);
                Assert.Equal(expectedOdds, odds);
            }
        }
    }
}
