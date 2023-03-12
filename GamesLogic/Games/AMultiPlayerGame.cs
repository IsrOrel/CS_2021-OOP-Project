using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLogic.Games
{
    public abstract class AMultiPlayerGame : AGame
    {
        private AMultiPlayerGameState State => (AMultiPlayerGameState)_state;
        public override void Init(string[] playersName)
        {
            if (playersName == null || playersName.Length == 0)
                throw new ArgumentNullException("Missing player");
            if (playersName.Length > GetMaxAllowedPlayers())
                throw new ArgumentOutOfRangeException("Too many players");

            if (!(_state is AMultiPlayerGameState gameState))
                throw new InvalidOperationException("Bad state");
             
            gameState.Players = playersName;
            gameState.CurrentPlayerIndex = -1;
            gameState.Scores = new Dictionary<string, int>();
            foreach (string player in playersName)
            {
                gameState.Scores[player] = 0;
            }
        }

        public string GetNextPlayer()
        {
            State.CurrentPlayerIndex = (State.CurrentPlayerIndex + 1) % State.Players.Length;
            return State.Players[State.CurrentPlayerIndex];
        }

        public override Dictionary<string, int> GetScores() =>
            State.Scores.ToDictionary(p => p.Key, p => p.Value);
    }
}
