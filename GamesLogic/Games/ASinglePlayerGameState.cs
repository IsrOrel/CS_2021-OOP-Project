using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLogic.Games
{
    [Serializable]
    public abstract class ASinglePlayerGameState : AGameState
    {
        [JsonProperty("playerName")]
        public string PlayerName { get; set; }
        
        [JsonProperty("score")]
        public int Score { get; set; }
    }
}
