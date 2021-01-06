using System;
using Xunit;
using NDash;

namespace NDash.Tests
{
    public class IdentityTests
    {
        [Fact]
        public void should_return_parameter_by_reference()
        {
            var obj = new object();

            Assert.Equal(obj, NDashLib.Identity(obj));
        }
    }
}
