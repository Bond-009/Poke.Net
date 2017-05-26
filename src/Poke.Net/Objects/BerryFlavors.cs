using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    public class BerryFlavors : Resource
    {
        /// <summary>
        /// A list of the berries with this flavor
        /// </summary>
        [JsonProperty("berries")]
        [JsonRequired]
        public IEnumerable<FlavorBerryMap> Berries { get; set; }
        /// <summary>
        /// The contest type that correlates with this berry flavor
        /// </summary>
        [JsonProperty("contest_type")]
        [JsonRequired]
        public NamedAPIResource ContestType { get; set; }
        /// <summary>
        /// The name of this berry flavor listed in different languages
        /// </summary>
        [JsonProperty("names")]
        [JsonRequired]
        public IEnumerable<LocalizedName> Names { get; set; }
    }
}
