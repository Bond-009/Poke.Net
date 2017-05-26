using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    public class BerryFirmness : Resource
    {
        /// <summary>
        /// A list of the berries with this firmness
        /// </summary>
        [JsonProperty("berries")]
        [JsonRequired]
        public IEnumerable<NamedAPIResource> Berries { get; set; }
        /// <summary>
        /// The name of this berry firmness listed in different languages
        /// </summary>
        [JsonProperty("names")]
        [JsonRequired]
        public IEnumerable<LocalizedName> Names { get; set; }
    }
}
