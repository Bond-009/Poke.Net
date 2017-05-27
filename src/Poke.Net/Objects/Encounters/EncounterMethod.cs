using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    /// <summary>
    /// Conditions which affect what pokemon might appear in the wild, e.g., day or night.
    /// </summary>
    public class EncounterMethod : Encounter
    {
        /// <summary>
        /// A good value for sorting
        /// </summary>
        [JsonProperty("order")]
        [JsonRequired]
        public int Order { get; set; }
    }
}
