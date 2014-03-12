using StickerBook.Logic.Common;
using StickerBook.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace StickerBook.Logic.ViewModels
{
    public class MainViewModel : BindableBase
    {
        INavigationService navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            Players = new ObservableCollection<PlayerViewModel>();
            Players.Add(new PlayerViewModel(navigationService)
            {
                Name = "Sorey",
                Photo = "",
                WasDiscovered = false
            });

            Players.Add(new PlayerViewModel(navigationService)
            {
                Name = "Hernan",
                Photo = "",
                WasDiscovered = false
            });
        }

        public ObservableCollection<PlayerViewModel> Players { get; set; }
    }
}
