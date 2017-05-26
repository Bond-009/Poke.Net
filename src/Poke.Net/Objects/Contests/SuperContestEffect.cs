using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    /// <summary>
    /// Super contest effects refer to the effects of moves when used in super contests.
    /// </summary>
    public class SuperContestEffect : ContestEffectBase
    {
        /// <summary>
        /// A list of moves that have the effect when used in super contests
        /// </summary>
        [JsonProperty("moves")]
        [JsonRequired]
        public IEnumerable<NamedAPIResource> Moves { get; set; }
    }
}
