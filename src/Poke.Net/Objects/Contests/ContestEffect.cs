using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    /// <summary>
    /// Contest effects refer to the effects of moves when used in contests.
    /// </summary>
    public class ContestEffect : ContestEffectBase
    {
        /// <summary>
        /// The base number of hearts the user's opponent loses
        /// </summary>
        [JsonProperty("jam")]
        [JsonRequired]
        public int Jam { get; set; }
        /// <summary>
        /// The result of this contest effect listed in different languages
        /// </summary>
        [JsonProperty("effect_entries")]
        [JsonRequired]
        public IEnumerable<LocalizedEffect> EffectEntries { get; set; }
    }
}
