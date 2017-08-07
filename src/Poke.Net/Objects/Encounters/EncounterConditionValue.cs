using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    /// <summary>
    /// Encounter condition values are the various states that an encounter condition can have, i.e., time of day can be either day or night.
    /// </summary>
    public class EncounterConditionValue : Encounter
    {
        /// <summary>
        /// The condition this encounter condition value pertains to
        /// </summary>
        [JsonProperty("condition")]
        [JsonRequired]
        public NamedAPIResource Condition { get; set; }
    }
}
