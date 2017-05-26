using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    /// <summary>
    /// Flavors determine whether a Pokémon will benefit or suffer from eating a berry based on their nature.
    /// Check out Bulbapedia for greater detail.
    /// </summary>
    public class BerryFlavor : Resource
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
