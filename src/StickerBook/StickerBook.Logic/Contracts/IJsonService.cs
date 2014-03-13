using StickerBook.Logic.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace StickerBook.Logic.Contracts
{
    interface IJsonService
    {
        Task<List<Player>> LoadPlayers();
    }
}
