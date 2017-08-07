using Newtonsoft.Json;
using System.Collections.Generic;

namespace Poke
{
    /// <summary>
    /// Berries are small fruits that can provide HP and status condition restoration,
    /// stat enhancement, and even damage negation when eaten by Pokémon.
    /// Check out Bulbapedia for greater detail.
    /// </summary>
    public class Berry : NamedResource
    {
        /// <summary>
        /// Time it takes the tree to grow one stage, in hours.
        /// Berry trees go through four of these growth stages before they can be picked.
        /// </summary>
        [JsonProperty("growth_time")]
        [JsonRequired]
        public int GrowthTime { get; set; }
        /// <summary>
        /// The maximum number of these berries that can grow on one tree in Generation IV
        /// </summary>
        [JsonProperty("max_harvest")]
        [JsonRequired]
        public int MaxHarvest { get; set; }
        /// <summary>
        /// The power of the move "Natural Gift" when used with this Berry
        /// </summary>
        [JsonProperty("natural_gift_power")]
        [JsonRequired]
        public int NaturalGiftPower { get; set; }
        /// <summary>
        /// The size of this Berry, in millimeters
        /// </summary>
        [JsonProperty("size")]
        [JsonRequired]
        public int Size { get; set; }
        /// <summary>
        /// The smoothness of this Berry, used in making Pokéblocks or Poffins
        /// </summary>
        [JsonProperty("smoothness")]
        [JsonRequired]
        public int Smoothness { get; set; }
        /// <summary>
        /// The speed at which this Berry dries out the soil as it grows.
        /// A higher rate means the soil dries more quickly.
        /// </summary>
        [JsonProperty("soil_dryness")]
        [JsonRequired]
        public int SoilDryness { get; set; }
        /// <summary>
        /// The firmness of this berry, used in making Pokéblocks or Poffins
        /// </summary>
        [JsonProperty("firmness")]
        [JsonRequired]
        public NamedAPIResource Firmness { get; set; }
        /// <summary>
        /// A list of references to each flavor a berry can have and the potency of each of those flavors in regard to this berry
        /// </summary>
        [JsonProperty("flavors")]
        [JsonRequired]
        public IEnumerable<BerryFlavorMap> flavors { get; set; }
        /// <summary>
        /// Berries are actually items.
        /// This is a reference to the item specific data for this berry.
        /// </summary>
        [JsonProperty("item")]
        [JsonRequired]
        public NamedAPIResource Item { get; set; }
        /// <summary>
        /// The Type the move "Natural Gift" has when used with this Berry
        /// </summary>
        [JsonProperty("natural_gift_type")]
        [JsonRequired]
        public NamedAPIResource NaturalGiftType { get; set; }
    }
}
