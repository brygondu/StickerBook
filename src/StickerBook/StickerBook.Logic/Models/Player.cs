
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StickerBook.Logic.Models
{
    class Player
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }    
        [JsonProperty("photo")]
        public string Photo { get; set; }
        [JsonProperty("clues")]
        public List<string> Clues { get; set; }
    }
}
