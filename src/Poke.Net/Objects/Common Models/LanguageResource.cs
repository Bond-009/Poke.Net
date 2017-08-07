using Newtonsoft.Json;

namespace Poke
{
    public abstract class LanguageResource
    {
        /// <summary>
        /// The language this name is in
        /// </summary>
        [JsonProperty("language")]
        [JsonRequired]
        public NamedAPIResource Language { get; set; }
    }
}
