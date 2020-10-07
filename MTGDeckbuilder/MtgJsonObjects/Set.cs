using System.Collections.Generic;
using Newtonsoft.Json;

namespace MTGDeckbuilder.MtgJsonObjects
{
    public class Set
    {
        [JsonProperty("baseSetSize")]
        public int BaseSetSize { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("cards")]
        public IList<Card> Cards { get; set; }

    }
}