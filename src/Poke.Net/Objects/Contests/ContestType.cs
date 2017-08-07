using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    /// <summary>
    /// Contest types are categories judges used to weigh a Pokémon's condition in Pokémon contests.
    /// Check out Bulbapedia for greater detail.
    /// </summary>
    public class ContestType : NamedResource
    {
        /// <summary>
        /// The berry flavor that correlates with this contest type
        /// </summary>
        [JsonProperty("berry_flavor")]
        [JsonRequired]
        public NamedAPIResource BerryFlavor { get; set; }
        /// <summary>
        /// The name of this contest type listed in different languages
        /// </summary>
        [JsonProperty("names")]
        [JsonRequired]
        public IEnumerable<ContestName> Names { get; set; }
    }
}
