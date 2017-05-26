using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Poke.Tests
{
    public class ContestTest : IDisposable
    {
        PokeClient client = new PokeClient();

        [Theory]
        [InlineData(1)]
        public Task GetContestTypeTest(int id)
            => client.GetContestTypeAsync(id);

        [Theory]
        [InlineData(1)]
        public Task GetContestEffectTest(int id)
            => client.GetContestEffectAsync(id);

        [Theory]
        [InlineData(1)]
        public Task GetSuperContestEffectTest(int id)
            => client.GetSuperContestEffectAsync(id);

        public void Dispose() => client.Dispose();
    }
}
