using Newtonsoft.Json;

namespace Poke
{
    public class LocalizedFlavorText : LanguageResource
    {
        /// <summary>
        /// The localized flavor text for an API resource in a specific language
        /// </summary>
        [JsonProperty("flavor_text")]
        [JsonRequired]
        public string FlavorText { get; set; }
    }
}
