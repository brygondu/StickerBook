
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StickerBook.Logic.Models
{
    class Player
    {
        [JsonProperty("nombre")]
        public string name = string.Empty;
        [JsonProperty("foto")]
        public string photo = string.Empty;
        [JsonProperty("pistas")]
        public List<string> clues;
    }
}
