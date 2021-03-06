using Newtonsoft.Json;

namespace Poke
{
    public abstract class Flavor
    {
        /// <summary>
        /// How powerful the referenced flavor is for this berry
        /// </summary>
        [JsonProperty("potency")]
        [JsonRequired]
        public int Potency { get; set; }
    }
}
