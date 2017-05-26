using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Poke.Tests
{
    public class BerryTest : IDisposable
    {
        PokeClient client = new PokeClient();

        [Fact]
        public Task GetBerryTest()
            => client.GetBerryAsync(1);

        [Fact]
        public Task GetBerryFirmnessesTest()
            => client.GetBerryFirmnessesAsync(1);

        [Fact]
        public Task GetBerryFlavorsTest()
            => client.GetBerryFlavorsAsync(1);

        public void Dispose() => client.Dispose();
    }
}
