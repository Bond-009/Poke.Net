using Newtonsoft.Json;

namespace Poke
{
    public class BerryFlavorMap : Flavor
    {
        /// <summary>
        /// The referenced berry flavor
        /// </summary>
        [JsonProperty("flavor")]
        [JsonRequired]
        public NamedAPIResource Flavor { get; set; }
    }
}
