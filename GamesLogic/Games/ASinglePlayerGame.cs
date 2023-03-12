using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLogic.Games
{
    public abstract class ASinglePlayerGame : AGame
    {
        private ASinglePlayerGameState State => (ASinglePlayerGameState)_state;
        public override int GetMaxAllowedPlayers()
        {
            return 1;
        }

        public override Dictionary<string, int> GetScores()
        {
            return new Dictionary<string, int>
            {
                [State.PlayerName] = State.Score
            };
        }

        public override void Init(string[] playersName)
        {
            if (playersName == null || playersName.Length == 0)
                throw new ArgumentNullException("Missing player");
            if (playersName.Length > GetMaxAllowedPlayers())
                throw new ArgumentOutOfRangeException("Too many players");

            State.PlayerName = playersName[0];
            State.Score = 0;
        }
    }
}
