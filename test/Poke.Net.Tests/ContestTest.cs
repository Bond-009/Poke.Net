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

        [Fact]
        public Task GetContestTypeTest()
            => client.GetContestTypeAsync(1);

        [Fact]
        public Task GetContestEffectTest()
            => client.GetContestEffectAsync(1);

        [Fact]
        public Task GetSuperContestEffectTest()
            => client.GetSuperContestEffectAsync(1);

        public void Dispose() => client.Dispose();
    }
}
