using System.Threading.Tasks;
using Xunit;

namespace NDash.Tests
{
    public class NoopTests
    {
        [Fact]
        public void should_accept_up_to_16_parameters_of_varying_types()
        {
            // just make sure this always compiles
            NDashLib.Noop();
            NDashLib.Noop(1);
            NDashLib.Noop(1, "2");
            NDashLib.Noop(1, "2", 3f);
            NDashLib.Noop(1, "2", 3f, 4d);
            NDashLib.Noop(1, "2", 3f, 4d, 5m);
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6);
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7");
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f);
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d);
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m);
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11);
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12");
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f);
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d);
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d, 15m);
            NDashLib.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d, 15m, 16);

            // one promotion please
            Assert.True(true);
        }

        [Fact]
        public async Task should_accept_up_to_16_parameters_of_varying_types_async()
        {
            // and you thought I was a one-trick pony
            await NDashLib.NoopAsync();
            await NDashLib.NoopAsync(1);
            await NDashLib.NoopAsync(1, "2");
            await NDashLib.NoopAsync(1, "2", 3f);
            await NDashLib.NoopAsync(1, "2", 3f, 4d);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7");
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12");
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d, 15m);
            await NDashLib.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d, 15m, 16);

            Assert.True(true);
        }
    }
}
