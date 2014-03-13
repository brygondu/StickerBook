using System;
using System.Threading.Tasks;
namespace StickerBook.Logic.Contracts
{
    public interface IPhoneService
    {
        bool ShowConfirmation(string title, string message);
        void ShowMessage(string title, string message);
        Task<string> ReadTextAsync(string fileName);
    }
}
