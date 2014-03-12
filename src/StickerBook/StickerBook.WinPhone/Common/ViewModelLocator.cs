using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StickerBook.Logic.ViewModels;
using StickerBook.Logic.Contracts;
using StickerBook.WinPhone.Services;

namespace StickerBook.WinPhone.Common
{
    public class ViewModelLocator
    {
        INavigationService navigationService;

        public ViewModelLocator()
        {
            navigationService = new NavigationService();
        }

        private MainViewModel main;

        public MainViewModel Main
        {
            get 
            {
                if (main == null)
                {
                    main = new MainViewModel(navigationService);
                }

                return main;
            }
        }
        
    }
}
