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
        public string Answer { get; set; }
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

        public ICommand GuessCommand
        {
            get
            {
                return new RelayCommand(Guess, null);
            }
        }

        private void Guess()
        {
            if (string.IsNullOrWhiteSpace(this.Answer))
            {
                phoneService.ShowMessage("???","Y la respuesta?");
                this.ParentViewModel.SufflePlayers();
            }
            else
            {
                if (this.Name.ToLower().Equals(this.Answer.ToLower()))
                {
                    this.WasDiscovered = true;
                    phoneService.ShowMessage("Felicitaciones", "Has descubierto a " + this.Name);
                }
                else
                {
                    phoneService.ShowMessage("Fallaste", "Intenta con otro jugador.");
                    this.ParentViewModel.SufflePlayers();
                }
            }

            navigationService.GoBack();
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


