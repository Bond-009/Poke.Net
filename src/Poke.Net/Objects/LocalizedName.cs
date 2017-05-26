using Newtonsoft.Json;

namespace Poke
{
    public class LocalizedName
    {
        /// <summary>
        /// The localized name for an API resource in a specific language
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }
        /// <summary>
        /// The language this name is in
        /// </summary>
        [JsonProperty("language")]
        [JsonRequired]
        public NamedAPIResource Language { get; set; }
    }
}
