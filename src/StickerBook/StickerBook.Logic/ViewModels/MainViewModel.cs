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
        IPhoneService phoneService;

        public MainViewModel(INavigationService navigationService, IPhoneService phoneService)
        {
            this.navigationService = navigationService;
            this.phoneService = phoneService;

            Players = new ObservableCollection<PlayerViewModel>();
            Players.Add(new PlayerViewModel(navigationService, phoneService)
            {
                Name = "Sorey",
                Photo = "",
                WasDiscovered = false,
                ParentViewModel = this
            });

            Players.Add(new PlayerViewModel(navigationService, phoneService)
            {
                Name = "Hernan",
                Photo = "",
                WasDiscovered = true,
                ParentViewModel = this
            });
        }

        public ObservableCollection<PlayerViewModel> Players { get; set; }

        public PlayerViewModel SelectedPlayer { get; set; }
    }
}
