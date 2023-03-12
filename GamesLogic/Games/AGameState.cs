using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLogic.Games
{
    [Serializable]
    public abstract class AGameState
    {
        [JsonProperty("isGameOver")]
        public bool IsGameOver { get; set; }

        [JsonProperty("winner")]
        public string Winner { get; set; }
    }
}
