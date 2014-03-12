using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace StickerBook.Logic.ViewModels
{
    public class MainViewModel
    {
        ObservableCollection<PlayerViewModel> Players { get; set; }
    }
}
