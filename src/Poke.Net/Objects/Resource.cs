using Newtonsoft.Json;

namespace Poke
{
    public class Resource : IResource
    {
        /// <summary>
        /// The identifier for this resource
        /// </summary>
        [JsonProperty("id")]
        [JsonRequired]
        public int ID { get; set; }
        /// <summary>
        /// The name for this resource
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }
    }
}
