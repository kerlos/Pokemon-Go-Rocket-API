using System.Configuration;
using PokemonGo.RocketAPI.Enums;
using PokemonGo.RocketAPI.GeneratedCode;
using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using AllEnum;
using Newtonsoft.Json;
using System.Dynamic;
using System.IO;
namespace PokemonGo.RocketAPI.Console
{
    public class Settings : ISettings
    {
        private dynamic _jsonConfig;
        private KeyValuePair<ItemId, int>[] itemRecycleFilter;
        public Settings()
        {
            string jsonString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, UserSettings.Default.ConfigFile));
            _jsonConfig = JsonConvert.DeserializeObject<ExpandoObject>(jsonString);
            AuthType = (AuthType)Enum.Parse(typeof(AuthType), _jsonConfig.authType);
            PtcUsername = _jsonConfig.ptcUsername;
            PtcPassword = _jsonConfig.ptcPassword;
            DefaultLatitude = _jsonConfig.defaultLatitude;
            DefaultLongitude = _jsonConfig.defaultLongitude;
            AutoTranferDuplicatePokemon = (bool)_jsonConfig.autoTranferDuplicatePokemon;
            AutoEvolvePokemon = (bool)_jsonConfig.autoEvolvePokemon;
            RecycleItem = (bool)_jsonConfig.recycleItem;
            itemRecycleFilter = ((IList<dynamic>)_jsonConfig.itemRecycleFilter).Select(item => new KeyValuePair<ItemId, int>((ItemId)Enum.Parse(typeof(ItemId), string.Format("Item{0}", item.name)), (int)item.amount)).ToArray();
        }
        public AuthType AuthType { get; }
        public string PtcUsername { get; set; }
        public string PtcPassword { get; set; }
        public double DefaultLatitude { get; }
        public double DefaultLongitude { get; }

        public bool AutoTranferDuplicatePokemon { get; }
        public bool AutoEvolvePokemon { get; }
        public bool RecycleItem { get; }

        ICollection<KeyValuePair<ItemId, int>> ISettings.itemRecycleFilter
        {
            get
            {
                return itemRecycleFilter;
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
