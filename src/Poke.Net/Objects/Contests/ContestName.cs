using Newtonsoft.Json;

namespace Poke
{
    public class ContestName : LocalizedName
    {
        /// <summary>
        /// The color associated with this contest's name
        /// </summary>
        [JsonProperty("color")]
        [JsonRequired]
        public string Color { get; set; }
    }
}
