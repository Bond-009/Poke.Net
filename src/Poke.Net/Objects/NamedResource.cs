using Newtonsoft.Json;

namespace Poke
{
    public class NamedResource : Resource
    {
        /// <summary>
        /// The name for this resource
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }
    }
}
