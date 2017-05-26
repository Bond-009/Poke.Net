using Newtonsoft.Json;

namespace Poke
{
    public class LocalizedName : LanguageResource
    {
        /// <summary>
        /// The localized name for an API resource in a specific language
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }
    }
}
