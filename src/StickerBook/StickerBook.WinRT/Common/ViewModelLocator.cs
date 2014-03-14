using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StickerBook.Logic.ViewModels;
using StickerBook.Logic.Contracts;
using StickerBook.WinRT.Services;

namespace StickerBook.WinRT.Common
{
    public class ViewModelLocator
    {
        INavigationService navigationService;
        IPhoneService phoneService;
        public ViewModelLocator()
        {
            navigationService = new NavigationService();
            phoneService = new PhoneService();
        }

        private MainViewModel main;

        public MainViewModel Main
        {
            get 
            {
                if (main == null)
                {
                    main = new MainViewModel(navigationService, phoneService);
                }

                return main;
            }
        }
        
    }
}
