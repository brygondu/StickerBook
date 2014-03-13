using Newtonsoft.Json;
using StickerBook.Logic.Contracts;
using StickerBook.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerBook.Logic.Services
{
    class JsonService : IJsonService
    {
        IPhoneService phoneService;

        public JsonService(IPhoneService phoneService)
        {
            this.phoneService = phoneService;
        }

        public async Task<List<Player>> LoadPlayers()
        {
            string json = await phoneService.ReadTextAsync("Data/Players.json");
            return JsonConvert.DeserializeObject<List<Player>>(json);
        }
    }
}
