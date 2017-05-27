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

        [Theory]
        [InlineData(1)]
        public Task GetBerryTest(int id)
            => client.GetBerryAsync(id);

        [Theory]
        [InlineData(1)]
        public Task GetBerryFirmnessTest(int id)
            => client.GetBerryFirmnessAsync(id);

        [Theory]
        [InlineData(1)]
        public Task GetBerryFlavorTest(int id)
            => client.GetBerryFlavorAsync(id);

        public void Dispose() => client.Dispose();
    }
}
