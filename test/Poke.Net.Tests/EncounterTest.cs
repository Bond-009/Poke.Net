using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Poke.Tests
{
    public class EncounterTest : IDisposable
    {
        PokeClient client = new PokeClient();

        [Theory]
        [InlineData(1)]
        public Task GetEncounterMethodTest(int id)
            => client.GetEncounterMethodAsync(id);

        [Theory]
        [InlineData(1)]
        public Task GetEncounterConditionTest(int id)
            => client.GetEncounterConditionAsync(id);

        [Theory]
        [InlineData(1)]
        public Task GetEncounterConditionValueTest(int id)
            => client.GetEncounterConditionValueAsync(id);

        public void Dispose() => client.Dispose();
    }
}
