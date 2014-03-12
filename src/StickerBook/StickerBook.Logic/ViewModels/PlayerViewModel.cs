using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StickerBook.Logic.ViewModels
{
    public class PlayerViewModel
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public List<string> Clues { get; set; }
        public bool WasDiscovered { get; set; }
    }
}


