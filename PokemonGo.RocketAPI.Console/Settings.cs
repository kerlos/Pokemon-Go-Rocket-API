using System.Configuration;
using PokemonGo.RocketAPI.Enums;
using PokemonGo.RocketAPI.GeneratedCode;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using AllEnum;

namespace PokemonGo.RocketAPI.Console
{
    public class Settings : ISettings
    {
        public AuthType AuthType => (AuthType)Enum.Parse(typeof(AuthType), UserSettings.Default.AuthType);
        public string PtcUsername => UserSettings.Default.PtcUsername;
        public string PtcPassword => UserSettings.Default.PtcPassword;
        public double DefaultLatitude => UserSettings.Default.DefaultLatitude;
        public double DefaultLongitude => UserSettings.Default.DefaultLongitude;

        ICollection<KeyValuePair<ItemId, int>> ISettings.itemRecycleFilter
        {
            get
            {
                //Type and amount to keep
                return new[]
                {
                    new KeyValuePair<ItemId, int>(ItemId.ItemPokeBall, 70),
                    new KeyValuePair<ItemId, int>(ItemId.ItemGreatBall, 100),
                    new KeyValuePair<ItemId, int>(ItemId.ItemPotion, 10),
                    new KeyValuePair<ItemId, int>(ItemId.ItemRevive, 30),
                    new KeyValuePair<ItemId, int>(ItemId.ItemSuperPotion, 20),
                    new KeyValuePair<ItemId, int>(ItemId.ItemRazzBerry, 80)
                };
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string GoogleRefreshToken
        {
            get { return UserSettings.Default.GoogleRefreshToken; }
            set
            {
                UserSettings.Default.GoogleRefreshToken = value;
                UserSettings.Default.Save();
            }
        }
    }
}
