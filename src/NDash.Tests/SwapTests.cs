using Xunit;

namespace NDash.Tests
{
    public class SwapTests
    {
        public class given_different_indices
        {
            [Fact]
            public void should_swap_at_indices()
            {
                var hello = new[] { 'h', 'e', 'l', 'l', 'o' };

                hello.Swap(1, 2);

                Assert.Equal("hlelo", string.Join("", hello));
            }
        }

        public class given_duplicate_index
        {
            [Fact]
            public void should_remain_unchanged()
            {
                var goodbye = new[] { 'g', 'o', 'o', 'd', 'b', 'y', 'e' };

                goodbye.Swap(0, 0);

                Assert.Equal("goodbye", string.Join("", goodbye));
            }
        }
    }
}
