using StickerBook.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace StickerBook.WinPhone.Services
{
    class NavigationService : INavigationService
    {
        public void Navigate(string viewName)
        {
            (Application.Current.RootVisual as Frame)
                .Navigate(new Uri("/Pages/" + viewName + ".xaml", UriKind.Relative));
        }

        public void GoBack()
        {
            if ((Application.Current.RootVisual as Frame).CanGoBack)
                (Application.Current.RootVisual as Frame).GoBack();
        }
    }
}
