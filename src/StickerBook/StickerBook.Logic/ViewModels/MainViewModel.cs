﻿using StickerBook.Logic.Common;
using StickerBook.Logic.Contracts;
using StickerBook.Logic.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace StickerBook.Logic.ViewModels
{
    public class MainViewModel : BindableBase
    {
        INavigationService navigationService;
        IPhoneService phoneService;
        IJsonService jsonService;

        public MainViewModel(INavigationService navigationService, IPhoneService phoneService)
        {
            this.Players = new ObservableCollection<PlayerViewModel>();

            this.navigationService = navigationService;
            this.phoneService = phoneService;

            this.jsonService = new JsonService(phoneService);

            LoadPlayers();
        }

        private async void LoadPlayers()
        {
            var players = await jsonService.LoadPlayers();

            foreach (var item in players)
            {
                PlayerViewModel player = new PlayerViewModel(navigationService, phoneService)
                {
                    Id = item.Id,
                    Name = item.Name,
                    Photo = item.Photo,
                    WasDiscovered = false,
                    Clues = new ObservableCollection<ClueViewModel>()
                };

                foreach (var clue in item.Clues)
                {
                    string[] clueArray = clue.Split(':');
                    player.Clues.Add(new ClueViewModel() 
                    {
                        Name = clueArray[0],
                        Value = clueArray[1]
                    });
                }

                this.Players.Add(player);
            }
        }

        public ObservableCollection<PlayerViewModel> Players { get; set; }

        public PlayerViewModel SelectedPlayer { get; set; }
    }
}
