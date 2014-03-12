using System;
namespace StickerBook.Logic.Contracts
{
    public interface IPhoneService
    {
        bool ShowConfirmation(string title, string message);
        void ShowMessage(string title, string message);
    }
}
