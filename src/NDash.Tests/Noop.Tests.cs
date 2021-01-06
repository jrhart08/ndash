using System.Threading.Tasks;
using Xunit;
using NDash.FP;

namespace NDash.Tests
{
    public class NoopTests
    {
        [Fact]
        public void should_accept_up_to_16_parameters_of_varying_types()
        {
            // just make sure this always compiles
            NDashFP.Noop();
            NDashFP.Noop(1);
            NDashFP.Noop(1, "2");
            NDashFP.Noop(1, "2", 3f);
            NDashFP.Noop(1, "2", 3f, 4d);
            NDashFP.Noop(1, "2", 3f, 4d, 5m);
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6);
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7");
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f);
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d);
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m);
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11);
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12");
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f);
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d);
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d, 15m);
            NDashFP.Noop(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d, 15m, 16);

            // one promotion please
            Assert.True(true);
        }

        [Fact]
        public async Task should_accept_up_to_16_parameters_of_varying_types_async()
        {
            // and you thought I was a one-trick pony
            await NDashFP.NoopAsync();
            await NDashFP.NoopAsync(1);
            await NDashFP.NoopAsync(1, "2");
            await NDashFP.NoopAsync(1, "2", 3f);
            await NDashFP.NoopAsync(1, "2", 3f, 4d);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7");
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12");
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d, 15m);
            await NDashFP.NoopAsync(1, "2", 3f, 4d, 5m, 6, "7", 8f, 9d, 10m, 11, "12", 13f, 14d, 15m, 16);

            Assert.True(true);
        }
    }
}
