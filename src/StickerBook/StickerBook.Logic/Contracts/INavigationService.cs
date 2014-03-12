using System;
namespace StickerBook.Logic.Contracts
{
    public interface INavigationService
    {
        void GoBack();
        void Navigate(string viewName);
    }
}
