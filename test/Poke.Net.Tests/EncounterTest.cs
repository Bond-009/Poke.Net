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
            => client.GetResourceAsync<EncounterMethod>(id);

        [Theory]
        [InlineData(1)]
        public Task GetEncounterConditionTest(int id)
            => client.GetResourceAsync<EncounterCondition>(id);

        [Theory]
        [InlineData(1)]
        public Task GetEncounterConditionValueTest(int id)
            => client.GetResourceAsync<EncounterConditionValue>(id);

        public void Dispose() => client.Dispose();
    }
}
