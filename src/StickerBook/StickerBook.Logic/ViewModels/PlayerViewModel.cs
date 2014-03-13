using StickerBook.Logic.Common;
using StickerBook.Logic.Contracts;
using StickerBook.Logic.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace StickerBook.Logic.ViewModels
{
    public class PlayerViewModel : BindableBase
    {
        INavigationService navigationService;
        IPhoneService phoneService;

        public PlayerViewModel(INavigationService navigationService, IPhoneService phoneService)
        {
            this.navigationService = navigationService;
            this.phoneService = phoneService;
        }

        public MainViewModel ParentViewModel { get; set; }
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

        public ObservableCollection<ClueViewModel> Clues { get; set; }

        public ICommand DiscoverCommand
        {
            get
            {
                return new RelayCommand(Discover, null);
            }
        }

        private void Discover()
        {
            this.ParentViewModel.SelectedPlayer = this;

            if (this.wasDiscovered)
            {
                phoneService.ShowMessage("Jugadores","Ya has descubierto este jugador");
            }
            else
            {
                navigationService.Navigate("DiscoverPage");
            }
        }

        public int Id { get; set; }
    }
}


