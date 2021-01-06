using Xunit;
using NDash.FP;

namespace NDash.Tests
{
    public class IdentityTests
    {
        [Fact]
        public void should_return_parameter_by_reference()
        {
            var obj = new object();

            Assert.Equal(obj, NDashFP.Identity(obj));
        }
    }
}
