using StickerBook.Logic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace StickerBook.Logic.ViewModels
{
    public class PlayerViewModel : BindableBase
    {
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
            this.WasDiscovered = true;
        }
    }
}


