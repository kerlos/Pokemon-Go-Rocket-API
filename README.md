# Pokemon-Go-Rocket-API

# Pokemon Go Client API Library in C# #

Example:

```
var client = new Client(Settings.DefaultLatitude, Settings.DefaultLongitude);

await client.LoginPtc("FeroxRev", "Sekret");
var serverResponse = await client.GetServer();
var profile = await client.GetProfile();
var settings = await client.GetSettings();
var mapObjects = await client.GetMapObjects();
var inventory = await client.GetInventory();

await ExecuteFarmingPokestops(client);
await ExecuteCatchAllNearbyPokemons(client);
```

General chat: https://discord.gg/xPCyNau

Features

Note: There is a list of feature requests [here](https://github.com/FeroxRev/Pokemon-Go-Rocket-API/wiki/Feature-requests).

```
#PTC Login / Google
#Get Map Objects and Inventory
#Search for gyms/pokestops/spawns
#Farm pokestops
#Farm all pokemons in neighbourhood
#Transfer pokemon
#Evolve pokemon
#Recycle items
```

Todo

```
#Gotta catch them all
#Map Enums
```

Config with json

```json
{
  "authType": "Google",
  "ptcUsername": "username",
  "ptcPassword": "pw",
  "defaultLatitude": 52.379189,
  "defaultLongitude": 4.899431,
  "autoTranferDuplicatePokemon": true,
  "autoEvolvePokemon": false,
  "recycleItem": true,
  "itemRecycleFilter": [
    {
      "name": "PokeBall",
      "amount": 70
    },
    {
      "name": "GreatBall",
      "amount": 100
    },
    {
      "name": "Potion",
      "amount": 10
    },
    {
      "name": "Revive",
      "amount": 30
    },
    {
      "name": "SuperPotion",
      "amount": 20
    },
    {
      "name": "RazzBerry",
      "amount": 80
    }
  ]
}
```
