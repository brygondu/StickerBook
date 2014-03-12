using StickerBook.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StickerBook.WinPhone.Services
{
    class PhoneService : IPhoneService
    {
        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButton.OK);
        }

        public bool ShowConfirmation(string title, string message)
        {
            MessageBoxResult result = MessageBox.Show(message, title, MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
                return true;
            else
                return false;
        }
    }
}
