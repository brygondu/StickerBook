using StickerBook.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Resources;
using Windows.Storage;

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

        public async Task<string> ReadTextAsync(string fileName)
        {
            StreamResourceInfo stream = Application.GetResourceStream(new Uri(fileName, UriKind.Relative));
            using (StreamReader reader = new StreamReader(stream.Stream))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
