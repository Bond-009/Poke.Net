using Newtonsoft.Json;

namespace Poke
{
    public class LanguageResource
    {
        /// <summary>
        /// The language this name is in
        /// </summary>
        [JsonProperty("language")]
        [JsonRequired]
        public NamedAPIResource Language { get; set; }
    }
}
