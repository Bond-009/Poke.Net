using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    public class Encounter : Resource
    {
        /// <summary>
        /// The name of this encounter listed in different languages
        /// </summary>
        [JsonProperty("names")]
        [JsonRequired]
        public IEnumerable<LocalizedName> Names { get; set; }
    }
}
