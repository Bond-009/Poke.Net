using Newtonsoft.Json;

namespace Poke
{
    public abstract class Resource
    {
        /// <summary>
        /// The identifier for this resource
        /// </summary>
        [JsonProperty("id")]
        [JsonRequired]
         int ID { get; set; }
    }
}
