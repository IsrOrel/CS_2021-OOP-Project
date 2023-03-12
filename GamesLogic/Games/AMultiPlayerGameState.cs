using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLogic.Games
{
    [Serializable]
    public abstract class AMultiPlayerGameState : AGameState
    {
        [JsonProperty("players")]
        public string[] Players { get; set; }
        
        [JsonProperty("scores")]
        public Dictionary<string, int> Scores { get; set; }
        
        [JsonProperty("currentPlayerIndex")]
        public int CurrentPlayerIndex { get; set; }
    }
}
