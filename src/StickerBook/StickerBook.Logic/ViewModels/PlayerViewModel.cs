using StickerBook.Logic.Common;
using StickerBook.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace StickerBook.Logic.ViewModels
{
    public class PlayerViewModel : BindableBase
    {
        INavigationService navigationService;

        public PlayerViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public string Name { get; set; }
        public string Photo { get; set; }

        private bool wasDiscovered;

        public bool WasDiscovered
        {
            get { return wasDiscovered; }
            set
            {
                wasDiscovered = value;
                RaisePropertyChanged("WasDiscovered");
            }
        }

        public ICommand DiscoverCommand
        {
            get
            {
                return new RelayCommand(Discover, null);
            }
        }

        private void Discover()
        {
            navigationService.Navigate("DiscoverPage");
        }
    }
}


