using System.Collections.Generic;
using Xunit;

namespace NDash.Tests
{
    public class NDash_Flatten_Tests
    {
        public class given_collection_of_collections
        {
            [Fact]
            public void should_flatten_collections()
            {
                int[][] matrix = new[]
                {
                    new[] { 1, 2, 3 },
                    new[] { 4, 5, 6 },
                    new[] { 7, 8, 9 },
                };

                IEnumerable<int> array = matrix.Flatten();

                Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, array);
            }
        }
    }
}
