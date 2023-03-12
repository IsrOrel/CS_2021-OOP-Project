using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamesLogic.Games
{
    public interface IGame
    {
        void Init(string[] playersName);
        bool IsGameOver();
        Dictionary<string, int> GetScores();
        void StartGame();
        void Save(string filePath);
        void Load(string filePath);
        int GetMaxAllowedPlayers();
    }
}
