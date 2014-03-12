using StickerBook.Logic.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace StickerBook.Logic.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            Players = new ObservableCollection<PlayerViewModel>();
            Players.Add(new PlayerViewModel()
            {
                Name = "Sorey",
                Photo = "",
                WasDiscovered = false
            });

            Players.Add(new PlayerViewModel()
            {
                Name = "Hernan",
                Photo = "",
                WasDiscovered = false
            });
        }

        public ObservableCollection<PlayerViewModel> Players { get; set; }
    }
}
