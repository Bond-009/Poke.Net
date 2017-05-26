using Newtonsoft.Json;

namespace Poke
{
    public class FlavorBerryMap : Flavor
    {
        /// <summary>
        /// The berry with the referenced flavor
        /// </summary>
        [JsonProperty("berry")]
        [JsonRequired]
        public NamedAPIResource Berry { get; set; }
    }
}
