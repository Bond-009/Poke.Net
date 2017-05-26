using Newtonsoft.Json;

namespace Poke
{
    public class LocalizedEffect : LanguageResource
    {
        /// <summary>
        /// The localized effect text for an API resource in a specific language
        /// </summary>
        [JsonProperty("effect")]
        [JsonRequired]
        public string Effect { get; set; }
    }
}
