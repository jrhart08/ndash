using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NDash.Tests
{
    public class CryptoShuffleTests
    {
        [Fact]
        public void should_not_mutate_original_collection()
        {
            var ascending = Enumerable.Range(0, 100);
            ascending.CryptoShuffle();

            var expected = Enumerable.Range(0, 100);
            Assert.Equal(expected, ascending);
            should_have_same_elements(expected, ascending);
        }

        [Fact]
        public void should_shuffle_randomly()
        {
            var ascending = Enumerable.Range(0, 100);

            var shuffled = ascending.CryptoShuffle();

            // if this somehow fails, it's an act of god
            Assert.NotEqual(ascending, shuffled);
            should_have_same_elements(ascending, shuffled);
        }

        static void should_have_same_elements<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            Assert.Empty(expected.DisjunctiveUnion(actual));
        }
    }
}
