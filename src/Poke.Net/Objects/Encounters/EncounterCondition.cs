using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    /// <summary>
    /// Methods by which the player might can encounter Pokémon in the wild, e.g., walking in tall grass.
    /// </summary>
    public class EncounterCondition : Encounter
    {
        /// <summary>
        /// A list of possible values for this encounter condition
        /// </summary>
        [JsonProperty("values")]
        [JsonRequired]
        public IEnumerable<NamedAPIResource> Values { get; set; }
    }
}
