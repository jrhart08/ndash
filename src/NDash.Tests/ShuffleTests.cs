using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NDash.Tests
{
    public class ShuffleTests
    {
        class ReverseRandom : Random
        {
            readonly int[] order = new[] { 4, 3, 2, 3, 4 };
            int curr = 0;

            public override int Next(int maxValue) => order[curr++];
        }

        public class given_custom_RNG
        {
            [Fact]
            public void should_shuffle_with_RNG()
            {
                var ascending = new[] { 1, 2, 3, 4, 5 };
                var descending = ascending.Shuffle(new ReverseRandom());

                Assert.Equal(new[] { 5, 4, 3, 2, 1 }, descending);
            }
        }

        public class given_default_RNG
        {
            [Fact]
            public void should_shuffle_randomly()
            {
                var ascending = Enumerable.Range(0, 100);

                var shuffled = ascending.Shuffle();

                // if this somehow fails, it's an act of god
                Assert.NotEqual(shuffled, ascending);
            }

            [Fact]
            public void should_not_mutate_original_collection()
            {
                var ascending = Enumerable.Range(0, 100);
                
                var shuffled = ascending.Shuffle();

                Assert.Equal(Enumerable.Range(0, 100), ascending);
            }
        }
    }
}
