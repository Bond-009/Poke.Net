using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    /// <summary>
    /// Contest effects refer to the effects of moves when used in contests.
    /// </summary>
    public abstract class ContestEffectBase : Resource
    {
        /// <summary>
        /// The base number of hearts the user of this move gets
        /// </summary>
        [JsonProperty("appeal")]
        [JsonRequired]
        public int Appeal { get; set; }
        /// <summary>
        /// The flavor text of this contest effect listed in different languages
        /// </summary>
        [JsonProperty("flavor_text_entries")]
        [JsonRequired]
        public IEnumerable<LocalizedFlavorText> FlavorTextEntries { get; set; }
    }
}
