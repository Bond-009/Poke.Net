using Newtonsoft.Json;

namespace Poke
{
    public class NamedAPIResource
    {
        /// <summary>
        /// The name of the referenced resource
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }
        /// <summary>
        /// The URL of the referenced resource
        /// </summary>
        [JsonProperty("url")]
        [JsonRequired]
        public string URL { get; set; }
    }
}
